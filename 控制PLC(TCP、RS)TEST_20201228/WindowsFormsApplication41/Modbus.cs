using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication41
{
    class Modbus
    {
        //===================Defind=================================        
        string Command_Tcp_Begin = "000000000006";       
        string Command_Rs232_Begin = ":";
        string Command_Rs232_End = "\r\n";

        string absport;

        SerialPort serialport = new SerialPort("COM1",9600,Parity.Even,7,StopBits.One);
        
        Socket T;
        bool TCP;

        //MySqlConnection conn;
        //  MySqlCommand command;
        //  string MyConnectionString = "server=192.168.0.112 ;  uid=user ;  pwd=40227000 ; database=scada ; ";

        //===================Property====================================
        public bool isopen;
        public string response;
        // public string Command;
        // public string Type;
        //  public string Lrc;

        //===================Method===================================
        //====================命令==========================================================================
        public  string  Command( string Command , string Type)
        {
            try
            {
                if (Type == "TCP")
                {
                    if(absport == "502")
                    {
                        Send(Command_Tcp_Begin + Command);
                    }
                    if (absport == "29999")
                    {
                        Send(Command);
                    }                    
                    string TCP_Butter = Listen();
                    Thread.Sleep(50);
                    return TCP_Butter;  //Command_Tcp_Begin + Command  + Command_Tcp_End;  
                }

                else if (Type == "RS232")
                {
                    string SerialPort_Butter="";
                    serialport.Write(Command_Rs232_Begin + Command + LRC(Command) + Command_Rs232_End);
                    Thread.Sleep(50); 
                    if (serialport.BytesToRead != 0)
                    {
                        SerialPort_Butter = serialport.ReadLine() + "\r\n";
                        Regex r = new Regex(":");
                        SerialPort_Butter = r.Replace(SerialPort_Butter, "");                        
                    }
                    else
                    {
                        SerialPort_Butter = "緩衝區未有訊號";
                    }
                    return SerialPort_Butter;
                }
                else
                {
                    MessageBox.Show("未選擇傳輸類型", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.ToString() );
                return "";
            }           
        }       
        
        //========================== TCＰ連線 ===============================================================
        public void  Connert( string Type , string IP , string Port )
        {
            absport = Port;
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), int.Parse( Port ) );    //IPAddress是ip，如" 127.0.0.1"  ;IPEndPoint是ip和端口對的組合，如"127.0.0.1: 1000 "  
                T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //new Socket( 通訊協定家族ip4 , 通訊端類型 , 通訊協定TCP)
                T.Connect(EP); //建立連線                
              //  MessageBox.Show( "已連線至伺服器" );
                TCP = true;
            }
            catch (Exception)
            {
             //   MessageBox.Show( "無法連線至伺服器" );
                TCP =  false;
            }
        }
        //================連接===================================================================
        public void Connert(string Type, string ComPort)
        {
            try
            {                
                serialport.PortName = ComPort;
                serialport.Open();
            }
            catch
            {
                serialport.Close();
                MessageBox.Show("通訊錯誤");
            }
        }

        //==================通訊偵測==================================================================
        public void IsOpen()
        {
            if (serialport.IsOpen == true || TCP == true)
            {
                isopen = true;
            }
            else
            {
                isopen = false;
            }
        }

        //======================中斷連線===============================================================
        public void Disconnect()
        {
            serialport.Close();
            try
            {
                T.Close();
            }
            catch { }
            TCP = false;
        }   


        //================================= private 內用副程式 =========================== ======================================================
        //=============傳送訊息給PLC (TCP傳需先轉成Byte!!!!)=========================================================
        private void Send(string Str)
        {
            if (absport == "502")
            {
                byte[] A = new byte[1]; //初始需告陣列(因不知道資料大小，下面會做陣列調整)
                for (int i = 0; i < Str.Length / 2; i++)
                {
                    Array.Resize(ref A, Str.Length / 2);  //Array.Resize(ref 陣列名稱, 新的陣列大小)  
                    string str2 = Str.Substring(i * 2, 2);
                    A[i] = Convert.ToByte(str2, 16); //字串依照"frombase"轉換數字(Byte)
                }
                T.Send(A, 0, Str.Length / 2, SocketFlags.None);
            }

            if (absport == "29999")
            {                
                Str = Str+ "\n";             
                T.Send(Encoding.ASCII.GetBytes(Str));
            }


        }

        //================接收訊息==========================================
        private string  Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint;
            byte[] Buffer = new byte[1023];
            int inLen = 0;
            try
            {
                inLen = T.ReceiveFrom(Buffer, ref ServerEP);
            }
            catch (Exception)
            {
                T.Close();
                MessageBox.Show("伺服器中斷連線!");                
            } 
            string response =  BitConverter.ToString(Buffer, 0, inLen);            
            Regex r = new Regex("-");
            response = r.Replace(response, "");
            return response;            
        }
       
        //===================校驗碼======================================================================
        private string LRC(string Command)
        {
            int str = 0;          
            int LRC_Length = Command.Length / 2;
            string LRC_Space = Command;
            for (int i = 0; i < LRC_Length; i++)
            {
                string midtext = LRC_Space.Substring(i * 2, 2);
                str += Convert.ToInt16(midtext, 16);
            }           
            while (str > 255)
            {
                str = str - 256;
            }
            str = Convert.ToByte(str);
            return (Convert.ToString(255 - str + 1, 16)).ToUpper();
        }

        //================接收訊息============================================================================
        /*private void Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint;
            byte[] B = new byte[1023];
            int inLen = 0;

            try
            {
                inLen = T.ReceiveFrom(B, ref ServerEP);
            }
            catch (Exception)
            {
                T.Close();
                MessageBox.Show("伺服器中斷連線!");                
            }
             response = BitConverter.ToString(B, 6, inLen - 6);
            // mysql.Database_Add(response);
        }

        */
    }
}
