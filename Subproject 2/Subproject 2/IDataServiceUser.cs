using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    public interface IDataServiceUser
    {

        List<User> getUser(int page, int pageSize);
        //done
        List<User> getUsername(string name, int page, int pageSize);
            //done    
        
        List<History> getHistory(int id, int page, int pageSize); 
            //show user history 
        
        List<Marking> getFavourites(int id, int page, int pageSize);
            //show user marking 
        
        History createHistory(int userid, string search);
        //done
        Marking createMarking(int userid, int postid, string note);
        //done
        bool updateMarking(int userid, int postid, string note);
        //done
        bool deleteHistory(int histId);

        bool deleteFavourites(int userid, int postid);
        //done
    }
}
