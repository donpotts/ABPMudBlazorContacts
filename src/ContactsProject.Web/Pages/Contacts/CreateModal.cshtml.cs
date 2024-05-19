using System.Threading.Tasks;
using ContactsProject.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace ContactsProject.Web.Pages.Contacts;

public class CreateModalModel : ContactsProjectPageModel
{
    [BindProperty]
    public CreateUpdateContactDto Contact { get; set; }

    private readonly IContactAppService _contactAppService;

    public CreateModalModel(IContactAppService contactAppService)
    {
        _contactAppService = contactAppService;
    }

    public void OnGet()
    {
        Contact = new CreateUpdateContactDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _contactAppService.CreateAsync(Contact);
        return NoContent();
    }
}
