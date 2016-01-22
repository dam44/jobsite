using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Feed
    {
        [Key]
        public string id { get; set; }
        public Uri url { get; set; }
        public string converterId { get; set; }
    }
}
