using DAL.Models;
using System.Collections.Generic;

namespace Exam.ViewModels
{
    public class HomeVM
    {
        public List<Feature> Features { get; set; }
        public List<Hero> Hero { get; set; }
        public List<AchivementTop> TopAchivements { get; set; }
        public List<AchivementBottom> BottomAchivements { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<ContactAddress> ContactAddresses { get; set; }
    }
}
