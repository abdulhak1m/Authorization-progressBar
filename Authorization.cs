using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWS_3
{
    public partial class Authorization : Form
    {
        void Panel(Panel panel) { panel.BringToFront(); }
        // метод переключения формы
        void Switch()
        {
            ActiveForm.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Close();
        }
        public Authorization()
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

            // поле пароль
            #region Password_txt
            Password_txt.TextChanged += (s, e) => { Password_txt.UseSystemPasswordChar = true; };
            Show_btn.MouseDown += (s, e) => { Password_txt.UseSystemPasswordChar = false; };
            Show_btn.MouseUp += (s, e) => { Password_txt.UseSystemPasswordChar = true; };
            #endregion

            // переход на форму регистрации
            Switch_reg.Click += (s, e) => { Switch(); };
        }

        async void Authorization_Load(object sender, System.EventArgs e)
        {
            for(int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value++;
                await Task.Delay(10);
            }
            if (progressBar1.Value == progressBar1.Maximum)
                Panel(Authorization_panel);
        }

        void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                Login_btn_Click(Login_btn, null);
        }

        void Login_btn_Click(object sender, System.EventArgs e)
        {
            // авторизация
        }
    }
}
