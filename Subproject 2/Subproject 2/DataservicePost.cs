using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Subproject_2
{
    public class DataservicePost : IDataServicePost
    {
        /*   public Post getCommments(int postid)
           {
               using (var db = new stackOverflowContext())
               {
                   var query1 =
                       (from c in db.Comment 
                       where c.postId == postid
                       select new Comment
                       {
                           score = c.score,
                           text = c.text,
                           creationDate = c.creationDate,
                       }).ToList();

                   var query2 =
                       (from p in db.Posts
                        //where p.postid == postid
                        select new Post
                        {
                            score = p.score,
                            text = p.text,
                            creationDate = p.creationDate,
                            comments = query1
                        });

                  // return query2;
               }
           }

           public List<Post> getPost()
           {
               using (var db = new stackOverflowContext())
               {
                   var query =
                       (from u in db.Posts
                        select new Post
                        {
                            id = u.id,
                            type = u.type,
                            parent_id = u.parent_id,
                            answer_id = u.answer_id,
                            creationDate = u.creationDate,
                            score = u.score,
                            text = u.text,
                            closedDate = u.closedDate,
                            title = u.title
                        }).ToList();

                   return query;
               }
           }

           public List<Post> getPostByTag(string tag)
           {
               using (var db = new stackOverflowContext())
               {
                   var query =
                       (from t in db.Tags 
                        join c in db.Combinations
                        on t.id equals c.tags_id 
                        where t.name == tag 
                        select new Post
                        {
                            //id = u.id,
                            //type = u.type,
                            //parent_id = u.parent_id,
                            //answer_id = u.answer_id,
                            //creationDate = u.creationDate,
                            //score = u.score,
                            //text = u.text,
                            //closedDate = u.closedDate,
                            //title = u.title
                        }).ToList();

                   return query;
               }
           }

           public List<Post> getPostByUser(int postuserid)
           {
               using (var db = new stackOverflowContext())
               {
                   var query =
                       (from u in db.Posts
                        //where u.postid == postuserid 
                        select new Post
                        {
                            type = u.type,
                            parent_id = u.parent_id,
                            answer_id = u.answer_id,
                            creationDate = u.creationDate,
                            score = u.score,
                            text = u.text,
                            closedDate = u.closedDate,
                            title = u.title
                        }).ToList();

                   return query;
               }
           }

           public List<Post> getPostWord(string postword)
           {
               using (var db = new stackOverflowContext())
               {
                   var query =
                       (from u in db.Posts
                        //where u.postid == postuserid 
                        select new Post
                        {
                            type = u.type,
                            parent_id = u.parent_id,
                            answer_id = u.answer_id,
                            creationDate = u.creationDate,
                            score = u.score,
                            text = u.text,
                            closedDate = u.closedDate,
                            title = u.title
                        }).ToList();

                   return query;
               }
           }
           */
        public Post getCommments(int postid)
        {
            throw new NotImplementedException();
        }

        public List<Post> getPost()
        {
            throw new NotImplementedException();
        }

        public List<Post> getPostByTag(string tag)
        {
            throw new NotImplementedException();
        }

        public List<Post> getPostByUser(int postuserid)
        {
            throw new NotImplementedException();
        }

        public List<Post> getPostWord(string postword)
        {
            throw new NotImplementedException();
        }
    }
}



