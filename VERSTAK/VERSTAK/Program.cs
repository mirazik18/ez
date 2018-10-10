using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERSTAK
{
    class Program
    {
     
        static void Main(string[] args)
        {
            IronStick ironStick = new IronStick();
            IronStick ironStick2 = new IronStick();
            ironStick.Volume = 5;
            ironStick2.Volume = 5;
        

            if(ironStick.Volume == ironStick2.Volume)
            {
                Console.WriteLine("Значения равны!");
            }
            else if (ironStick.Volume != ironStick2.Volume)
            {
                Console.WriteLine("Значения не равны");
            }
           
            

            Console.ReadLine();
            Console.Clear();
            SecondTask();
            Console.ReadLine();
        }
        static void SecondTask()
        {
            IronStick firstList = new IronStick();
            IronStick secondList = new IronStick();
            firstList.AddNum(1);
            firstList.AddNum(8);
            secondList.AddNum(1);
            secondList.AddNum(3);

            Console.WriteLine((firstList > secondList) ? "Сумма первого массива больше" : "Сумма второго массива больше");
        }
    }
}
