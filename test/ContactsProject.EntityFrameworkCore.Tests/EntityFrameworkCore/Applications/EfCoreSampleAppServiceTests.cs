using ContactsProject.Samples;
using Xunit;

namespace ContactsProject.EntityFrameworkCore.Applications;

[Collection(ContactsProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ContactsProjectEntityFrameworkCoreTestModule>
{

}
