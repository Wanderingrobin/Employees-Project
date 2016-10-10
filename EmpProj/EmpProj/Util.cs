using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProj
{
    public class Util
    {
        public static void Pay([Emp] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i].firstName + " " + newArray[i].lastName = "paid");
            }

        }
    }
}
