using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициатор
            Initiator Potato = new Initiator("ООО Картошка");

            // Тимлид
            TeamLead ChikChirick = new TeamLead("Чыкчырык");

            // Списки способностей
            List<string> ability1 = new List<string>() { "Разработка"  };
            List<string> ability2 = new List<string>() { "Фронтент" };
            List<string> ability3 = new List<string>() { "Сортировка" };
            List<string> ability4 = new List<string>() { "Программирование" };
            List<string> ability5 = new List<string>() { "Мат-проектирование" };
            List<string> ability6 = new List<string>() { "Дизайн" };
            List<string> ability7 = new List<string>() { "Бэкенд" };
            List<string> ability8 = new List<string>() { "Механизация" };
            List<string> ability9 = new List<string>() { "Работа с базами данных" };
            List<string> ability10 = new List<string>() { "Проектирование" };
            // Команда
            Person Nikolay = new Person("Николай", ability1);
            Person Vladimir = new Person("Владимир", ability2);
            Person Jho = new Person("Джо", ability3);
            Person Zelenski = new Person("Зеленски", ability4);
            Person Sholc = new Person("Шольц", ability5);
            Person Vuchich = new Person("Вучич", ability6);
            Person Makron = new Person("Макрон", ability7);
            Person Tokaev = new Person("Токаев", ability8);
            Person CiZinpin = new Person("СиЦзинпин", ability9);
            Person KimChenIn = new Person("КимЧенЫн", ability10);

            List<Person> persons = new List<Person>() { Nikolay, Vladimir, Jho, Zelenski, Sholc, Vuchich, Makron, Tokaev, CiZinpin, KimChenIn };

            // Задачи
            string decript1 = "Разработка";
            string decript2 = "Фронтент";
            string decript3 = "Сортировка";
            string decript4 = "Мат-проектирование";
            string decript5 = "Программирование";
            string decript6 = "Дизайн";
            string decript7 = "Бэкенд";
            string decript8 = "Механизация";
            string decript9 = "Работа с базами данных";
            string decript10 = "Проектирование";

            // Список всех задач
            List<string> decript = new List<string>() { decript1, decript2, decript3, decript4, decript5, decript6, decript7,
                decript8, decript9, decript10 };

            // Даты

            DateTime date1 = new DateTime(2022,11,18);
            DateTime date2 = new DateTime(2022, 12, 20);
            DateTime date3 = new DateTime(2023, 1, 10);
            DateTime date4 = new DateTime(2023, 11, 18);

            List<DateTime> date = new List<DateTime>() { date1, date2, date3, date4 };

            List<Task> tasks = new List<Task>() { };


            // Создание проекта 
            Project project = new Project(decript, date1, date4, Potato, ChikChirick, "Проект");

            Raspr(decript, persons, date, ref tasks, Potato, ref project);

            Work(ref tasks, ref persons);
            

            CheckTask(tasks);
            Console.Read();
        }
        public static void Work(ref List<Task> tasks,ref List<Person> persons)
        {
            foreach (var i in persons)
            {
                foreach (var q in tasks)
                {
                    if (q.person == i)
                    {
                        Console.WriteLine($"{i.Name} должен сдавать отчеты каждый месяц");
                        var y = q.date1;
                        var u = q.date2;
                        if (y.Month == u.Month && y.Year == u.Year - 1)
                        {
                            int cnt = 0;
                            while (cnt != 12)
                            {
                                string repo = "Хорошо поработал";
                                var a = new Report(repo);

                                cnt++;
                                q.report.Add(a);
                            }
                            
                        }
                        else
                        {
                            var a = new Report("Хорошо поработал");
                            q.report.Add(a);
                        }


                    }
                }
            }
        }
        public static void Raspr(List<string> decripts, List<Person> persons, List<DateTime> c, ref List<Task> tasks, Initiator init, ref Project project)
        {
            int cnt = 0;
            foreach (var i in persons)
            {
                cnt = 0;
                foreach (var q in decripts)
                {
                    if (i.ability.Contains(q) && cnt != 1)
                    {
                        Console.WriteLine($"Задача {q} дана {i.Name}");
                        Console.WriteLine($"Выберем дату для работ\n1 - {c[0]}\n2 - {c[1]}\n3 - {c[2]}\n4 - {c[3]}\nНапишите две подряд идущие цифры");

                        int cnt2 = 0;
                        while (cnt2 != 1)
                        {
                            int vari = int.Parse(Console.ReadLine());
                            switch (vari)
                            {
                                case 12:
                                    tasks.Add(new Task(q, c[0], c[1], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                case 13:
                                    tasks.Add(new Task(q, c[0], c[2], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                case 14:
                                    tasks.Add(new Task(q, c[0], c[3], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                case 23:
                                    tasks.Add(new Task(q, c[1], c[2], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                case 24:
                                    tasks.Add(new Task(q, c[1], c[3], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                case 34:
                                    tasks.Add(new Task(q, c[2], c[3], init, i, "Назначена", new List<Report>())); cnt2 = 1;
                                    break;
                                default:
                                    Console.WriteLine("Попробуйте еще раз"); cnt2 = 0;
                                    break;
                            }
                        }
                        cnt = 1;
                        break;
                    }
                    else if (cnt != 1) { continue; }
                    else { break; }
                }

            }
            if (project.status == "Проект") { project.status = "Исполнение"; }
        }
        public static void CheckTask(List<Task> a)
        {
            foreach (var i in a)
            {
                Console.Write(i.person.Name);
                Console.WriteLine(i.description + "\n");
            }
        }
    }
}
