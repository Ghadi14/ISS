﻿namespace backend_iss.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }=string.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; } = string.Empty;

    }
}
