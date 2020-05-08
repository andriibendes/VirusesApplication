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
    public partial class Medicine : Form
    {
        private SqlConnection cnn;
        private Form form;
        public Medicine(SqlConnection connection, Form mainFrom)
        {
            form = mainFrom;
            cnn = connection;
            InitializeComponent();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet5.VirusDrug' table. You can move, or remove it, as needed.
            this.virusDrugTableAdapter.Fill(this.virusesDBDataSet5.VirusDrug);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = mId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet5.VirusDrug.Select(searchId);

                if (rowId.Length == 1)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "DELETE from VirusDrug Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.virusDrugTableAdapter.Fill(this.virusesDBDataSet5.VirusDrug);
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

        private void add_Click(object sender, EventArgs e)
        {
            string id = mId.Text;
            string vir = mVir.Text;
            string drug = mDrug.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id) && regexId.IsMatch(vir) && regexId.IsMatch(drug))
            {
                string searchId = "Id = " + id;
                string searchDrug = "Select Id from Drug Where Id = '" + drug + "'";
                string searchVir = "Select Id from Virus Where Id = '" + vir + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchDrug, cnn);
                Object drugCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchVir, cnn);
                Object virCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet5.VirusDrug.Select(searchId);
                if (rowId.Length == 0 && virCounter != null && drugCounter != null)
                {
                    String sql = "INSERT INTO VirusDrug (Id, VirusId, DrugId) " +
                        "VALUES ('" + id + "','" + vir + "','" + drug + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.virusDrugTableAdapter.Fill(this.virusesDBDataSet5.VirusDrug);
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
            string id = mId.Text;
            string vir = mVir.Text;
            string drug = mDrug.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id) && regexId.IsMatch(vir) && regexId.IsMatch(drug))
            {
                string searchId = "Id = " + id;
                string searchDrug = "Select Id from Drug Where Id = '" + drug + "'";
                string searchVir = "Select Id from Virus Where Id = '" + vir + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchDrug, cnn);
                Object drugCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchVir, cnn);
                Object virCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet5.VirusDrug.Select(searchId);
                if (rowId.Length == 1 && virCounter != null && drugCounter != null)
                {
                    String sql = "UPDATE VirusDrug SET DrugId = '" + drug + "', VirusId ='" + vir + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.virusDrugTableAdapter.Fill(this.virusesDBDataSet5.VirusDrug);
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

        private void button1_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Close();
        }
    }
}
