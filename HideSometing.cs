using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace HideSometing
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class HideSometing : Mod
    {
        

        public override void Load()
        {
            Terraria.On_Main.DrawDust += HideDust;
         
        }
        public override void Unload()
        {
            Terraria.On_Main.DrawDust -= HideDust;
        }

        private static void HideDust(Terraria.On_Main.orig_DrawDust orig, Main self)
        {
            var config = ModContent.GetInstance<Config>();
            if (!config.DustHide) 
              orig(self);  
 
        }

       
      
    }
    
}
