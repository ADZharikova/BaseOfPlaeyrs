using System;

namespace BaseOfPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseOfPlayers dataBaseOfPlayers = new DataBaseOfPlayers();
            string username;
            string putUser;
            bool putIdIsNumber;
            bool isActive = true;
            string deleteParameter;

            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Каждое завершеное действие увеличивает уровень игрока на 1.");
                Console.ResetColor();
                dataBaseOfPlayers.ShowInfo();

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Выберете 3 действия: \n1. Добавить.\n2. Удолить\n3. Забанить\n4. Разбанить\nДля выхода напишите \"exit\".");
                Console.WriteLine();
                Console.Write("Действие: ");
                putUser = Console.ReadLine();


                switch (putUser)
                {
                    case "1":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Ник не должен быть пустым");

                        Console.ResetColor();
                        Console.Write("Чтобы создать нового пользователя введите ник: ");
                        username = Console.ReadLine();
                        if (!String.IsNullOrEmpty(username.Trim()))
                        {
                            dataBaseOfPlayers.AddPlayer(username);
                        }
                        else
                        {
                            Console.WriteLine("Вы ничего не ввели.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("По какому параметру хотите удолить?\n1. Ник\n2. ИД\nДля отмены действия нажмите любую другую кнопку");
                        deleteParameter = Console.ReadLine();

                        switch (deleteParameter)
                        {
                            case "1":
                                Console.Write("Введите ник пользователя, которого хотите удолить: ");
                                username = Console.ReadLine();
                                dataBaseOfPlayers.DeletePlayer(username);
                                break;

                            case "2":
                                Console.Write("Введите ИД пользователя, которого хотите удолить: ");
                                putIdIsNumber = int.TryParse(Console.ReadLine(), out int putId);
                                if (putIdIsNumber)
                                {
                                    dataBaseOfPlayers.DeletePlayer(putId);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число.");
                                    break;
                                }

                            default:
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!!!ВНИМАНИЕ!!!");

                        Console.ResetColor();

                        Console.WriteLine("Бан также обнуляет уровень.\nИ при разбане его нельзя будет вернуть.");
                        Console.WriteLine();
                        Console.WriteLine("По какому параметру хотите забанить?\n1. Ник\n2. ИД\nДля отмены действия нажмите любую другую кнопку");
                        deleteParameter = Console.ReadLine();

                        switch (deleteParameter)
                        {
                            case "1":
                                Console.Write("Введите ник пользователя, которого хотите забанить: ");
                                username = Console.ReadLine();
                                dataBaseOfPlayers.BanPlayer(username);
                                break;

                            case "2":
                                Console.Write("Введите ИД пользователя, которого хотите забанить: ");
                                putIdIsNumber = int.TryParse(Console.ReadLine(), out int putId);
                                if (putIdIsNumber)
                                {
                                    dataBaseOfPlayers.BanPlayer(putId);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число.");
                                    break;
                                }

                            default:
                                break;
                        }
                        break;

                    case "4":
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!!!ВНИМАНИЕ!!!");

                        Console.ResetColor();

                        Console.WriteLine("Возврат из бана не возвращает уровень.");
                        Console.WriteLine();
                        Console.WriteLine("По какому параметру хотите разбанить?\n1. Ник\n2. ИД\nДля отмены действия нажмите любую другую кнопку");
                        deleteParameter = Console.ReadLine();

                        switch (deleteParameter)
                        {
                            case "1":
                                Console.Write("Введите ник пользователя, которого хотите разбанить: ");
                                username = Console.ReadLine();
                                dataBaseOfPlayers.UnbanPlayer(username);
                                break;

                            case "2":
                                Console.Write("Введите ИД пользователя, которого хотите разбанить: ");
                                putIdIsNumber = int.TryParse(Console.ReadLine(), out int putId);
                                if (putIdIsNumber)
                                {
                                    dataBaseOfPlayers.UnbanPlayer(putId);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число.");
                                    break;
                                }

                            default:
                                break;
                        }
                        break;

                    default:
                        if (putUser.ToLower() == "exit")
                        {
                            isActive = false;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели что-то не то");
                        }
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Для продолжения нажмите любую клавишу.");
                Console.ReadKey(true);
                dataBaseOfPlayers.LevelUp();
                Console.Clear();

            }

            Console.WriteLine("До скорых встреч!");

        }
    }
}




