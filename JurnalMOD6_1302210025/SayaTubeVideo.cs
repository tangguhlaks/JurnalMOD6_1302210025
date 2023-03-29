using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalMOD6_1302210025
{
    internal class SayaTubeVideo
    {
        Random rnd = new Random();
        private int id;
        private string title;
        public int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = rnd.Next(1,10000);
            this.title = title;
            this.playCount = 0;
        }
        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public void printVideoDetail()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }
        public string getTitle()
        {
            return title;
        }
    }
}
