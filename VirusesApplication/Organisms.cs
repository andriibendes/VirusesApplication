using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace VirusesApplication
{
    public partial class Organisms : Form
    {
        private SqlConnection cnn;
        private Form form;
        public Organisms(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Organisms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet.Organism' table. You can move, or remove it, as needed.
            this.organismTableAdapter.Fill(this.virusesDBDataSet.Organism);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_org_button_Click(object sender, EventArgs e)
        {
            string id = orgId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = orgName.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet.Organism.Select(searchId);
                DataRow[] rowName = virusesDBDataSet.Organism.Select(searchName);
                Regex regexName = new Regex(@"^[A-Z][a-z]+");

                if (rowId.Length == 0 && rowName.Length == 0 && regexName.IsMatch(name))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "INSERT INTO Organism (Id, Name) " +
                        "VALUES ('" + id + "','" + name + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.organismTableAdapter.Fill(this.virusesDBDataSet.Organism);
                    OrganismsGrid.Refresh();
                    OrganismsGrid.Update();
                }
                else
                {
                    MessageBox.Show("Name is not correct or element with this ID or Name is in table!");
                }
            }
            else
            {
                MessageBox.Show("Id is not correct!");
            }
        }

        private void upd_org_button_Click(object sender, EventArgs e)
        {
            string id = orgId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = orgName.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet.Organism.Select(searchId);
                DataRow[] rowName = virusesDBDataSet.Organism.Select(searchName);
                Regex regexName = new Regex(@"^[A-Z][a-z]+");

                if (rowId.Length == 1 && rowName.Length == 0 && regexName.IsMatch(name))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE Organism SET Name = '" + name + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.organismTableAdapter.Fill(this.virusesDBDataSet.Organism);
                    OrganismsGrid.Refresh();
                    OrganismsGrid.Update();
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

        private void del_org_button_Click(object sender, EventArgs e)
        {
            string id = orgId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet.Organism.Select(searchId);
                SqlDataAdapter adapter = new SqlDataAdapter();
                String vCheck = "Select Id from Virus where OrganismId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(vCheck, cnn);
                Object check = adapter.SelectCommand.ExecuteScalar();
                if (rowId.Length == 1 && check == null)
                {
                    String sql = "DELETE from Organism Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.organismTableAdapter.Fill(this.virusesDBDataSet.Organism);
                    OrganismsGrid.Refresh();
                    OrganismsGrid.Update();
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

        private void back_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Close();
        }
    }
}
