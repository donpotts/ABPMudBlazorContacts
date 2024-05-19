using ContactsProject.Contacts;
using AutoMapper;

namespace ContactsProject.Web;

public class ContactsProjectWebAutoMapperProfile : Profile
{
    public ContactsProjectWebAutoMapperProfile()
    {
        CreateMap<ContactDto, CreateUpdateContactDto>();
    }
}
