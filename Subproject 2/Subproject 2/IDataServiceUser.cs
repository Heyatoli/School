using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    interface IDataServiceUser
    {
        List<User> getUser();

        List<User> getUsername(string u);
            //search for user, both whole name, and input contains part of name    
        
        List<History> getHistory(int userid); 
            //show user history 
        
        List<Marking> getFavourites(int userid);
            //show user marking 
        
        History createHistory(int userid, string search);

        Marking createMarking(int userid, int postid, string note);

        Marking updateMarking(int userid, int postid, string note);

        bool deleteHistory(int histId);

        bool deleteFavourites(int markId);
    }
}
