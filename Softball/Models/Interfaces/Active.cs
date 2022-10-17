using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Interfaces
{
    public class Active
    {

        public DateTime? InactiveDate { get; private set; }
        public bool IsActive
        {
            get
            {
                if (InactiveDate.HasValue && DateTime.Now > InactiveDate)
                    return true;
                else return false;
            }
        }

        public Active() : this(null) { }

        public Active(DateTime? inactiveDate)
        {
            InactiveDate = inactiveDate;
        }

        public void SetInactiveDate(DateTime? inactiveDate)
        {
            InactiveDate = inactiveDate;
        }

        public void Inactivate()
        {
            SetInactiveDate(DateTime.Now);
        }

        public void Activate()
        {
            SetInactiveDate(null);
        }
    }
}
