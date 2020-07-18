using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Department
    {
        [Key]
        public int de_id { get; set; }
        public string de_tittle { get; set; }
    }
}
