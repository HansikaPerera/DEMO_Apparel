using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textile_Demo
{
    public partial class PurchaseMainGrid : Form
    {
        public PurchaseMainGrid(PurchaseGrid parent)
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in parent.dataGridView1.Columns)
            {
                dataGridView.Columns.Add(column.Clone() as DataGridViewColumn);
            }

            foreach (DataGridViewRow row in parent.dataGridView1.SelectedRows)
            {
                int index = dataGridView.Rows.Add(row.Clone() as DataGridViewRow);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataGridView.Rows[index].Cells[cell.ColumnIndex].Value = cell.Value;
                }
            }

            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.NavajoWhite;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.Lavender;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView.Rows.Add();
            this.Hide();
            PurchaseOrder po01 = new PurchaseOrder();
            PurchaseOrder.SetValueForText1 = "";
            PurchaseOrder.SetValueForText2 = "";
            PurchaseOrder.SetValueForText3 = "";
            PurchaseOrder.SetValueForText4 = "";
            PurchaseOrder.SetValueForText5 = "";
            PurchaseOrder.SetValueForText6 = "";
            PurchaseOrder.SetValueForText7 = "";
            PurchaseOrder.SetValueForText8 = "";
            PurchaseOrder.SetValueForText9 = "";
            PurchaseOrder.SetValueForText10 = "";
            PurchaseOrder.SetValueForText11 = "";
        }

        public List<DataGridViewRow> Rows
        {
            get;
            set;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (MerchPanel.Width != 0)
            {
                MerchPanel.Width = 0;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MerchPanel.Width = 250;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (CostPanel.Width != 0)
            {
                CostPanel.Width = 0;
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            CostPanel.Width = 250;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetMaterial cm1 = new CostSheetMaterial();
            cm1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetGroups cg1 = new CostSheetGroups();
            cg1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheet c1 = new CostSheet();
            c1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder po = new PurchaseOrder();
            po.Show();
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox28.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox28.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox28.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            button11.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox32.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox32.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox32.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            button15.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox33.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox33.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox33.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            button20.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox34.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox34.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox34.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button21_MouseClick(object sender, MouseEventArgs e)
        {
            button21.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox35.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox35.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox35.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            button22.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox27.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox36.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox27.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox36.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox27.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox36.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox12.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox13.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox8.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox8.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox8.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox10.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox10.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox7.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox10.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox9.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox9.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox6.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox9.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox3.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            button12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox5.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            button13.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox1.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void PurchaseMainGrid_Load(object sender, EventArgs e)
        {
            PurchaseOrder pp1 = new PurchaseOrder();
            pp1.Hide();

            label8.Text = PurchaseOrder.SetValueForText1;
            label9.Text = PurchaseOrder.SetValueForText2;
            label10.Text = PurchaseOrder.SetValueForText3;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView.Rows.Add();
            this.Hide();
            PurchaseOrder po01 = new PurchaseOrder();
            PurchaseOrder.SetValueForText1 = "";
            PurchaseOrder.SetValueForText2 = "";
            PurchaseOrder.SetValueForText3 = "";
            PurchaseOrder.SetValueForText4 = "";
            PurchaseOrder.SetValueForText5 = "";
            PurchaseOrder.SetValueForText6 = "";
            PurchaseOrder.SetValueForText7 = "";
            PurchaseOrder.SetValueForText8 = "";
            PurchaseOrder.SetValueForText9 = "";
            PurchaseOrder.SetValueForText10 = "";
            PurchaseOrder.SetValueForText11 = "";
        }
    }
}
