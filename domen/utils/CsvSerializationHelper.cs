using lw1.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L55.domen.utils
{
    internal class CsvSerializationHelper : ISerializationHelper<Door>
    {
        public List<Door> Deserialize(string filePath)
        {
            var doors = new List<Door>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Door.TryParse(line, out Door door))
                    {
                        doors.Add(door);
                    }
                }
            }
            return doors;
        }

        public void Serialize(List<Door> doors, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var door in doors)
                {
                    writer.WriteLine(door.ToString());
                }
            }
        }
    }
}
