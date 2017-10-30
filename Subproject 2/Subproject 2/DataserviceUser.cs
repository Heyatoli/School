using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Subproject_2
{
    class DataserviceUser : IDataServiceUser
    {
        public History createHistory(int userid, string search)
        {
            throw new NotImplementedException();
        }

        public Marking createMarking(int userid, int postid, string note)
        {
            throw new NotImplementedException();
        }

        public bool deleteFavourites(int markId)
        {
            throw new NotImplementedException();
        }

        public bool deleteHistory(int histId)
        {
            throw new NotImplementedException();
        }

        public List<Marking> getFavourites(int userid)
        {
            throw new NotImplementedException();
        }

        public List<History> getHistory(int userid)
        {
            throw new NotImplementedException();
        }

        public List<User> getUser()
        {
            throw new NotImplementedException();
        }

        public List<User> getUsername(string u)
        {
            throw new NotImplementedException();
        }

        public Marking updateMarking(int userid, int postid, string note)
        {
            throw new NotImplementedException();
        }
    }
}
