using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;          // Color 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace HideSometing
{
    public class OthersProjectileHide : GlobalProjectile
    {
        // 仅在本客户端生效
        
        public override bool PreDraw(
            Projectile projectile,
            ref Color lightColor)   
        {
            var config = ModContent.GetInstance<Config>();
            //宠物隐藏
            if (Main.projPet[projectile.type]&&!config.OthersPetHide)return true;
            //召唤物隐藏
            if (projectile.minion)
            {
                if (!config.OthersMinionHide) return true;
                else return false;
            }

            if (!config.OthersProjectileHide) return true;
            if(!Keybind.OPHEnabled) return true;

            // 自己发的弹幕正常绘制
            if (projectile.owner == Main.myPlayer)
                return true;

            // 别人发的弹幕直接跳过绘制
            return false;
        }

       
    }
}