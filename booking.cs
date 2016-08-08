using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empp
{
   public class booking:Ivehicle
    {
      
            int Book_id,id,booked;
        string addess;
        public int book_id
        {
            get { return Book_id; }
            set { Book_id = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NumberofVehicles
        {
            get { return booked; }
            set { booked = value; }
        }
        public string Address
        {
            get { return addess; }
            set { addess = value; }
        }
        public booking(int vehicle1,int booked_vehicles,string address11)
        {
           id = vehicle1;
            booked = booked_vehicles;
            addess = address11;
        }
    }
}
