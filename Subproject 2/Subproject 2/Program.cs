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

            d.getPostByUser(13,0,15);

        }
    }
}
