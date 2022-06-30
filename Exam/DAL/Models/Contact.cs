using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }
}
