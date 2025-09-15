using System;
using System.Windows.Forms;

namespace BibliotecaApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabBooks, tabUsers, tabLoans, tabStats;
        private DataGridView dgvBooks, dgvUsers, dgvLoans, dgvStats;
        private Button btnAddBook, btnRemoveBook;
        private Button btnAddUser, btnRemoveUser;
        private Button btnAddLoan, btnReturnLoan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Tabs
            this.tabControl = new TabControl();
            this.tabBooks = new TabPage("Libros");
            this.tabUsers = new TabPage("Usuarios");
            this.tabLoans = new TabPage("Préstamos");
            this.tabStats = new TabPage("Estadísticas");

            this.tabControl.Controls.AddRange(new Control[] { tabBooks, tabUsers, tabLoans, tabStats });
            this.tabControl.Dock = DockStyle.Fill;

            // DataGridViews
            dgvBooks = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };
            dgvUsers = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };
            dgvLoans = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };
            dgvStats = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };

            // Botones
            btnAddBook = new Button { Text = "➕ Agregar Libro" };
            btnRemoveBook = new Button { Text = "🗑️ Eliminar Libro" };
            btnAddUser = new Button { Text = "➕ Agregar Usuario" };
            btnRemoveUser = new Button { Text = "🗑️ Eliminar Usuario" };
            btnAddLoan = new Button { Text = "➕ Prestar Libro" };
            btnReturnLoan = new Button { Text = "✅ Devolver Libro" };

            // Layout Libros
            var flowBooks = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true };
            flowBooks.Controls.AddRange(new Control[] { btnAddBook, btnRemoveBook });
            var panelBooks = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 };
            panelBooks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelBooks.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBooks.Controls.Add(flowBooks, 0, 0);
            panelBooks.Controls.Add(dgvBooks, 0, 1);
            tabBooks.Controls.Add(panelBooks);

            // Layout Usuarios
            var flowUsers = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true };
            flowUsers.Controls.AddRange(new Control[] { btnAddUser, btnRemoveUser });
            var panelUsers = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 };
            panelUsers.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelUsers.Controls.Add(flowUsers, 0, 0);
            panelUsers.Controls.Add(dgvUsers, 0, 1);
            tabUsers.Controls.Add(panelUsers);

            // Layout Préstamos
            var flowLoans = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true };
            flowLoans.Controls.AddRange(new Control[] { btnAddLoan, btnReturnLoan });
            var panelLoans = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 };
            panelLoans.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelLoans.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelLoans.Controls.Add(flowLoans, 0, 0);
            panelLoans.Controls.Add(dgvLoans, 0, 1);
            tabLoans.Controls.Add(panelLoans);

            // Estadísticas
            tabStats.Controls.Add(dgvStats);

            // Form
            this.Text = "📚 BibliotecaApp";
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
        }
    }
}