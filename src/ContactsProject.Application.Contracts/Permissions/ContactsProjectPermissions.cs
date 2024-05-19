namespace ContactsProject.Permissions;

public static class ContactsProjectPermissions
{
    public const string GroupName = "ContactsProject";

    public static class Contacts
    {
        public const string Default = GroupName + ".Contacts";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
