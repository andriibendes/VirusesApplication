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
    public partial class Viruses : Form
    {
        private SqlConnection cnn;
        private Form form;

        public Viruses(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private void Viruses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet4.Virus' table. You can move, or remove it, as needed.
            this.virusTableAdapter.Fill(this.virusesDBDataSet4.Virus);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string id = vId.Text;
            string org = vOrg.Text;
            string gen = vGen.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id) && regexId.IsMatch(org) && regexId.IsMatch(gen))
            {
                string name = vName.Text;

                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                string searchOrg = "Select Id from Organism Where Id = '" + org + "'";
                string searchGen = "Select Id from Genome Where Id = '" + gen + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchOrg, cnn);
                Object orgCounter = null;
                orgCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchGen, cnn);
                Object genCounter = null;
                genCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet4.Virus.Select(searchId);
                DataRow[] rowName = virusesDBDataSet4.Virus.Select(searchName);
                Regex regex = new Regex(@"^[A-Z][a-z]+");
                if (rowId.Length == 0 && rowName.Length == 0 && regex.IsMatch(name) && orgCounter != null && genCounter != null)
                {
                    String sql = "INSERT INTO Virus (Id, Name, GenomeId, OrganismId) " +
                        "VALUES ('" + id + "','" + name + "','" + gen + "','" + org + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.virusTableAdapter.Fill(this.virusesDBDataSet4.Virus);
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
            string id = vId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = vName.Text;
                string org = vOrg.Text;
                string gen = vGen.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                string searchOrg = "Select Id from Organism Where Id = '" + org + "'";
                string searchGen = "Select Id from Genome Where Id = '" + gen + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(searchOrg, cnn);
                Object orgCounter = null;
                orgCounter = adapter.SelectCommand.ExecuteScalar();
                adapter.SelectCommand = new SqlCommand(searchGen, cnn);
                Object genCounter = null;
                genCounter = adapter.SelectCommand.ExecuteScalar();
                DataRow[] rowId = virusesDBDataSet4.Virus.Select(searchId);
                DataRow[] rowName = virusesDBDataSet4.Virus.Select(searchName);
                Regex regex = new Regex(@"^[A-Z][a-z]+");
                if (rowId.Length == 1 && rowName.Length == 0 && regex.IsMatch(name) && regexId.IsMatch(org) && regexId.IsMatch(gen) && orgCounter != null && genCounter != null)
                {
                    String sql = "UPDATE Virus SET Name = '" + name + "', GenomeId ='" + gen + "', OrganismId ='" + org + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.virusTableAdapter.Fill(this.virusesDBDataSet4.Virus);
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
            string id = vId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet4.Virus.Select(searchId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                String vCheck = "Select Id from VirusDrug where VirusId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(vCheck, cnn);
                Object vcheck = adapter.SelectCommand.ExecuteScalar();
                String sCheck = "Select Id from VirusScientist where VirusId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(sCheck, cnn);
                Object check = adapter.SelectCommand.ExecuteScalar();
                if (rowId.Length == 1 && vcheck == null && check == null)
                {
                    String sql = "DELETE from Virus Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.virusTableAdapter.Fill(this.virusesDBDataSet4.Virus);
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
