using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    interface IDataServicePost
    {
        List<Post> getPost();


        List<Post> getPostWord(string postword);
            //search post title by given name 

        List<Post> getPostByTag(string tag);
            //show posts by tag

        List<Post> getPostByUser(int postuserid);
            //list posts by user

        Post getCommments(int postid);
    }       
}
