using Volo.Abp.Modularity;

namespace ContactsProject;

/* Inherit from this class for your domain layer tests. */
public abstract class ContactsProjectDomainTestBase<TStartupModule> : ContactsProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
