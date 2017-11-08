using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    public interface IDataServiceUser
    {

        int userAmount();

        List<User> getUser(int page, int pageSize);
        //done

        int userNameAmount(string name);
        
        List<User> getUsername(string name, int page, int pageSize);
        //done  

        int historyAmount(int id);
        
        List<History> getHistory(int id, int page, int pageSize);
        //show user history 

        int markingAmount(int id);
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
