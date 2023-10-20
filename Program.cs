
using ezhednevnik;
using System.Diagnostics;

namespace jhgkhgkhgj
{
    internal class Program
    {
        static DateTime a = DateTime.Now;
        static List<openzametka> zap = new List<openzametka>();
        static void Main(string[] args)
        {
            openzametka notee1 = new openzametka();
            notee1.data = new DateTime(2023, 10, 13);
            notee1.zapi1 = "1. Жёстко писать код на шарпах";
            notee1.zapi2 = "Жёстко писать код на шарпах";
            notee1.zapi3 = "--------------------";
            notee1.zapi4 = "Описание: Я в шоке...";

            openzametka notee2 = new openzametka();
            notee2.data = new DateTime(2023, 10, 14);
            notee2.zapi1 = "1. Сходить на пары";
            notee2.zapi2 = "Сходить на пары";
            notee2.zapi3 = "--------------------";
            notee2.zapi4 = "Описание: ММММ ЛЮБИМОЕ МПТ";

            openzametka notee3 = new openzametka();
            notee3.data = new DateTime(2023, 10, 14);
            notee3.zapi1 = "2. Уйти после первой";
            notee3.zapi2 = "Уйти после первой";
            notee3.zapi3 = "--------------------";
            notee3.zapi4 = "Описание: Ну а не надо ставить две бесполезные пары подряд";

            openzametka notee4 = new openzametka();
            notee4.data = new DateTime(2023, 10, 14);
            notee4.zapi1 = "3. Сидеть на скамейке";
            notee4.zapi2 = "Сидеть на скамейке";
            notee4.zapi3 = "--------------------";
            notee4.zapi4 = "Описание: \"У меня всё тут нормально, у меня мысли мыслят, я всё понимаю\"";

            openzametka notee5 = new openzametka();
            notee5.data = new DateTime(2023, 10, 15);
            notee5.zapi1 = "1. Подать на отчисление";
            notee5.zapi2 = "Подать на отчисление";
            notee5.zapi3 = "--------------------";
            notee5.zapi4 = "Описание: Радоваться";

            openzametka notee6 = new openzametka();
            notee6.data = new DateTime(2023, 10, 16);
            notee6.zapi1 = "1. Пойти обратно в МПТ";
            notee6.zapi2 = "Пойти обратно в МПТ";
            notee6.zapi3 = "--------------------";
            notee6.zapi4 = "Описание: Стало скусно, захотелось опять пострадать";

            zap.Add(notee1);
            zap.Add(notee2);
            zap.Add(notee3);
            zap.Add(notee4);
            zap.Add(notee5);
            zap.Add(notee6);

            int pos = 1;
            ConsoleKeyInfo strelka;
            do
            {
                strelka = Console.ReadKey();
                if (strelka.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    Console.WriteLine(a.ToString());
                }
                if (strelka.Key != ConsoleKey.Enter)
                {
                    for(int i = 0; i < zap.Count; i++)
                    {
                        if (zap[i].data.Date == a.Date)
                        {
                            Console.WriteLine("  " + zap[i].zapi1);
                        }
                    }
                    pos = izmenstrelka(pos);
                }
                if (strelka.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    for (int i = 0; i < zap.Count; i++)
                    {
                      
                        if (zap[i].data.Date == a.Date && pos == 1)
                        {
                            Console.WriteLine(zap[i].zapi2);
                            Console.WriteLine(zap[i].zapi3);
                            Console.WriteLine(zap[i].zapi4);
                            Console.WriteLine(zap[i].data);
                            break;
                        }
                        if (zap[i].data.Date == a.Date && pos == 2)
                        {
                            Console.WriteLine(zap[2].zapi2);
                            Console.WriteLine(zap[2].zapi3);
                            Console.WriteLine(zap[2].zapi4);
                            Console.WriteLine(zap[2].data);
                            break;
                        }
                        if (zap[i].data.Date == a.Date && pos == 3)
                        {
                            Console.WriteLine(zap[3].zapi2);
                            Console.WriteLine(zap[3].zapi3);
                            Console.WriteLine(zap[3].zapi4);
                            Console.WriteLine(zap[3].data);
                            break;
                        }
                    }
                    Console.WriteLine("Нажмите z, чтобы выйти");
                }
            } while (strelka.Key != ConsoleKey.Escape);
            Console.Clear();
            Console.WriteLine("  пока((");
            Console.SetCursorPosition(0, 5);
        }
        static int izmenstrelka(int pos)
        {
            pos = 1;
            ConsoleKeyInfo strelka;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                strelka = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (strelka.Key == ConsoleKey.UpArrow)
                {
                    if (pos == 1)
                    {
                        pos = 4;
                    }
                    pos--;
                }
                if (strelka.Key == ConsoleKey.DownArrow)
                {
                    if (pos == 3)
                    {
                        pos = 0;
                    }
                    pos++;
                }
                Izmendata(strelka);
            } while (strelka.Key == ConsoleKey.UpArrow || strelka.Key == ConsoleKey.DownArrow);
            return pos;
        }
        static void Izmendata(ConsoleKeyInfo strelka)
        {
            if (strelka.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                a = a.AddDays(1);
                Console.WriteLine(a.ToString());
            }
            if (strelka.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                a = a.AddDays(-1);
                Console.WriteLine(a.ToString());
            }
        }
    }
}