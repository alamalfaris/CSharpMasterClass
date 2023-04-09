using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        /*Default constructor. If a derived class does not invoke a base class
         constructor explitcitly, the default constructor is called implicitly*/
        public Post()
        {
            Id = 0;
            Title = "My First Post";
            SendByUsername = "alamalfaris";
            IsPublic = true;
        }

        // Constructor that has three parameters
        public Post(string title, string sendByUsername, bool isPublic)
        {
            Id = GetNextId();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        /*Virtual method override of the ToString method that is
         inherited from System.Object*/
        public override string ToString()
        {
            return string.Format("{0} - {1} by {2}", Id, Title, SendByUsername);
        }
    }
}
