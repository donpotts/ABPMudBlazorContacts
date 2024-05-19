using Volo.Abp.Settings;

namespace ContactsProject.Settings;

public class ContactsProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ContactsProjectSettings.MySetting1));
    }
}
