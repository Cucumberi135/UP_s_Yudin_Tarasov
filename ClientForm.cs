using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                row.Visible = row.Cells[0].Value.ToString()
                    .IndexOf(textBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxSuppliers.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                row.Visible = (selected == "Все поставщики" ||
                               row.Cells[1].Value.ToString() == selected);
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort.SelectedIndex == 0)
                dataGridViewMaterials.Sort(dataGridViewMaterials.Columns[2],
                    System.ComponentModel.ListSortDirection.Ascending);
            else if (comboBoxSort.SelectedIndex == 1)
                dataGridViewMaterials.Sort(dataGridViewMaterials.Columns[2],
                    System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма создания заявки (пока заглушка)");
        }

        private void buttonMyOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма просмотра моих заявок (пока заглушка)");
        }
    }
}
