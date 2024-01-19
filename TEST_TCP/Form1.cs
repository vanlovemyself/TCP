using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace TEST_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SimpleTcpClient client;
        private string receiver;
        private bool led1 = false;
        private bool led2 = false;
        private bool led3 = false;

        private void btn_cnt_Click(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            if(String.IsNullOrEmpty(adrbox.Text) || Convert.ToInt32(portbox.Text) <= 0)
            {
                MessageBox.Show("NHAP DIA CHI IP VA CONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    client.Connect(adrbox.Text, Convert.ToInt32(portbox.Text));
                    btn_cnt.BackColor = Color.Green;
                    btn_cnt.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to ESP8266: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void btn_led1_Click(object sender, EventArgs e)
        {
            if(led1)
            {
                //send_data("T1");
                led1_off();
            }    
            else
            {
                // send_data("B1");
                led1_on();
            }    

        }

        private void btn_led2_Click(object sender, EventArgs e)
        {
            if (led2)
            {
                send_data("T2");
            }
            else
            {
                send_data("B2");
            }
        }

        private void btn_led3_Click(object sender, EventArgs e)
        {
            if (led3)
            {
                send_data("T3");
            }
            else
            {
                send_data("B3");
            }
        }

        private void send_data(string command)
        {
            string request = $"/control-light?command={command}";
            client.WriteLineAndGetReply(request, TimeSpan.FromSeconds(1));
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to rêceiver
            receiver = e.MessageString.Trim();

            if(receiver == "B1")
            {
                led1_on();
            }    
            else if (receiver == "T1")
            {
                led1_off();
            }
            if (receiver == "B2")
            {
                led2_on();
            }
            else if (receiver == "T2")
            {
                led2_off();
            }
            if (receiver == "B3")
            {
                led3_on();
            }
            else if (receiver == "T3")
            {
                led3_off();
            }

        }

        private void led1_on()
        {
            pictureBox1.Image = TEST_TCP.Properties.Resources.lighton;
            btn_led1.BackColor = Color.Red;
            btn_led1.Text = "OFF";
            led1 = true;

        }
        private void led2_on()
        {
            pictureBox2.Image = TEST_TCP.Properties.Resources.lighton;
            btn_led2.BackColor = Color.Red;
            btn_led2.Text = "OFF";
            led2 = true;

        }
        private void led3_on()
        {
            pictureBox3.Image = TEST_TCP.Properties.Resources.lighton;
            btn_led3.BackColor = Color.Red;
            btn_led3.Text = "OFF";
            led3 = true;

        }

        private void led1_off()
        {
            pictureBox1.Image = TEST_TCP.Properties.Resources.lightoff1;
            btn_led1.BackColor = Color.Green;
            btn_led1.Text = "ON";
            led1 = false;

        }
        private void led2_off()
        {
            pictureBox2.Image = TEST_TCP.Properties.Resources.lightoff1;
            btn_led2.BackColor = Color.Green;
            btn_led2.Text = "ON";
            led2 = false;

        }
        private void led3_off()
        {
            pictureBox3.Image = TEST_TCP.Properties.Resources.lightoff1;
            btn_led3.BackColor = Color.Green;
            btn_led3.Text = "ON";
            led3 = false;

        }
    }

}
