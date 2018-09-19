using System;

namespace ChallengeMpetrini.Api.DTOs
{
    public class BaseContactDto
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Company { get; set; }

        public virtual string Profile_Image { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime Birthdate { get; set; }
        public virtual string Home_Phone_Number { get; set; }
        public virtual string Work_Phone_Number { get; set; }
        public virtual string Mobile_Phone_Number { get; set; }
        public virtual string Address { get; set; }
    }
}
