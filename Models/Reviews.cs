using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public Guid VendorID { get; set; }
        public Guid UserID { get; set; }
        public int Rating { get; set; }
        public string Subject { get; set; }
        public string RatingDesc { get; set; }
        public int UpVoteCnt { get; set; }
        public int DownVoteCnt { get; set; }
        public int Suspicious { get; set; }
    }
}
