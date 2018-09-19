using AutoMapper;
using ChallengeMpetrini.Api.Models;

namespace ChallengeMpetrini.Api.DTOs.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AddOrUpdateContactDto, Contact>().ReverseMap();

            CreateMap<Contact, ContactDto>()
                .ForMember(d => d.Phone, o => o.MapFrom(p => new PhoneDto { Home = p.Home_Phone_Number, Work = p.Work_Phone_Number, Mobile = p.Mobile_Phone_Number }))
                .ForMember(d => d.Address, o => o.MapFrom(p => new AddressDto { Street = p.Address, City = p.City.Name, State = p.City.State.Name }));
        }
    }
}
