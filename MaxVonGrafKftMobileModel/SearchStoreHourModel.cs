using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class SearchStoreHourModel
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public int ClientId { get; set; }

        public int StoreHoursId { get; set; }

        public int Day { get; set; }

        public DateTime? StartTime { get; set; }

        public string StartTimeStr { get; set; }

        public DateTime? EndTime { get; set; }

        public string EndTimeStr { get; set; }

        public bool IsHoliday { get; set; }

        public int Status { get; set; } //Status 1 => CheckOut , 2 => CheckIn
        public string ErrorCode { get; set; }
        public string Message { get; set; }


        public bool IsWeekend { get; set; }
    }
}
