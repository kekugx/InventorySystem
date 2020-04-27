using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.InventorySystem.Interfaces
{
    interface IDestroyable
    {
        void Destroy();
        void Destroy(int count);
    }
}
