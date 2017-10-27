using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    class User
    {

        public int id { get; set; }

        public string name { get; set; }

        public DateTime creationDate { get; set; }

        public string location { get; set; }

        public int age { get; set; }

        public List<Marking> marks { get; set; }

        public List<History> history { get; set; }
    }
}
