using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD_MSSQL
{
    public partial class Form1 : Form
    {
        private string ConnectionString;
        private SqlConnection connection = null;
        private string SQLExpression = "SELECT * FROM metrics";

        public Form1()
        {
            InitializeComponent();
            tbConnectionStr.Text = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";
        }
    }
}
