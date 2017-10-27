using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public int PostId { get; set; }

        public string Body { get; set; }


    }
}