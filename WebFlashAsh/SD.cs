﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlashAsh
{
    public static class SD
    {
        public static string ProductAPIBase { get; set; }
        public enum ApiType 
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
