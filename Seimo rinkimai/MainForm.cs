using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Seimo_rinkimai
{
    public partial class MainForm : Form
    {
        public SqlConnection Connection { get; set; }
        public string ConnectionString { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ConnectionString =
                ConfigurationManager.ConnectionStrings["Seimo_rinkimai.Properties.Settings.DuombazeConnectionString"]
                    .ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GautiKandidatus();
        }

        private void GautiKandidatus()
        {
            string uzklausa = "SELECT * FROM Kandidatai";

            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapteris = new SqlDataAdapter(uzklausa, Connection))
            {
                DataTable duomenys = new DataTable();
                adapteris.Fill(duomenys);

                listBox1.DisplayMember = "Pavarde";
                listBox1.ValueMember = "Id";
                listBox1.DataSource = duomenys;
            }
        }

        private void GautiVienaKandidata()
        {
            string uzklausa = "SELECT * FROM Kandidatai WHERE Id = @Id";

            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand komanda = new SqlCommand(uzklausa, Connection))
            using (SqlDataAdapter adapteris = new SqlDataAdapter(komanda))
            {
                komanda.Parameters.AddWithValue("@Id", listBox1.SelectedValue);

                DataTable duomenys = new DataTable();
                adapteris.Fill(duomenys);

                textBoxVardas.Text = duomenys.Rows[0]["Vardas"].ToString();
                textBoxPavarde.Text = duomenys.Rows[0]["Pavarde"].ToString();
                textBoxAmzius.Text = duomenys.Rows[0]["Amzius"].ToString();
                textBoxTeistumas.Text = duomenys.Rows[0]["Teistumas"].ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Id: " + listBox1.SelectedValue);

            GautiVienaKandidata();
        }

        private void buttonNaujas_Click(object sender, EventArgs e)
        {
            string uzklausa = "INSERT INTO Kandidatai VALUES (@Vardas, @Pavarde, @Amzius, @Teistumas)";

            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(uzklausa, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@Vardas", textBoxNaujasVardas.Text);
                command.Parameters.AddWithValue("@Pavarde", textBoxNaujaPavarde.Text);
                command.Parameters.AddWithValue("@Amzius", textBoxNaujasAmzius.Text);
                command.Parameters.AddWithValue("@Teistumas", textBoxNaujasTeistumas.Text);
                command.ExecuteNonQuery();
                textBoxNaujasVardas.Text = "";
                textBoxNaujaPavarde.Text = "";
                textBoxNaujasAmzius.Text = "";
                textBoxNaujasTeistumas.Text = "";
            }

            GautiKandidatus();
        }

        private void buttonIstrinti_Click(object sender, EventArgs e)
        {
            string uzklausa = "DELETE FROM Kandidatai WHERE Id = @Id";

            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(uzklausa, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@Id", listBox1.SelectedValue);
                command.ExecuteNonQuery();
            }

            GautiKandidatus();
        }
    }
}
