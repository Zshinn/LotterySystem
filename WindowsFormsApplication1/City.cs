using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class City : IComparable<City> 
    {
        
        public override bool Equals(Object obj)
        {
            City c = (City)obj;
            return this.Name.Equals(c.Name);
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode() ;
        }
        public int GetHashCode(City obj)
        {
            return obj.GetHashCode();
        }  
        public City()
        {
        }
        public City(string n)
        {
            name = n;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int order;

        public int Order
        {
            get { return order; }
            set { order = value; }
        }
        public int CompareTo(City c)
        {
            int result;
            if (this.Name.Equals(c.Name))
            {
                result = 0;
            }
            else
            {
                if (this.order > c.order)
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
        
    }
}
