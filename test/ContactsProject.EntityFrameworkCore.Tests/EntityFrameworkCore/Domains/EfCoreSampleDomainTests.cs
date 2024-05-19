using ContactsProject.Samples;
using Xunit;

namespace ContactsProject.EntityFrameworkCore.Domains;

[Collection(ContactsProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ContactsProjectEntityFrameworkCoreTestModule>
{

}
