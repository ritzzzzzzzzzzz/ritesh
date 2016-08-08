using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empp
{
   public class vehicle
    {
        int id, num;
        string type;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Type
        {
            get
            {
                return type;
            }
                set
                    { type = value; }
            }
      
    public vehicle(int id1,int num1)
    {
            id = id1;
           
            num = num1;
    }

    }
}
