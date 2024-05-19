using Microsoft.AspNetCore.Builder;
using ContactsProject;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ContactsProjectWebTestModule>();

public partial class Program
{
}
