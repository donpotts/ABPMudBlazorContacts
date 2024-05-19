using Volo.Abp.Modularity;

namespace ContactsProject;

[DependsOn(
    typeof(ContactsProjectDomainModule),
    typeof(ContactsProjectTestBaseModule)
)]
public class ContactsProjectDomainTestModule : AbpModule
{

}
