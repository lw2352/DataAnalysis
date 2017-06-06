namespace WindowsFormsApplication1
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开A文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开B文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.探测器参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管线参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.算法ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.算术平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.广义互相关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.互功率谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.比较ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据采集toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采集探头数据toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAvgB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAvgA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOffSet = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 225);
            this.label1.TabIndex = 1;
            this.label1.Text = "        A探头数据窗口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(27, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "A探头数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "二进制文件|*.dat";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.算法ToolStripMenuItem1,
            this.数据采集toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开A文件,
            this.打开B文件,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(F)";
            // 
            // 打开A文件
            // 
            this.打开A文件.Name = "打开A文件";
            this.打开A文件.ShortcutKeyDisplayString = "";
            this.打开A文件.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.打开A文件.ShowShortcutKeys = false;
            this.打开A文件.Size = new System.Drawing.Size(140, 22);
            this.打开A文件.Text = "打开A文件(A)";
            this.打开A文件.Click += new System.EventHandler(this.button1_Click);
            // 
            // 打开B文件
            // 
            this.打开B文件.Name = "打开B文件";
            this.打开B文件.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.打开B文件.ShowShortcutKeys = false;
            this.打开B文件.Size = new System.Drawing.Size(140, 22);
            this.打开B文件.Text = "打开B文件(B)";
            this.打开B文件.Click += new System.EventHandler(this.button2_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.退出ToolStripMenuItem.ShowShortcutKeys = false;
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.退出ToolStripMenuItem.Text = "退出(X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.探测器参数ToolStripMenuItem,
            this.管线参数ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.配置ToolStripMenuItem.Text = "配置(C)";
            // 
            // 探测器参数ToolStripMenuItem
            // 
            this.探测器参数ToolStripMenuItem.Name = "探测器参数ToolStripMenuItem";
            this.探测器参数ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.探测器参数ToolStripMenuItem.Text = "探测器参数";
            // 
            // 管线参数ToolStripMenuItem
            // 
            this.管线参数ToolStripMenuItem.Name = "管线参数ToolStripMenuItem";
            this.管线参数ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.管线参数ToolStripMenuItem.Text = "管线参数";
            // 
            // 算法ToolStripMenuItem1
            // 
            this.算法ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.算术平均ToolStripMenuItem,
            this.LMSToolStripMenuItem,
            this.广义互相关ToolStripMenuItem,
            this.互功率谱ToolStripMenuItem,
            this.比较ToolStripMenuItem});
            this.算法ToolStripMenuItem1.Name = "算法ToolStripMenuItem1";
            this.算法ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.算法ToolStripMenuItem1.Size = new System.Drawing.Size(64, 21);
            this.算法ToolStripMenuItem1.Text = "算法(M)";
            // 
            // 算术平均ToolStripMenuItem
            // 
            this.算术平均ToolStripMenuItem.Checked = true;
            this.算术平均ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.算术平均ToolStripMenuItem.Name = "算术平均ToolStripMenuItem";
            this.算术平均ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.算术平均ToolStripMenuItem.Text = "算术平均";
            this.算术平均ToolStripMenuItem.Click += new System.EventHandler(this.算术平均ToolStripMenuItem_Click);
            // 
            // LMSToolStripMenuItem
            // 
            this.LMSToolStripMenuItem.Name = "LMSToolStripMenuItem";
            this.LMSToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.LMSToolStripMenuItem.Text = "LMS";
            this.LMSToolStripMenuItem.Click += new System.EventHandler(this.LMSToolStripMenuItem_Click);
            // 
            // 广义互相关ToolStripMenuItem
            // 
            this.广义互相关ToolStripMenuItem.Name = "广义互相关ToolStripMenuItem";
            this.广义互相关ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.广义互相关ToolStripMenuItem.Text = "广义互相关";
            this.广义互相关ToolStripMenuItem.Click += new System.EventHandler(this.广义互相关ToolStripMenuItem_Click);
            // 
            // 互功率谱ToolStripMenuItem
            // 
            this.互功率谱ToolStripMenuItem.Name = "互功率谱ToolStripMenuItem";
            this.互功率谱ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.互功率谱ToolStripMenuItem.Text = "互功率谱";
            this.互功率谱ToolStripMenuItem.Click += new System.EventHandler(this.互功率谱ToolStripMenuItem_Click);
            // 
            // 比较ToolStripMenuItem
            // 
            this.比较ToolStripMenuItem.Name = "比较ToolStripMenuItem";
            this.比较ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.比较ToolStripMenuItem.Text = "比较";
            this.比较ToolStripMenuItem.Click += new System.EventHandler(this.比较ToolStripMenuItem_Click);
            // 
            // 数据采集toolStripMenuItem
            // 
            this.数据采集toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采集探头数据toolStripMenuItem});
            this.数据采集toolStripMenuItem.Name = "数据采集toolStripMenuItem";
            this.数据采集toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.数据采集toolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.数据采集toolStripMenuItem.Text = "数据采集(D)";
            // 
            // 采集探头数据toolStripMenuItem
            // 
            this.采集探头数据toolStripMenuItem.Name = "采集探头数据toolStripMenuItem";
            this.采集探头数据toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.采集探头数据toolStripMenuItem.ShowShortcutKeys = false;
            this.采集探头数据toolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.采集探头数据toolStripMenuItem.Text = "采集探头数据(C)";
            this.采集探头数据toolStripMenuItem.Click += new System.EventHandler(this.采集探头数据toolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(0, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 225);
            this.label2.TabIndex = 6;
            this.label2.Text = "        B探头数据窗口";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(0, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 225);
            this.label3.TabIndex = 7;
            this.label3.Text = "        处理结果窗口";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxAvgB);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxAvgA);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxOffSet);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(1, 718);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "漏水检测操作";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(183, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "B平均幅值:";
            // 
            // textBoxAvgB
            // 
            this.textBoxAvgB.Location = new System.Drawing.Point(257, 24);
            this.textBoxAvgB.Name = "textBoxAvgB";
            this.textBoxAvgB.Size = new System.Drawing.Size(111, 23);
            this.textBoxAvgB.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "A平均幅值:";
            // 
            // textBoxAvgA
            // 
            this.textBoxAvgA.Location = new System.Drawing.Point(73, 23);
            this.textBoxAvgA.Name = "textBoxAvgA";
            this.textBoxAvgA.Size = new System.Drawing.Size(104, 23);
            this.textBoxAvgA.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "AB偏移基点:";
            // 
            // textBoxOffSet
            // 
            this.textBoxOffSet.Location = new System.Drawing.Point(475, 23);
            this.textBoxOffSet.Name = "textBoxOffSet";
            this.textBoxOffSet.Size = new System.Drawing.Size(67, 23);
            this.textBoxOffSet.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(426, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "开始处理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(222, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "B探头数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(604, 720);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数输入";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "5.PVC管:340米/秒。";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "4.PE管:380米/秒；";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "3.石棉水泥:1000米/秒；";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "2.铸铁:1200米/秒；";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "1.钢铁:1300米/秒；";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "管材参数备注：";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("华文中宋", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(399, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 75);
            this.button4.TabIndex = 6;
            this.button4.Text = "保存设置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "数据采集频率（KHz）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "管线材料参数（米/秒）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "AB两点管线距离（米）";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 839);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1182, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(28, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 225);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(28, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 225);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(28, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 225);
            this.panel2.TabIndex = 16;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(600, 450);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "漏水检测演示系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开A文件;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 探测器参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管线参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开B文件;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem 算法ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 算术平均ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 广义互相关ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据采集toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采集探头数据toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 互功率谱ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem 比较ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxOffSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAvgA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAvgB;
        private System.Windows.Forms.Label label14;
    }
}

