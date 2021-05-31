using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_v01
{
    class Helper
    {
        public static void SaveToJson(Chess chess, string fileName)
        {
            string json = JsonConvert.SerializeObject(chess);
            System.IO.File.WriteAllText(fileName , json);
        }

        public static Chess LoadFromJson(string fileName)
        {
            string json = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<Chess>(json);
        }
    }
}
