﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBookWeb.Models
{
    public class PhoneBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}