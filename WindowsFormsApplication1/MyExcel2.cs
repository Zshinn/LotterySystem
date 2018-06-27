using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; 

namespace WindowsFormsApplication1
{
    public class MyExcel2
    {
        Excel.Application app;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;

        private List<City> city=new List<City>();
        private List<Project> project;

        public List<Project> Project
        {
            get { return project; }
            set { project = value; }
        } 

        public List<City> City
        {
            get { return city; }
        }
        private List<Player> player=new List<Player>();

        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        //城市  项目
        string cate;

        public int rows, cols;
        object misvalue = System.Reflection.Missing.Value;
        public MyExcel2(string s,string cate)
        {
            this.cate = cate;
            app = new Excel.Application();
            //excel.Visible = true;
            workbook = app.Application.Workbooks.Add(@s);
            //获取表
           // worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.Sheets[1];

            //获取行数和列数
            rows = worksheet.UsedRange.CurrentRegion.Rows.Count;
            cols = worksheet.UsedRange.CurrentRegion.Columns.Count;

            //worksheet.Cells[2, 3] = "22222";
            //workbook.Save();
            try
            {
                    workbook.SaveAs(@s, Type.Missing, "", "", Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, 1, 
                false, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //workbook.Close();
            read();
            if (cate == "项目")
            {
                project = getProject();
            }
        }

        //项目名---总组数
        public List<Project> getProject()
        {
            List<Project> project=new List<Project>();
            Project p;
            for (int i = 0; i < player.Count; i++)
            {
                string n = player[i].Project_name;
                string c = player[i].Category;
                p = new Project(n,c);

                if (!project.Contains(p))
                {
                    project.Add(p);
                }
                if (project.Contains(p))
                {
                    //p.Num++;
                    int t = project.IndexOf(p);
                    project[t].Num++;
                    
                }
            }
            return project;


        }

        //读取excel中的数据
        public void read()
        {
            Excel.Range range;
            range = app.ActiveCell;
            if (cate.Trim().Equals("城市"))
            {
                for (int i = 2; i <= rows ; i++)
                {
                    //城市名
                    range = (Excel.Range)worksheet.Cells[i, 2];
                    string na = range.Value2;
                    City c = new City(na);
                    
                    if (!city.Contains(c))
                    {
                        city.Add(c);
                    }
                    
                }
            }
            if (cate.Trim().Equals("项目"))
            {
                string s;
                //城市 2 组别 3 项目名 4 队员名 5 学校 6 指导老师 7
                for (int i = 2; i <= rows; i++)
                {
                    Player p = new Player();
                    //城市名
                    range = (Excel.Range)worksheet.Cells[i, 2];
                    s = range.Value2;
                    p.City = new City(s);
                    //组别
                    range = (Excel.Range)worksheet.Cells[i, 3];
                    s = range.Value2;
                    p.Category = s;
                    //项目名
                    range = (Excel.Range)worksheet.Cells[i, 4];
                    s = range.Value2;
                    p.Project_name = s;
                    //队员名
                    range = (Excel.Range)worksheet.Cells[i, 5];
                    s = range.Value2;
                    p.Name = s;
                    //学习
                    range = (Excel.Range)worksheet.Cells[i, 6];
                    s = range.Value2;
                    p.School = s;
                    //指导老师
                    range = (Excel.Range)worksheet.Cells[i, 7];
                    s = range.Value2;
                    p.Teacher = s;

                    if (!player.Contains(p))
                    {
                        player.Add(p);
                    }

                }
            }
        }

        public void draw()
        {
            if (cate == "城市")
            {
                int k = 1;
                Draw d = new Draw(city);
                d.draw();
                //向文件写入结果,重新 更新S中的内容
                //清空excel
                for (int i = 2; i <= rows; i++)
                {
                    worksheet.Cells[i, 1] = "";
                    worksheet.Cells[i, 2] = "";
                    worksheet.Cells[i, 3] = "";
                }
                    for (int i = 0; i < d.City.Count; i++)
                    {
                        int c = i + 2;
                        worksheet.Cells[c, 1] = k++;
                        worksheet.Cells[c, 2] = d.City[i].Name;
                        worksheet.Cells[c, 3] = d.City[i].Order;
                    }

            }
            if (cate == "项目")
            {
                int k = 1;
                //向文件写入结果,重新 更新S中的内容
                //清空excel
                for (int i = 2; i <= rows; i++)
                {
                    worksheet.Cells[i, 1] = "";
                    worksheet.Cells[i, 2] = "";
                    worksheet.Cells[i, 3] = "";
                    worksheet.Cells[i, 4] = "";
                    worksheet.Cells[i, 5] = "";
                    worksheet.Cells[i, 6] = "";
                    worksheet.Cells[i, 7] = "";
                    worksheet.Cells[i, 8] = "";
                    worksheet.Cells[i, 9] = "";
                }
                for (int i = 0; i < player.Count; i++)
                {
                    int c = i + 2;
                    worksheet.Cells[c, 1] = k++;
                    worksheet.Cells[c, 2] = player[i].City.Name;
                    worksheet.Cells[c, 3] = player[i].Category;
                    worksheet.Cells[c, 4] = player[i].Project_name;
                    worksheet.Cells[c, 5] = player[i].Name;
                    worksheet.Cells[c, 6] = player[i].School;
                    worksheet.Cells[c, 7] = player[i].Teacher;
                    worksheet.Cells[c, 8] = player[i].Group.ToString();
                    worksheet.Cells[c, 9] = player[i].Order;
                }






            }
        }
        public void Close()
        //关闭一个Microsoft.Office.Interop.Excel对象，销毁对象
        {
            //wb.Save();
            workbook.Close(Type.Missing, Type.Missing, Type.Missing);
            //workbooks.Close();
            app.Quit();
            workbook = null;
            app = null;
            GC.Collect();
        }

    }
}
