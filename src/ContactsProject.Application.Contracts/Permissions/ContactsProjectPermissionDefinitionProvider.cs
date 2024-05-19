using ContactsProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ContactsProject.Permissions;

public class ContactsProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var contactsProjectGroup = context.AddGroup(ContactsProjectPermissions.GroupName, L("Permission:ContactsProject"));

        var contactsPermission = contactsProjectGroup.AddPermission(ContactsProjectPermissions.Contacts.Default, L("Permission:Contacts"));
        contactsPermission.AddChild(ContactsProjectPermissions.Contacts.Create, L("Permission:Contacts.Create"));
        contactsPermission.AddChild(ContactsProjectPermissions.Contacts.Edit, L("Permission:Contacts.Edit"));
        contactsPermission.AddChild(ContactsProjectPermissions.Contacts.Delete, L("Permission:Contacts.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ContactsProjectResource>(name);
    }
}
