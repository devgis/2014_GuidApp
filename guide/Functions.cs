using System;
using System.Collections.Generic;
using System.Text;
using guide;

namespace Functions
{
    public class Shortest
    {
        public static void Dijkstra(mgraph G, int v0, int[] path, int[] dist)
        {
            int i, j;
            int k = v0;
            int v, w, min;
            int[] s = new int[guide.guide.max_ver_num];
            for (v = 0; v < G.vernum; v++)
            {
                s[v] = 0;
                dist[v] = G.arcs[v0,v];
                if (dist[v] < guide.guide.MAX)
                    path[v] = v0;
                else
                    path[v] = -1;
            }
            dist[v0] = 0;
            s[v0] = 1;
            for (i = 1; i < G.vernum; i++)
            {
                min = guide.guide.MAX;
                for (w = 0; w < G.vernum; w++)
                {
                    if (s[w] == 0 && dist[w] < min)
                    {
                        k = w;
                        min = dist[w];
                    }
                }
                s[k] = 1;
                for (j = 0; j < G.vernum; j++)
                    if (s[j] == 0 && (min + G.arcs[k,j] < dist[j]))
                    {
                        dist[j] = min + G.arcs[k,j];
                        path[j] = k;
                    }
            }
        }//Dijkstra算法，用于求两点间最短路径和单源点最短路径。G为图，v0为起始点，path保存求得的路径，dist保存求得的距离

        public static String PrintPath(mgraph G, int v0, int i, int[] p, int[] d)
        {
            String res = "";
            int next, k = 0;
            int[] q = new int[guide.guide.max_ver_num];
            if (p[i] != -1 && i != v0)
            {
                q[++k] = i;
                next = p[i];
                while (next != v0)
                {
                    q[++k] = next;
                    next = p[next];
                }
                res += G.name[v0];
                while (k > 0)
                {
                    next = q[k--];
                    res += "→" + G.name[next];
                }
                res += Environment.NewLine + "总路线长：" + Convert.ToString(d[i]) + "米" + Environment.NewLine;
            }
            else
                if (p[i] == -1 && i != v0)
                    res += "没有路径存在";
            return res;
        }//用于输出由Dijkstra方法求得的路径和距离。其中g、v0、path和dist同Dijkstra，i为终止点
    }

