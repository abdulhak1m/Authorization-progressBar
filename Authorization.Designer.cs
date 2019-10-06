namespace ProjectWS_3
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Loading_panel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Authorization_panel = new System.Windows.Forms.Panel();
            this.Switch_reg = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Top_panel.SuspendLayout();
            this.Loading_panel.SuspendLayout();
            this.Authorization_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.DarkViolet;
            this.Top_panel.Controls.Add(this.Close_btn);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(940, 25);
            this.Top_panel.TabIndex = 0;
            // 
            // Close_btn
            // 
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(915, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(25, 25);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // Loading_panel
            // 
            this.Loading_panel.BackColor = System.Drawing.Color.Indigo;
            this.Loading_panel.Controls.Add(this.progressBar1);
            this.Loading_panel.Controls.Add(this.label4);
            this.Loading_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_panel.Location = new System.Drawing.Point(0, 25);
            this.Loading_panel.Name = "Loading_panel";
            this.Loading_panel.Size = new System.Drawing.Size(940, 490);
            this.Loading_panel.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(217, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(506, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(509, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Загрузка, пожалуйста подождите...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authorization_panel
            // 
            this.Authorization_panel.Controls.Add(this.Switch_reg);
            this.Authorization_panel.Controls.Add(this.label3);
            this.Authorization_panel.Controls.Add(this.Show_btn);
            this.Authorization_panel.Controls.Add(this.Login_btn);
            this.Authorization_panel.Controls.Add(this.label2);
            this.Authorization_panel.Controls.Add(this.label1);
            this.Authorization_panel.Controls.Add(this.panel2);
            this.Authorization_panel.Controls.Add(this.panel4);
            this.Authorization_panel.Controls.Add(this.Password_txt);
            this.Authorization_panel.Controls.Add(this.Username_txt);
            this.Authorization_panel.Controls.Add(this.pictureBox1);
            this.Authorization_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Authorization_panel.Location = new System.Drawing.Point(0, 25);
            this.Authorization_panel.Name = "Authorization_panel";
            this.Authorization_panel.Size = new System.Drawing.Size(940, 490);
            this.Authorization_panel.TabIndex = 0;
            // 
            // Switch_reg
            // 
            this.Switch_reg.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.Switch_reg.AutoSize = true;
            this.Switch_reg.LinkColor = System.Drawing.Color.DarkViolet;
            this.Switch_reg.Location = new System.Drawing.Point(247, 368);
            this.Switch_reg.Name = "Switch_reg";
            this.Switch_reg.Size = new System.Drawing.Size(44, 17);
            this.Switch_reg.TabIndex = 18;
            this.Switch_reg.TabStop = true;
            this.Switch_reg.Text = "здесь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(90, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Нет аккаунта, нажмите ";
            // 
            // Show_btn
            // 
            this.Show_btn.BackColor = System.Drawing.Color.White;
            this.Show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_btn.FlatAppearance.BorderSize = 0;
            this.Show_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_btn.ForeColor = System.Drawing.Color.White;
            this.Show_btn.Image = ((System.Drawing.Image)(resources.GetObject("Show_btn.Image")));
            this.Show_btn.Location = new System.Drawing.Point(330, 246);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(42, 29);
            this.Show_btn.TabIndex = 15;
            this.Show_btn.UseVisualStyleBackColor = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(128, 303);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(115, 38);
            this.Login_btn.TabIndex = 16;
            this.Login_btn.Text = "Войти";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя пользователя:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(35, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 5);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(35, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 5);
            this.panel4.TabIndex = 12;
            // 
            // Password_txt
            // 
            this.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_txt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_txt.Location = new System.Drawing.Point(35, 252);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(289, 19);
            this.Password_txt.TabIndex = 9;
            // 
            // Username_txt
            // 
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_txt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username_txt.Location = new System.Drawing.Point(35, 167);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(289, 19);
            this.Username_txt.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 515);
            this.Controls.Add(this.Loading_panel);
            this.Controls.Add(this.Authorization_panel);
            this.Controls.Add(this.Top_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            this.Top_panel.ResumeLayout(false);
            this.Loading_panel.ResumeLayout(false);
            this.Authorization_panel.ResumeLayout(false);
            this.Authorization_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Panel Loading_panel;
        private System.Windows.Forms.Panel Authorization_panel;
        private System.Windows.Forms.LinkLabel Switch_reg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
    }
}

