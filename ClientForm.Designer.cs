using System.Windows.Forms;

namespace LoginApp
{
    partial class ClientForm
    {
        private DataGridView dataGridViewMaterials;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private ComboBox comboBoxSuppliers;
        private Label labelSuppliers;
        private ComboBox comboBoxSort;
        private Label labelSort;
        private Button buttonCreateOrder;
        private Button buttonMyOrders;

        private void InitializeComponent()
        {
            dataGridViewMaterials = new DataGridView();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            comboBoxSuppliers = new ComboBox();
            labelSuppliers = new Label();
            comboBoxSort = new ComboBox();
            labelSort = new Label();
            buttonCreateOrder = new Button();
            buttonMyOrders = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterials
            // 
            dataGridViewMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterials.ColumnHeadersHeight = 29;
            dataGridViewMaterials.Location = new Point(20, 80);
            dataGridViewMaterials.Name = "dataGridViewMaterials";
            dataGridViewMaterials.RowHeadersWidth = 51;
            dataGridViewMaterials.Size = new Size(600, 300);
            dataGridViewMaterials.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(80, 20);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 27);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.Location = new Point(20, 20);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(100, 23);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Поиск:";
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.Location = new Point(380, 20);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(150, 28);
            comboBoxSuppliers.TabIndex = 3;
            comboBoxSuppliers.SelectedIndexChanged += comboBoxSuppliers_SelectedIndexChanged;
            // 
            // labelSuppliers
            // 
            labelSuppliers.Location = new Point(300, 20);
            labelSuppliers.Name = "labelSuppliers";
            labelSuppliers.Size = new Size(100, 23);
            labelSuppliers.TabIndex = 4;
            labelSuppliers.Text = "Поставщик:";
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.Items.AddRange(new object[] { "Количество ↑", "Количество ↓" });
            comboBoxSort.Location = new Point(640, 20);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(120, 28);
            comboBoxSort.TabIndex = 5;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // labelSort
            // 
            labelSort.Location = new Point(550, 20);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(100, 23);
            labelSort.TabIndex = 6;
            labelSort.Text = "Сортировка:";
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(20, 400);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(88, 33);
            buttonCreateOrder.TabIndex = 7;
            buttonCreateOrder.Text = "Создать заявку";
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonMyOrders
            // 
            buttonMyOrders.Location = new Point(150, 400);
            buttonMyOrders.Name = "buttonMyOrders";
            buttonMyOrders.Size = new Size(85, 33);
            buttonMyOrders.TabIndex = 8;
            buttonMyOrders.Text = "Мои заявки";
            buttonMyOrders.Click += buttonMyOrders_Click;
            // 
            // ClientForm
            // 
            ClientSize = new Size(853, 482);
            Controls.Add(dataGridViewMaterials);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(labelSuppliers);
            Controls.Add(comboBoxSort);
            Controls.Add(labelSort);
            Controls.Add(buttonCreateOrder);
            Controls.Add(buttonMyOrders);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Интерфейс клиента";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
