using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectWS_3
{
    public partial class Registration : Form
    {
        // метод переключения между панелями
        void Panel(Panel panel) { panel.BringToFront(); }
        // метод переключения в окно авторизации
        void SwitchAutho()
        {
            ActiveForm.Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            Close();
        }
        public Registration()
        {
            InitializeComponent();


            // передвижение формы
            #region Top_panel
            int move = 0, moveX = 0, moveY = 0;
            Top_panel.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            Top_panel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            Top_panel.MouseUp += (s, e) => { move = 0; };
            #endregion
            // закрыть форму
            Close_btn.Click += (s, e) => { Close(); };
            // переключение между панелями
            Continue_btn.Click += (s, e) => Panel(Registration_general);
            // копка продолжить регистрацию, переключения на панель конфиденциальной информации
            NextPanelConfidentility_btn.Click += (s, e) => { Panel(panel_Confidentiality); };
            // кнопка переключения в панель выбора типа рользователя
            BackPanleTypeUser_btn.Click += (s, e) => { Panel(Type_user); };
            // кнопка переключения в панель основного регистрационного окна
            BackRegistrationGeneralbtn.Click += (s, e) => { Panel(Registration_general); };
            // пользовательский интерфейс
            #region Passord & Confrim Password
            // событие на изменение текста
            Password_txt.TextChanged += (s, e) => { Password_txt.UseSystemPasswordChar = true; };
            ConfirmPassword_txt.TextChanged += (s, e) => { ConfirmPassword_txt.UseSystemPasswordChar = true; };
            // кнопка, показывающая текст пароля по нажатию
            show_password.MouseDown += (s, e) => { Password_txt.UseSystemPasswordChar = false; };
            showConfirmPassword.MouseDown += (s, e) => { ConfirmPassword_txt.UseSystemPasswordChar = false; };
            // пропишем сценари, когдп отпускаем кнопку пароль шифруется
            show_password.MouseUp += (s, e) => { Password_txt.UseSystemPasswordChar = true; };
            showConfirmPassword.MouseUp += (s, e) => { ConfirmPassword_txt.UseSystemPasswordChar = true; };
            #endregion

            // linkLabel переключние в окно авторизации, после успешной регистрации
            linklblBackAutho.Click += (s, e) => { SwitchAutho(); };
            // linkLabel переключени в окно авторизации, после не удачной регистрации
            linklblErrorPanelBackAutho.Click += (s, e) => { SwitchAutho(); };
            // переключение в панель выбора типа пользователя, при не удачной регистрации
            linklblReturnRegistr.Click += (s, e) => { Panel(Type_user); };
        }

        readonly static string MyConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        // создаем метож добавления, т.е. реализуем модуль регистрации
        public bool Insert()
        {
            bool IsSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(MyConnection))
                {
                    string query = $" insert into tbl_TypeUser ([Name], [Surname], [E-mail], [Gender], [Username], [Passsword], [ConfirmPassword])" +
                        $"'{Name_txt.Text}', '{Surname_txt.Text}', '{Gender_cmb.Text}', '{Email_txt.Text}', '{Function_cmb.Text}', '{Usernama_txt.Text}', '{Password_txt.Text}', '{ConfirmPassword_txt.Text}'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int row = command.ExecuteNonQuery();
                    IsSuccess = row > 0 ? true : false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
            return IsSuccess;
           
        }

        void Btn_done_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Insert();
                Panel(success ? Registration_done : Registration_error);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
        }
    }
}
