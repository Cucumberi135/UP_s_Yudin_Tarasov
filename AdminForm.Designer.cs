using System.Windows.Forms;

namespace LoginApp
{
    partial class AdminForm
    {
        private TabControl tabControlAdmin;
        private TabPage tabPageMaterials;
        private TabPage tabPageOrders;
        private TabPage tabPagePartners;
        private TabPage tabPageUsers;
        private TabPage tabPageLoginHistory;

        private DataGridView dataGridViewMaterials;
        private DataGridView dataGridViewOrders;
        private DataGridView dataGridViewPartners;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewLoginHistory;

        private Button buttonAddUser;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private TextBox textBoxFilterLogin;
        private Label labelFilter;
        private Button buttonLogout;

        private void InitializeComponent()
        {
            this.tabControlAdmin = new TabControl();
            this.tabPageMaterials = new TabPage("Материалы");
            this.tabPageOrders = new TabPage("Заявки");
            this.tabPagePartners = new TabPage("Партнёры");
            this.tabPageUsers = new TabPage("Пользователи");
            this.tabPageLoginHistory = new TabPage("История входов");

            this.dataGridViewMaterials = new DataGridView();
            this.dataGridViewOrders = new DataGridView();
            this.dataGridViewPartners = new DataGridView();
            this.dataGridViewUsers = new DataGridView();
            this.dataGridViewLoginHistory = new DataGridView();

            this.buttonAddUser = new Button();
            this.buttonEditUser = new Button();
            this.buttonDeleteUser = new Button();
            this.textBoxFilterLogin = new TextBox();
            this.labelFilter = new Label();
            this.buttonLogout = new Button();

            this.SuspendLayout();

            // tabControlAdmin
            this.tabControlAdmin.Location = new System.Drawing.Point(10, 10);
            this.tabControlAdmin.Size = new System.Drawing.Size(900, 450);
            this.tabControlAdmin.Controls.Add(this.tabPageMaterials);
            this.tabControlAdmin.Controls.Add(this.tabPageOrders);
            this.tabControlAdmin.Controls.Add(this.tabPagePartners);
            this.tabControlAdmin.Controls.Add(this.tabPageUsers);
            this.tabControlAdmin.Controls.Add(this.tabPageLoginHistory);

            // ===== Материалы =====
            this.dataGridViewMaterials.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewMaterials.Size = new System.Drawing.Size(860, 380);
            this.dataGridViewMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabPageMaterials.Controls.Add(this.dataGridViewMaterials);

            // ===== Заявки =====
            this.dataGridViewOrders.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOrders.Size = new System.Drawing.Size(860, 380);
            this.dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);

            // ===== Партнёры =====
            this.dataGridViewPartners.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewPartners.Size = new System.Drawing.Size(860, 380);
            this.dataGridViewPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabPagePartners.Controls.Add(this.dataGridViewPartners);

            // ===== Пользователи =====
            this.dataGridViewUsers.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewUsers.Size = new System.Drawing.Size(860, 300);
            this.dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.Location = new System.Drawing.Point(10, 330);
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);

            this.buttonEditUser.Text = "Изменить";
            this.buttonEditUser.Location = new System.Drawing.Point(120, 330);
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);

            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.Location = new System.Drawing.Point(230, 330);
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);

            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Controls.Add(this.buttonAddUser);
            this.tabPageUsers.Controls.Add(this.buttonEditUser);
            this.tabPageUsers.Controls.Add(this.buttonDeleteUser);

            // ===== История входов =====
            this.dataGridViewLoginHistory.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewLoginHistory.Size = new System.Drawing.Size(860, 350);
            this.dataGridViewLoginHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.labelFilter.Text = "Фильтр по логину:";
            this.labelFilter.Location = new System.Drawing.Point(10, 20);

            this.textBoxFilterLogin.Location = new System.Drawing.Point(150, 17);
            this.textBoxFilterLogin.Width = 200;
            this.textBoxFilterLogin.TextChanged += new System.EventHandler(this.textBoxFilterLogin_TextChanged);

            this.tabPageLoginHistory.Controls.Add(this.dataGridViewLoginHistory);
            this.tabPageLoginHistory.Controls.Add(this.textBoxFilterLogin);
            this.tabPageLoginHistory.Controls.Add(this.labelFilter);

            // ===== Logout Button =====
            this.buttonLogout.Text = "Выход";
            this.buttonLogout.Location = new System.Drawing.Point(780, 470);
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);

            // ===== Форма =====
            this.ClientSize = new System.Drawing.Size(930, 520);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.buttonLogout);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Интерфейс администратора";
            this.ResumeLayout(false);
        }
    }
}
