﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDemo.Model
{
    public class AtomicFunc
    {
        [JsonProperty("enable")]
        public int Enable { get; set; }
    }
}
