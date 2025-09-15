using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace HideSometing
{
    internal class NPCHide : GlobalNPC
    {
        public override bool PreDraw(NPC npc, SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
        {
            var config=ModContent.GetInstance<Config>();
            if (npc.townNPC&&config.TownNPCHide)
                return false;

            return base.PreDraw(npc, spriteBatch, screenPos, drawColor);
        }
    }
}
