﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNPAssignment.Models {
    public class User {
        public string UserName { get; set; }
        public int BirthYear { get; set; }
        public string Role { get; set; }
        public int SecurityLevel { get; set; }
        public string Password { get; set; }
    }
}
