﻿using System;
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
    public partial class CostSheetGroups : Form
    {
        private PurchaseGrid parent;


        public CostSheetGroups()
        {
            InitializeComponent();


            MerchPanel.BringToFront();
            CostPanel.BringToFront();
            mainPanel.SendToBack();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag1 = -1;

            if (mainText.Text == "Group-01")
            {
                flag1 = 1;

                if (flag1 == 1)
                {
                    subPanel2.Show();
                    Group_01 g1 = new Group_01()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    this.subPanel2.Controls.Add(g1);
                    g1.Show();
                }
                else
                {
                    subPanel2.Hide();
                }
            }

            else if (mainText.Text == "Group-02")
            {
                flag1 = 1;

                if (flag1 == 1)
                {
                    subPanel3.Show();
                    Group_02 g2 = new Group_02()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    this.subPanel3.Controls.Add(g2);
                    g2.Show();
                }
                else
                {
                    subPanel3.Hide();
                }
            }

            else if (mainText.Text == "Split-01")
            {
                flag1 = 1;

                if (flag1 == 1)
                {
                    subPanel4.Show();
                    Split_01 s1 = new Split_01()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    this.subPanel4.Controls.Add(s1);
                    s1.Show();
                }
                else
                {
                    subPanel4.Hide();
                }
            }

            else if (mainText.Text == "Split-02")
            {
                flag1 = 1;

                if (flag1 == 1)
                {
                    subPanel1.Show();
                    Split_02 s2 = new Split_02()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    this.subPanel1.Controls.Add(s2);
                    s2.Show();
                }
                else
                {
                    subPanel1.Hide();
                }
            }

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

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox12.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox13.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(1, 3, 16);
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

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox3.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox3.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox5.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox5.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(230, 90, 50);
            pictureBox1.BackColor = Color.FromArgb(230, 90, 50);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(1, 3, 16);
            pictureBox1.BackColor = Color.FromArgb(1, 3, 16);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MerchPanel.Width = 250;
            MerchPanel.Height = 147;
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
            CostPanel.Height = 147;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostSheet c1 = new CostSheet();
            c1.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetGroups cg1 = new CostSheetGroups();
            cg1.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CostSheetMaterial cm1 = new CostSheetMaterial();
            cm1.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CostSheetGroups_Load(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Groups Added Successfully.");
        }
    }
}
