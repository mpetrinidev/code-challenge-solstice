using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeMpetrini.Api.Models
{
    [Table("City")]
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int State_Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }
        public State State { get; set; }
    }
}
