using Volo.Abp.Settings;

namespace Iot.Settings;

public class IotSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IotSettings.MySetting1));
    }
}
