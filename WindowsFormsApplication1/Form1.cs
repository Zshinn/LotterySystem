using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string city_path="";
        string player_path="";
        string project_path = "";
        List<Project> project;
        List<City> city;
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel_city_edit.Visible = false;
            panel_project.Visible = false;
            panel_player.Visible = false;
            //dataGridView1.Width = 770;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar1.Value = 5;
            panel3.BackgroundImage = Image.FromFile("timg.jpg");
            progressBar2.Value = 20;
        }

        public void testDraw(int s)
        {
            List<Player> li = new List<Player>();
            for (int i = 0; i < s; i++)
            {
                Player p = new Player();
                p.Name = i.ToString();
                li.Add(p);
            }
            Draw d = new Draw(li);
            //n为每组人数
            int n = li.Count / 2;
            if ((li.Count % 2) != 0)
            {
                n = n + 1;
                d.Size = n;
                d.N = 2 - 1;
                d.End = li.Count - d.N * n;
            }
            else
            {
                d.Size = n;
                d.N = 2;
                d.End = 0;
            }
            d.draw();
            string t = "";
            for (int i = 0; i < li.Count; i++)
            {
                t += li[i].Group.ToString()+" "+li[i].Order + "\r\n";
            }
            MessageBox.Show(t);
        }

        private void draw_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            //验证随机数
            //testDraw(7);

        }

        private void city_edit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_city_edit.Visible = true; 
        }

        //导入城市文件
        private void city_return_Click(object sender, EventArgs e)
        {
            panel_city_edit.Visible = false;
            panel2.Visible = true;
        }

        private void city_watch_Click(object sender, EventArgs e)
        {
            if (city_path.Equals(""))
            {
                MessageBox.Show("请先上传文件！");
            }
            else
                System.Diagnostics.Process.Start(@city_path);
        }

        private void city_add_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " xls|*.xls";
            //openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                city_textbox.Text = this.openFileDialog1.FileName;
                city_path = city_textbox.Text.ToString().Trim();
            }
        }

        private void city_delet_Click(object sender, EventArgs e)
        {
            city_textbox.Text = "";
            city_path = "";
        }

        private void city_print_Click(object sender, EventArgs e)
        {
            if (city_path.Equals(""))
            {
                MessageBox.Show("目前没有需要打印的文件");
            }
            else
                System.Diagnostics.Process.Start(@city_path);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex != -1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_project.Visible = false;
            panel2.Visible = true;
            if (project!=null)
            {
                project.Clear();
                //将数据更新到list当中,所有datagirdview的数据重新重写 project
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                    //组别，名称，总数，分组数
                    string c = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    string n = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    int num = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value) ;
                    int div = Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value);
                    Project p = new Project(n,c);
                    p.Divide = div;
                    p.Num = num;

                    if (!project.Contains(p))
                    {
                        project.Add(p);
                    }
                }

            }
        }

        private void projrct_setting_Click(object sender, EventArgs e)
        {
            panel_project.Visible = true;
            panel2.Visible = false;
        }

        private void player_watch_Click(object sender, EventArgs e)
        {
            if (player_path.Equals(""))
                MessageBox.Show("请先上传文件！");
           else
                System.Diagnostics.Process.Start(@player_path);
        }

        private void player_add_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xls|*.xls";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                player_textbox.Text = this.openFileDialog1.FileName;
                player_path = player_textbox.Text.ToString().Trim();
            }
        }

        private void player_delet_Click(object sender, EventArgs e)
        {
            player_textbox.Text = "";
            player_path = "";
        }

        private void player_return_Click(object sender, EventArgs e)
        {
            panel_player.Visible = false;
            panel2.Visible = true;
        }

        //选手编辑模块
        private void player_edit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_player.Visible = true;
        }

        private void project_print_Click(object sender, EventArgs e)
        {
            if (player_path.Equals(""))
                MessageBox.Show("目前没有需要打印的文件");
            else
                System.Diagnostics.Process.Start(@player_path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1); 
        }

        private void city_draw_Click(object sender, EventArgs e)
        {
            if (!city_path.Equals(""))
            {
                MyExcel2 xl2 = new MyExcel2(city_path,"城市");
                city = xl2.City;
                xl2.draw();
                xl2.Close();

                MessageBox.Show("成功");
            }
            else
            {
                MessageBox.Show("抽签数据为空");
            }
            
        }

        //项目设置-导入excel表
        private void project_import_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xls|*.xls";
           // openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                project_textbox.Text = this.openFileDialog1.FileName;
                project_path = project_textbox.Text.ToString().Trim();
            }
            
        }

        //项目设置导入datagirdView中
        private void button4_Click(object sender, EventArgs e)
        {
            if (project_path != "")
            {
                progressBar2.Visible = true;
                MyExcel2 ex = new MyExcel2(project_path,"项目");
                project = ex.getProject();
                ex.Close();
                progressBar2.Value = 50;
                int value = 50;
                 for (int i = 0; i < project.Count; i++)
                {
                    
                     //组别，名称，总数，分组数
                    dataGridView1.Rows.Add();
                    //dataGridView1.Rows[i].Cells[1].Value = keys[i];
                    dataGridView1.Rows[i].Cells[0].Value = project[i].Category;
                    dataGridView1.Rows[i].Cells[1].Value = project[i].Name;
                    dataGridView1.Rows[i].Cells[2].Value = project[i].Num;
                    dataGridView1.Rows[i].Cells[3].Value = project[i].Divide;
                }
                 dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                 progressBar2.Value = 100;
                 progressBar2.Visible = false;
                
            }
            else
            {
                MessageBox.Show("没有文件可以导入！");
            }
            
        }

        //选手抽签，根据已经读取的选手信息表  筛选出各个项目的参赛组数  然后根据 参赛组数设置 进行分组  分组完成后  进行组内编号
        private void project_draw_Click(object sender, EventArgs e)
        {
            if (city_path != "")
            {
                if (project_path != "")
                {
                    if (player_path != "")
                    {
                        

                        progressBar1.Visible = true;
                        progressBar1.Value = 8;
                        //进行选手抽签
                        MyExcel2 m = new MyExcel2(player_path, "项目");
                        Dictionary<Project, List<Player>> primary = new Dictionary<Project, List<Player>>();
                        Dictionary<Project, List<Player>> senior = new Dictionary<Project, List<Player>>();
                        Dictionary<Project, List<Player>> high = new Dictionary<Project, List<Player>>();
                        progressBar1.Value = 10;
                        //添加键值
                        for(int i=0;i<project.Count;i++){
                            if(project[i].Category.Equals("小学")){
                                if(!primary.ContainsKey(project[i])){
                                    primary.Add(project[i],new List<Player>());
                                }
                            }
                            
                            if (project[i].Category.Equals("初中"))
                            {
                                if (!senior.ContainsKey(project[i]))
                                {
                                    senior.Add(project[i], new List<Player>());
                                }
                            }

                            if (project[i].Category.Equals("高中"))
                            {
                                if (!high.ContainsKey(project[i]))
                                {
                                    high.Add(project[i], new List<Player>());
                                }
                            }
                        }
                        progressBar1.Value = 20;
                        //添加值
                        
                        for (int i = 0; i < m.Player.Count; i++)
                        {
                            Project p = new Project(m.Player[i].Project_name,m.Player[i].Category);
                            if (p.Category.Equals("小学"))
                            {
                                primary[p].Add(m.Player[i]);
                            }
                            if (p.Category.Equals("初中"))
                            {
                                senior[p].Add(m.Player[i]);
                            }
                            if (p.Category.Equals("高中"))
                            {
                                high[p].Add(m.Player[i]);
                            }
                        }

                        progressBar1.Value = 40;
                        Project[] keys;
                        List<Player> lis = new List<Player>();
                        //为小学组抽签,计算分组数，按分组数抽签
                        keys = primary.Keys.ToArray<Project>();
                        for (int i = 0; i < keys.Length; i++)
                        {
                            primary[keys[i]].Sort();
                            Draw d = new Draw(primary[keys[i]]);
                            //n为每组人数
                            int n = keys[i].Num / keys[i].Divide;

                            if ((keys[i].Num % keys[i].Divide) != 0)
                            {
                                n = n + 1;
                                d.Size = n;
                                d.N = keys[i].Divide - 1;
                                d.End = keys[i].Num - d.N * n;
                            }
                            else
                            {
                                d.Size = n;
                                d.N = keys[i].Divide;
                                d.End = 0;
                            }
                            d.draw();
                            //整合
                            for (int k = 0; k < primary[keys[i]].Count; k++)
                            {
                                lis.Add(primary[keys[i]][k]);
                            }
                        }
                            
                        progressBar1.Value = 60;
                        //为初中组抽签
                        keys = senior.Keys.ToArray<Project>();
                        for (int i = 0; i < keys.Length; i++)
                        {
                            senior[keys[i]].Sort();
                            Draw d = new Draw(senior[keys[i]]);
                            //n为每组人数
                            int n = keys[i].Num / keys[i].Divide;

                            if ((keys[i].Num % keys[i].Divide) != 0)
                            {
                                n = n + 1;
                                d.Size = n;
                                d.N = keys[i].Divide - 1;
                                d.End = keys[i].Num - d.N * n;
                            }
                            else
                            {
                                d.Size = n;
                                d.N = keys[i].Divide;
                                d.End = 0;
                            }
                            d.draw();
                            for (int k = 0; k < senior[keys[i]].Count; k++)
                            {
                                lis.Add(senior[keys[i]][k]);
                            }
                        }
                        progressBar1.Value = 70;
                        //为高中组抽签
                        keys = high.Keys.ToArray<Project>();
                        for (int i = 0; i < keys.Length; i++)
                        {
                            high[keys[i]].Sort();
                            Draw d = new Draw(high[keys[i]]);
                            //n为每组人数
                            int n = keys[i].Num / keys[i].Divide;

                            if ((keys[i].Num % keys[i].Divide) != 0)
                            {
                                n = n + 1;
                                d.Size = n;
                                d.N = keys[i].Divide - 1;
                                d.End = keys[i].Num - d.N * n;
                            }
                            else
                            {
                                d.Size = n;
                                d.N = keys[i].Divide;
                                d.End = 0;
                            }
                            d.draw();
                            for (int k = 0; k < high[keys[i]].Count; k++)
                            {
                                lis.Add(high[keys[i]][k]);
                            }
                        }
                        progressBar1.Value = 80;
                        //整合成一个List,
                        m.Player = lis;
                        progressBar1.Value = 90;
                        //写入内容
                        m.draw();
                        progressBar1.Value = 100;
                        m.Close();
                        MessageBox.Show("成功！");
                        progressBar1.Visible=false;




                    }
                    else
                    {
                        MessageBox.Show("请先上传选手信息！");
                    }
                }
                else
                {
                    MessageBox.Show("请先进行项目设置！");
                }
            }
            else
            {
                MessageBox.Show("请先进行城市抽签！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚在建设中！");
        }





     
    }
}
