using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ContactsProject.Contacts;

public interface IContactAppService :
    ICrudAppService< //Defines CRUD methods
        ContactDto, //Used to show contacts
        int, //Primary key of the contact entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateContactDto> //Used to create/update a contact
{

}
