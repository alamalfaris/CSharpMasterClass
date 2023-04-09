using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class ImagePost : Post
    {
        public string ImageUrl { get; set; }
        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, bool isPublic, string imageUrl)
        {
            // The following properties and the GetNextId() are inherited from Post
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property ImageUrl is a member of ImagePost
            this.ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} by {2} - {3}", Id, Title, SendByUsername, ImageUrl);
        }
    }
}
