using Xunit;

namespace ContactsProject.EntityFrameworkCore;

[CollectionDefinition(ContactsProjectTestConsts.CollectionDefinitionName)]
public class ContactsProjectEntityFrameworkCoreCollection : ICollectionFixture<ContactsProjectEntityFrameworkCoreFixture>
{

}
