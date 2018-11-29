using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonComrades
{
    class ToDo
    {
            [JsonProperty("userId")]
            public int UserId { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("completed")]
            public bool Completed { get; set; }
       
    }
}
