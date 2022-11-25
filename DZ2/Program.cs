using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Основная информация: \n\n\n");
            //Console.WriteLine("");

            // Умения
            string abil1 = "Тест";
            string abil2 = "Кодинг";
            string abil3 = "Базы данных";
            string abil4 = "Детализация";

            // Имена
            string name1 = "Виталий";
            string name2 = "Володя";
            string name3 = "Вячеслав";
            string name4 = "Витя";

            // Создание списка умений работников |||
            List<string> list1 = new List<string>() { name1, abil1 };
            List<string> list2 = new List<string>() { name2, abil2 };
            List<string> list3 = new List<string>() { name3, abil3 };
            List<string> list4 = new List<string>() { name4, abil4 };

            // Список работников без дела
            List<string> list5 = new List<string>() { name1, name2, name3, name4 };

            // Создание работников |||
            Person Vityalya = new Person(list1[0], list1);
            Person Volodya = new Person(list2[0], list2);
            Person Vyacyaslav = new Person(list3[0], list3);
            Person Vitya = new Person(list4[0], list4);

            // Список списков для умений работников 
            List<List<string>> lsd = new List<List<string>>();
            lsd.Add(Vityalya.Abilities); lsd.Add(Vitya.Abilities);
            lsd.Add(Volodya.Abilities); lsd.Add(Vyacyaslav.Abilities);
            //CheckList(lsd);
            // Создание проекта |||
            /*Описание*/
            string description = "Суть проекта - сделать сайт, который будет считывать ваш почерк," +
                " копировать его - писать на листе бумаги вашим почерком";

            /*Даты*/
            DateTime data1 = new DateTime(2022, 11, 18);
            DateTime data2 = new DateTime(2023, 11, 18);

            /*Инициатор*/
            string Initiator = "Дон Корлеоне";

            /*ТимЛид*/
            string TeamLead = "Джон Сноу";

            /*Задачи*/
            List<string> task = new List<string>() { "Детализация сайта - украшения, красота",
                "Базы данных - работа с таблицами, с фотографиями", "Тест - хорошая раббота, быстрый отклик",
                "Кодинг - построение сайта, внутренняя сторона сайта"};

            /*Статус*/
            string status = "Проект";

            /*Проект*/
            Project xernya = new Project(description, data1, data2, Initiator, TeamLead, task, status);

            // ТимЛид создает задачи |||
            // Список задач
            List<Task> empl = new List<Task>();

            Distribution(task, lsd, ref list5, ref empl);
            


            empl[0].nametask = "Вождение";
            CheckTasks(ref empl, lsd, task, ref list5);

            // Список отчетов
            List<Entity> entities = new List<Entity>();

            // ||| Работа проекта
            if (xernya.status == "Проект")
            {
                Console.WriteLine("\nРабота с задачами\n");
                xernya.status = "Исполнение";
                foreach (var i in empl)
                {
                    if (i.Status == "Назначена")
                    {
                        Console.WriteLine($"||| {i.Executor} думает как выполнить задачу {i.nametask}\n");
                        Thread.Sleep(3000);
                        i.Status = "В работе";
                        Console.WriteLine($"Статус --- {i.Status}\n");
                        Console.WriteLine($"{i.Executor} пыхтит... занимается {i.nametask} и в итоге доделывает\n");
                        Thread.Sleep(3000);
                        i.Status = "На проверке";
                        Console.WriteLine($"{i.Executor} проверяет свою работу... все верно..\n");
                        Thread.Sleep(3000);
                        i.Status = "Выполнена";
                        Console.WriteLine($"{i.Executor} составляет отчет...\n");
                        Thread.Sleep(3000);
                        string textent = $"Работа по {i.nametask} была выполнена, после проверок багов не нашлось" +
                            $"дата выполнение {i.data4}, работу выполнял {i.Executor}";
                        entities.Add(new Entity(textent, i.Executor));
                    }
                    else if (i.Status == "Отклонена")
                    {
                        Console.WriteLine($"||| {i.Executor} отклонил работу {i.nametask} так как, это не его " +
                            $"специализация..\n");
                    }
                    else if (i.Status == "Передана")
                    {
                        Console.WriteLine($"||| {i.Executor} передал задачу по {i.nametask}\n");
                    }
                    else { Console.WriteLine($"XYi {i.Status}") ; }
                    continue;

                }
                xernya.status = "Закрыт";
            }
            





            Console.Read();
        }
        public static void CheckTasks(ref List<Task> empl, List<List<string>> lsd, List<string> task, ref List<string> list5)
        {
            // Проверка данных задач

            foreach (var i in empl)
            {
                foreach (var q in lsd)
                {
                    if (q.Contains(i.nametask) != true && i.Executor == q[0])
                    {
                        Console.WriteLine($"Задача для {i.Executor} дана неправильно, {i.Executor} пробует избавиться от нее");
                        foreach (var q2 in lsd)
                        {
                            if (q2.Contains(i.nametask))
                            {
                                Console.WriteLine($"{i.Executor} передает задачу {q2[0]}");
                                q2.Add(i.nametask);
                                i.Status = "Передана";
                                Distribution(task, lsd, ref list5, ref empl);

                            }
                            else
                            {
                                Console.WriteLine($"Задача {i.nametask} не найдена, она будет отклонена ");
                                i.Status = "Отклонена";
                                break;
                            }
                            
                        }
                        break;
                    }
                }
            }
        }
        public static void Distribution(List<string> task, List<List<string>> lsd, ref List<string> list5, ref List<Task> empl)
        {
            // ТимЛид создает задачи |||
            Console.WriteLine("ТимЛид раздает задачи");
            string nameinit = "Vladimir";
            // Список задач
            empl.Clear();
            // Список отчетов


            // Распределение задач
            foreach (var i in task)
            {

                foreach (var t in lsd)
                {
                    if (i.Contains(t[1]))
                    {
                        Console.WriteLine($"Задача {t[1]} дана {t[0]}");
                        string variab = t[1];
                        string variab2 = t[0];
                        Console.Write("Введите дату назначения задачи:"); DateTime data3 = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите дату дедлайна: "); DateTime data4 = Convert.ToDateTime(Console.ReadLine());
                        string statuss = "Назначена";
                        empl.Add(new Task(variab2, statuss, nameinit, data3, data4, variab));
                        if (list5.Contains(variab2))
                        {
                            list5.Remove(variab2);
                        }
                        break;
                    }

                }

            }
        }
        public static void CheckList(List<string> a)
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static void CheckList(List<List<string>> a)
        {
            foreach (var i in a)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("\n\n");
            }
        }
    }

}
