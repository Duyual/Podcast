using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_Models.Interfaces
{
    interface ISerialize<T>
    {
        void Serialize();
        T Deserialize();
    }
}
