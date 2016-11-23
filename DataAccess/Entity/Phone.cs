using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Phone : BaseEntity
    {
        public int CurrentContactId { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return this.PhoneNumber;
        }
    }
}
