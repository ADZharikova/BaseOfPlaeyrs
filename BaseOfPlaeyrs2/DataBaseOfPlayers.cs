using System;
using System.Collections.Generic;

namespace BaseOfPlayers
{
    public class DataBaseOfPlayers
    {
        private List<Players> _dataBaseOfPlayers = new List<Players>();
        private int j = -1;
        private static int _id = 0;

        public void AddPlayer(string username)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].Username == username)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                _id++;
                _dataBaseOfPlayers.Add(new Players(username, _id));

            }

            if (j != -1)
            {
                Console.WriteLine("Такой ник уже существует");
                j = -1;
            }
        }

        public void ShowInfo()
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                Console.SetCursorPosition(60, i + 3);
                Console.WriteLine($"ИД: {_dataBaseOfPlayers[i].PlayerId}, Ник: {_dataBaseOfPlayers[i].Username}, Уровень: {_dataBaseOfPlayers[i].Level}, Активен: {_dataBaseOfPlayers[i].IsActive}.");
            }

        }

        public void DeletePlayer(string username)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].Username == username)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого ника не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers.RemoveAt(j);
                j = -1;
            }
        }

        public void DeletePlayer(int id)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].PlayerId == id)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого id не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers.RemoveAt(j);
                j = -1;
            }
        }

        public void BanPlayer(string username)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].Username == username)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого ника не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers[j].IsActive = false;
                _dataBaseOfPlayers[j].Level = 0;
                j = -1;
            }
        }

        public void BanPlayer(int id)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].PlayerId == id)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого id не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers[j].IsActive = false;
                _dataBaseOfPlayers[j].Level = 0;
                j = -1;
            }
        }

        public void UnbanPlayer(string username)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].Username == username)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого ника не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers[j].IsActive = true;
                j = -1;
            }
        }

        public void UnbanPlayer(int id)
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].PlayerId == id)
                {
                    j = i;
                }
            }

            if (j == -1)
            {
                Console.WriteLine("Такого id не существует.");
            }

            if (j != -1)
            {
                _dataBaseOfPlayers[j].IsActive = true;
                j = -1;
            }
        }

        public void LevelUp()
        {
            for (int i = 0; i < _dataBaseOfPlayers.Count; i++)
            {
                if (_dataBaseOfPlayers[i].IsActive)
                {
                    ++_dataBaseOfPlayers[i].Level;
                }
            }
        }
    }
}
