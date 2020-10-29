using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSaver
{
    public class JSONUtils
    {
        public static void saveData (DataTable dt, string fileName)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dt);

            var wfile = new StreamWriter(fileName);
            wfile.Write(JSONString);
            wfile.Close();
        }

        public static DataTable openData (string fileName)
        {
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(File.ReadAllText(fileName));
            return dt;
        }
    }
}
