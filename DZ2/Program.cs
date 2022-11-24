using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание списка умений работников
            List<string> list1 = new List<string>() { "Тест" };
            List<string> list2 = new List<string>() { "Кодинг"};
            List<string> list3 = new List<string>() { "Базы данных" };
            List<string> list4 = new List<string>() { "Детализация" };

            // Создание работников
            Person Vityalya = new Person("Виталий", list1);
            Person Volodya = new Person("Володя", list2);
            Person Vyacyaslav = new Person("Вячеслав", list3);
            Person Vitya = new Person("Витя", list4);

            // Создание проекта
            /*Описание*/
            string description = "Суть проекта - сделать сайт, который будет считывать ваш почерк, копировать его - писать на листе бумаги вашим почерком";

            /*Даты*/
            DateTime data1 = new DateTime(2022, 11, 18);
            DateTime data2 = new DateTime(2023, 11, 18);

            /*Инициатор*/
            string Initiator = "Дон Корлеоне";

            /*ТимЛид*/
            string TeamLead = "Джон Сноу";

            /*Задачи*/
            List<string> task = new List<string>() { "Детализация сайта - украшения, красота" +
                "Базы данных - работа с таблицами, с фотографиями", "Тест - хорошая раббота, быстрый отклик" +
                "Кодинг - построение сайта, внутренняя сторона сайта"};

            /*Статус*/
            string status = "Проект";

            /*Проект*/
            Project xernya = new Project(description, data1, data2, Initiator, TeamLead, task, status);

            // ТимЛид создает задачи
        }
        public static void CheckList(List<string> a)
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }

}
