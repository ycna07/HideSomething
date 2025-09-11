using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HideSometing
{
    internal class Keybind : ModSystem
    {
        public static ModKeybind OPHidekey;//OthersProjectileHideKey
        public static bool OPHEnabled=true;
        public override void Load()
        {
            // 注册快捷键（在控件设置中显示为本地化名称）
            OPHidekey = KeybindLoader.RegisterKeybind(
                Mod,
                "OthersProjectileHide",
                "T"
            );
        }
        public override void Unload()
        {
            OPHidekey = null;
        }

        public override void PostUpdateInput()
        {
            if (OPHidekey.JustPressed)
            {
                // 切换启用状态
                OPHEnabled = !OPHEnabled;
                if (OPHEnabled)
                {
                    Main.NewText(Language.GetTextValue("Keybind.OPHideEnabled"));
                }
                else
                {
                    Main.NewText(Language.GetTextValue("Keybind.OPHideDisabled"));
                }
                
            }
        }
    }
}
