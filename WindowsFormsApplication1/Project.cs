using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Project : IComparable<Project>
    {
        public override bool Equals(Object obj)
        {
            Project c = (Project)obj;
            return this.Name.Equals(c.Name) && this.Category.Equals(c.Category);
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode()+this.Category.GetHashCode();
        }
        public Project(string n, string c)
        {
            this.name = n;
            this.category = c;
            this.divide = 2;
            this.num = 0;
        }
        public int CompareTo(Project c)
        {
            int result;
            if (this.Name == c.Name && this.Category==c.Category)
            {
                result = 0;
            }
            else
            {
                if (this.Name.CompareTo(c.Name)>0)
                {
                    result = 1;
                }
                else
                {
                    result = -1;
                }
            }
            return result;
        }


        string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        int divide;

        public int Divide
        {
            get { return divide; }
            set { divide = value; }
        }



    }
}
