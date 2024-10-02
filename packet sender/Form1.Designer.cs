namespace packet_sender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSentData = new System.Windows.Forms.TextBox();
            this.linesPerInterval_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalSeconds_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linesSent_lbl = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emei_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(61, 92);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(125, 27);
            this.address_txt.TabIndex = 0;
            this.address_txt.Text = "192.168.30.1";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(256, 92);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(125, 27);
            this.port_txt.TabIndex = 1;
            this.port_txt.Text = "81";
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(441, 92);
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(125, 27);
            this.status_txt.TabIndex = 2;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(272, 257);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(94, 29);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // bt
            // 
            this.bt.AutoSize = true;
            this.bt.Location = new System.Drawing.Point(303, 69);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(35, 20);
            this.bt.TabIndex = 4;
            this.bt.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            // 
            // txtSentData
            // 
            this.txtSentData.Location = new System.Drawing.Point(69, 292);
            this.txtSentData.Multiline = true;
            this.txtSentData.Name = "txtSentData";
            this.txtSentData.Size = new System.Drawing.Size(908, 327);
            this.txtSentData.TabIndex = 7;
            // 
            // linesPerInterval_txt
            // 
            this.linesPerInterval_txt.Location = new System.Drawing.Point(648, 92);
            this.linesPerInterval_txt.Name = "linesPerInterval_txt";
            this.linesPerInterval_txt.Size = new System.Drawing.Size(125, 27);
            this.linesPerInterval_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max data";
            // 
            // intervalSeconds_txt
            // 
            this.intervalSeconds_txt.Location = new System.Drawing.Point(844, 92);
            this.intervalSeconds_txt.Name = "intervalSeconds_txt";
            this.intervalSeconds_txt.Size = new System.Drawing.Size(125, 27);
            this.intervalSeconds_txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(844, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "seconds of waiting";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // linesSent_lbl
            // 
            this.linesSent_lbl.AutoSize = true;
            this.linesSent_lbl.Location = new System.Drawing.Point(483, 9);
            this.linesSent_lbl.Name = "linesSent_lbl";
            this.linesSent_lbl.Size = new System.Drawing.Size(0, 20);
            this.linesSent_lbl.TabIndex = 12;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(648, 175);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(125, 27);
            this.fileName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "File Name";
            // 
            // emei_txt
            // 
            this.emei_txt.Location = new System.Drawing.Point(256, 177);
            this.emei_txt.Name = "emei_txt";
            this.emei_txt.Size = new System.Drawing.Size(125, 27);
            this.emei_txt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Device EMEI";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(63, 139);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All Log";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 178);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Single EMEI";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Extract";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 641);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.emei_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.linesSent_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intervalSeconds_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linesPerInterval_txt);
            this.Controls.Add(this.txtSentData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.address_txt);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox address_txt;
        private TextBox port_txt;
        private TextBox status_txt;
        private Button send_btn;
        private Label bt;
        private Label label1;
        private Label label2;
        private TextBox txtSentData;
        private TextBox linesPerInterval_txt;
        private Label label3;
        private TextBox intervalSeconds_txt;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label linesSent_lbl;
        private TextBox fileName;
        private Label label5;
        private TextBox emei_txt;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
    }
}