using lw1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L55.domen.utils
{
    internal interface ISerializationHelper<T>
    {
        void Serialize(List<T> doors, string filePath);
        List<T> Deserialize(string filePath);
    }
}
