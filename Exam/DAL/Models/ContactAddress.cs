using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ContactAddress : BaseEntity
    {
        public string Title { get; set; }
        public string Address { get; set; }
    }
}
