﻿using Brivia.Device.Helpers;
using Brivia.Device.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brivia.Device.Services.Requests
{
    public static class UserService
    {
        public static List<UserModel> Users { get; set; } = Seed.SeedUsers();

        public static void SaveUser(UserModel user) => Users.Add(user);

        public static UserModel SearchUser(string login, string password)
        {
            return Users.Find(u => u.Login == login && u.Password == password);
        }
    }
}
