using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobile.Views
{

    public class HomePageMasterMenuItem
    {
        public HomePageMasterMenuItem()
        {
            TargetType = typeof(HomePageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}