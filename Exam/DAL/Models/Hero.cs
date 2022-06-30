using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Hero : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
    }
}
