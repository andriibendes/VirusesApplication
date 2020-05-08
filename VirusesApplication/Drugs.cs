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
    public partial class Drugs : Form
    {
        private SqlConnection cnn;
        private Form form;

        public Drugs(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private void Drugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet3.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.virusesDBDataSet3.Drug);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string id = dId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = dName.Text;
                string formula = dForm.Text;
                string cost = dCost.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet3.Drug.Select(searchId);
                DataRow[] rowName = virusesDBDataSet3.Drug.Select(searchName);
                Regex rc = new Regex("^(?=.+)(?:[1-9]\\d*|0)?(?:\\.\\d+)?$");
                Regex regex = new Regex(@"[A-Z][a-z]+");
                Regex regexFormula = new Regex(@"[A-Z][a-z]?\\d*|(?<!\\([^)]*)\\(.*\\)\\d+(?![^(]*\\))");
                if (rowId.Length == 0 && rowName.Length == 0 && regex.IsMatch(name) && regexFormula.IsMatch(formula) && rc.IsMatch(cost))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "INSERT INTO Drug (Id, Name, Formula, Cost) " +
                        "VALUES ('" + id + "','" + name + "','" + formula + "','" + cost + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.drugTableAdapter.Fill(this.virusesDBDataSet3.Drug);
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

        private void Update_Click(object sender, EventArgs e)
        {
            string id = dId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = dName.Text;
                string formula = dForm.Text;
                string cost = dCost.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet3.Drug.Select(searchId);
                DataRow[] rowName = virusesDBDataSet3.Drug.Select(searchName);
                Regex rc = new Regex("^(?=.+)(?:[1-9]\\d*|0)?(?:\\.\\d+)?$");
                Regex regex = new Regex(@"^[A-Z][a-z]+");
                Regex regexFormula = new Regex(@"^[A-Z][a-z]?\\d*|(?<!\\([^)]*)\\(.*\\)\\d+(?![^(]*\\))");

                if (rowId.Length == 1 && rowName.Length == 0 && regex.IsMatch(name) && rc.IsMatch(cost) && regexFormula.IsMatch(formula))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE Drug SET Name = '" + name + "', Formula ='" + formula + "', Cost ='" + cost + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.drugTableAdapter.Fill(this.virusesDBDataSet3.Drug);
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Name is not correct or element with this ID or Name is not in table!");
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
                DataRow[] rowId = virusesDBDataSet3.Drug.Select(searchId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                String vCheck = "Select Id from VirusDrug where DrugId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(vCheck, cnn);
                Object check = adapter.SelectCommand.ExecuteScalar();
                if (rowId.Length == 1 && check == null)
                {
                    String sql = "DELETE from Drug Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.drugTableAdapter.Fill(this.virusesDBDataSet3.Drug);
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Cannot delete this element!");
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
