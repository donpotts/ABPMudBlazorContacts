using System.Threading.Tasks;

namespace ContactsProject.Data;

public interface IContactsProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
