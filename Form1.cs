using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ComPortRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = 19200;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.Parity = Parity.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            comboBox1.SelectedIndex = 0;
            BtnClose.Enabled = false;
        }

        private async void ReceiveData (object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            BtnOpen.Enabled = false;
            BtnClose.Enabled = true;
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Encoding = Encoding.GetEncoding(28591);
                    serialPort1.WriteLine(SendTextBox1.Text);
                    SendTextBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReceive_Click(object sender, EventArgs e)
        {

            serialPort1.Encoding = Encoding.GetEncoding(28591);
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.ReadTimeout = 500;
                    string s = ToDec(serialPort1.ReadExisting());
                    ReceiveTextBox2.Clear();
                    ReceiveTextBox2.Text += s;
                    serialPort1.ReadBufferSize.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            BtnOpen.Enabled = true;
            BtnClose.Enabled = false;
            try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        public string ToHex(string inp)
        {
            
            string outp = string.Empty;
            char[] value = inp.ToCharArray();

            foreach (char L in value)
            {
                int v = Convert.ToInt32(L);

                outp += string.Format("{0:X2}" + "  ", v);

            }

            return outp;

        }
        public string ToDec(string inp2)
        {


            string outp2 = string.Empty;
            char[] value = inp2.ToCharArray();

            foreach (char L in value)
            {

                int v2 = Convert.ToInt32(L);
                //long v2 = Convert.ToInt64(L);

                outp2 += string.Format("{0:000}" + "  ", v2);

            }
            return outp2;
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            ReceiveTextBox2.Clear();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Encoding = Encoding.GetEncoding(28591);
            if (serialPort1.IsOpen)
            {
                try
                {
                    string[] vs;

                    string s;

                    //string s = serialPort1.ReadExisting();
                    s = ToDec(serialPort1.ReadExisting());
                    vs = new string[8];



                    for (int i = 0; i < vs.Length; i++)
                    {
                        vs[i] = s;
                    }

                    // for (int i = 0; i < vs.Length; i++)
                    string v = vs[3];
                    ReceiveTextBox2.Text = v;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }  
        }
    }
}
