﻿using System;
using ViralRadar.Entities;

namespace ViralRadar.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";   // User, Admin

        public ICollection<UserInterest> UserInterests { get; set; }
        public ICollection<UserSavedContent> SavedContents { get; set; }
    }
}

