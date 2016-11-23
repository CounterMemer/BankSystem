using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
        public class Contact : BaseEntity
        {
            public int CurrentUserId { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return string.Format("{0} ({1})", this.FullName, this.Email);
            }
        }
}

