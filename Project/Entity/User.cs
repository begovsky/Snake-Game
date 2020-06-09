using SQLite;
using System;

namespace Project.Entity
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String Email { get; set; }

        public int Record { get; set; }
    }
}
