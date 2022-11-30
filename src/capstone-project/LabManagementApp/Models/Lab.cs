using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LabManagementApp.Models
{
    public class Lab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        [ForeignKey("Category")]
        public int categoryId { get; set; }
        [ForeignKey("Author")]
        public int authorId { get; set; }
    }
}
