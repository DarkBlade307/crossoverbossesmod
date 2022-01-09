using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CBs.NPCs
{
    public class OrangeFret : ModNPC
    {

        public float targetx = 0;
        public float targety = 0;

        public int vMax = 0;
        public float vAccel = 0;

        public float tVel = 0;
        public float vMag = 0;

        float someTimer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yello Fret");
        }

        public override void SetDefaults()
        {
            vMax = 6;
            vAccel = 0.2f;
            npc.width = 160;
            npc.height = 160;
            npc.damage = 25;
            npc.defense = 25;
            npc.aiStyle = 0;
            npc.lifeMax = 800;
            npc.HitSound = SoundID.DD2_SkeletonHurt;
            npc.DeathSound = SoundID.DD2_SkeletonDeath;
            npc.npcSlots = 5f;
            npc.value = 12f;
            npc.knockBackResist = 0f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = 80000 + numPlayers * 80000;
            npc.damage = 45;
        }

        public override void AI()
        {
            {
                int bossWhoAmI = (int)npc.ai[1];
                NPC boss = Main.npc[bossWhoAmI];
                npc.Center = boss.Center + new Vector2(0, 320).RotatedBy(someTimer);
                someTimer += 0.05f;
            }
        }

        public override bool CheckActive()
        {
            int bossWhoAmI = (int)npc.ai[1];
            NPC boss = Main.npc[bossWhoAmI];
            if (boss.active == false)
            {
                npc.active = false;
                return false;
            }
            else
            {
                return true;
            }

        }
        public OrangeFret()
        {
        }
    }
}
