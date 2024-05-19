using Volo.Abp.Modularity;

namespace ContactsProject;

[DependsOn(
    typeof(ContactsProjectApplicationModule),
    typeof(ContactsProjectDomainTestModule)
)]
public class ContactsProjectApplicationTestModule : AbpModule
{

}
