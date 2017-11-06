using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Subproject_2
{
    public class DataserviceUser : IDataServiceUser
    {
        public History createHistory(int id, string search)
        {

            using (var db = new stackOverflowContext())
            {

                var query = new History
                {
                    userId = id,
                    searchWord = search
                };

                db.History.Add(query);
                db.SaveChanges();
                Console.WriteLine("Succesfully created");
                return query;
            }
        }


        public Marking createMarking(int userid, int postid, string note)
        {
            using (var db = new stackOverflowContext())
            {

                var query = new Marking
                {
                    postId = postid,
                    userID = userid,
                    note = note
                };

                db.Marking.Add(query);
                db.SaveChanges();
                return query;

            }
        }
        

        public bool deleteFavourites(int userid, int postid)
        {
            using (var db = new stackOverflowContext())
            {
                var delete = new Marking
                {
                    userID = userid,
                    postId = postid
                };


                try
                {
                    db.Marking.Remove(delete);
                    db.SaveChanges();
                    Console.WriteLine("Deletion complete");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Couldn't delete");
                    return false;
                    throw;
                }
            }
        }
        //DOOOONE

        public bool deleteHistory(int id)
        {
            using (var db = new stackOverflowContext())
            {

                var delete = new History
                {
                    id = id
                };

                try
                {
                    db.History.Remove(delete);
                    db.SaveChanges();
                    Console.WriteLine("Succesfully deleted");
                    return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Couldn't delete");
                    return false;
                }


            }
        }
        //DOOOONE

        public List<Marking> getFavourites(int id)
        {
            using (var db = new stackOverflowContext())
            {
                var q =
                    (from m in db.Marking
                     where m.userID == id
                     select new Marking
                     {
                         postId = m.postId,
                         userID = m.userID,
                         note = m.note
                     }).ToList();
                return q;
            }
        }
        //DOOOONE

        public List<History> getHistory(int id)
        {
            using (var db = new stackOverflowContext())
            {

                var q =
                    (from h in db.History
                     where h.userId == id
                     select new History
                     {
                         id = h.id,
                         userId = h.userId,
                         searchWord = h.searchWord
                     }).ToList();
                return q;
            }
        }
        //DOOOONE

        public List<User> getUser()
        {
            using (var db = new stackOverflowContext())
            {
                var q =
                    (from u in db.User
                     //where u.id == id
                     select new User
                     {
                        age = u.age,
                        creationDate = u.creationDate,
                        location = u.location,
                        name = u.name
                     }).ToList();

                Console.WriteLine(q.FirstOrDefault());
                return q;
            }
        }
        //DOOOONE

        public List<User> getUsername(string s)
        {
            using (var db = new stackOverflowContext())
            {
                var users =
                    (from n in db.User
                     where n.name.Contains(s)
                     select new User
                     {
                         age = n.age,
                         creationDate = n.creationDate,
                         location = n.location,
                         name = n.name
                     }).ToList();
                return users;      
            }
        }

        public bool updateMarking(int userid, int postid, string note)
        {
            using (var db = new stackOverflowContext())
            {

                var update = new Marking
                {
                    postId = postid,
                    userID = userid,
                    note = note
                };

                try
                {
                    db.Marking.Update(update);
                    db.SaveChanges();
                    Console.WriteLine("Updated");
                    return true;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Couldn't update");
                    return false;
                }

            }
        }
    }
}
