using Newtonsoft.Json;
using System.Data;
using System.IO;

namespace SmartSaver
{
    public class JSONUtils
    {
        public static void saveData(DataTable dataTable, string fileName)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dataTable);

            var wfile = new StreamWriter(fileName);
            wfile.Write(JSONString);
            wfile.Close();
        }

        public static DataTable openData(string fileName)
        {
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(File.ReadAllText(fileName));
            return dt;
        }
    }
}
