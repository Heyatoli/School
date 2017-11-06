using System;

namespace Subproject_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //test here

            //DataserviceUser d = new DataserviceUser();
            DataservicePost d = new DataservicePost();

            var test = d.getPostWord("what");
            Console.WriteLine(test);

        }
    }
}
