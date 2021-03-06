﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMedius.SendSecure.JsonObjects
{
    internal class GetTokenResponseError
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int Code { get; set; }
    }
}
