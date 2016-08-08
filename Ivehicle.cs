using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empp
{
    interface Ivehicle
    {
      int book_id
        {
            get;
            set;
        }
        int Id
        {
            get;
            set;
        }
        int NumberofVehicles
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }
    }
}
