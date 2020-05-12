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
    public partial class CostSheet : Form
    {
        private PurchaseGrid parent;

        public CostSheet()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CostPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox1.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox5.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox3.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox9.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox9.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox6.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox9.BackColor = Color.FromArgb(1, 3, 16);
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

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox13.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox12.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            button22.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox36.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox27.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox36.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox27.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox36.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox27.BackColor = Color.FromArgb(1, 3, 16);
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

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox28.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox28.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox28.BackColor = Color.FromArgb(1, 3, 16);
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

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheet c1 = new CostSheet();
            c1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetGroups cg1 = new CostSheetGroups();
            cg1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetMaterial cm1 = new CostSheetMaterial();
            cm1.Show();
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

        private void casual_MouseClick(object sender, MouseEventArgs e)
        {
            casual.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox37.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void casual_MouseEnter(object sender, EventArgs e)
        {
            casual.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox37.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void casual_MouseLeave(object sender, EventArgs e)
        {
            casual.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox37.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void kids_MouseClick(object sender, MouseEventArgs e)
        {
            kids.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox26.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void kids_MouseEnter(object sender, EventArgs e)
        {
            kids.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox26.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void kids_MouseLeave(object sender, EventArgs e)
        {
            kids.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox26.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void party_MouseClick(object sender, MouseEventArgs e)
        {
            party.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox11.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void party_MouseEnter(object sender, EventArgs e)
        {
            party.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox11.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void party_MouseLeave(object sender, EventArgs e)
        {
            party.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox11.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer3.Start();

            if (storePanel.Width != 0)
            {
                storePanel.Width = 0;
                timer3.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            CostPanel.Width = 250;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder po1 = new PurchaseOrder();
            po1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox14.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();

            MessageBox.Show("Added Successfully.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            //textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox14.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}

