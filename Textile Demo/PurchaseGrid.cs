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
using System.IO;


namespace Textile_Demo
{
    public partial class PurchaseGrid : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HansikaPerera\Documents\Potenza Demo\Textile Demo\Textile Demo\Textile Demo\DemoApparelDB.mdf;Integrated Security = True; Connect Timeout = 30");

        public PurchaseGrid()
        {
            InitializeComponent();
    
        }

        private void PurchaseGrid_Load(object sender, EventArgs e)
        {          
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("PurchaseViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@item", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }



        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedRows.Add(row);
            }

            PurchaseMainGrid oForm = new PurchaseMainGrid(this);
            oForm.Rows = selectedRows;
            this.Hide();

            oForm.Show();
            PurchaseOrder po1 = new PurchaseOrder();
            po1.Hide();

        }

    }
}
