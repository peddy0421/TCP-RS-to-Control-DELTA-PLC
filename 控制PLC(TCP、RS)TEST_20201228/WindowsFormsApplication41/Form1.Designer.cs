namespace WindowsFormsApplication41
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_PLC = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtb_Command = new System.Windows.Forms.RichTextBox();
            this.btn_Command_clear = new System.Windows.Forms.Button();
            this.btn_Command = new System.Windows.Forms.Button();
            this.rtb_response = new System.Windows.Forms.RichTextBox();
            this.tpg_PLC = new System.Windows.Forms.TabPage();
            this.gpb_Type_TCP = new System.Windows.Forms.GroupBox();
            this.txb_Tcp_Port = new System.Windows.Forms.TextBox();
            this.txb_Tcp_Ip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpb_RS232 = new System.Windows.Forms.GroupBox();
            this.cmb_Comport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PLC)).BeginInit();
            this.tpg_PLC.SuspendLayout();
            this.gpb_Type_TCP.SuspendLayout();
            this.gpb_RS232.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLC";
            // 
            // pictureBox_PLC
            // 
            this.pictureBox_PLC.Location = new System.Drawing.Point(54, 12);
            this.pictureBox_PLC.Name = "pictureBox_PLC";
            this.pictureBox_PLC.Size = new System.Drawing.Size(71, 24);
            this.pictureBox_PLC.TabIndex = 3;
            this.pictureBox_PLC.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtb_Command
            // 
            this.rtb_Command.Location = new System.Drawing.Point(563, 69);
            this.rtb_Command.Name = "rtb_Command";
            this.rtb_Command.Size = new System.Drawing.Size(144, 96);
            this.rtb_Command.TabIndex = 11;
            this.rtb_Command.Text = "power on";
            // 
            // btn_Command_clear
            // 
            this.btn_Command_clear.Location = new System.Drawing.Point(562, 172);
            this.btn_Command_clear.Name = "btn_Command_clear";
            this.btn_Command_clear.Size = new System.Drawing.Size(64, 35);
            this.btn_Command_clear.TabIndex = 13;
            this.btn_Command_clear.Text = "清除";
            this.btn_Command_clear.UseVisualStyleBackColor = true;
            this.btn_Command_clear.Click += new System.EventHandler(this.btn_Command_clear_Click);
            // 
            // btn_Command
            // 
            this.btn_Command.Location = new System.Drawing.Point(642, 172);
            this.btn_Command.Name = "btn_Command";
            this.btn_Command.Size = new System.Drawing.Size(64, 35);
            this.btn_Command.TabIndex = 14;
            this.btn_Command.Text = "寫入";
            this.btn_Command.UseVisualStyleBackColor = true;
            this.btn_Command.Click += new System.EventHandler(this.btn_Command_Click);
            // 
            // rtb_response
            // 
            this.rtb_response.Location = new System.Drawing.Point(562, 213);
            this.rtb_response.Name = "rtb_response";
            this.rtb_response.Size = new System.Drawing.Size(144, 61);
            this.rtb_response.TabIndex = 11;
            this.rtb_response.Text = "";
            // 
            // tpg_PLC
            // 
            this.tpg_PLC.Controls.Add(this.gpb_Type_TCP);
            this.tpg_PLC.Controls.Add(this.gpb_RS232);
            this.tpg_PLC.Controls.Add(this.label4);
            this.tpg_PLC.Controls.Add(this.btn_Restart);
            this.tpg_PLC.Controls.Add(this.btn_Disconnect);
            this.tpg_PLC.Controls.Add(this.btn_Connect);
            this.tpg_PLC.Controls.Add(this.cmb_Type);
            this.tpg_PLC.Location = new System.Drawing.Point(4, 22);
            this.tpg_PLC.Name = "tpg_PLC";
            this.tpg_PLC.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_PLC.Size = new System.Drawing.Size(536, 196);
            this.tpg_PLC.TabIndex = 0;
            this.tpg_PLC.Text = "PLC";
            this.tpg_PLC.UseVisualStyleBackColor = true;
            // 
            // gpb_Type_TCP
            // 
            this.gpb_Type_TCP.Controls.Add(this.txb_Tcp_Port);
            this.gpb_Type_TCP.Controls.Add(this.txb_Tcp_Ip);
            this.gpb_Type_TCP.Controls.Add(this.label6);
            this.gpb_Type_TCP.Controls.Add(this.label5);
            this.gpb_Type_TCP.Location = new System.Drawing.Point(19, 122);
            this.gpb_Type_TCP.Name = "gpb_Type_TCP";
            this.gpb_Type_TCP.Size = new System.Drawing.Size(260, 59);
            this.gpb_Type_TCP.TabIndex = 7;
            this.gpb_Type_TCP.TabStop = false;
            this.gpb_Type_TCP.Text = "Type_TCP";
            // 
            // txb_Tcp_Port
            // 
            this.txb_Tcp_Port.Location = new System.Drawing.Point(176, 21);
            this.txb_Tcp_Port.Name = "txb_Tcp_Port";
            this.txb_Tcp_Port.Size = new System.Drawing.Size(65, 22);
            this.txb_Tcp_Port.TabIndex = 5;
            this.txb_Tcp_Port.Text = "502";
            // 
            // txb_Tcp_Ip
            // 
            this.txb_Tcp_Ip.Location = new System.Drawing.Point(38, 21);
            this.txb_Tcp_Ip.Name = "txb_Tcp_Ip";
            this.txb_Tcp_Ip.Size = new System.Drawing.Size(93, 22);
            this.txb_Tcp_Ip.TabIndex = 5;
            this.txb_Tcp_Ip.Text = "192.168.1.6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP";
            // 
            // gpb_RS232
            // 
            this.gpb_RS232.Controls.Add(this.cmb_Comport);
            this.gpb_RS232.Controls.Add(this.label3);
            this.gpb_RS232.Location = new System.Drawing.Point(19, 60);
            this.gpb_RS232.Name = "gpb_RS232";
            this.gpb_RS232.Size = new System.Drawing.Size(227, 56);
            this.gpb_RS232.TabIndex = 6;
            this.gpb_RS232.TabStop = false;
            this.gpb_RS232.Text = "Type_RS232/485";
            // 
            // cmb_Comport
            // 
            this.cmb_Comport.FormattingEnabled = true;
            this.cmb_Comport.Location = new System.Drawing.Point(75, 21);
            this.cmb_Comport.Name = "cmb_Comport";
            this.cmb_Comport.Size = new System.Drawing.Size(114, 20);
            this.cmb_Comport.TabIndex = 1;
            this.cmb_Comport.SelectedIndexChanged += new System.EventHandler(this.cmb_Comport_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ComPort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(448, 21);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 61);
            this.btn_Restart.TabIndex = 3;
            this.btn_Restart.Text = "Re ComPort";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(358, 21);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 61);
            this.btn_Disconnect.TabIndex = 3;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(267, 21);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 61);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cmb_Type
            // 
            this.cmb_Type.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(66, 21);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(114, 20);
            this.cmb_Type.TabIndex = 0;
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_PLC);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "X",
            "Y",
            "M",
            "D"});
            this.comboBox2.Location = new System.Drawing.Point(41, 295);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 20);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "資料位址";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboBox3.Location = new System.Drawing.Point(198, 295);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(79, 20);
            this.comboBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 22);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_Command);
            this.Controls.Add(this.btn_Command_clear);
            this.Controls.Add(this.rtb_response);
            this.Controls.Add(this.rtb_Command);
            this.Controls.Add(this.pictureBox_PLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PLC)).EndInit();
            this.tpg_PLC.ResumeLayout(false);
            this.tpg_PLC.PerformLayout();
            this.gpb_Type_TCP.ResumeLayout(false);
            this.gpb_Type_TCP.PerformLayout();
            this.gpb_RS232.ResumeLayout(false);
            this.gpb_RS232.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_PLC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtb_Command;
        private System.Windows.Forms.Button btn_Command_clear;
        private System.Windows.Forms.Button btn_Command;
        private System.Windows.Forms.RichTextBox rtb_response;
        private System.Windows.Forms.TabPage tpg_PLC;
        private System.Windows.Forms.GroupBox gpb_Type_TCP;
        private System.Windows.Forms.TextBox txb_Tcp_Port;
        private System.Windows.Forms.TextBox txb_Tcp_Ip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpb_RS232;
        private System.Windows.Forms.ComboBox cmb_Comport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

