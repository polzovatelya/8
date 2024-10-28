using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static void Print(List<elem> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("Команда " + i + " - "+lst[i].name_k);
                Console.WriteLine("Тренер " + i + " - "+lst[i].name_t);
                Console.WriteLine("Победы " + i + " - "+lst[i].win);
            }

        }
        public static void Input(int count, List<elem> lst) { 
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
        }
        public static void Delete(List<elem> lst1, int index)
        {
            if (index >= 0 && index < lst1.Count)
            {
                lst1.RemoveAt(index);
            }

        }

        public void Add(List<elem> lst1, elem el)
        {
            lst1.Add(el);
        }
        public void Edit(List<elem> lst1, int index, elem el)
        {
            if (index >= 0 && index < lst1.Count)
            {
                lst1[index] = el;
            }
        }

        static void Main(string[] args)
        {
            List<elem> lst1 = new List<elem>();
            Console.WriteLine("Введите число элементов");
            int count = Convert.ToInt32(Console.ReadLine());
            Input(count, lst1);
            Print(lst1);

        }
    }
}
