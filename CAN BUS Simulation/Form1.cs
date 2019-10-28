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
        byte[] PrevPayload;
        UInt32 inputID;
        byte[] inputPayload;
        byte inputSignal;
        int counter = 0;
        string tempPayload;
        
        CANmsg CanMessage = new CANmsg();
        CopySignal CpSignal = new CopySignal();
        CopyTelegram CpTelegram = new CopyTelegram();
        LogFile WriteLog = new LogFile();
        string Date = DateTime.Now.ToString();

        private void InputSend(object sender, EventArgs e)
        {

            if (CopySignalRB.Checked == false && CopyTelegramRB.Checked == false)
            {
                MessageBox.Show("Please select one of the message sending options!!");
            }
            else
            {
                if (InputTxtBox.Text != null)
                {
                    inputID = CanMessage.GetId(InputTxtBox.Text.Substring(0, 4));   // odvoji id poruke
                    inputPayload = CanMessage.GetPayload(InputTxtBox.Text.Substring(9, 28));
                    tempPayload = InputTxtBox.Text.Substring(9, 28);
                    inputSignal = CanMessage.GetSignal(InputTxtBox.Text.Substring(5,4));
                    inputPayload[0] = inputSignal;
                }
                if (CopySignalRB.Checked == true)
                {
                    if (counter == 0)
                    {
                       WriteLog.Start(Date);
                       WriteLog.WriteLogTx(inputID, inputPayload, inputSignal, CopySignalRB.Name);
                        OutputTxtBox.Text = CpSignal.CopySg(inputID, CanMessage.DefPayload, inputSignal); //prvi klik uzima defaultni value
                        counter++;
                       WriteLog.WriteLogRx(OutputTxtBox.Text, CopySignalRB.Name);

                    }
                    else
                    {
                      WriteLog.WriteLogTx(inputID, inputPayload, inputSignal, CopySignalRB.Name);
                        PrevPayload = CanMessage.GetPayload(PrevPayloadTXT);
                        OutputTxtBox.Text = CpSignal.CopySg(inputID, PrevPayload, inputSignal); //uzmi prethodnu vrijednost
                      WriteLog.WriteLogRx(OutputTxtBox.Text,CopySignalRB.Name);
                    }
                    // Outpt = CanMessage.OutputMsg(inputID, inputPayload);    //vraća id i payload zajedno kao string
                    //pozvati copysignal i dati ovaj output
                    // MessageBox.Show(Outpt);

                }
                else 
                {
                      WriteLog.WriteError();
                }

                PrevPayloadTXT = tempPayload;
            }



            if (CopyTelegramRB.Checked == true)
            {
                WriteLog.WriteLogTx(inputID, inputPayload, inputSignal, CopyTelegramRB.Name);
                OutputTxtBox.Text = CpTelegram.CopyTg(inputID, inputPayload, inputSignal);
                WriteLog.WriteLogRx(OutputTxtBox.Text, CopyTelegramRB.Name);
            }
        }
    }
}


//0xA1 0xFF0x000x000x000x000x000x000x00