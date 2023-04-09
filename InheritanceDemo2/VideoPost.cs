using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        public string VideoUrl { get; set; }
        public int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoUrl, int length)
        {
            // The following properties and the GetNextId() are inherited from Post
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property ImageUrl is a member of ImagePost
            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            Console.WriteLine("Playing");
            timer = new Timer(TimerCallback, null, 0, 1000);
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopped at {0}", currDuration);
            currDuration = 0;
            timer.Dispose();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} by {2} - {3} - duration: {4} sec", Id, Title, SendByUsername, VideoUrl, Length);
        }
    }
}
