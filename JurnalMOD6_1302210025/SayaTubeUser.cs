using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalMOD6_1302210025
{
    internal class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;
        Random rnd = new Random();
        public SayaTubeUser(string username)
        {
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();
            id = rnd.Next(1,10000);
        }
        public int getTotalVideoPlayCount()
        {
            return uploadedVideos.Sum(x => x.playCount);
        }
        public void addVideo(SayaTubeVideo tubeVideo)
        {
            uploadedVideos.Add(tubeVideo);
        }
        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User : " + username);
            var i = 1;
            foreach(var video in uploadedVideos) {
                Console.WriteLine("Video " + i + " judul : " + video.getTitle());
                i++;
            }
        }

    }
}
