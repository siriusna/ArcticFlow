using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArcticFlow.Models.Entities
{
    public class RedeSocial
    {

        public int RedeSocialID { get; set; }

        [Display(Description = "Facebook")]
        public string Facebook { get; set; }

        [Display(Description = "Whatsapp")]
        public string Whatsapp { get; set; }

        [Display(Description = "Telegram")]
        public string Telegram { get; set; }

        [Display(Description = "Twitter")]
        public string Twitter { get; set; }

        [Display(Description = "Youtube")]
        public string Youtube { get; set; }
        
        [Display(Description = "Site")]
        public string Site { get; set; }
      

    }
}
