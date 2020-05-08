using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusesApplication
{
    public partial class Scientists : Form
    {
        private SqlConnection cnn;
        private Form form;

        public Scientists(SqlConnection connection, Form mainForm)
        {
            form = mainForm;
            cnn = connection;
            InitializeComponent();
        }

        private bool CountryValidator(string country)
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            List<string> countries = new List<string>();
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.Name);
                if (!(countries.Contains(region.EnglishName)))
                {
                    countries.Add(region.EnglishName);
                }
            }
            foreach (string name in countries)
            {
                if (country == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void Scientists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'virusesDBDataSet2.Scientist' table. You can move, or remove it, as needed.
            this.scientistTableAdapter.Fill(this.virusesDBDataSet2.Scientist);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string id = sId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = sName.Text;
                string country = sCou.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet2.Scientist.Select(searchId);
                DataRow[] rowName = virusesDBDataSet2.Scientist.Select(searchName);
                Regex regex = new Regex("^([a-zA-Z]{2,}\\s[a-zA-z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");
                if (rowId.Length == 0 && rowName.Length == 0 && regex.IsMatch(name) && CountryValidator(country))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "INSERT INTO Scientist (Id, Name, Country) " +
                        "VALUES ('" + id + "','" + name + "','" + country + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.scientistTableAdapter.Fill(this.virusesDBDataSet2.Scientist);
                    SGrid.Refresh();
                    SGrid.Update();
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
            string id = sId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string name = sName.Text;
                string country = sCou.Text;
                string searchId = "Id = " + id;
                string searchName = "Name = '" + name + "'";
                DataRow[] rowId = virusesDBDataSet2.Scientist.Select(searchId);
                DataRow[] rowName = virusesDBDataSet2.Scientist.Select(searchName);
                Regex regex = new Regex("^([a-zA-Z]{2,}\\s[a-zA-z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");

                if (rowId.Length == 1 && rowName.Length == 0 && regex.IsMatch(name) && CountryValidator(country))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE Scientist SET Name = '" + name + "', Country ='" + country + "' Where Id = " + id;
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.scientistTableAdapter.Fill(this.virusesDBDataSet2.Scientist);
                    SGrid.Refresh();
                    SGrid.Update();
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
            string id = sId.Text;
            Regex regexId = new Regex(@"^[1-9]\d*$");
            if (regexId.IsMatch(id))
            {
                string searchId = "Id = " + id;
                DataRow[] rowId = virusesDBDataSet2.Scientist.Select(searchId);
                SqlDataAdapter adapter = new SqlDataAdapter();
                String vCheck = "Select Id from VirusScientist where ScientistId = '" + id + "'";
                adapter.SelectCommand = new SqlCommand(vCheck, cnn);
                Object check = adapter.SelectCommand.ExecuteScalar();
                if (rowId.Length == 1 && check == null)
                {
                    String sql = "DELETE from Scientist Where Id = " + id;
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    this.scientistTableAdapter.Fill(this.virusesDBDataSet2.Scientist);
                    SGrid.Refresh();
                    SGrid.Update();
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
