using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SmartSaver.DB
{
    public class Account
    {
        [Key]

        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

    }
}
