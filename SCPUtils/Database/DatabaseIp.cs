﻿using System.Collections.Generic;

namespace SCPUtils
{
    public class DatabaseIp
    {
        public string Ip { get; set; }
        public List<string> UserId { get; set; } = new List<string>();

        public string Asn;
    }
}


// For future use