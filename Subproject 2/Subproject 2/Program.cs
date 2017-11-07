using System;

namespace Subproject_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //test here

            //DataserviceUser d = new DataserviceUser();
            DataserviceUser d = new DataserviceUser();

            var getU = d.getUsername("an");
        }
    }
}
