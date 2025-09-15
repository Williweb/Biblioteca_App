using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using BibliotecaApp.Models;
using BibliotecaApp.Repository;
using Microsoft.VisualBasic; // Para InputBox

namespace BibliotecaApp
{
    public partial class MainForm : Form
    {
        private LibraryRepository repo = new LibraryRepository();
        private readonly string pathBooks = "books.json";
        private readonly string pathUsers = "users.json";
        private readonly string pathLoans = "loans.json";

        public MainForm()
        {
            InitializeComponent();

            // Eventos
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;

            btnAddBook.Click += BtnAddBook_Click;
            btnRemoveBook.Click += BtnRemoveBook_Click;
            btnAddUser.Click += BtnAddUser_Click;
            btnRemoveUser.Click += BtnRemoveUser_Click;
            btnAddLoan.Click += BtnAddLoan_Click;
            btnReturnLoan.Click += BtnReturnLoan_Click;
        }

        // ---------------- Evento Load ----------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            RefreshData();
            ApplyVisualStyles(); // Aplicar mejoras visuales
        }

        // ---------------- Botones Libros ----------------
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            var title = Prompt("Título:"); if (string.IsNullOrWhiteSpace(title)) return;
            var author = Prompt("Autor:"); if (string.IsNullOrWhiteSpace(author)) return;
            var isbn = Prompt("ISBN:"); if (string.IsNullOrWhiteSpace(isbn)) return;
            var copiesStr = Prompt("Número de copias:");
            if (!int.TryParse(copiesStr, out int copies) || copies < 1) { MessageBox.Show("Número de copias inválido"); return; }

            repo.AddBook(new Book { Title = title, Author = author, ISBN = isbn, Copies = copies });
            RefreshData();
        }

        private void BtnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                var book = dgvBooks.CurrentRow.DataBoundItem as Book;
                repo.RemoveBook(book.Id);
                RefreshData();
            }
        }

        // ---------------- Botones Usuarios ----------------
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            var name = Prompt("Nombre:"); if (string.IsNullOrWhiteSpace(name)) return;
            var email = Prompt("Correo:"); if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) { MessageBox.Show("Correo inválido"); return; }

            repo.AddUser(new User { Name = name, Email = email });
            RefreshData();
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                var user = dgvUsers.CurrentRow.DataBoundItem as User;
                repo.RemoveUser(user.Id);
                RefreshData();
            }
        }

        // ---------------- Botones Préstamos ----------------
        private void BtnAddLoan_Click(object sender, EventArgs e)
        {
            if (repo.Users.Count == 0 || repo.Books.Count == 0) { MessageBox.Show("Debe haber al menos un usuario y un libro."); return; }

            var user = SelectFromList("Seleccionar usuario", repo.Users.Cast<object>().ToList()) as User;
            var book = SelectFromList("Seleccionar libro", repo.Books.Where(b => b.Copies > 0).Cast<object>().ToList()) as Book;

            if (user == null || book == null) return;

            repo.AddLoan(new Loan { UserId = user.Id, BookId = book.Id, LoanDate = DateTime.Now, Returned = false });
            book.Copies--;
            RefreshData();
        }

        private void BtnReturnLoan_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                var loan = dgvLoans.CurrentRow.DataBoundItem as Loan;
                if (!loan.Returned)
                {
                    loan.Returned = true;
                    loan.ReturnDate = DateTime.Now;
                    var book = repo.Books.FirstOrDefault(b => b.Id == loan.BookId);
                    if (book != null) book.Copies++;
                }
                RefreshData();
            }
        }

        // ---------------- Persistencia JSON ----------------
        private void LoadData()
        {
            if (File.Exists(pathBooks)) repo.Books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(pathBooks)) ?? new List<Book>();
            if (File.Exists(pathUsers)) repo.Users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(pathUsers)) ?? new List<User>();
            if (File.Exists(pathLoans)) repo.Loans = JsonSerializer.Deserialize<List<Loan>>(File.ReadAllText(pathLoans)) ?? new List<Loan>();
        }

        private void SaveData()
        {
            File.WriteAllText(pathBooks, JsonSerializer.Serialize(repo.Books));
            File.WriteAllText(pathUsers, JsonSerializer.Serialize(repo.Users));
            File.WriteAllText(pathLoans, JsonSerializer.Serialize(repo.Loans));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => SaveData();

        // ---------------- Refrescar DataGridViews ----------------
        private void RefreshData()
        {
            dgvBooks.DataSource = null; dgvBooks.DataSource = repo.Books.ToList();
            dgvUsers.DataSource = null; dgvUsers.DataSource = repo.Users.ToList();
            dgvLoans.DataSource = null;
            dgvLoans.DataSource = repo.Loans.Select(l => new
            {
                l.Id,
                Usuario = repo.Users.FirstOrDefault(u => u.Id == l.UserId)?.Name,
                Libro = repo.Books.FirstOrDefault(b => b.Id == l.BookId)?.Title,
                l.LoanDate,
                l.ReturnDate,
                l.Returned
            }).ToList();

            dgvStats.DataSource = null;
            dgvStats.DataSource = repo.Loans.GroupBy(l => l.BookId).Select(g => new
            {
                Libro = repo.Books.FirstOrDefault(b => b.Id == g.Key)?.Title,
                TotalPrestamos = g.Count()
            }).OrderByDescending(x => x.TotalPrestamos).ToList();
        }

        // ---------------- Mejoras visuales ----------------
        private void ApplyVisualStyles()
        {
            // DataGridViews
            var dgvList = new List<DataGridView> { dgvBooks, dgvUsers, dgvLoans, dgvStats };
            foreach (var dgv in dgvList)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;
                dgv.ReadOnly = true;
                dgv.RowHeadersVisible = false;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.Font = new System.Drawing.Font("Segoe UI", 10);
            }

            // Resaltar préstamos
            dgvLoans.CellFormatting += (s, e) =>
            {
                if (dgvLoans.Columns[e.ColumnIndex].Name == "Returned")
                {
                    if (e.Value != null && e.Value is bool returned)
                    {
                        e.CellStyle.BackColor = returned ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightCoral;
                    }
                }
            };

            // Botones
            var btnList = new List<Button> { btnAddBook, btnRemoveBook, btnAddUser, btnRemoveUser, btnAddLoan, btnReturnLoan };
            foreach (var btn in btnList)
            {
                btn.BackColor = System.Drawing.Color.MidnightBlue;
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(5);
            }
        }

        // ---------------- Utilidades ----------------
        private string Prompt(string text) => Interaction.InputBox(text, "BibliotecaApp", "");

        private object SelectFromList(string title, List<object> items)
        {
            if (items.Count == 0) return null;
            using (var form = new Form { Text = title, Size = new System.Drawing.Size(300, 400) })
            {
                var list = new ListBox { Dock = DockStyle.Fill };
                list.Items.AddRange(items.ToArray());
                form.Controls.Add(list);
                var btnOk = new Button { Text = "OK", Dock = DockStyle.Bottom };
                btnOk.Click += (s, e) => form.DialogResult = DialogResult.OK;
                form.Controls.Add(btnOk);
                return form.ShowDialog() == DialogResult.OK ? list.SelectedItem : null;
            }
        }
    }
}