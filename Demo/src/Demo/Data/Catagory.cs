using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Data
{
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }
        [Required]
        [MaxLength(150)]
        public string CatagoryName { get; set; }
    }
}
