using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class_dal_save_at_list
    {
        List<BE.Flower> Flowers = new List<BE.Flower>();

        internal List<BE.Flower> Flowers1 { get => Flowers; set => Flowers = value; }

        public Class_dal_save_at_list(List<BE.Flower> flowers)
        {
            Flowers1 = flowers;
        }

        public Class_dal_save_at_list()
        {
        }

    }
  
}
