using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class AchivementTop : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public bool IsSmall { get; set; }
    }
}
