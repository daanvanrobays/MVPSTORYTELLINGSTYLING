using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVPSolutions.Models.MVPModels
{
    public class Credits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Credit_ID { get; set; }

        public string Photography { get; set; }

        public string MUA { get; set; }

        public string Hair { get; set; }

        public string Styling { get; set; }

        public string Concept { get; set; }

    }
}