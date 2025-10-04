using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "123")
                MessageBox.Show($"Добро пожаловать, {textBoxLogin.Text}!");
            else
                labelError.Text = "Неверный логин или пароль";
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вход как гость");
        }
    }
}
