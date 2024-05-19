using ContactsProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ContactsProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ContactsProjectController : AbpControllerBase
{
    protected ContactsProjectController()
    {
        LocalizationResource = typeof(ContactsProjectResource);
    }
}
