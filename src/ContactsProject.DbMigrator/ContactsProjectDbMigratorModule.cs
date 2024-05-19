using ContactsProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ContactsProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ContactsProjectEntityFrameworkCoreModule),
    typeof(ContactsProjectApplicationContractsModule)
    )]
public class ContactsProjectDbMigratorModule : AbpModule
{
}
