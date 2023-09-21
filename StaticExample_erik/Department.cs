using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample_erik
{
    public class Department
    {

        public string depName;
        public static int depCount = 2;


        //declare static depCount member with value of 2

        //complete the constructor
        public Department(string name)
        {
            Department.depCount++;
            Console.WriteLine("Department opened: " + name);
            this.depName = name;

        }
    }
}
