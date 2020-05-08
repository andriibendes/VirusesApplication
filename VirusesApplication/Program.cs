using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusesApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-MO7NEDDO8MB\SQLEXPRESS;Initial Catalog=VirusesDB;User ID=sa;Password=12";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            Application.Run(new MainForm(cnn));
        }
    }
}
