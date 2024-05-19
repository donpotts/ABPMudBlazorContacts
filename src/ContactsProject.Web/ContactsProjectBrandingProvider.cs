using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ContactsProject.Web;

[Dependency(ReplaceServices = true)]
public class ContactsProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ContactsProject";
}
