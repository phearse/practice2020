using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Teachers
    {
        [Key]
        public int te_id { get; set; }
        public int de_id { get; set;}
        public string te_name { get; set; }
    }
}
