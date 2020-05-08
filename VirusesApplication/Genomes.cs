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
    public partial class Genomes : Form
    {
        private SqlConnection cnn;
        private Form form;

        public Genomes(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private void virusesDBDataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Genomes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet1.Genome' table. You can move, or remove it, as needed.
            this.genomeTableAdapter.Fill(this.virusesDBDataSet1.Genome);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string id = genId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = genName.Text;
                string strand = genStrand.Text;
                string sense = genSense.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet1.Genome.Select(searchId);
                DataRow[] rowName = virusesDBDataSet1.Genome.Select(searchName);
                Regex regex = new Regex(@"^[A-Z][a-z]+");
                if (rowId.Length == 0 && rowName.Length == 0 && regex.IsMatch(name) && regex.IsMatch(strand) && regex.IsMatch(sense))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "INSERT INTO Genome (Id, Name, Strand, Sense) " +
                        "VALUES ('" + id + "','" + name + "','" + strand + "','" + sense + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.genomeTableAdapter.Fill(this.virusesDBDataSet1.Genome);
                    GenomeGrid.Refresh();
                    GenomeGrid.Update();
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
            string id = genId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = genName.Text;
                string strand = genStrand.Text;
                string sense = genSense.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet1.Genome.Select(searchId);
                DataRow[] rowName = virusesDBDataSet1.Genome.Select(searchName);
                Regex regex = new Regex(@"^[A-Z][a-z]+");

                if (rowId.Length == 1 && rowName.Length == 0 && regex.IsMatch(name) && regex.IsMatch(strand) && regex.IsMatch(sense))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE Genome SET Name = '" + name + "', Strand ='" + strand + "', Sense ='" + sense + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.genomeTableAdapter.Fill(this.virusesDBDataSet1.Genome);
                    GenomeGrid.Refresh();
                    GenomeGrid.Update();
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
            string id = genId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet1.Genome.Select(searchId);
                SqlDataAdapter adapter = new SqlDataAdapter();
                String vCheck = "Select Id from Virus where GenomeId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(vCheck, cnn);
                Object check = adapter.SelectCommand.ExecuteScalar();
                if (rowId.Length == 1 && check == null)
                {
                    String sql = "DELETE from Genome Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.genomeTableAdapter.Fill(this.virusesDBDataSet1.Genome);
                    GenomeGrid.Refresh();
                    GenomeGrid.Update();
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
