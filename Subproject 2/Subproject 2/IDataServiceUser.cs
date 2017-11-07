using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    public interface IDataServiceUser
    {
        List<User> getUser();
        //done
        List<User> getUsername(string name);
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
