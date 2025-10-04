using System.Windows.Forms;

namespace LoginApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Button buttonGuest;
        private Label labelError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGuest = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(30, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 17);
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(100, 27);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(160, 22);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 17);
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(160, 22);
            this.textBoxPassword.PasswordChar = '*';
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(100, 98);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(140, 21);
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(30, 140);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 30);
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Location = new System.Drawing.Point(160, 140);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(100, 30);
            this.buttonGuest.Text = "Гость";
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(30, 185);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.labelError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
