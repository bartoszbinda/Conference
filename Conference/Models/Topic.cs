using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Conference.Models
{


    public class Topic
    {
        public Topic()
        {
            this.Documents = new HashSet<Document>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public String Name { get; set; }

        public virtual ICollection<Document> Documents { get; set; }



        }
}