namespace guide_form
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNavInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(0, 28);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(808, 672);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // cbStart
            // 
            this.cbStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(58, 709);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(120, 20);
            this.cbStart.TabIndex = 15;
            // 
            // cbEnd
            // 
            this.cbEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(240, 709);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(120, 20);
            this.cbEnd.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(369, 706);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "最短路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 714);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "出发地";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(185, 714);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "目的地";
            // 
            // tbNavInfo
            // 
            this.tbNavInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNavInfo.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNavInfo.Location = new System.Drawing.Point(814, 28);
            this.tbNavInfo.Multiline = true;
            this.tbNavInfo.Name = "tbNavInfo";
            this.tbNavInfo.ReadOnly = true;
            this.tbNavInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNavInfo.Size = new System.Drawing.Size(200, 701);
            this.tbNavInfo.TabIndex = 8;
            this.tbNavInfo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FileToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FileToolStripMenuItem
            // 
            this.文件FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FileToolStripMenuItem.Name = "文件FileToolStripMenuItem";
            this.文件FileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FileToolStripMenuItem.Text = "文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明IToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 使用说明IToolStripMenuItem
            // 
            this.使用说明IToolStripMenuItem.Name = "使用说明IToolStripMenuItem";
            this.使用说明IToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.使用说明IToolStripMenuItem.Text = "使用说明(&I)";
            this.使用说明IToolStripMenuItem.Click += new System.EventHandler(this.使用说明IToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(94, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 19);
            this.button1.TabIndex = 24;
            this.button1.Tag = "0";
            this.button1.Text = "0办公楼";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(94, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 19);
            this.button2.TabIndex = 25;
            this.button2.Tag = "1";
            this.button2.Text = "1号教学楼";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(94, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 19);
            this.button4.TabIndex = 26;
            this.button4.Tag = "2";
            this.button4.Text = "2号教学楼";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(166, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 19);
            this.button5.TabIndex = 27;
            this.button5.Tag = "3";
            this.button5.Text = "3号教学楼";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(179, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 19);
            this.button6.TabIndex = 28;
            this.button6.Tag = "4";
            this.button6.Text = "4号教学楼";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(188, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 19);
            this.button7.TabIndex = 29;
            this.button7.Tag = "5";
            this.button7.Text = "5幼儿园";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(188, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 19);
            this.button8.TabIndex = 30;
            this.button8.Tag = "6";
            this.button8.Text = "6北苑餐厅";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(229, 390);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 19);
            this.button9.TabIndex = 31;
            this.button9.Tag = "7";
            this.button9.Text = "7西苑餐厅";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(443, 284);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 19);
            this.button10.TabIndex = 32;
            this.button10.Tag = "8";
            this.button10.Text = "8东苑餐厅";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(267, 272);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 19);
            this.button11.TabIndex = 33;
            this.button11.Tag = "9";
            this.button11.Text = "9校医院";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(419, 370);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(71, 19);
            this.button12.TabIndex = 34;
            this.button12.Tag = "10";
            this.button12.Text = "10图书馆";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(342, 370);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(71, 19);
            this.button13.TabIndex = 35;
            this.button13.Tag = "11";
            this.button13.Text = "11逸夫楼";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(402, 336);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 19);
            this.button14.TabIndex = 36;
            this.button14.Tag = "12";
            this.button14.Text = "12校园超市";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(481, 381);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(99, 19);
            this.button15.TabIndex = 37;
            this.button15.Tag = "13";
            this.button15.Text = "13国际交流中心";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button16.Location = new System.Drawing.Point(360, 205);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(99, 19);
            this.button16.TabIndex = 38;
            this.button16.Tag = "14";
            this.button16.Text = "14足球场";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(267, 191);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(71, 19);
            this.button17.TabIndex = 39;
            this.button17.Tag = "15";
            this.button17.Text = "15大篮球场";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button18.Location = new System.Drawing.Point(281, 244);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(79, 19);
            this.button18.TabIndex = 40;
            this.button18.Tag = "16";
            this.button18.Text = "16小篮球场";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button19.Location = new System.Drawing.Point(301, 411);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(79, 19);
            this.button19.TabIndex = 41;
            this.button19.Tag = "17";
            this.button19.Text = "17学生公寓1";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button20.Location = new System.Drawing.Point(301, 381);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(79, 19);
            this.button20.TabIndex = 42;
            this.button20.Tag = "18";
            this.button20.Text = "18学生公寓2";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button21.Location = new System.Drawing.Point(301, 336);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(79, 19);
            this.button21.TabIndex = 43;
            this.button21.Tag = "19";
            this.button21.Text = "19学生公寓9";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button22.Location = new System.Drawing.Point(240, 406);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(79, 19);
            this.button22.TabIndex = 44;
            this.button22.Tag = "20";
            this.button22.Text = "20学生公寓4";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button23.Location = new System.Drawing.Point(229, 334);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(79, 19);
            this.button23.TabIndex = 45;
            this.button23.Tag = "21";
            this.button23.Text = "21学生公寓5";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button24.Location = new System.Drawing.Point(520, 268);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(79, 19);
            this.button24.TabIndex = 46;
            this.button24.Tag = "22";
            this.button24.Text = "22学生公寓6";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button25.Location = new System.Drawing.Point(568, 284);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(79, 19);
            this.button25.TabIndex = 47;
            this.button25.Tag = "23";
            this.button25.Text = "23学生公寓7";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button26.Location = new System.Drawing.Point(520, 297);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(79, 19);
            this.button26.TabIndex = 48;
            this.button26.Tag = "24";
            this.button26.Text = "24学生公寓8";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button27
            // 
            this.button27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button27.Location = new System.Drawing.Point(502, 332);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(79, 19);
            this.button27.TabIndex = 49;
            this.button27.Tag = "25";
            this.button27.Text = "25学生公寓9";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // button28
            // 
            this.button28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button28.Location = new System.Drawing.Point(502, 368);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(79, 19);
            this.button28.TabIndex = 50;
            this.button28.Tag = "26";
            this.button28.Text = "26学生公寓10";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.ShowInfoClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 735);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbNavInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pbMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山东财经大学校园导游咨询系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNavInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明IToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
    }
}

