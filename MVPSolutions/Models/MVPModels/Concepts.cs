using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVPSolutions.Models.MVPModels
{
    public class Concepts
    {

        public Concepts()
        {
            this.Pics = new HashSet<Pics>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Concept_ID { get; set; }

        public int Credit_ID { get; set; }

        public virtual Credits Credits { get; set; }

        public virtual ICollection<Pics> Pics { get; set; }

    }
}