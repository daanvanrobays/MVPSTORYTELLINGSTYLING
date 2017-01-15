using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVPSolutions.Models.MVPModels
{
    public class Stories
    {
        public Stories()
        {
            this.Pics = new HashSet<Pics>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Story_ID { get; set; }

        public string Story { get; set; }

        public int Credit_ID { get; set; }

        public virtual Credits Credits { get; set; }

        public virtual ICollection<Pics> Pics { get; set; }
    }
}