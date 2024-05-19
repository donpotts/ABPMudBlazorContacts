using System;
using System.Threading.Tasks;
using ContactsProject.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace ContactsProject.Web.Pages.Contacts;

public class EditModalModel : ContactsProjectPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; }

    [BindProperty]
    public CreateUpdateContactDto Contact { get; set; }

    private readonly IContactAppService _contactAppService;

    public EditModalModel(IContactAppService contactAppService)
    {
        _contactAppService = contactAppService;
    }

    public async Task OnGetAsync()
    {
        var contactDto = await _contactAppService.GetAsync(Id);
        Contact = ObjectMapper.Map<ContactDto, CreateUpdateContactDto>(contactDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _contactAppService.UpdateAsync(Id, Contact);
        return NoContent();
    }
}
