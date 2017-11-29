using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDAL : IDAL
    {

        Class_dal_save_at_list myDB = new Class_dal_save_at_list();


        public MyDAL()
        {
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "blue", "brazil"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "blue", "egipt"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "red", "argentina"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "red", "chile"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "pink", "colombia"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "orange", "panama"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "green", "israel"));
            //myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "lilas", "canada"));
            myDB.Flowers1.Add(new BE.Flower("calanit", "red", "all israel", @"http://www.wildflowers.co.il/images/320-pics/21.jpg"));
            myDB.Flowers1.Add(new BE.Flower("narkis", "yelow", "Negev", @"http://www.wildflowers.co.il/images/320-pics/210.jpg"));
            myDB.Flowers1.Add(new BE.Flower("Vered", "whith", "all israel" , @"https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Small_Red_Rose.JPG/200px-Small_Red_Rose.JPG"));
            myDB.Flowers1.Add(new BE.Flower("Hatsav", "green", "north", @"https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Drimia_maritima_EnfoqueFlores_2010-10-03_SierraMadrona.jpg/250px-Drimia_maritima_EnfoqueFlores_2010-10-03_SierraMadrona.jpg"));
        }

        internal Class_dal_save_at_list DB { get => myDB; set => myDB = value; }

        public List<BE.Flower> getFlowersWithTheWord(string key)
        {
            List<BE.Flower> tmpFlower = new List<BE.Flower>();
            foreach(var flower in myDB.Flowers1)
            {
                if (flower.Area.Contains(key) || flower.Color.Contains(key) || flower.Description.Contains(key))
                    tmpFlower.Add(flower);
            }
            return tmpFlower;
        }
    }
}
