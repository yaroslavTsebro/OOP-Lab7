using lw1.model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace L55.domen.utils
{
    internal class JSONSerializationHelper : ISerializationHelper<Door>
    {
        public List<Door> Deserialize(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Door>>(json);
        }

        public void Serialize(List<Door> doors, string filePath)
        {
            var json = JsonConvert.SerializeObject(doors);
            File.WriteAllText(filePath, json);
        }
    }
}
