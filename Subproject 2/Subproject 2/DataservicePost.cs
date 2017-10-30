using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Subproject_2
{
    class DataservicePost : IDataServicePost
    {
        //public void getPost()
        //{
        //    using (var db = new stackOverflowContext())
        //    {
        //        var get_post =
        //            (from o in db.Posts
        //             where o.id == 713
        //             select new Post
        //             {
        //                 id = o.id
        //             }).ToList();

        //        foreach (var item in get_post)
        //        {
        //            Console.WriteLine(item.id);
        //        }

        //     
        //}
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
