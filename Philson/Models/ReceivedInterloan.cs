using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Philson.Models
{
    public class ReceivedInterloan
    {
        public int ID { get; set; }
        public string BookTitle { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ILLNo { get; set; }
        public string PatronName { get; set; }

        public string Barcode { get; set; }
        public DateTime OriginalDueDate { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? DateOfReturn { get; set; }

        public string Notes { get; set; }

    }
}
