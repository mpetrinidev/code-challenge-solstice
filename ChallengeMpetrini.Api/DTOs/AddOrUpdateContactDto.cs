using System;
using System.ComponentModel.DataAnnotations;

namespace ChallengeMpetrini.Api.DTOs
{
    public class AddOrUpdateContactDto : BaseContactDto
    {
        [Required, MaxLength(50)]
        public override string Name { get; set; }

        [Required, MaxLength(50)]
        public override string Company { get; set; }

        [Required, MaxLength(250), Url]
        public override string Profile_Image { get; set; }

        [Required, MaxLength(100), EmailAddress]
        public override string Email { get; set; }

        [Required]
        public override DateTime Birthdate { get; set; }

        [Required, MaxLength(50), Phone]
        public override string Home_Phone_Number { get; set; }

        [Required, MaxLength(50), Phone]
        public override string Work_Phone_Number { get; set; }

        [Required, MaxLength(50), Phone]
        public override string Mobile_Phone_Number { get; set; }

        [Required, MaxLength(100)]
        public override string Address { get; set; }

        [Required]
        public int City_Id { get; set; }
    }
}
