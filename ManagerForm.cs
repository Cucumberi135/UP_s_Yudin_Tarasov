using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            LoadMaterials();
            LoadOrders();
            LoadPartners();
        }

        private void LoadMaterials()
        {
            dataGridViewMaterials.Columns.Add("Name", "Наименование");
            dataGridViewMaterials.Columns.Add("Qty", "Количество");
            dataGridViewMaterials.Columns.Add("Price", "Цена");

            dataGridViewMaterials.Rows.Add("Цемент", 50, 320);
            dataGridViewMaterials.Rows.Add("Кирпич", 200, 12);
            dataGridViewMaterials.Rows.Add("Арматура", 80, 700);
        }

        private void LoadOrders()
        {
            dataGridViewOrders.Columns.Add("OrderID", "ID заявки");
            dataGridViewOrders.Columns.Add("Client", "Клиент");
            dataGridViewOrders.Columns.Add("Status", "Статус");

            dataGridViewOrders.Rows.Add("001", "ООО МостСтрой", "Ожидает оплаты");
            dataGridViewOrders.Rows.Add("002", "ЗАО Лидер", "В обработке");
        }

        private void LoadPartners()
        {
            dataGridViewPartners.Columns.Add("PartnerName", "Партнёр");
            dataGridViewPartners.Columns.Add("Contact", "Контакт");
            dataGridViewPartners.Columns.Add("Rating", "Рейтинг");

            dataGridViewPartners.Rows.Add("ООО МостСтрой", "+7 900 123 45 67", "5★");
            dataGridViewPartners.Rows.Add("ЗАО Лидер", "+7 921 777 99 00", "4★");
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление материала (заглушка)");
        }

        private void buttonEditMaterial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование материала (заглушка)");
        }

        private void buttonDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterials.SelectedRows.Count > 0)
                MessageBox.Show("Материал удалён (заглушка)");
            else
                MessageBox.Show("Выберите материал для удаления");
        }
    }
}
