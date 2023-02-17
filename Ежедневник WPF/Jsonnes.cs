using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ежедневник_WPF
{
    internal class Jsonnes
    {
        public string name { get; set; }
        public string opisanie { get; set; }
        public string date { get; set; }
        public void Serialize(List<Jsonnes> jsonnes)
        {
            string json = JsonConvert.SerializeObject(jsonnes);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\Day.json", json);
            string text = File.ReadAllText("C:\\Users\\nikol\\Desktop\\Day.json");
        }
    }
}
