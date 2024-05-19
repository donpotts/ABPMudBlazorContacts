using Volo.Abp.Modularity;

namespace ContactsProject;

public abstract class ContactsProjectApplicationTestBase<TStartupModule> : ContactsProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
