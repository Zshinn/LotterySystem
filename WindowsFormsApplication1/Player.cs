using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Player : IComparable<Player>
    {

        public override bool Equals(Object obj)
        {
            Player c = (Player)obj;
            return this.Name.Equals(c.Name)&&this.Project_name.Equals(c.Project_name) && this.Category.Equals(c.Category) && this.teacher.Equals(c.teacher) 
                && this.School.Equals(c.School);
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode()+this.Project_name.GetHashCode()+this.Teacher.GetHashCode()+this.City.GetHashCode()+this.Category.GetHashCode()
                +this.School.GetHashCode();
        }

        public int CompareTo(Player p)
        {
            int result;
            if (this.City.Order == p.City.Order)
            {
                result = 0;
            }
            else
            {
                if (this.City.Order > p.City.Order)
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

        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string project_name;

        public string Project_name
        {
            get { return project_name; }
            set { project_name = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string school;

        public string School
        {
            get { return school; }
            set { school = value; }
        }
        private string teacher;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        private char group='A';

        public char Group
        {
            get { return group; }
            set { group = value; }
        }
        private int order;

        public int Order
        {
            get { return order; }
            set { order = value; }
        }
        
    }
}
