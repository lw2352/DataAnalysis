using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        
        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 Form1 = new Form1();                      


            for(int i = 0; i < 16; i++) 
            { 
                cbxCOMPort.Items.Add("COM" + (i+1).ToString());
            }  

            cbxCOMPort.SelectedIndex=3;
            //列出常用的波特率
            cbxBaudRate.Items.Add("300"); 
            cbxBaudRate.Items.Add("600"); 
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400"); 
            cbxBaudRate.Items.Add("4800"); 
            cbxBaudRate.Items.Add("9600"); 
            cbxBaudRate.Items.Add("19200"); 
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000"); 
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex=11;
            //列出停止位
            cbxStopBits.Items.Add("0"); 
            cbxStopBits.Items.Add("1"); 
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex=1;  

            //列出数据位
            cbxDataBits.Items.Add("8"); 
            cbxDataBits.Items.Add("7"); 
            cbxDataBits.Items.Add("6"); 
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex=0;

            //列出奇偶校验位
            cbxParity.Items.Add("无"); 
            cbxParity.Items.Add("奇校验");                        
            cbxParity.Items.Add("偶校验"); 
            cbxParity.SelectedIndex=0;  

        }

        private void btnCheckCOM_Click(object sender, EventArgs e)
        {
               
            //检测哪些串口可用
            cbxCOMPort.Items.Clear(); 
            for(int i = 0; i < 16; i++)
            {   
                try           
                {
                   // SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sPort.PortName = "COM" + (i + 1).ToString();
                    sPort.Open();
                    sPort.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                }
                catch(Exception)
                {
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString() + "不可用"); 
                    //richTextBox1.Text += "COM" + (i + 1).ToString() + "不可用"; 
                    continue; 
                } 
            }
        }

        private void cbxCOMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sPort.PortName = cbxCOMPort.SelectedItem.ToString();
        }

        private void cbxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设置奇偶校验位
            string s = cbxParity.SelectedItem.ToString();
            if(s.CompareTo("无") == 0)            
            //sPort.Parity = cbxParity.SelectedItem.ToString();
       
            {
                sPort.Parity = Parity.None; 
            }
            else if(s.CompareTo("奇校验") == 0) 
            {
                sPort.Parity = Parity.Odd; 
            }  
            else if(s.CompareTo("偶校验") == 0) 
            {
                sPort.Parity = Parity.Even;
            } 
            else 
            {
                sPort.Parity = Parity.None;  

            }         
        }

        private void cbxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //设置串口的波特率
            sPort.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim()); 
        }

        private void cbxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //设置停止位

            float f = Convert.ToSingle(cbxStopBits.Text.Trim()); 

            if(f == 0) 
            {
                sPort.StopBits = StopBits.None; 
            } 
            else if (f == 1.5)
            {
                sPort.StopBits = StopBits.OnePointFive; 
            }  
            else if(f == 1)
            {
                sPort.StopBits = StopBits.One; 
            } 
            else if(f == 2) 
            {
                sPort.StopBits = StopBits.Two; 
            } 
            else 
            {
                sPort.StopBits = StopBits.One;
            } 
        }

        private void cbxDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设置数据位
            sPort.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim()); 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {              
            //打开串口
            try
            {
                sPort.PortName = "COM" + (cbxCOMPort.SelectedIndex + 1).ToString();
                sPort.Open();

            }
            catch (Exception)
            {
                if (cbxCOMPort.SelectedIndex<0)
                    richTextBox1.Text +="无可用串口！" +System.Environment.NewLine; 
                else
                    richTextBox1.Text += "COM" + (cbxCOMPort.SelectedIndex + 1).ToString() + "不可用"+System.Environment.NewLine ; 
                return;
            }

            if (tbCommand.Text == "")
            {
                richTextBox1.Text += "请输入要发送的指令!" + System.Environment.NewLine;
                sPort.Close();
                return;            
            }

            //写串口数据  
            try                
            {
                sPort.Write(tbCommand.Text);
                richTextBox1.Text += "发送数据成功！" + System.Environment.NewLine;               
            }
            catch(Exception)                
            {                     
                richTextBox1.Text +="发送数据时发生错误！"+ System.Environment.NewLine;                
             }              
            sPort.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string FileName="";

            if (radioButton1.Checked == true)//保存文件                    
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    FileName = saveFileDialog1.FileName;       
                    // openFileDialog1.FileName = "*.txt";
                    richTextBox1.AppendText("文件名为：" + FileName + System.Environment.NewLine);
                }
                else
                    return;

            }   
            
            if (sPort.IsOpen == false)                
            {
                   
                //打开串口
               try
               {
                   sPort.PortName = "COM" + (cbxCOMPort.SelectedIndex + 1).ToString();
                   sPort.Open();
                   
               }
                    
               catch (Exception)                
               {                        
                   richTextBox1.Text += "COM" + (cbxCOMPort.SelectedIndex + 1).ToString() + "不可用" + System.Environment.NewLine;                        
                   return;                    
               }
                
            }


                
            //写数据采集命令  
                
            try                
            {                    
                sPort.Write("$0001$");                    
                richTextBox1.Text += "发送数据采集命令成功！，准备接收数据......" + System.Environment.NewLine;                
            }                
            catch (Exception)                
            {                   
                richTextBox1.Text += "发送数据采集命令失败，请重新发送！" + System.Environment.NewLine;                    
                sPort.Close();                    
                return;                
            }  
              
                
            int data_Counter = 0; 
            int Max_Counter = 600002;               
            byte[] data_Receive = new byte[Max_Counter];                
               
            //准备数据接收               
            sPort.DiscardOutBuffer();//清空缓冲区  
            data_Counter = 0;               
            int tmp;
                
            while (data_Counter < Max_Counter)                
            { 
                if (sPort.BytesToRead < 1)                    
                {                        
                    Application.DoEvents();                        
                    continue;                   
                }
                    
                tmp = sPort.ReadByte();                    
                data_Receive[data_Counter] = (byte)(tmp);
                if (radioButton2.Checked == true)//本地显示选择                  
                {
                    richTextBox1.AppendText(data_Receive[data_Counter].ToString("X").PadLeft(2, '0') + " ");
                    if ((data_Counter % 30) == 0) richTextBox1.AppendText(System.Environment.NewLine + (data_Counter / 30).ToString("D6") + ": ");
                }
                else//保存文件
                {
                    if (data_Counter == 0) richTextBox1.AppendText("正在接收数据，请稍候！......");
                }
                data_Counter++;                    
                progressBar1.Value =(int)( 100 * data_Counter / Max_Counter);                    
                Application.DoEvents();                
            }
                            
            richTextBox1.AppendText(System.Environment.NewLine+"数据接收完毕，总数据量为："+data_Counter.ToString("D6") + "字节");
            progressBar1.Value = 100;
            sPort.Close();

            if (radioButton1.Checked == true)//保存文件                    
            {
                richTextBox1.AppendText(System.Environment.NewLine + "正在保存文件，请稍候！.....");

                FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
                BinaryWriter w = new BinaryWriter(fs);
                w.Seek(0, SeekOrigin.Begin);
                w.Write(data_Receive);
                w.Flush();

                richTextBox1.AppendText(System.Environment.NewLine + "保存文件完毕！.....");  

                w.Close();
                fs.Close();
                fs.Dispose();

            }

        }

        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {




        }






    }
}
