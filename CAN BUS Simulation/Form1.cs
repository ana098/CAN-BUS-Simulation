using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAN_BUS_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string PrevPayloadTXT;
        int counter = 0;
        string tempPayload;
        byte[] buffer;
        
        LogFile WriteLog = new LogFile();
        Conversion conv = new Conversion();
        CANInput Input = new CANInput();
        CANOutput Output = new CANOutput();
        static Random random = new Random();

        private void InputSend(object sender, EventArgs e)
        {
            InputTxtBox.Text = GetRandomHexNumber(16);
            OutputTxtBox.ResetText();

            if (CopySignalRB.Checked == false && CopyTelegramRB.Checked == false)
            {
                MessageBox.Show("Please select one of the message sending options!!");
            }
            else
            {
                if (InputTxtBox.Text != null)
                {
                    tempPayload = InputTxtBox.Text;
                }
                if (CopySignalRB.Checked == true)
                {
                    if (counter == 0)
                    {
                       Input.CAN_Input(InputTxtBox.Text,Convert.ToInt16(SignalPositionCmBox.SelectedItem));
                       LogTextBox.Text = BitConverter.ToString(CANInput.InPayload); 
                       OutputTxtBox.Text = Output.CAN_Output("CS", true);
                       LogTextBox.Text = LogTextBox.Text + "\n" + CANOutput.OutPayload + "\n";
                       counter++;
                    }

                    else
                    {
                        Input.CAN_Input(InputTxtBox.Text, PrevPayloadTXT, Convert.ToInt16(SignalPositionCmBox.SelectedItem));
                        LogTextBox.Text = LogTextBox.Text + "\n" + BitConverter.ToString(CANInput.InPayload);
                        Output.CAN_Output("CS", false);
                        OutputTxtBox.Text = CANOutput.OutPayload;
                        LogTextBox.Text = LogTextBox.Text + "\n" + CANOutput.OutPayload + "\n";
                    }

                }

                PrevPayloadTXT = tempPayload;
            }


            if (CopyTelegramRB.Checked == true)
            {
                Input.CAN_Input(InputTxtBox.Text);
                LogTextBox.Text = LogTextBox.Text + "\n" + BitConverter.ToString(CANInput.InPayload);
                Output.CAN_Output("CT", false);
                OutputTxtBox.Text = CANOutput.OutPayload;
                LogTextBox.Text = LogTextBox.Text + "\n" + CANOutput.OutPayload + "\n";
            }

        }
      

        public string GetRandomHexNumber(int digits)
        {
            while (true)
            {
                buffer = new byte[digits / 2];
                random.NextBytes(buffer);
                System.Threading.Thread.Sleep(500); // pola sekunde

                StringBuilder hex = new StringBuilder(buffer.Length * 2);
                foreach (byte b in buffer)
                    hex.AppendFormat("{0:x2}", b);

                return hex.ToString().ToUpper();

            }
        }

    }
}
