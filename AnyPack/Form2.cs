using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPack
{
    public partial class MainWindows : Form
    {
        int lamp1 = 0;
        int lamp2 = 0;
        int lamp3 = 0;
        int lamp4 = 0;
        int lamp5 = 0;
        int lamp6 = 0;
        int lamp7 = 0;
        int predvudyv = 0;
        int vudyv = 0;
        int timepred = 0;
        int timevudyv = 0;
        public MainWindows()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            panel2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Проверка на активность любого чекбокса на трушность
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false
                && checkBox6.Checked == false && checkBox7.Checked == false)
            {
                
                label2.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;

                
               
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;

                lamp1 = 0;
                lamp2 = 0;
                lamp3 = 0;
                lamp4 = 0;
                lamp5 = 0;
                lamp6 = 0;
                lamp7 = 0;
                predvudyv = 0;
                vudyv = 0;
                timepred = 0;
                timevudyv = 0;

            }
            // Проверка на активность 1 чекбокса на трушность
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
               
                checkBox1.Checked = false;
                checkBox2.Checked = false;
               
            }

            if (checkBox8.Checked == true)
            {
                if (checkBox9.Checked ==true)
                {
                    checkBox9.Checked = false;
                }
            }

            if (checkBox9.Checked == true)
            {
                if (checkBox8.Checked == true)
                {
                    checkBox8.Checked = false;
                }
            }


            if (checkBox1.Checked == true)
            {
                
                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "12 гр";
                checkBox9.Text = "15 гр";
          
            }
            // Проверка на активность 2 чекбокса на трушность
            if (checkBox2.Checked == true)
            {
                
                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }

            if (checkBox3.Checked == true)
            {

                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }

            if (checkBox4.Checked == true)
            {

                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }

            if (checkBox5.Checked == true)
            {

                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }

            if (checkBox6.Checked == true)
            {

                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }

            if (checkBox7.Checked == true)
            {

                label2.Visible = true;
                checkBox8.Visible = true;
                checkBox9.Visible = true;
                checkBox8.Text = "20 гр";
                checkBox9.Text = "22 гр";

            }


            // Проверка на активность чекбокса на вес и трушность
            if (checkBox8.Checked == true)
            {
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
                timer8.Start();
                timer9.Start();
                timer10.Start();
                timer11.Start();
                timer12.Start();



                
                pictureBox3.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;

            }
            // Проверка на активность чекбокса на вес и трушность
            if (checkBox9.Checked == true)
            {
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
                timer8.Start();
                timer9.Start();
                timer10.Start();
                timer11.Start();
                timer12.Start();


                
                pictureBox2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;


            }
            

            if (checkBox8.Checked == false && checkBox9.Checked == false)
            {

                
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;

                lamp1 = 0;
                lamp2 = 0;
                lamp3 = 0;
                lamp4 = 0;
                lamp5 = 0;
                lamp6 = 0;
                lamp7 = 0;
                predvudyv = 0;
                vudyv = 0;
                timepred = 0;
                timevudyv = 0;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lamp1++;

            if (label11.Text == "189" && checkBox8.Checked == true && checkBox1.Checked == true)
            {
                timer2.Stop();
                lamp1--;
            }

            if (label11.Text == "59" && checkBox9.Checked == true && checkBox1.Checked == true)
            {
                timer2.Stop();
                lamp1--;
            }

            if (label11.Text == "150" && checkBox8.Checked == true && checkBox2.Checked == true)
            {
                timer2.Stop();
                lamp1--;
            }

            if (label11.Text == "80" && checkBox9.Checked == true && checkBox2.Checked == true)
            {
                timer2.Stop();
                lamp1--;
            }

            label11.Text = lamp1.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lamp2++;

            if (label12.Text == "90")
            {
                timer3.Stop();
                lamp2--;
            }

            label12.Text = lamp2.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lamp3++;

            if (label13.Text == "50")
            {
                timer4.Stop();
                lamp3--;
            }

            label13.Text = lamp3.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            lamp4++;

            if (label14.Text == "50")
            {
                timer5.Stop();
                lamp4--;
            }

            label14.Text = lamp4.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            lamp5++;

            if (label15.Text == "90")
            {
                timer6.Stop();
                lamp5--;
            }

            label15.Text = lamp5.ToString();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            //lamp6++;

            if (label16.Text == "1")
            {
                timer7.Stop();
                lamp6--;
            }

            label16.Text = lamp6.ToString();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            //lamp7++;

            if (label17.Text == "1")
            {
                timer8.Stop();
                lamp7--;
            }

            label17.Text = lamp7.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке...","Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            predvudyv++;

            if (label24.Text == "4")
            {
                timer9.Stop();
                predvudyv--;
            }

            label24.Text = predvudyv.ToString();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            
            vudyv++;

            if (label26.Text == "4")
            {
                timer10.Stop();
                vudyv--;
            }

            label26.Text = vudyv.ToString();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            timepred++;

            if (label23.Text == "4")
            {
                timer11.Stop();
                timepred--;
            }

            label23.Text = timepred.ToString();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timevudyv++;

            if (label25.Text == "4")
            {
                timer12.Stop();
                timevudyv--;
            }

            label25.Text = timevudyv.ToString();
        }
    }
}
