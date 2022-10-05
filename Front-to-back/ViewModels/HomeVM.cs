using Front_to_back.Models;
using System.Collections.Generic;

namespace Front_to_back.ViewModels
{
    public class HomeVM
    {
        public SliderImage SliderImage { get; set; }
        public List<SliderText> SliderTexts { get; set; }
        public List<RecentWork> RecentWorks { get; set; }
        public List<RecentWorkSecond> RecentWorkSeconds { get; set; }
    }
}
