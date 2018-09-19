using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeMpetrini.Api.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int City_Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Company { get; set; }

        [Required, StringLength(250)]
        public string Profile_Image { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required, StringLength(50)]
        public string Home_Phone_Number { get; set; }

        [Required, StringLength(50)]
        public string Work_Phone_Number { get; set; }

        [Required, StringLength(50)]
        public string Mobile_Phone_Number { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        public City City { get; set; }
    }
}
