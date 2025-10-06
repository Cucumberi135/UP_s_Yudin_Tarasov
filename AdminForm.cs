using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadMaterials();
            LoadOrders();
            LoadPartners();
            LoadUsers();
            LoadLoginHistory();
        }

        private void LoadMaterials()
        {
            dataGridViewMaterials.Columns.Add("Name", "Наименование");
            dataGridViewMaterials.Columns.Add("Qty", "Количество");
            dataGridViewMaterials.Columns.Add("Price", "Цена");
            dataGridViewMaterials.Rows.Add("Цемент", 50, 320);
            dataGridViewMaterials.Rows.Add("Арматура", 80, 700);
        }

        private void LoadOrders()
        {
            dataGridViewOrders.Columns.Add("ID", "ID");
            dataGridViewOrders.Columns.Add("Client", "Клиент");
            dataGridViewOrders.Columns.Add("Status", "Статус");
            dataGridViewOrders.Rows.Add("001", "ООО МостСтрой", "Оплачено");
            dataGridViewOrders.Rows.Add("002", "ЗАО Лидер", "В обработке");
        }

        private void LoadPartners()
        {
            dataGridViewPartners.Columns.Add("Name", "Партнёр");
            dataGridViewPartners.Columns.Add("Contact", "Контакт");
            dataGridViewPartners.Columns.Add("Rating", "Рейтинг");
            dataGridViewPartners.Rows.Add("ООО МостСтрой", "+7 900 111 22 33", "5★");
        }

        private void LoadUsers()
        {
            dataGridViewUsers.Columns.Add("Login", "Логин");
            dataGridViewUsers.Columns.Add("Role", "Роль");
            dataGridViewUsers.Columns.Add("FullName", "ФИО");
            dataGridViewUsers.Rows.Add("admin", "Администратор", "Иванов И.И.");
            dataGridViewUsers.Rows.Add("manager1", "Менеджер", "Петров П.П.");
        }

        private void LoadLoginHistory()
        {
            dataGridViewLoginHistory.Columns.Add("DateTime", "Время");
            dataGridViewLoginHistory.Columns.Add("Login", "Логин");
            dataGridViewLoginHistory.Columns.Add("Result", "Результат");
            dataGridViewLoginHistory.Rows.Add("2025-10-03 14:20", "admin", "Успешно");
            dataGridViewLoginHistory.Rows.Add("2025-10-03 14:23", "guest", "Ошибка пароля");
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление пользователя (заглушка)");
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменение пользователя (заглушка)");
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
                MessageBox.Show("Пользователь удалён (заглушка)");
            else
                MessageBox.Show("Выберите пользователя для удаления");
        }

        private void textBoxFilterLogin_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLoginHistory.Rows)
            {
                row.Visible = row.Cells[1].Value.ToString()
                    .IndexOf(textBoxFilterLogin.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
