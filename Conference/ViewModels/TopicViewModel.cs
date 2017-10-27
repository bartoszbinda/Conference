using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using Conference.Models;

    public class TopicViewModel
    {

        [Required]
        public IEnumerable<SelectListItem> Topics { get; set; }

        public Document Document { get; set; }

        public int[] TopicIds { get; set; }
    }
}