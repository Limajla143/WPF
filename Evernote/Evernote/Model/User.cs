﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evernote.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
