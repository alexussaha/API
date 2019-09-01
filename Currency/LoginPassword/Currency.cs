using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoginPassword
{
    class Currency
    {
        
        [JsonProperty("USD_PHP")]
        public double course { get; set; }
    }
}
