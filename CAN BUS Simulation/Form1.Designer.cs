namespace CAN_BUS_Simulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendInput_Btn = new System.Windows.Forms.Button();
            this.CopyTelegramRB = new System.Windows.Forms.RadioButton();
            this.CopySignalRB = new System.Windows.Forms.RadioButton();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignalPositionCmBox = new System.Windows.Forms.ComboBox();
            this.IDtxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendInput_Btn
            // 
            this.SendInput_Btn.Location = new System.Drawing.Point(80, 56);
            this.SendInput_Btn.Name = "SendInput_Btn";
            this.SendInput_Btn.Size = new System.Drawing.Size(106, 34);
            this.SendInput_Btn.TabIndex = 0;
            this.SendInput_Btn.Text = "Send Input";
            this.SendInput_Btn.UseVisualStyleBackColor = true;
            this.SendInput_Btn.Click += new System.EventHandler(this.InputSend);
            // 
            // CopyTelegramRB
            // 
            this.CopyTelegramRB.AutoSize = true;
            this.CopyTelegramRB.Location = new System.Drawing.Point(30, 13);
            this.CopyTelegramRB.Name = "CopyTelegramRB";
            this.CopyTelegramRB.Size = new System.Drawing.Size(96, 17);
            this.CopyTelegramRB.TabIndex = 1;
            this.CopyTelegramRB.TabStop = true;
            this.CopyTelegramRB.Text = "Copy Telegram";
            this.CopyTelegramRB.UseVisualStyleBackColor = true;
            // 
            // CopySignalRB
            // 
            this.CopySignalRB.AutoSize = true;
            this.CopySignalRB.Location = new System.Drawing.Point(131, 12);
            this.CopySignalRB.Name = "CopySignalRB";
            this.CopySignalRB.Size = new System.Drawing.Size(81, 17);
            this.CopySignalRB.TabIndex = 2;
            this.CopySignalRB.TabStop = true;
            this.CopySignalRB.Text = "Copy Signal";
            this.CopySignalRB.UseVisualStyleBackColor = true;
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(324, 60);
            this.InputTxtBox.MaxLength = 255;
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(359, 20);
            this.InputTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input:";
            // 
            // OutputTxtBox
            // 
            this.OutputTxtBox.Location = new System.Drawing.Point(324, 108);
            this.OutputTxtBox.Name = "OutputTxtBox";
            this.OutputTxtBox.Size = new System.Drawing.Size(359, 20);
            this.OutputTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(250, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output:";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 245);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(690, 160);
            this.LogTextBox.TabIndex = 7;
            this.LogTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(278, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // SignalPositionCmBox
            // 
            this.SignalPositionCmBox.FormattingEnabled = true;
            this.SignalPositionCmBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.SignalPositionCmBox.Location = new System.Drawing.Point(578, 14);
            this.SignalPositionCmBox.Name = "SignalPositionCmBox";
            this.SignalPositionCmBox.Size = new System.Drawing.Size(41, 21);
            this.SignalPositionCmBox.TabIndex = 9;
            // 
            // IDtxtBox
            // 
            this.IDtxtBox.Location = new System.Drawing.Point(324, 15);
            this.IDtxtBox.Name = "IDtxtBox";
            this.IDtxtBox.Size = new System.Drawing.Size(28, 20);
            this.IDtxtBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(465, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Signal position:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDtxtBox);
            this.Controls.Add(this.SignalPositionCmBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.CopySignalRB);
            this.Controls.Add(this.CopyTelegramRB);
            this.Controls.Add(this.SendInput_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendInput_Btn;
        private System.Windows.Forms.RadioButton CopyTelegramRB;
        private System.Windows.Forms.RadioButton CopySignalRB;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SignalPositionCmBox;
        private System.Windows.Forms.TextBox IDtxtBox;
        private System.Windows.Forms.Label label4;
    }
}

