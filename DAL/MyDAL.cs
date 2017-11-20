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
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "blue", "brazil"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "blue", "egipt"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "red", "argentina"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "red", "chile"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "pink", "colombia"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "orange", "panama"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "green", "israel"));
            myDB.Flowers1.Add(new BE.Flower("tropical flower, beatiful", "lilas", "canada"));
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
