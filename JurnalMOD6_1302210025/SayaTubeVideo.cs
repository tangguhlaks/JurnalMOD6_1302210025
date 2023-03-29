using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null,"Title tidak boleh null");
            Debug.Assert(title.Length <= 200,"Title length tidak boleh lebih besar dari 200");
            this.id = rnd.Next(1, 10000);
            this.title = title;
            this.playCount = 0;        
        }
        public void increasePlayCount(int playCounts)
        {
            Debug.Assert(playCounts >= 0, "Input playcount tidak boleh bilangan negatif");
            Debug.Assert(playCounts <= 25000000);
          
            int updateCount;
            try
            {
                updateCount = checked(this.playCount+playCounts);
            }catch {
                Console.WriteLine("penambahan play count maksimal 25.000.000");
                updateCount = playCounts;
            }

            playCounts = updateCount;
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
