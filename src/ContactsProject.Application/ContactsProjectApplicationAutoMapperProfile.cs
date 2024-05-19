using ContactsProject.Contacts;
using AutoMapper;

namespace ContactsProject;

public class ContactsProjectApplicationAutoMapperProfile : Profile
{
    public ContactsProjectApplicationAutoMapperProfile()
    {
        CreateMap<Contact, ContactDto>();
        CreateMap<CreateUpdateContactDto, Contact>();
    }
}
