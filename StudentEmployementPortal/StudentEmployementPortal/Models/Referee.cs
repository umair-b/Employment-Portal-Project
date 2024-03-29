﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Referee
    {
        [Key]
        public int RefereeId { get; set; }

        [DisplayName("Name and Surname")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Job Title")]
        [Required]
        public string JobTitle { get; set; }

        [DisplayName("Institution")]
        [Required]
        public string Institution { get; set; }

        [DisplayName("Cellphone Number")]
        [Required]
        public string CellNumber { get; set; }

        [DisplayName("Email Address")]
        [Required]
        public string Email { get; set; }

        //Navigation Property
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public Student Student { get; set; }
    }
}
