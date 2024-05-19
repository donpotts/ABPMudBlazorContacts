using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ContactsProject.Data;

/* This is used if database provider does't define
 * IContactsProjectDbSchemaMigrator implementation.
 */
public class NullContactsProjectDbSchemaMigrator : IContactsProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
