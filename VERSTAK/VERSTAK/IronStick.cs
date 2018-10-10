using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERSTAK
{
    public class IronStick
    {
        public int Volume { get; set; }
        public int Mass { get; set; }
        public List<int> numList = new List<int>();



        public void AddNum(int num)
        {
            numList.Add(num);
        }
        public static bool operator ==(IronStick st1, IronStick st2)

        {
            if (st1.Volume == st2.Volume)
            {
                return true;
            }
            else if (st1.Volume != st2.Volume)
            {
                return false;
            }
            return false;
        }
        public static bool operator !=(IronStick st1, IronStick st2)
        {
            if (st1.Volume != st2.Volume)
            {
                return true;
            }
            else if (st1.Volume == st2.Volume)
            {
                return false;
            }
            return false;
        }
        public static bool operator <(IronStick firsList, IronStick secondList)
        {
            return (firsList.numList.Sum() < secondList.numList.Sum()) ? true : false;
        }

        public static bool operator >(IronStick firsList, IronStick secondList)
        {
            return (firsList.numList.Sum() > secondList.numList.Sum()) ? true : false;
        }

    }
}
