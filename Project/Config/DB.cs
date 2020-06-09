using Project.ClassSnake;
using Project.Entity;
using SQLite;
using System;
using System.IO;

namespace Project.Config
{
    class DB
    {

        // Get an absolute path to the database file
        String databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SnakeGame.db");

        public static User currentUser = null;
        public static bool newRecord;

        private SQLiteConnection db;

        public DB()
        {
            db = new SQLiteConnection(databasePath);

            db.CreateTable<User>();
        }

        public bool SearchUserInfo(string username, string password)
        {
            var user = db.Table<User>().Where(u => u.Password == username && u.Password == password).FirstOrDefault();

            currentUser = user;

            return user == null ? false : true;
        }

        public void InsertUserInfo(string username, string password, string email)
        {
            try
            {
                db.Insert(new User { Username = username, Password = password, Email = email });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UserRecord()
        {
            if (currentUser == null)
                return 0;

            if (Settings.Score > currentUser.Record)
            {
                currentUser.Record = Settings.Score;
                newRecord = true;

                currentUser.Record = Settings.Score;
                db.Update(currentUser);

                return Settings.Score;

            }
            else
            {
                newRecord = false;
                return currentUser.Record;
            }
        }

        public void UserRecordReset()
        {

            try
            {
                if (currentUser != null)
                {
                    currentUser.Record = 0;
                    db.Update(currentUser);
                }
            }
            catch (Exception ex)
            {

            }

        }


    }
}
