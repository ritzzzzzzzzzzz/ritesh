using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empp
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicledb vh = new vehicledb();  
            int c;
            do
            {
                Console.WriteLine("! for view, 2 for booking");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("give type of vehicle");
                        string type =Console.ReadLine();
                        List<vehicle> listt = vh.viewd(type);
                        if (listt.Count > 0)
                        {
                            foreach (vehicle objj in listt)
                            {
                                Console.WriteLine("vehicle id is " + objj.Id);
                                Console.WriteLine("Stock available " + objj.Num);
                            }
                        }
                        else
                        {
                            Console.WriteLine("no data found");
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter the id of vehicle");
                        int id1 =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the number of vehicle to be booked");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("give your address");
                        string add = Console.ReadLine();
                        booking oj = new booking(id1, num, add);
                        int s = vh.add(oj);
                        if(s>0)

                        Console.WriteLine("booking id is "+s);
                        break;
                    default:
                        Console.WriteLine("provide with specified option");
                        break;
                }
            } while (c < 5);

        }
    }
}
