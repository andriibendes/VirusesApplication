using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusesApplication
{
    public partial class Discoveries : Form
    {
        private SqlConnection cnn;
        private Form form;

        public Discoveries(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private void Discoveries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet6.VirusScientist' table. You can move, or remove it, as needed.
            this.virusScientistTableAdapter.Fill(this.virusesDBDataSet6.VirusScientist);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string id = dId.Text;
            string vir = dVir.Text;
            string sci = dSci.Text;
            string year = dYear.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id) && regexId.IsMatch(vir) && regexId.IsMatch(sci))
            {
                string searchId = "Id = " + id;
                string searchSci = "Select Id from Scientist Where Id = '" + sci + "'";
                string searchVir = "Select Id from Virus Where Id = '" + vir + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchSci, cnn);
                Object sciCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchVir, cnn);
                Object virCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet6.VirusScientist.Select(searchId);
                if (rowId.Length == 0 && virCounter != null && sciCounter != null && regexId.IsMatch(year) && Int32.Parse(year) >= 1700 && Int32.Parse(year) <= 2020)
                {
                    String sql = "INSERT INTO VirusScientist (Id, VirusId, ScientistId, Year) " +
                        "VALUES ('" + id + "','" + vir + "','" + sci + "','" + year + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.virusScientistTableAdapter.Fill(this.virusesDBDataSet6.VirusScientist);
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Element is not correct or element with this ID or Name is in table!");
                }
            }
            else
            {
                MessageBox.Show("Id is not correct!");
            }
        }

        private void upd_Click(object sender, EventArgs e)
        {
            string id = dId.Text;
            string vir = dVir.Text;
            string sci = dSci.Text;
            string year = dYear.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id) && regexId.IsMatch(vir) && regexId.IsMatch(sci))
            {
                string searchId = "Id = " + id;
                string searchSci = "Select Id from Scientist Where Id = '" + sci + "'";
                string searchVir = "Select Id from Virus Where Id = '" + vir + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchSci, cnn);
                Object sciCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchVir, cnn);
                Object virCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet6.VirusScientist.Select(searchId);
                if (rowId.Length == 1 && virCounter != null && sciCounter != null && regexId.IsMatch(year) && Int32.Parse(year) >= 1700 && Int32.Parse(year) <= 2020)
                {
                    String sql = "UPDATE VirusScientist SET ScientistId ='" + sci + "', VirusId ='" + vir + "', Year ='" + year + "' Where Id = " + id;
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.virusScientistTableAdapter.Fill(this.virusesDBDataSet6.VirusScientist);
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Element is not correct!");
                }
            }
            else
            {
                MessageBox.Show("Id is not correct!");
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            string id = dId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet6.VirusScientist.Select(searchId);

                if (rowId.Length == 1)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "DELETE from VirusScientist Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.virusScientistTableAdapter.Fill(this.virusesDBDataSet6.VirusScientist);
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Element with this ID is not in table!");
                }
            }
            else
            {
                MessageBox.Show("Id is not correct!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Close();
        }
    }
}
