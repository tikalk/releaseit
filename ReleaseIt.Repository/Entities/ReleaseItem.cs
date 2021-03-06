﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseIt.Repository.Entities
{
    [Table("ReleaseItems")]
    public class ReleaseItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("User")]
        public int ID { get; set; }

        public ReleaseDomainTypes DomainType { get; set; }

        public ReleaseTypes ReleaseType { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Body { get; set; }

        [Required]
        [MaxLength(256)]
        public string Uri { get; set; }

        public DateTime CreateTime { get; set; }

        public string CreateTimeString
        {
            get
            {
                return CreateTime.ToShortDateString();
            }
            set
            {
                // required for serealization
            }
        }

        public DateTime UpdateTime { get; set; }

        public virtual User User { get; set; }

        public string UpdateTimeString
        {
            get
            {
                return UpdateTime.ToShortDateString();
            }
            set
            {
                // required for serealization
            }
        }
    }
}
