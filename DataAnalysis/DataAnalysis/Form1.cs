using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using MyClassLibrary;
using ZedGraph;
//using MathWorks.MATLAB.NET.Arrays;
//using MathWorks.MATLAB.NET.Utility;
//using MatlabFunction;
//using System.Threading;
//using System.Math;
//using max;
namespace WindowsFormsApplication1
{
  
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();

            

            // frm_width = this.Width;
            //   frm_height = this.Height;

        }

        public int cutNum = 10000;

        public byte[] data_A = new byte[600000 - 10000 * 2];
        public byte[] data_B = new byte[600000 - 10000 * 2];

        public double[] dataA;
        public double[] dataB;

        PointPairList listA = new PointPairList();
        PointPairList listB = new PointPairList();

        MasterPane master;


        //画图并同步缩放
        private void CreateGraph()
        {
            //画图 add by lw 6-19
            /*MasterPane master = zedGraphControl1.MasterPane;
            master.Title.IsVisible = true;
            //master.Title.Text = "原始数据";
            master.Margin.All = 3;
            master.Fill = new Fill(Color.WhiteSmoke, Color.FromArgb(220, 220, 255), 45.0f);*/   

            GraphPane paneA = new GraphPane();
            GraphPane paneB = new GraphPane();

            paneA.Title.IsVisible = false;
            paneB.Title.IsVisible = false;

            LineItem myCurveA = paneA.AddCurve("A", listA, Color.Blue, SymbolType.None);
            LineItem myCurveB = paneB.AddCurve("B", listB, Color.Red, SymbolType.None);

            master.Add(paneA);
            master.Add(paneB);

            using (Graphics g = zedGraphControl1.CreateGraphics())
            {
                master.SetLayout(g, PaneLayout.SquareColPreferred);
                master.SetLayout(g, PaneLayout.SingleColumn);
                master.AxisChange(g);
            }

            zedGraphControl1.IsSynchronizeXAxes = true;
            zedGraphControl1.IsSynchronizeYAxes = true;

            zedGraphControl1.IsAutoScrollRange = true;

            zedGraphControl1.IsShowHScrollBar = true;
            zedGraphControl1.IsShowVScrollBar = true;

            zedGraphControl1.AxisChange();


            //finished
        }

        //初始化图表
        private void SetGraph()
        {
            //add 6-20
            master = zedGraphControl1.MasterPane;
            master.Title.IsVisible = true;
            master.Title.Text = "原始数据";
            master.Margin.All = 3;
            master.Fill = new Fill(Color.WhiteSmoke, Color.FromArgb(220, 220, 255), 45.0f);
        }

        ////清空图
        private void EraseGraph()
        {
            //清空
            master.PaneList.Clear();
            zedGraphControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EraseGraph();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName;
                int datalength=0;
                double dataA_avg = 0;
                double dataA_avgAbs = 0;
                //double[] dataA;

                FileName = openFileDialog1.FileName; //选取的文件

                //openFileDialog1.FileName = "*.txt";                                 

                if (openFileDialog1.FilterIndex == 0)  //文件筛选器的索引，第一项
                {

                    StreamReader sr = new StreamReader(FileName, Encoding.ASCII); //输入流用于从外部源读取数据
                    //  int nextChar = sr.Read();
                    //  nextChar = sr.Read();
                    //  nextChar -= 0x30;
                    // 全部读完 
                    string restOfStream = sr.ReadToEnd();  //从流的当前位置到末尾读取流。
                    datalength = (restOfStream.Length - 6) / 6;
                    //  label4.Text = Convert.ToString(nextChar);
                    //处理数据,计算平均值
                    byte[] tmp = new byte[4];
                    dataA = new double[datalength];

                    for (int i = 0; i < datalength; i++)
                    {
                        tmp[0] = (byte)restOfStream[3 + i * 6];
                        tmp[1] = (byte)restOfStream[3 + i * 6 + 1];
                        tmp[2] = (byte)restOfStream[3 + i * 6 + 3];
                        tmp[3] = (byte)restOfStream[3 + i * 6 + 4];

                        for (int j = 0; j < 4; j++)
                        {

                            if (tmp[j] > 96 && tmp[j] < 103)
                                tmp[j] = (byte)((int)tmp[j] - 87);
                            else if (tmp[j] > 64 && tmp[j] < 71)
                                tmp[j] = (byte)((int)tmp[j] - 55);
                            else if (tmp[j] > 47 && tmp[j] < 58)
                                tmp[j] = (byte)((int)tmp[j] - 48);
                        }

                        dataA[i] = 0;
                        for (int j = 0; j < 4; j++)
                            dataA[i] = (dataA[i] * 0x10 + tmp[j]);

                        dataA_avg += dataA[i] / datalength;
                    }

                    sr.Dispose();

                }
                else 
                {
                    FileStream fs = new FileStream(FileName, FileMode.Open);
                    //datalength = (int)(fs.Length-2)/2;

                    datalength = (int)((fs.Length - 2) / 2) - cutNum;
                    dataA = new double[datalength];
                    byte[] data = new byte[datalength*2];

                    

                    fs.Seek(cutNum+1, SeekOrigin.Begin);//跳过字符
                    fs.Read(data, 0, datalength*2);

                    fs.Dispose();


                    //byte[] adata = new byte[datalength * 2];
                    //adata = data;
                    //data_A = adata;


                    for (int i = 0; i < datalength; i++)
                        dataA[i] = (double)(data[2 * i] * 0x100 + data[2 * i + 1]);
                    dataA_avg = 0;
                    for(int i=0;i<datalength;i++)
                        dataA_avg += dataA[i] / datalength;
                }

                //double[] data1 = dataA;
                //double[] data2 = dataA;
                //MyMath mm = new MyMath();
                //double fc = mm.mse(data1);
                //double[] maxten = new double[10];
                //maxten = mm.maxten(data1);
                //double[] minten = new double[10];
                //minten = mm.minten(data2);

                for (int i = 0; i < datalength; i++)//归一处理
                    dataA[i] = (dataA[i] - dataA_avg) / dataA_avg;

                //A平均幅值
                for (int i = 0; i < datalength; i++)
                    dataA_avgAbs += System.Math.Abs(dataA[i]) / datalength;
                textBoxAvgA.Text = dataA_avgAbs.ToString();

                //保存数据
                WaterLeak.set_DataLength(datalength);
                WaterLeak.set_DataA(dataA);
                WaterLeak.set_DataA_Avg(dataA_avg);                

                //画图形
                /*MasterPane.Controls.Clear();  //清空

                ZedGraphControl zed1 = new ZedGraphControl();
                zed1.Width = MasterPane.Width;
                zed1.Height = MasterPane.Height;
                MasterPane.Controls.Add(zed1);

                GraphPane Pane = zed1.GraphPane;
                /*Pane.Title = "数据A";
                Pane.XAxis.Title = "点数";
                Pane.YAxis.Title = "信号强度";*/

                //PointPairList list = new PointPairList();

                for (int i = 0; i < datalength; i++)
                {
                    listA.Add(i, dataA[i]);
                }

                //LineItem myCurve = Pane.AddCurve("Porsche", list, Color.Blue, SymbolType.None);
                //zed1.AxisChange();

                //开启状态使能
                button2.Enabled = true;
            } 

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EraseGraph();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName;
                int datalength = 0;
                double dataB_avg = 0;
                double dataB_avgAbs = 0;
                //double[] dataA;

                    FileName = openFileDialog1.FileName;
                    //openFileDialog1.FileName = "*.txt"; 

                    if (openFileDialog1.FilterIndex == 0)
                    {

                    /*StreamReader sr = new StreamReader(FileName, Encoding.ASCII);
                    //  int nextChar = sr.Read();
                    //  nextChar = sr.Read();
                    //  nextChar -= 0x30;
                    // 全部读完 
                    string restOfStream = sr.ReadToEnd();
                    sr.Dispose();
                    datalength = (restOfStream.Length - 6) / 6;
                    //  label4.Text = Convert.ToString(nextChar);
                    //处理数据,计算平均值
                   // float dataA_avg = 0;
                    dataA = new double[datalength];
                    byte[] tmp = new byte[4];
                    for (int i = 0; i < datalength; i++)
                    {
                        tmp[0] = (byte)restOfStream[3 + i * 6];
                        tmp[1] = (byte)restOfStream[3 + i * 6 + 1];
                        tmp[2] = (byte)restOfStream[3 + i * 6 + 3];
                        tmp[3] = (byte)restOfStream[3 + i * 6 + 4];

                        for (int j = 0; j < 4; j++)
                        {

                            if (tmp[j] > 96 && tmp[j] < 103)
                                tmp[j] = (byte)((int)tmp[j] - 87);
                            else if (tmp[j] > 64 && tmp[j] < 71)
                                tmp[j] = (byte)((int)tmp[j] - 55);
                            else if (tmp[j] > 47 && tmp[j] < 58)
                                tmp[j] = (byte)((int)tmp[j] - 48);
                        }

                        dataA[i] = 0;
                        for (int j = 0; j < 4; j++)
                            dataA[i] = (dataA[i] * 0x10 + tmp[j]);

                        dataA_avg += dataA[i] / datalength;
                    }*/

                }
                else
                {

                    FileStream fs = new FileStream(FileName, FileMode.Open);
                    datalength = (int)(fs.Length - 2) / 2 - cutNum;
                    dataB = new double[datalength];
                    byte[] data = new byte[datalength * 2];



                    fs.Seek(cutNum+1, SeekOrigin.Begin);//跳过第一个字符
                    fs.Read(data, 0, datalength * 2);


                    fs.Dispose();



                   // byte[] adata = new byte[datalength * 2];
                   // adata = data;
                    //data_B = adata;



                    for (int i = 0; i < datalength; i++)
                        dataB[i] = (double)(data[2 * i] * 0x100 + data[2 * i + 1]);


                    dataB_avg = 0;
                    for (int i = 0; i < datalength; i++)
                        dataB_avg += dataB[i] / datalength;
                
                }


                 for (int i = 0; i < datalength; i++)
                    dataB[i] = (dataB[i] - dataB_avg) / dataB_avg;
                
                 //B平均幅值
                for (int i = 0; i < datalength; i++)
                    dataB_avgAbs += System.Math.Abs(dataB[i]) / datalength;
                textBoxAvgB.Text = dataB_avgAbs.ToString();

                //保存数据
                WaterLeak.set_DataLength(datalength);
                WaterLeak.set_DataB(dataB);
                WaterLeak.set_DataB_Avg(dataB_avg);


                //画图形
                /*panel2.Controls.Clear();

                ZedGraphControl zed2 = new ZedGraphControl();
                zed2.Width = MasterPane.Width;
                zed2.Height = MasterPane.Height;
                panel2.Controls.Add(zed2);

                GraphPane Pane = zed2.GraphPane;*/
                /*Pane.Title = "数据B";
                Pane.XAxis.Title = "点数";
                Pane.YAxis.Title = "信号强度";*/

                
                for (int i = 0; i < datalength; i++)
                {
                    listB.Add(i, dataB[i]);
                }

                //LineItem myCurve = Pane.AddCurve("Porsche", list, Color.Blue, SymbolType.None);
                //zed2.AxisChange();                

                //开启状态使能
                button3.Enabled = true;
            } 
        }
     
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            EraseGraph();

            CreateGraph();

            panel3.Controls.Clear();

            /*Label label13 = new Label();
            Label label14 = new Label();
            label13.Font = label14.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            label13.ForeColor = label14.ForeColor = Color.Red;
            label13.Location = new System.Drawing.Point(100, 30);
            label14.Location = new System.Drawing.Point(900, 30);
            label13.AutoSize = label14.AutoSize = true;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);*/
           
            ZedGraphControl zed3 = new ZedGraphControl();
            zed3.Width = panel3.Width;
            zed3.Height = panel3.Height;
                  
            //读取数据
            int datalength = WaterLeak.get_DataLength();
            double[] dataA = WaterLeak.get_DataA();
            double[] dataB = WaterLeak.get_DataB();
            double dataA_avg = WaterLeak.get_DataA_Avg();
            double dataB_avg = WaterLeak.get_DataB_Avg();


            if (比较ToolStripMenuItem.Checked == true)
            {
                byte[] A = data_A;
                byte[] B = data_B;

                int[] m = new int[2 * datalength];
                int j;
                int k = 0;
                for (int i = 0; i < 2 * datalength; i++)
                {
                    if (A[i] != B[i])
                    {
                        j = i;
                        m[k] = j;
                        k++;
                    }
                }

                int index = 0;
                for (int i = 0; i < 2 * datalength; i++)
                {
                    if (m[i] == 0)
                    {
                        index = i;
                    }
                }
                int[] n = new int[index];
                for (int i = 0; i < index; i++)
                {
                    n[i] = m[i];
                }
                MessageBox.Show("" + index);
            }

         
            //处理数据，采用均方差算法
            if (算术平均ToolStripMenuItem.Checked == true)
            {
                progressBar1.Value = 0;

                int j = 0;
                double MINC = 0;
                int bias = 5000;
                int w = 5000;
                double[] C = new double[2 * bias];
                for (int i = -bias; i < bias; i++)
                {
                    C[i + bias] = 0;
                    for (int k = w; k < datalength - w; k++)
                        C[i + bias] += Math.Abs(dataA[k + i] - dataB[k]);  //曼哈顿距离
                    if (i == -bias) MINC = C[0];
                    else if (C[bias + i] < MINC)
                    {
                        j = i;
                        MINC = C[bias + i];
                    }
                    Application.DoEvents();
                    progressBar1.Value = (i + bias) * 50 / bias;

                }
                progressBar1.Value += 1;  //进度条

                double w_avg;
                w_avg = 0;
                for (int i = 0; i < 2 * bias; i++)
                    w_avg += C[i] / (2 * bias);

                for (int i = 0; i < 2 * bias; i++)
                    C[i] = (C[i] - w_avg) / w_avg;

                panel3.Controls.Add(zed3);
                GraphPane Pane = zed3.GraphPane;
                /*Pane.Title = "偏差结果";
                Pane.XAxis.Title = "";
                Pane.YAxis.Title = "";*/

                PointPairList list1 = new PointPairList();
                for (int i = 0; i < 2 * bias; i++)
                {
                    list1.Add(i, C[i]);
                }
                
                LineItem myCurve1 = Pane.AddCurve("Porsche", list1, Color.Blue, SymbolType.None);
                zed3.AxisChange();             

                //计算漏水点位置
                double positon = (WaterLeak.get_PipelineLength() + WaterLeak.get_WaveNumber() * j / (1000 * WaterLeak.get_CaptureRate())) / 2;
                /*label14.Text = "漏水点距离A探头" + positon.ToString() + "米!";

                //显示标注数据
                if (j > 0)
                    label13.Text = "A探头滞后B探头" + j.ToString("G") + "个基点!";
                if (j < 0)
                    label13.Text = "A探头超前B探头" + (-j).ToString() + "个基点!";
                if (j == 0)
                    label13.Text = "A探头与B探头无偏移!";*/

                //显示基点
                textBoxOffSet.Text = j.ToString();

                //保存参数
                WaterLeak.set_dataC_factor(500);
                WaterLeak.set_dataC_shift(100);
                WaterLeak.set_Bias(bias);
                WaterLeak.set_Min_Position(j);
                WaterLeak.set_Min_Value(MINC);
                WaterLeak.set_DataC(C);
            }

            //if (LMSToolStripMenuItem.Checked == true)
            //{
            //    progressBar1.Value = 0;


            //    MatlabClass mat = new MatlabClass();
            //    MWNumericArray dataA_m = new MWNumericArray(1, datalength, dataA);
            //    MWNumericArray dataB_m = new MWNumericArray(1, datalength, dataB);
            //    MWArray M_m = 100;
            //    MWArray mu_m = 0.00001;
            //    MWArray W_m = mat.my_LMS(dataA_m, dataB_m, M_m, mu_m);
            //    Array W = ((MWNumericArray)W_m).ToArray();
            //    int M = ((MWNumericArray)M_m).ToScalarInteger();
            //    int W_length = W.Length;
            //    int d = 0;
            //    double temp = Convert.ToDouble(W.GetValue(0, 0));

            //    for (int i = 1; i < W_length; i++)
            //    {
            //        if (temp < Convert.ToDouble(W.GetValue(i, 0)))
            //        {
            //            temp = Convert.ToDouble(W.GetValue(i, 0));
            //            d = i - 2 * M;
            //        }
            //    }

            //    panel3.Controls.Add(zed3);
            //    GraphPane Pane = zed3.GraphPane;
            //    Pane.Title = "偏差结果";
            //    Pane.XAxis.Title = "";
            //    Pane.YAxis.Title = "";

            //    PointPairList list = new PointPairList();
            //    for (int i = 0; i < W_length; i++)
            //    {
            //        list.Add(i - 2 * M, Convert.ToDouble(W.GetValue(i, 0)));
            //    }

            //    LineItem myCurve = Pane.AddCurve("Porsche", list, Color.Blue, SymbolType.None);
            //    zed3.AxisChange();

            //    //计算漏水点位置
            //    double positon = (WaterLeak.get_PipelineLength() + WaterLeak.get_WaveNumber() * d / (1000 * WaterLeak.get_CaptureRate())) / 2;
            //    label14.Text = "漏水点距离A探头" + positon.ToString() + "米!";

            //    //显示标注数据
            //    if (d > 0)
            //        label13.Text = "A探头滞后B探头" + d.ToString("G") + "个基点!";
            //    if (d < 0)
            //        label13.Text = "A探头超前B探头" + (-d).ToString() + "个基点!";
            //    if (d == 0)
            //        label13.Text = "A探头与B探头无偏移!";
            //}

            if (广义互相关ToolStripMenuItem.Checked == true)
            {
                DateTime startDT = System.DateTime.Now;
                progressBar1.Value = 0;
                int len = 262144;


                double[] A = new double[len];
                double[] B = new double[len];

                for (int i = 0; i < len; i++)
                {
                    A[i] = dataA[i];
                    B[i] = dataB[i];
                }

                CrossCorrelation ccorr = new CrossCorrelation();
                double[] R = ccorr.Rxy(A, B);
                int R_length = R.Length;

                Position p = new Position();
                int location = p.max(R);
                int d = location - R_length / 2;
            
                panel3.Controls.Add(zed3);
                GraphPane Pane = zed3.GraphPane;
                /*Pane.Title = "互相关系数";
                Pane.XAxis.Title = "";
                Pane.YAxis.Title = "";*/

                PointPairList list = new PointPairList();
                for (int i = 0; i < R_length; i++)
                {
                    list.Add(i, R[i]);
                }

                LineItem myCurve = Pane.AddCurve("Porsche", list, Color.Blue, SymbolType.None);
                zed3.AxisChange();

                //计算漏水点位置
                double positon = (WaterLeak.get_PipelineLength() + WaterLeak.get_WaveNumber() * d / (1000 * WaterLeak.get_CaptureRate())) / 2;
                /*label14.Text = "漏水点距离A探头" + positon.ToString() + "米!";
                //显示标注数据
                if (d > 0)
                    label13.Text = "A探头滞后B探头" + d.ToString("G") + "个基点!";
                if (d < 0)
                    label13.Text = "A探头超前B探头" + (-d).ToString() + "个基点!";
                if (d == 0)
                    label13.Text = "A探头与B探头无偏移!";*/

                //显示基点
                textBoxOffSet.Text = d.ToString();

                DateTime endDT = System.DateTime.Now;
                TimeSpan time = endDT.Subtract(startDT);
                //MessageBox.Show(time.TotalMilliseconds.ToString() + "ms");
            }

            //if (互功率谱ToolStripMenuItem.Checked == true)
            //{
            //    progressBar1.Value = 0;


            //    MatlabClass mat = new MatlabClass();
            //    MWNumericArray dataA_m = new MWNumericArray(1, datalength, dataA);
            //    MWNumericArray dataB_m = new MWNumericArray(1, datalength, dataB);
            //    MWArray datalength_m = datalength;
            //    MWArray R_m = mat.my_xcorrPow(dataA_m, dataB_m);  
            //    Array R = ((MWNumericArray)R_m).ToArray();
            //    int R_length = R.Length;

            //    int d = 0;
            //    double temp = Convert.ToDouble(R.GetValue(0, 0));

            //    for (int i = 1; i < R_length; i++)
            //    {
            //        if (temp < Convert.ToDouble(R.GetValue(0, i)))
            //        {
            //            temp = Convert.ToDouble(R.GetValue(0, i));
            //            d = i - datalength + 1;
            //        }
            //    }

            //    panel3.Controls.Add(zed3);
            //    GraphPane Pane = zed3.GraphPane;
            //    Pane.Title = "偏差结果";
            //    Pane.XAxis.Title = "";
            //    Pane.YAxis.Title = "";

            //    PointPairList list = new PointPairList();
            //    for (int i = 0; i < R_length; i++)
            //    {
            //        list.Add(i - datalength + 1, Convert.ToDouble(R.GetValue(0, i)));
            //    }

            //    LineItem myCurve = Pane.AddCurve("Porsche", list, Color.Blue, SymbolType.None);
            //    zed3.AxisChange();

            //    //计算漏水点位置
            //    double positon = (WaterLeak.get_PipelineLength() + WaterLeak.get_WaveNumber() * d / (1000 * WaterLeak.get_CaptureRate())) / 2;
            //    label14.Text = "漏水点距离A探头" + positon.ToString() + "米!";

            //    //显示标注数据
            //    if (d > 0)
            //        label13.Text = "A探头滞后B探头" + d.ToString("G") + "个基点!";
            //    if (d < 0)
            //        label13.Text = "A探头超前B探头" + (-d).ToString() + "个基点!";
            //    if (d == 0)
            //        label13.Text = "A探头与B探头无偏移!";              
            //}
               //int bias = 5000;
            //int w = 2500;
            //double[] C = new double[bias];
            //double minc = 0;
            //int d = 0;
            //int n = 5;//计算次数
            //int sp = datalength / n;//每次计算的间隔
            //int[] T = new int[n];//时延点数
            //double[] S = new double[n];//离A点距离
            //DataTable dt = new DataTable();
            //dt.Columns.Add("A探头超前点数", typeof(int));
            //dt.Columns.Add("漏水点离A探头距离", typeof(double));
            //for (int m = 0; m < n; m++)
            //{
            //    for (int i = 0 + m * sp; i < bias + m * sp; i++)
            //    {
            //        C[i - m * sp] = 0;
            //        for (int j = w + m * sp; j < w + bias + m * sp; j++)
            //        {
            //            C[i - m * sp] += Math.Abs(dataA[i + j - w - m * sp] - dataB[j]);
            //        }
            //        if (i == 0) minc = C[0];
            //        else if (C[i - m * sp] < minc)
            //        {
            //            d = i - m * sp;
            //            minc = C[i - m * sp];
            //        }
            //    }
            //    T[m] = w - d;
            //    S[m] = 500 - (double)T[m] / 10;
            //    DataRow dr = dt.NewRow();
            //    dr[0] = T[m].ToString();
            //    dr[1] = S[m].ToString();
            //    dt.Rows.Add(dr);
            //    Application.DoEvents();
            //    progressBar1.Value = (m - 1) * 100 / n;
            //}
            //dataGridView1.DataSource = dt;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            /*
            
            //处理数据，采用LMS算法
            //初始化
            int M=1000;
            float mu = (float)0.1;
            float[] en = new float[datalength];
            for (int i = 0; i < datalength; i++)
                en[i] = 0;
            double[] w = new double[M];
            for (int i = 0; i < M; i++)
                w[i] = 0;
            float y;
            //迭代运算
            for (int k = M - 1; k < datalength; k++)
            { 
                y=0;
                for (int i = 0; i < M; i++)
                    y += (float)(w[i]) * dataB[k - i];
                if (double.IsNaN(y)) y = 0;
                en[k] =dataA[k] - y;

                for (int i = 0; i < M; i++)
                {
                    w[i] = w[i] + 2 * mu * en[k] * dataB[k - i];
                    if (double.IsNaN(w[i])) w[i] = 0;
                    // w[i] = Math.Round(w[i], 6);
                }

                progressBar1.Value = (k-M) * 100 / (datalength - M-1);
               
                Application.DoEvents();

            }
             

           float w_avg;
           w_avg = 0;
            for (int i = 0; i < M; i++)
               w_avg += (float)w[i];

           w_avg /= M;
          // w_avg = Math.Round(w_avg, 6);

          // w[0] = Math.Round(w[0], 10);
           textBox1.Text = w[0].ToString("G");
            */
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            WaterLeak.set_PipelineLength(Convert.ToSingle(textBox1.Text));
            WaterLeak.set_WaveNumber(Convert.ToInt32(textBox2.Text));
            WaterLeak.set_CaptureRate(Convert.ToInt32(textBox3.Text));
            MessageBox.Show("参数保存成功！","消息");
        }

        //显示选中算法
        private void SingleCheck(object sender)
        {
            算术平均ToolStripMenuItem.Checked = false;
            LMSToolStripMenuItem.Checked = false;
            广义互相关ToolStripMenuItem.Checked = false;
            互功率谱ToolStripMenuItem.Checked = false;
            比较ToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void 算术平均ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }

        private void LMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }

        private void 广义互相关ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }
  
        private void 互功率谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }


     
        private void 采集探头数据toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }


        private void 比较ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SetGraph();
        }
    }

    public class WaterLeak
    {

        public WaterLeak()//int wn, int pll, int ABd, int length,short *dataA,short *dataB, float DAA,float DBA)
        {
         //TODO:添加构造函数逻辑
      
        
        }

          private static int _WaveNumber=1000;//管材波数
          private static double _PipelineLength = 1000;//管线长度
          private static int _CaptureRate=5;//采样频率

        //   private static int _AtoB_Deviation;//AB两个设备的偏移系数
        private static int _DataLength;
        private static double[] _DataA;
        private static double[] _DataB;
        private static double _DataA_Avg;
        private static double _DataB_Avg;

        private static int _dataA_shift;
        private static int _dataA_factor;

        private static int _dataB_shift;
        private static int _dataB_factor;

        private static int _Bias;
        private static int _Min_Position;
        private static double _Min_Value;
        private static int _dataC_shift;
        private static int _dataC_factor;
        private static double[] _DataC;

        public static void set_WaveNumber(int wn)
        {
            _WaveNumber = wn;
        }
        public static int get_WaveNumber()
        {
            return _WaveNumber;
        }
        public static void set_PipelineLength(double pll)
        {
            _PipelineLength = pll;
        }
        public static double get_PipelineLength()
        {
            return _PipelineLength;
        }
        public static void set_CaptureRate(int cr)
        {
            _CaptureRate = cr;
        }
        public static int get_CaptureRate()
        {
            return _CaptureRate;
        }


        public static void set_DataLength(int length)
        {
            _DataLength = length;
        }
        public static int get_DataLength()
        {
            return _DataLength;
        }
        public static void set_DataA(double[] dataA)
        {
            _DataA = new double[_DataLength];
            _DataA = dataA;

        }
        public static double[] get_DataA()
        {
            return _DataA;
        }

        public static void set_DataB(double[] dataB)
        {
            _DataB = new double[_DataLength];
            _DataB = dataB;

        }
        public static double[] get_DataB()
        {
            return _DataB;
        }
        public static void set_DataA_Avg(double DAA)
        {
            _DataA_Avg = DAA;
        }
        public static double get_DataA_Avg()
        {
            return _DataA_Avg;
        }
        public static void set_DataB_Avg(double DBA)
        {
            _DataB_Avg = DBA;
        }
        public static double get_DataB_Avg()
        {
            return _DataB_Avg;
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        /// <param name="shift"></param>
        public static void set_dataA_shift(int shift)
        {
            _dataA_shift = shift;
        }
        public static int get_dataA_shift()
        {
            return _dataA_shift;
        }
        public static void set_dataA_factor(int factor)
        {
            _dataA_factor = factor;
        }
        public static int get_dataA_factor()
        {
            return _dataA_factor;
        }
        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="shift"></param>
        public static void set_dataB_shift(int shift)
        {
            _dataB_shift = shift;
        }
        public static int get_dataB_shift()
        {
            return _dataB_shift;
        }
        public static void set_dataB_factor(int factor)
        {
            _dataB_factor = factor;
        }
        public static int get_dataB_factor()
        {
            return _dataB_factor;
        }

        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="shift"></param>
        public static void set_dataC_shift(int shift)
        {
            _dataC_shift = shift;
        }
        public static int get_dataC_shift()
        {
            return _dataC_shift;
        }
        public static void set_dataC_factor(int factor)
        {
            _dataC_factor = factor;
        }
        public static int get_dataC_factor()
        {
            return _dataC_factor;
        }
        public static void set_Bias(int bias)
        {
           _Bias = bias;
        }
        public static int get_dataC_Bias()
        {
            return _Bias;
        }
        public static void set_Min_Position(int min_pos)
        {
            _Min_Position = min_pos;
        }
        public static int get_Min_Position()
        {
            return _Min_Position;
        }
        public static void set_Min_Value(double min_value)
        {
            _Min_Value = min_value;
        }
        public static double get_Min_Value()
        {
            return _Min_Value;
        }
        public static void set_DataC(double[] dataC)
        {
            _DataC = new double[2*_Bias];
            _DataC = dataC;

        }
        public static double[] get_DataC()
        {
            return _DataC;
        }

    
    }


}