    public class ETC
    {
        public static int InitGragh(ref mgraph G)//校园导游图的初始化
        {
            int i, j;
            G.vernum = 27;
            G.arcnum = 27;
            for (i = 0; i < G.vernum; i++)
                G.no[i] = i;//各景点的编号
            G.name[0] = "办公楼";
            G.name[1] = "1号教学楼";
            G.name[2] = "2号教学楼";
            G.name[3] = "3号教学楼";
            G.name[4] = "4号教学楼";
            G.name[5] = "幼儿园";
            G.name[6] = "北苑餐厅";
            G.name[7] = "西苑餐厅";
            G.name[8] = "东苑餐厅";
            G.name[9] = "校医院";
            G.name[10] = "图书馆";
            G.name[11] = "逸夫楼";
            G.name[12] = "校园超市";
            G.name[13] = "国际交流中心";
            G.name[14] = "足球场";//各景点的名称
            G.name[15] = "大篮球场";//各景点的名称
            G.name[16] = "小篮球场";//各景点的名称
            G.name[17] = "学生公寓1";//各景点的名称
            G.name[18] = "学生公寓2";//各景点的名称
            G.name[19] = "学生公寓3";//各景点的名称
            G.name[20] = "学生公寓4";//各景点的名称
            G.name[21] = "学生公寓5";//各景点的名称
            G.name[22] = "学生公寓6";//各景点的名称
            G.name[23] = "学生公寓7";//各景点的名称
            G.name[24] = "学生公寓8";//各景点的名称
            G.name[25] = "学生公寓9";//各景点的名称
            G.name[26] = "学生公寓10";//各景点的名称

            //G.info[0] = "取快递、去校外的必经之路";
            //G.info[1] = "图书馆，标志性建筑";
            //G.info[2] = "信息学院楼";
            //G.info[3] = "三层食堂";
            //G.info[4] = "大浴室";
            //G.info[5] = "教学楼A，A教";
            //G.info[6] = "教学楼B，B教";
            //G.info[7] = "教学楼C，C教";
            //G.info[8] = "教学楼D，D教";
            //G.info[9] = "大活，休闲活动场所";
            //G.info[10] = "田径场、足球场、看台";
            //G.info[11] = "新建成的体育场馆，由主馆和副馆组成";
            //G.info[12] = "校区南侧大门";
            //G.info[13] = "校区北侧大门";
            //G.info[14] = "理学院楼，大学物理实验实验室";//各景点的信息
            //初始化边矩阵
            for (i = 0; i < G.vernum; i++)
                for (j = 0; j < G.vernum; j++)
                    G.arcs[i,j] = guide.guide.MAX;
            G.arcs[0,1] = 100;
            G.arcs[0, 4] = 30;
            G.arcs[0, 5] = 40;
            G.arcs[0, 6] = 50;

            G.arcs[1, 2] = 50;
            G.arcs[1, 21] = 100;
            G.arcs[1, 4] = 150;
            G.arcs[1, 4] = 50;

            G.arcs[2, 3] = 50;

            G.arcs[3, 7] = 50;
            G.arcs[3, 21] = 150;
            G.arcs[3, 4] = 180;

            G.arcs[4, 5] = 10;
            G.arcs[4, 6] = 20;
            G.arcs[4, 16] = 100;
            G.arcs[4, 15] = 100;

            G.arcs[5, 6] = 10;
            G.arcs[5, 16] = 100;
            G.arcs[5, 15] = 100;

            G.arcs[6, 15] = 50;

            G.arcs[7, 20] = 10;
            G.arcs[7, 17] = 20;
            G.arcs[7, 18] = 20;

            G.arcs[8,22] = 20;
            G.arcs[8, 23] = 30;
            G.arcs[8, 24] = 20;
            G.arcs[8, 25] = 50;

            G.arcs[9, 16] = 20;
            G.arcs[9, 15] = 50; 
            G.arcs[9, 21] = 30;
            G.arcs[9, 19] = 30;

            G.arcs[10, 11] = 30;
            G.arcs[10, 12] = 10;
            G.arcs[10, 13] = 30;

            G.arcs[12, 8] = 30;

            G.arcs[13, 26] = 10;
            G.arcs[14, 8] = 50;

            G.arcs[15, 14] = 30;

            G.arcs[16, 14] = 20;

            G.arcs[17, 18] = 10;
            G.arcs[17, 20] = 20;
            G.arcs[17, 11] = 20;

            G.arcs[18, 11] = 10;
            G.arcs[18, 19] = 30;

            G.arcs[19, 12] = 50;

            G.arcs[20, 17] = 20;
            G.arcs[20, 18] = 20;

            G.arcs[21, 19] = 30;

            G.arcs[22, 23] = 20;

            G.arcs[23, 24] = 20;

            G.arcs[24, 25] = 30;

            G.arcs[25, 26] = 30;

            for (j = 0; j < G.vernum; j++)
                for (i = 0; i < G.vernum; i++)
                    G.arcs[i,j] = G.arcs[j,i];
            return 1;
        }//图的初始化

        public static String ShowInfo(mgraph G, int n)//景点信息查询；
        {
            String res = "";
            int [] path = new int [guide.guide.max_ver_num];
            int [] dist = new int [guide.guide.max_ver_num];
            res += "景点编号：" + Convert.ToString(G.no[n]) + Environment.NewLine + "景点名称：" + G.name[n] + Environment.NewLine + "景点简介：" + G.info[n] + Environment.NewLine + Environment.NewLine;
            Shortest.Dijkstra(G, n, path, dist);
            for (int i=0;i<G.vernum;i++)
            {
                res += Shortest.PrintPath(G, n, i, path, dist);
            }
            return res;
        }//用于显示景点的详细信息（包括单源点最短路径），n为要显示的景点编号
    }
}