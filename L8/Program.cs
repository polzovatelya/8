using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    internal class Program
    {
        public struct elem
        {
            public string name_k;
            public string name_t;

            public int win;
        }
        public void Print(List<elem> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i].name_k, lst[i].name_t, lst[i].win);
            }

        }
        public List<elem> Input(int count)
        {   List<elem> lst = new List<elem>();
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    elem el = new elem();
                    Console.WriteLine("Введите название команды: ");
                    el.name_k = Console.ReadLine();
                    Console.WriteLine("Введите ФИО тренера: ");
                    el.name_t = Console.ReadLine();
                    Console.WriteLine("Введите число побед: ");
                    el.win = Convert.ToInt32(Console.ReadLine());
                    lst.Add(el);

                }
            }
            else
            {
                elem el = new elem();
                el.name_k = "Error";
                el.name_t = "Error";
                el.win = -1;
            }
            return lst;
        }
        static void Main(string[] args)
        {
            List<elem> list = new List<elem>();
            Console.WriteLine("Введите число элементов");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                elem el = new elem();
                Console.WriteLine("Введите название команды: ");
                el.name_k = Console.ReadLine();
                Console.WriteLine("Введите ФИО тренера: ");
                el.name_t = Console.ReadLine();
                Console.WriteLine("Введите число побед: ");
                el.win = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
