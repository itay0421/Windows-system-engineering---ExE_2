using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class BlAdapter
    {
        private static DAL.IDAL dal = DAL.FactoryDal.getDal();

        public static IDAL Dal { get => dal; set => dal = value; }
    }
}
