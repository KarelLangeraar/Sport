using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Interfaces
{
    interface IActive
    {
        void Activate();
        void Inactivate();
        bool IsActive();
    }
}
