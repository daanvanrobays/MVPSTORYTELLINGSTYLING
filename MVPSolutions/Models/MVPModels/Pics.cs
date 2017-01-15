using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVPSolutions.Models.MVPModels
{
    public class Pics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pic_ID { get; set; }

        public int? Story_ID { get; set; }

        public int? Concept_ID { get; set; }

        public string Path { get; set; }

        public virtual Stories Story { get; set; }

        public virtual Concepts Concept { get; set; }
    }
}