using System;
using System.Collections.Generic;
using System.Text;
using ContactsProject.Localization;
using Volo.Abp.Application.Services;

namespace ContactsProject;

/* Inherit your application services from this class.
 */
public abstract class ContactsProjectAppService : ApplicationService
{
    protected ContactsProjectAppService()
    {
        LocalizationResource = typeof(ContactsProjectResource);
    }
}
