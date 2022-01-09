using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CBs.Items;

namespace CBs.NPCs.Bosses
{
    [AutoloadBossHead]
    public class Villain : ModNPC
    {
        public float targetx = 0;
        public float targety = 0;

        public int vMax = 0;
        public float vAccel = 0;

        public float tVel = 0;
        public float vMag = 0;

        bool Green = false;
        bool Red = false;
        bool Yellow = false;
        bool Blue = false;
        bool Orange = false;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Guitar Villain");
        }

        public override void SetDefaults()
        {
            vMax = 3;
            vAccel = 0.2f;
            npc.width = 320;
            npc.height = 320;
            npc.damage = 30;
            npc.defense = 16;
            npc.aiStyle = 0;
            npc.lifeMax = 800;
            npc.HitSound = SoundID.DD2_SkeletonHurt;
            npc.DeathSound = SoundID.DD2_SkeletonDeath;
            npc.npcSlots = 15f;
            npc.value = 12f;
            npc.knockBackResist = 0f;
            
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            music = MusicID.Boss1;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = 80000 + numPlayers * 80000;
            npc.damage = 45;
        }

        public override void AI()
        {
            Player player = Main.player[npc.target];
            targetx = player.Center.X;
            targety = player.Center.Y;

            if (Green == false)
            {
                NPC.NewNPC(0, 0, ModContent.NPCType<GreenFret>(), ai1: npc.whoAmI);
                Green = true;
            }

            if (Red == false)
            {
                NPC.NewNPC(0, 0, ModContent.NPCType<RedFret>(), ai1: npc.whoAmI);
                Red = true;
            }

            if (Yellow == false)
            {
                NPC.NewNPC(0, 0, ModContent.NPCType<YellowFret>(), ai1: npc.whoAmI);
                Yellow = true;
            }

            if (Blue == false)
            {
                NPC.NewNPC(0, 0, ModContent.NPCType<GreenFret>(), ai1: npc.whoAmI);
                Blue = true;
            }

            if (Orange == false)
            {
                NPC.NewNPC(0, 0, ModContent.NPCType<GreenFret>(), ai1: npc.whoAmI);
                Orange = true;
            }

            float dist = Vector2.Distance(npc.Center, Main.player[npc.target].Center);
            tVel = dist / 20;
            if(vMag < vMax && vMag < tVel)
            {
                vMag += vAccel;
            }
            if(vMag > tVel)
            {
                vMag -= vAccel;
            }

            if(dist != 0)
            {
                Vector2 tPos;
                tPos.X = targetx;
                tPos.Y = targety;
                npc.velocity = npc.DirectionTo(tPos) * vMag;
            }

        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(7) == 0) {
            Item.NewItem(npc.getRect(), ModContent.itemType<FiveFrettedStaff>());
            }
            if (Main.rand.Next(21) == 0) {
            Item.NewItem(npc.getRect(), mod.itemType<RedOctane>());
            }
        }

        public Villain()
        {
        }

    }
}
