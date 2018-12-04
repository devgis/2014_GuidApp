using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace guide_form
{
    public partial class Form1 : Form
    {
        public guide.mgraph g = new guide.mgraph();

        public Form1()
        {
            InitializeComponent();
            Functions.ETC.InitGragh(ref g);//初始化图
        }

        /// <summary>
        /// 全局变量的定义
        /// </summary>
        bool flag = false;//用于交替更改组合框选项
        const int max_ver_num = 20;
        const int MAX = 65535;
        String inst = "通过点击图上按钮或者更改组合框，选择“出发地”和“目的地”，\n点击“景点信息”，查询对应景点的信息以及单源点最短路径，\n点击“最短路径”，查询两景点间的最短路径。";//使用说明
        int[] path = new int[guide.guide.max_ver_num];
        int[] dist = new int[guide.guide.max_ver_num];

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //this.statusStrip1.Text = System.DateTime.Now.ToString();
        }//这两个方法用于状态栏时间的显示

        private void 使用说明IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inst, "使用说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbStart.Items.Clear();
            cbEnd.Items.Clear();
            for (int i = 0; i < g.name.Length; i++)
            {
                cbStart.Items.Add(g.name[i]);
                cbEnd.Items.Add(g.name[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbStart.Text.Trim()) || String.IsNullOrEmpty(cbEnd.Text.Trim()))
            {
                MessageBox.Show("起点终点不能为空，请选择！");
            }
            else
            {
                Functions.Shortest.Dijkstra(g, cbStart.SelectedIndex, path, dist);
                tbNavInfo.Text = Functions.Shortest.PrintPath(g, cbStart.SelectedIndex, cbEnd.SelectedIndex, path, dist);
            }
        }

        private void ShowInfoClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                int iTag = Convert.ToInt32((sender as Button).Tag);
                tbNavInfo.Text = Functions.ETC.ShowInfo(g, iTag);
            }
        }
    }
}
