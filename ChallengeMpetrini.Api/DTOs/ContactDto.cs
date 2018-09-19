using System;

namespace ChallengeMpetrini.Api.DTOs
{
    public class ContactDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Company { get; set; }

        public string Profile_Image { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        public PhoneDto Phone { get; set; }
        public AddressDto Address { get; set; }
    }
}
