using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Philson.Models
{
    public class SuppliedInterloan
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Request Date")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        [Display(Name ="Staff Requesting")]
        public string StaffRequesting { get; set; }

        public string ILLRequestNo { get; set; }

        [Display(Name = "Call No.")]
        public string CallNo { get; set; }
        public string Barcode { get; set; }

        [Display(Name = "Item Type")]
        public string ItemType {get; set;}

        public string Handler { get; set; }

        [Display(Name ="Return Date")]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        [Display(Name ="Further Details")]
        public string FurtherDetails { get; set; }

    }
}
