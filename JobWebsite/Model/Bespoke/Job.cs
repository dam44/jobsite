using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Job
    {
        [Key]
        public string id { get; set; }
        [Key]
        public Feed feed { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string company { get; set; }
        public DateTime end { get; set; }
        public string salary { get; set; }
        public Uri jobpic { get; set; }
    }
}
