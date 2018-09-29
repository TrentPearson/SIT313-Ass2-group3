﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ResumeBuilder.Data
{
    public class UserInfoDB
    {
        readonly SQLiteAsyncConnection database;
        public UserInfoDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }



        public Task<List<User>> GetUsersAsync()
        {
            return database.Table<User>().ToListAsync();
        }



        public Task<List<User>> GetUserAsync(string EmailAddress)
        {
            return database.Table<User>().Where(i => i.Email == EmailAddress).ToListAsync();
        }




        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return database.UpdateAsync(user);
            }
            else
            {
                return database.InsertAsync(user);
            }
        }




        public Task<int> DeleteUserAsync(User user)
        {
            return database.DeleteAsync(user);
        }
    }
}