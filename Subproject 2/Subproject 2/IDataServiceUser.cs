using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    interface IDataServiceUser
    {
        List<User> getUser(int id);
        //done
        List<User> getUsername(string u);
            //done    
        
        List<History> getHistory(int id); 
            //show user history 
        
        List<Marking> getFavourites(int id);
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
