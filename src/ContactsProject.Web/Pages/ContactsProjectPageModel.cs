using ContactsProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ContactsProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ContactsProjectPageModel : AbpPageModel
{
    protected ContactsProjectPageModel()
    {
        LocalizationResourceType = typeof(ContactsProjectResource);
    }
}
