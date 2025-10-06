using System.Windows.Forms;

namespace LoginApp
{
    partial class ManagerForm
    {
        private TabControl tabControlMain;
        private TabPage tabPageMaterials;
        private TabPage tabPageOrders;
        private TabPage tabPagePartners;
        private DataGridView dataGridViewMaterials;
        private DataGridView dataGridViewOrders;
        private DataGridView dataGridViewPartners;
        private Button buttonAddMaterial;
        private Button buttonEditMaterial;
        private Button buttonDeleteMaterial;

        private void InitializeComponent()
        {
            this.tabControlMain = new TabControl();
            this.tabPageMaterials = new TabPage("Материалы");
            this.tabPageOrders = new TabPage("Заявки");
            this.tabPagePartners = new TabPage("Партнёры");
            this.dataGridViewMaterials = new DataGridView();
            this.dataGridViewOrders = new DataGridView();
            this.dataGridViewPartners = new DataGridView();
            this.buttonAddMaterial = new Button();
            this.buttonEditMaterial = new Button();
            this.buttonDeleteMaterial = new Button();

            this.SuspendLayout();

            // tabControlMain
            this.tabControlMain.Location = new System.Drawing.Point(10, 10);
            this.tabControlMain.Size = new System.Drawing.Size(780, 420);
            this.tabControlMain.Controls.Add(this.tabPageMaterials);
            this.tabControlMain.Controls.Add(this.tabPageOrders);
            this.tabControlMain.Controls.Add(this.tabPagePartners);

            // ===== Материалы =====
            this.dataGridViewMaterials.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewMaterials.Size = new System.Drawing.Size(740, 300);
            this.dataGridViewMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.buttonAddMaterial.Text = "Добавить";
            this.buttonAddMaterial.Location = new System.Drawing.Point(10, 320);
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);

            this.buttonEditMaterial.Text = "Изменить";
            this.buttonEditMaterial.Location = new System.Drawing.Point(120, 320);
            this.buttonEditMaterial.Click += new System.EventHandler(this.buttonEditMaterial_Click);

            this.buttonDeleteMaterial.Text = "Удалить";
            this.buttonDeleteMaterial.Location = new System.Drawing.Point(230, 320);
            this.buttonDeleteMaterial.Click += new System.EventHandler(this.buttonDeleteMaterial_Click);

            this.tabPageMaterials.Controls.Add(this.dataGridViewMaterials);
            this.tabPageMaterials.Controls.Add(this.buttonAddMaterial);
            this.tabPageMaterials.Controls.Add(this.buttonEditMaterial);
            this.tabPageMaterials.Controls.Add(this.buttonDeleteMaterial);

            // ===== Заявки =====
            this.dataGridViewOrders.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOrders.Size = new System.Drawing.Size(740, 350);
            this.dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);

            // ===== Партнёры =====
            this.dataGridViewPartners.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewPartners.Size = new System.Drawing.Size(740, 350);
            this.dataGridViewPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabPagePartners.Controls.Add(this.dataGridViewPartners);

            // ===== Форма =====
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Интерфейс менеджера";
            this.ResumeLayout(false);
        }
    }
}
