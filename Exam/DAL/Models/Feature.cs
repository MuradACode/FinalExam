using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Feature : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
    }
}
