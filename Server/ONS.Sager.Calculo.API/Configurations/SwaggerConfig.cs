﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.API.Configurations
{
    public class SwaggerConfig
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public string RoutePrefix { get; set; }
        public bool IncludeSecurity { get; set; }
    }
}
