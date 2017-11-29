using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MyBL
    {
        DAL.IDAL dal = BlAdapter.Dal;
    
        public List<Flower> getFlowersWithTheWord(string key)
        {
            return dal.getFlowersWithTheWord(key);
        }
    }
}
