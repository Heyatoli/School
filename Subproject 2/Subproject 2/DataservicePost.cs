using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Subproject_2
{
    public class DataservicePost : IDataServicePost
    {
        public Post getCommments(int postid, int page, int pageSize)
        {
            using (var db = new stackOverflowContext())
            {
                var query1 =
                    (from c in db.Comments
                    where c.postId == postid
                    select new Comment
                    {
                        score = c.score,
                        text = c.text,
                        creationDate = c.creationDate,
                    }).ToList();

                var query2 =
                    (from p in db.Posts
                     where p.id == postid
                     select new Post
                     {
                         score = p.score,
                         text = p.text,
                         creationDate = p.creationDate,
                         comments = query1
                     });

                for (int i = 0; i < query2.FirstOrDefault().comments.Count(); i++)
                {
                    Console.WriteLine(query2.FirstOrDefault().comments.ElementAt(i).text);
                }
                    
                

                return query2.FirstOrDefault();
            }
        }

        public List<Post> getPost(int page, int pageSize)
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
                     }).OrderBy(u => u.id)
                     .Skip(page * pageSize)
                     .Take(pageSize)
                     .ToList();

                return query;
            }
        }

        public List<Post> getPostByTag(string tag, int page, int pageSize)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from t in db.Tags
                     join c in db.Combinations
                     on t.id equals c.tags_id
                     join p in db.Posts
                     on c.post_id equals p.id
                     where t.name == tag
                     select new Post
                     {
                         id = p.id,
                         type = p.type,
                         parent_id = p.parent_id,
                         answer_id = p.answer_id,
                         creationDate = p.creationDate,
                         score = p.score,
                         text = p.text,
                         closedDate = p.closedDate,
                         title = p.title
                     }).OrderBy(u => u.id)
                     .Skip(page * pageSize)
                     .Take(pageSize)
                     .ToList();

                Console.WriteLine(query.FirstOrDefault().title);

                return query;
            }
        }

        public List<Post> getPostByUser(int postuserid, int page, int pageSize)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from u in db.Posts
                     where u.id == postuserid 
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
                     }).OrderBy(u => u.id)
                     .Skip(page * pageSize)
                     .Take(pageSize)
                     .ToList();

                return query;
            }
        }

        public List<Post> getPostWord(string postword, int page, int pageSize)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from p in db.Posts
                     where p.title.Contains(postword) 
                     select new Post
                     {
                         id = p.id,
                         type = p.type,
                         parent_id = p.parent_id,
                         answer_id = p.answer_id,
                         creationDate = p.creationDate,
                         score = p.score,
                         text = p.text,
                         closedDate = p.closedDate,
                         title = p.title
                     }).OrderBy(u => u.id)
                     .Skip(page * pageSize)
                     .Take(pageSize)
                     .ToList();

                return query;
            }
        }

        public int amountPost()
        {
            using (var db = new stackOverflowContext())
            {
                var q =
                    (from p in db.Posts
                     select new Post
                     {
                         id = p.id
                     }).ToList();
                return q.Count();
            }
        }

        public int amountPostWord(string postWord)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from p in db.Posts
                     where p.title.Contains(postWord)
                     select new Post
                     {
                         id = p.id,

                     }).ToList();

                return query.Count();
            }
        }

        public int amountPostByTag(string tag)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from t in db.Tags
                     join c in db.Combinations
                     on t.id equals c.tags_id
                     join p in db.Posts
                     on c.post_id equals p.id
                     where t.name == tag
                     select new Post
                     {
                         id = p.id
                     }).ToList();

                return query.Count();
            }
        }

        public int amountPostByUser(int postuserid)
        {
            using (var db = new stackOverflowContext())
            {
                var query =
                    (from u in db.Posts
                     where u.id == postuserid
                     select new Post
                     {
                         id = u.id
                     }).ToList();

                return query.Count();
            }
        }

        public int amountComments(int postid)
        {
            using (var db = new stackOverflowContext())
            {
                var q =
                    (from c in db.Comments
                     where c.postId == postid
                     select new Post
                     {
                         score = c.score
                     }).ToList();

                return q.Count();
            }
        }
    }
}



