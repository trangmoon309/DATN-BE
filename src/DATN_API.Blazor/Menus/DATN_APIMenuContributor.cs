using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace DATN_API.Blazor.Menus;

public class DATN_APIMenuContributor : IMenuContributor
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
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(DATN_APIMenus.Prefix, displayName: "DATN_API", "/DATN_API", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
