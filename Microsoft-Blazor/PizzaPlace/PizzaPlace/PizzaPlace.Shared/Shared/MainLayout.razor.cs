using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace PizzaPlace.Shared.Shared
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MainLayout
    {
        private bool IsFixedFooter { get; set; } = true;
        private bool IsFixedHeader { get; set; } = true;
        private bool IsFullSide { get; set; } = true;
        private bool IsOpen { get; set; }
        private List<MenuItem>? Menus { get; set; }
        private bool ShowFooter { get; set; } = true;
        private string Theme { get; set; } = "";
        private bool UseTabSet { get; set; } = true;

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Menus = GetIconSideMenuItems();
        }

        private static List<MenuItem> GetIconSideMenuItems()
        {
            var menus = new List<MenuItem>
        {
            new MenuItem() { Text = "Index", Icon = "fa-solid fa-fw fa-flag", Url = "/" , Match = NavLinkMatch.All},
            new MenuItem() { Text = "Counter", Icon = "fa-solid fa-fw fa-check-square", Url = "/counter" },
            new MenuItem() { Text = "Fetch Data", Icon = "fa-solid fa-fw fa-database", Url = "fetchdata" },
            new MenuItem() { Text = "Pizza List", Icon = "fa-solid fa-fw fa-database", Url = "pizzalist" },
          };

            return menus;
        }
    }
}