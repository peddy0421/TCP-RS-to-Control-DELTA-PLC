using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.IO;
using System.IO.Ports;


namespace WindowsFormsApplication41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //=================全域變數宣告==================
        string[] type = { "RS232", "TCP" };
        Modbus modbus = new Modbus();


        string SetY0 = "01050500FF00";
        string ResetY0 = "010505000000";
        string SetY1 = "01050501FF00";
        string ResetY1 = "010505010000";
        string SetY2 = "01050502FF00";
        string ResetY2 = "010505020000";
        string SetY3 = "01050503FF00";
        string ResetY3 = "010505030000";
        string SetY4 = "01050504FF00";
        string ResetY4 = "010505040000";
        string SetY5 = "01050505FF00";
        string ResetY5 = "010505050000";
        string SetY6 = "01050506FF00";
        string ResetY6 = "010505060000";
        string SetY7 = "01050507FF00";
        string ResetY7 = "010505070000";
        string ReadY = "010205000008";
        string ReadX = "010204000008";




        //================視窗載入  初始宣告===============
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox_PLC.BackColor = Color.Silver;
            gpb_Type_TCP.Enabled = false;
            gpb_RS232.Enabled = false;
            btn_Connect.Enabled = false;
            btn_Disconnect.Enabled = false;
            cmb_Type.Items.AddRange(type);
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        //============= ComPort_Name載入combobox ====================
        public void ComportName()
        {
            cmb_Comport.Items.Clear();
            cmb_Comport.Items.AddRange(SerialPort.GetPortNames());
        }

        //===================== Timer掃描內容 ==================================================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            //============= Comport狀態 ==========================
            modbus.IsOpen();
            if (modbus.isopen)
            {
                pictureBox_PLC.BackColor = Color.GreenYellow;
            }
            else
            {
                pictureBox_PLC.BackColor = Color.Silver;
            }
            //====================== 按鈕權限 ========================
            if (cmb_Comport.Text != "" || txb_Tcp_Ip.Text != "" && txb_Tcp_Port.Text != "")
            {
                btn_Connect.Enabled = true;
                btn_Disconnect.Enabled = true;
            }
            else
            {
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = false;
            }
        }

        //=================== 連線 =============================================================================
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (cmb_Type.Text == "TCP")
            {
                modbus.Connert(cmb_Type.Text, txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
            }
            else if (cmb_Type.Text == "RS232")
                modbus.Connert(cmb_Type.Text, cmb_Comport.Text);


        }

        //===============重置comport=================================================================================
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            ComportName();
        }

        //====================TCP/RS232區域是否開啟==========================================================
        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            modbus.Disconnect();
            if (cmb_Type.Text == "TCP")
            {
                gpb_Type_TCP.Enabled = true;
                gpb_RS232.Enabled = false;
            }
            else if (cmb_Type.Text == "RS232")
            {
                ComportName();
                gpb_Type_TCP.Enabled = false;
                gpb_RS232.Enabled = true;
            }
        }

        //=================中斷連線===================================================================
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            modbus.Disconnect();

        }

        //================= 命令輸出 ===============================================================
        private void btn_Command_Click(object sender, EventArgs e)
        {
            string _reply = "";
            string reply = "";

            btn_Connect.PerformClick();
            _reply = modbus.Command(rtb_Command.Text, cmb_Type.Text);

            if (txb_Tcp_Port.Text == "29999")
            {
                for (int i = 0; i < _reply.Length; i = i + 2)
                {
                    reply = reply + _reply.Substring(i, 2) + " ";
                }
                rtb_response.Text = HexStringToASCII(reply);
            }
            else
            {
                rtb_response.Text = _reply;
            }
        }

        //===================== 命令欄清除 =================== ==================================
        private void btn_Command_clear_Click(object sender, EventArgs e)
        {
            rtb_Command.Clear();
        }

        //======================= 視窗關閉 ============================================================
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            modbus.Disconnect();

            
        }
        //======================= string to ascii ============================================================
        public static string HexStringToASCII(string hexstring)
        {
            byte[] bt = HexStringToBinary(hexstring);
            string lin = "";
            for (int i = 0; i < bt.Length; i++)
            {
                lin = lin + bt[i] + " ";
            }

            string[] ss = lin.Trim().Split(new char[] { ' ' });
            char[] c = new char[ss.Length];
            int a;
            for (int i = 0; i < c.Length; i++)
            {
                a = Convert.ToInt32(ss[i]);
                c[i] = Convert.ToChar(a);
            }

            string b = new string(c);
            return b;
        }      
        public static byte[] HexStringToBinary(string hexstring)
        {

            string[] tmpary = hexstring.Trim().Split(' ');
            byte[] buff = new byte[tmpary.Length];
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = Convert.ToByte(tmpary[i], 16);
            }
            return buff;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Comport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}

