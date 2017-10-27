using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Conference.Models
{
    using System.Collections;
    using System.Web.Mvc;

    public class Document
    {
        public Document()
        {
            this.Topics = new HashSet<Topic>();
        }

        public int Id { get; set; }

        [Required] 
        [StringLength(300)]
        public String Title { get; set; }

        public String ApplicationUserId { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }

        
        // private IEnumerable<SelectListItem> Topics { get; set; }

//        public int[] TopicIds { get; set; }


        [Required]
        [StringLength(2000)]
        public String Abstract { get; set; }

        [Required]
        public String Body { get; set; }

        [Required]
        public String References { get; set; }


    }
}