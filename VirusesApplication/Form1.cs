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

namespace VirusesApplication
{
    public partial class MainForm : Form
    {
        private SqlConnection cnn;
        public MainForm(SqlConnection connection)
        {
            cnn = connection;
            InitializeComponent();
        }

        private void organisms_button_Click(object sender, EventArgs e)
        {
            Organisms organisms = new Organisms(cnn, this);
            organisms.Show();
            this.Visible = false;
        }

        private void genomes_button_Click(object sender, EventArgs e)
        {
            Genomes genomes = new Genomes(cnn, this);
            genomes.Show();
            this.Visible = false;
        }

        private void sci_btn_Click(object sender, EventArgs e)
        {
            Scientists scientists = new Scientists(cnn, this);
            scientists.Show();
            this.Visible = false;
        }

        private void drug_btn_Click(object sender, EventArgs e)
        {
            Drugs drugs = new Drugs(cnn, this);
            drugs.Show();
            this.Visible = false;
        }

        private void vir_btn_Click(object sender, EventArgs e)
        {
            Viruses viruses = new Viruses(cnn, this);
            viruses.Show();
            this.Visible = false;
        }

        private void med_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine(cnn, this);
            medicine.Show();
            this.Visible = false;
        }

        private void dis_Click(object sender, EventArgs e)
        {
            Discoveries discoveries = new Discoveries(cnn, this);
            discoveries.Show();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            DataSet ds = new DataSet();
            string ans = " " ;
            if (one.Checked)
            {
                sql = "Select distinct Virus.Name " +
                    "from Virus inner join ( " +
                    "VirusScientist inner join Scientist " +
                    "on VirusScientist.ScientistId = Scientist.Id) " +
                    "on Virus.Id = VirusScientist.VirusId " +
                    "where Scientist.Country = '" + x.Text + "'";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + " ";
                }
                MessageBox.Show(ans);
            }
            if (two.Checked && Int32.TryParse(x.Text, out int num))
            {
                sql = "Select Virus.Name " +
                    "from Virus inner join ( " +
                    "VirusDrug inner join Drug " +
                    "on VirusDrug.DrugId = Drug.Id) " +
                    "on Virus.Id = VirusDrug.VirusId " +
                    "where Drug.Cost  < " + num;
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (three.Checked)
            {
                sql = "Select Virus.Name from Virus inner join ( " +
                    "VirusScientist inner join Scientist " +
                    "on VirusScientist.ScientistId = Scientist.Id) " +
                    "on Virus.Id = VirusScientist.VirusId" +
                    " where Scientist.Id = ( " +
                    "select Scientist.Id" +
                    " from Virus inner join(" +
                    " VirusScientist inner join Scientist" +
                    " on VirusScientist.ScientistId = Scientist.Id)" +
                    " on Virus.Id = VirusScientist.VirusId" +
                    " where Virus.Name = '" + x.Text + "')";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (four.Checked)
            {
                sql = "Select Virus.Name from Virus inner join Genome " +
                    "on Virus.GenomeId = Genome.Id " +
                    "where Genome.Strand = '" + x.Text + "'";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (six.Checked)
            {
                sql = "Select Drug.Name " +
                    "from Virus inner join ( " +
                    "VirusDrug inner join Drug " +
                    "on VirusDrug.DrugId = Drug.Id) " +
                    "on Virus.Id = VirusDrug.VirusId " +
                    "where Virus.Name = '" + x.Text +"'";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (five.Checked)
            {
                sql = "Select Virus.Name " +
                    "from Virus inner join ( " +
                    "VirusDrug inner join Drug " +
                    "on VirusDrug.DrugId = Drug.Id) " +
                    "on Virus.Id = VirusDrug.VirusId " +
                    "where Drug.Name = '" + x.Text + "')";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (seven.Checked && Int32.TryParse(x.Text, out int number))
            {
                sql = "Select Virus.Name " +
                    "from Virus inner join ( " +
                    "VirusDrug inner join Drug " +
                    "on VirusDrug.DrugId = Drug.Id) " +
                    "on Virus.Id = VirusDrug.VirusId " +
                    "Group by Virus.Name " +
                    "Having Count(distinct Drug.Id) >" + number;
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
            if (eight.Checked)
            {
                sql = "Select distinct Scientist.Name " +
                    "from Virus inner join ( " +
                    "VirusScientist inner join Scientist " +
                    "on VirusScientist.ScientistId = Scientist.Id) " +
                    "on Virus.Id = VirusScientist.VirusId " +
                    "where Virus.Id = ( " +
                    "Select Virus.Id " +
                    "from Virus inner join ( " +
                    "VirusDrug inner join Drug " +
                    "on VirusDrug.DrugId = Drug.Id) " +
                    "on Virus.Id = VirusDrug.VirusId " +
                    "where Drug.Name = '" + x.Text + "'";
                adapter.SelectCommand = new SqlCommand(sql, cnn);
                adapter.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ans += ds.Tables[0].Rows[i].ItemArray[0].ToString() + ", ";
                }
                MessageBox.Show(ans);
            }
        }
    }
}
