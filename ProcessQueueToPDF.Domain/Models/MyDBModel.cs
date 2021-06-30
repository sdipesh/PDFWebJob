using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProcessQueueToPDF.Domain.Models
{
    public class MyDBModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}