using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static System.Console;


//namespace Homework



namespace Homework
{

    class Menu
    {
        private static string? name;
        static string? task;
        static List<string> ToDoList = [];



        static void Main(string[] args)
        {
            WriteLine("Приветствую! Что Вы хотели бы сделать? Доступные команды:");
            WriteLine(@"/start, /help, /info, /addtask, /showtasks, /removetask, /exit");
            while (true)
            {
                WriteLine("Жду вашу команду: ");
                string? UserCommand = Console.ReadLine();

                if (UserCommand == "/start")
                    CommandStart();
                else if (UserCommand == "/help")
                    CommandHelp();
                else if (UserCommand == "/info")
                    CommandInfo();
                else if (UserCommand == "/addtask")
                    CommandAddTask();
                else if (UserCommand == "/showtasks")
                    CommandShowTasks();
                else if (UserCommand == "/removetask")
                    CommandRemoveTask();
                else if (UserCommand == "/exit")
                    break;
                else
                    WriteLine("Попробуйте еще раз");
            }
        }

        public static void CommandStart()
        {
            WriteLine("Введите Ваше имя: ");
            string? name = Console.ReadLine();
            WriteLine($"Добро пожаловать, {name}!");
            CheckCommandPlusEcho(name);
        }

        public static void CheckCommandPlusEcho(string name)
        {

            while (true)
            {
                WriteLine($"Жду вашу команду, {name}: ");
                string? UserCommand = Console.ReadLine();

                if (UserCommand == "/start")
                    CommandStart();
                else if (UserCommand.StartsWith("/echo"))
                    WriteLine(UserCommand["/echo".Length..].Trim());
                else if (UserCommand == "/help")
                    CommandHelpWithEcho();
                else if (UserCommand == "/info")
                    CommandInfo();
                else if (UserCommand == "/addtask")
                    CommandAddTask();
                else if (UserCommand == "/showtasks")
                    CommandShowTasks();
                else if (UserCommand == "/removetask")
                    CommandRemoveTask();
                else if (UserCommand == "/exit")
                    break;
                else
                    WriteLine("Попробуйте еще раз");
            }
        }

        public static void CommandHelp()
        {
            Console.WriteLine("Как пользоваться программой: ");
            Console.WriteLine("/start - запрос Вашего имени");
            Console.WriteLine("/info - предоставляет информацию о версии программы и дате её создания");
            Console.WriteLine("/addtask - добавление задачи в список");
            Console.WriteLine("/showtasks - отображение списка актуальных задач");
            Console.WriteLine("/showalltasks - отображение списка всех задач");
            Console.WriteLine("/completetask - завершение задачи");
            Console.WriteLine("/removetask - удаление задачи по номеру в списке");
            Console.WriteLine("/exit - для выхода из программы");
        }

        public static void CommandHelpWithEcho()
        {
            WriteLine("Как пользоваться программой: ");
            WriteLine("/start - запрос Вашего имени");
            WriteLine("/info - предоставляет информацию о версии программы и дате её создания");
            WriteLine("/echo - при вводе этой команды с аргументом программа возвращает введенный текст");
            WriteLine("/addtask - добавление задачи в список");
            WriteLine("/showtasks - отображение списка всех добавленных задач");
            WriteLine("/removetask - удаление задачи по номеру в списке");
            WriteLine("/exit - для выхода из программы");
        }

        public static void CommandInfo()
        {
            WriteLine("Версия программы: V3, дата создания 10.10.2026");
        }

        public static void CommandAddTask()
        {
            WriteLine("Пожалуйста, введите описание задачи:");    //запрос на добавление.
            while (true)                                                  //чтоб не писать для каждой задачи addtask, можно через Enter вводить сразу несколько
            {
                String? task = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(task))                   //выход при нажатии Enter
                {
                    break;
                }

                ToDoList.Add(task);
                WriteLine($"Задача ''{task}'' добавлена. Введите новую задачу или нажмите Enter для завершения:");
            }
        }

        public static void CommandShowTasks()
        {
            if (ToDoList.Count == 0)
            {
                WriteLine("Список задач пуст");
            }
            else
                WriteLine("Вот ваш список задач:");
            for (int i = 0; i < ToDoList.Count; i++)
            {
                WriteLine($"{i + 1}. {ToDoList[i]}");
            }
        }

        //public static void CommandShowAllTasks()
        //{
        //    WriteLine("Укажите статус задач");

        //    WriteLine($"Имя задачи - {} - {}");
        //}

        public static void CommandRemoveTask()
        {
            WriteLine("Напоминаем, что вы запланировали.");         //вывод акутального списка задач, чтобы видеть номера
            CommandShowTasks();


            WriteLine("Введите номер задачи для удаления:");    //запрос на удаление.
            while (true)                                                //чтоб не писать для каждой задачи addtask, можно через Enter вводить сразу несколько
            {
                String? task = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(task))                   //выход при нажатии Enter
                {
                    break;
                }

                int.TryParse(task, out int TaskPosition);              //уточняем, что номер позиции на 1 больше, чем индекс
                int IndexToRemove = TaskPosition - 1;


                if (IndexToRemove >= 0 && IndexToRemove < ToDoList.Count)
                {
                    string removedTask = ToDoList[IndexToRemove];
                    ToDoList.RemoveAt(IndexToRemove);
                    WriteLine($"Задача ''{removedTask}'' удалена. Введите еще одну задачу или нажмите Enter для завершения:");
                }
                else
                {
                    WriteLine("Пожалуйста, введите корректный номер из списка или нажмите Enter для завершения:");     //если введен левый номер или вообще буква
                }
            }
        }
    }

}











