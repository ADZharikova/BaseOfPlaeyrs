using System;

namespace BaseOfPlayers
{
    internal class Players
    {
        public int PlayerId { get; private set; }
        public int Level { get; set; }
        public bool IsActive { get; set; }
        public string Username { get; private set; }

        public Players(string username, int id)
        {
            Username = username;
            PlayerId = id;
            Level = 0;
            IsActive = true;
        }
    }
}
