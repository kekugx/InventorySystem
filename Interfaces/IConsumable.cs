using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.InventorySystem.Interfaces
{
    public interface IConsumable : IUsable
    {
        void Consume();
    }
}
