using System.Threading.Tasks;
using ContactsProject.Localization;
using ContactsProject.MultiTenancy;
using ContactsProject.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace ContactsProject.Web.Menus;

public class ContactsProjectMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ContactsProjectResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ContactsProjectMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        context.Menu.AddItem(
            new ApplicationMenuItem(
                "ContactsProject",
                l["Menu:ContactsProject"],
                icon: "fa fa-database")
            .AddItem(
                new ApplicationMenuItem(
                    "ContactsProject.Contacts",
                    l["Menu:Contacts"],
                    url: "/Contacts"
                ).RequirePermissions(ContactsProjectPermissions.Contacts.Default) // Check the permission!
            )
        );

        return Task.CompletedTask;
    }
}
