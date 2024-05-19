using System;
using ContactsProject.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ContactsProject.Contacts;

public class ContactAppService :
    CrudAppService<
        Contact, //The Contact entity
        ContactDto, //Used to show contacts
        int, //Primary key of the contact entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateContactDto>, //Used to create/update a contact
    IContactAppService //implement the IContactAppService
{
    public ContactAppService(IRepository<Contact, int> repository)
        : base(repository)
    {
        GetPolicyName = ContactsProjectPermissions.Contacts.Default;
        GetListPolicyName = ContactsProjectPermissions.Contacts.Default;
        CreatePolicyName = ContactsProjectPermissions.Contacts.Create;
        UpdatePolicyName = ContactsProjectPermissions.Contacts.Edit;
        DeletePolicyName = ContactsProjectPermissions.Contacts.Delete;
    }
}
