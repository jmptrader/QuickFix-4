﻿using Microsoft.AspNetCore.Components;

namespace PjQuickFix.Web
{
   public class NavMenuModel : ComponentBase
    {
        private bool CollapseNavMenu { get; set; } = true;

        public string NavMenuCssClass => this.CollapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu()
        {
            this.CollapseNavMenu = !this.CollapseNavMenu;
        }
    }
}