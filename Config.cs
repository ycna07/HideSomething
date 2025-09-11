using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;
namespace HideSometing
{
    public class Config:ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        
        [DefaultValue(true)]
        public bool OthersProjectileHide { get; set; } // 弹幕隐藏开关

        
        [DefaultValue(false)]
        public bool DustHide { get; set; } // 尘埃隐藏开关

        
        [DefaultValue(false)]
        public bool OthersMinionHide { get; set; } // 召唤物隐藏开关

        [DefaultValue(false)]
        public bool OthersPetHide { get; set; } // 宠物隐藏开关

    }
}
