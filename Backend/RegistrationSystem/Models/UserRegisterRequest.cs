﻿using System.ComponentModel.DataAnnotations;

namespace RegistrationSystem.Models
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [Required, MinLength(8)]
        public string Password { get; set; } = string.Empty;
        
        [Required,]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
