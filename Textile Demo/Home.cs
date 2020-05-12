using System;
using System.Collections;
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
    public partial class Home : Form
    {

        bool IsMenuPanelOpen = false;

        public Home()
        {
            InitializeComponent();

            MerchPanel.BringToFront();
            CostPanel.BringToFront();
            storesPanel.BringToFront();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Hide();
            CostSheet c1 = new CostSheet();
            c1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox1.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox5.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(1, 3, 16);
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

            if (storesPanel.Width != 0)
            {
                storesPanel.Width = 0;
                timer3.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            storesPanel.Width = 250;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private int imageNumber = 1;
        private PurchaseGrid parent;

        private void LoadNextImage()
        {
            if (pictureBoxSlide1.Visible == true)
            {
                pictureBoxSlide1.Visible = false;
                pictureBoxSlide2.Visible = true;
            }

            else if (pictureBoxSlide2.Visible == true)
            {
                pictureBoxSlide2.Visible = false;
                pictureBoxSlide3.Visible = true;
            }

            else if (pictureBoxSlide3.Visible == true)
            {
                pictureBoxSlide3.Visible = false;
                pictureBoxSlide1.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void sliderPanel_Click(object sender, EventArgs e)
        {

        }
    }

    


}
