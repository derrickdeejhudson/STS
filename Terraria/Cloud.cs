using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
    public class Cloud
    {
        private static readonly Random rand = new Random();
        public bool active;
        public float Alpha;
        public int height;
        public bool kill;
        public Vector2 position;
        public float rotation;
        public float rSpeed;
        public float scale;
        public SpriteEffects spriteDir;
        public float sSpeed;
        public int type;
        public int width;

        public static void resetClouds()
        {
            if (Main.dedServ)
            {
                return;
            }
            if (Main.cloudLimit < 10)
            {
                return;
            }
            Main.windSpeed = Main.windSpeedSet;
            for (var i = 0; i < 200; i++)
            {
                Main.cloud[i].active = false;
            }
            for (var j = 0; j < Main.numClouds; j++)
            {
                // Cloud.addCloud();
                // Main.cloud[j].Alpha = 1f;
            }
            for (var k = 0; k < 200; k++)
            {
                // Main.cloud[k].Alpha = 1f;
            }
        }

        public static void addCloud()
        {
            if (Main.netMode == 2)
            {
                return;
            }
            var num = -1;
            for (var i = 0; i < 200; i++)
            {
                if (!Main.cloud[i].active)
                {
                    num = i;
                    break;
                }
            }
            if (num >= 0)
            {
                Main.cloud[num].kill = false;
                Main.cloud[num].rSpeed = 0f;
                Main.cloud[num].sSpeed = 0f;
                Main.cloud[num].scale = rand.Next(70, 131)*0.01f;
                Main.cloud[num].rotation = rand.Next(-10, 11)*0.01f;
                Main.cloud[num].width = (int) (Main.cloudTexture[Main.cloud[num].type].Width*Main.cloud[num].scale);
                Main.cloud[num].height = (int) (Main.cloudTexture[Main.cloud[num].type].Height*Main.cloud[num].scale);
                Main.cloud[num].Alpha = 0f;
                Main.cloud[num].spriteDir = SpriteEffects.None;
                if (rand.Next(2) == 0)
                {
                    Main.cloud[num].spriteDir = SpriteEffects.FlipHorizontally;
                }
                var num2 = Main.windSpeed;
                if (!Main.gameMenu)
                {
                    num2 = Main.windSpeed - Main.player[Main.myPlayer].velocity.X*0.1f;
                }
                var num3 = 0;
                var num4 = 0;
                if (num2 > 0f)
                {
                    num3 -= 200;
                }
                if (num2 < 0f)
                {
                    num4 += 200;
                }
                var num5 = 300;
                float x = WorldGen.genRand.Next(num3 - num5, Main.screenWidth + num4 + num5);
                Main.cloud[num].Alpha = 0f;
                Main.cloud[num].position.Y = rand.Next((int) (-(float) Main.screenHeight*0.25f), (int) (Main.screenHeight*0.25f));
                var expr_211_cp_0 = Main.cloud[num];
                expr_211_cp_0.position.Y = expr_211_cp_0.position.Y - rand.Next((int) (Main.screenHeight*0.15f));
                var expr_241_cp_0 = Main.cloud[num];
                expr_241_cp_0.position.Y = expr_241_cp_0.position.Y - rand.Next((int) (Main.screenHeight*0.15f));
                Main.cloud[num].type = rand.Next(4);
                if (Main.rand == null)
                {
                    Main.rand = new Random();
                }
                if ((Main.cloudAlpha > 0f && rand.Next(4) != 0) || (Main.cloudBGActive >= 1f && Main.rand.Next(2) == 0))
                {
                    Main.cloud[num].type = rand.Next(18, 22);
                    if (Main.cloud[num].scale >= 1.15)
                    {
                        var expr_303_cp_0 = Main.cloud[num];
                        expr_303_cp_0.position.Y = expr_303_cp_0.position.Y - 150f;
                    }
                    if (Main.cloud[num].scale >= 1f)
                    {
                        var expr_336_cp_0 = Main.cloud[num];
                        expr_336_cp_0.position.Y = expr_336_cp_0.position.Y - 150f;
                    }
                }
                else
                {
                    if (((Main.cloudBGActive <= 0f && Main.cloudAlpha == 0f && Main.cloud[num].scale < 1f && Main.cloud[num].position.Y < -(float) Main.screenHeight*0.2f) || Main.cloud[num].position.Y < -(float) Main.screenHeight*0.2f) && Main.numClouds < 50.0)
                    {
                        Main.cloud[num].type = rand.Next(9, 14);
                    }
                    else
                    {
                        if (((Main.cloud[num].scale < 1.15 && Main.cloud[num].position.Y < -(float) Main.screenHeight*0.3f) || (Main.cloud[num].scale < 0.85 && Main.cloud[num].position.Y < Main.screenHeight*0.15f)) && (Main.numClouds > 70.0 || Main.cloudBGActive >= 1f))
                        {
                            Main.cloud[num].type = rand.Next(4, 9);
                        }
                        else
                        {
                            if (Main.cloud[num].position.Y > -(float) Main.screenHeight*0.15f && rand.Next(2) == 0 && Main.numClouds > 20.0)
                            {
                                Main.cloud[num].type = rand.Next(14, 18);
                            }
                        }
                    }
                }
                if (Main.cloud[num].scale > 1.2)
                {
                    var expr_50A_cp_0 = Main.cloud[num];
                    expr_50A_cp_0.position.Y = expr_50A_cp_0.position.Y + 100f;
                }
                if (Main.cloud[num].scale > 1.3)
                {
                    Main.cloud[num].scale = 1.3f;
                }
                if (Main.cloud[num].scale < 0.7)
                {
                    Main.cloud[num].scale = 0.7f;
                }
                Main.cloud[num].active = true;
                Main.cloud[num].position.X = x;
                if (Main.cloud[num].position.X > Main.screenWidth + 100)
                {
                    Main.cloud[num].Alpha = 1f;
                }
                if (Main.cloud[num].position.X + Main.cloudTexture[Main.cloud[num].type].Width*Main.cloud[num].scale < -100f)
                {
                    Main.cloud[num].Alpha = 1f;
                }
                var rectangle = new Rectangle((int) Main.cloud[num].position.X, (int) Main.cloud[num].position.Y, Main.cloud[num].width, Main.cloud[num].height);
                for (var j = 0; j < 200; j++)
                {
                    if (num != j && Main.cloud[j].active)
                    {
                        var value = new Rectangle((int) Main.cloud[j].position.X, (int) Main.cloud[j].position.Y, Main.cloud[j].width, Main.cloud[j].height);
                        if (rectangle.Intersects(value))
                        {
                            Main.cloud[num].active = false;
                        }
                    }
                }
            }
        }

        public Color cloudColor(Color bgColor)
        {
            var num = scale*Alpha;
            if (num > 1f)
            {
                num = 1f;
            }
            float num2 = (int) (bgColor.R*num);
            float num3 = (int) (bgColor.G*num);
            float num4 = (int) (bgColor.B*num);
            float num5 = (int) (bgColor.A*num);
            return new Color((byte) num2, (byte) num3, (byte) num4, (byte) num5);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public static void UpdateClouds()
        {
            if (Main.netMode == 2)
            {
                return;
            }
            var num = 0;
            for (var i = 0; i < 200; i++)
            {
                if (Main.cloud[i].active)
                {
                    Main.cloud[i].Update();
                    if (!Main.cloud[i].kill)
                    {
                        num++;
                    }
                }
            }
            for (var j = 0; j < 200; j++)
            {
                if (Main.cloud[j].active)
                {
                    if (j > 1 && (!Main.cloud[j - 1].active || Main.cloud[j - 1].scale > Main.cloud[j].scale + 0.02))
                    {
                        var cloud = (Cloud) Main.cloud[j - 1].Clone();
                        Main.cloud[j - 1] = (Cloud) Main.cloud[j].Clone();
                        Main.cloud[j] = cloud;
                    }
                    if (j < 199 && (!Main.cloud[j].active || Main.cloud[j + 1].scale < Main.cloud[j].scale - 0.02))
                    {
                        var cloud2 = (Cloud) Main.cloud[j + 1].Clone();
                        Main.cloud[j + 1] = (Cloud) Main.cloud[j].Clone();
                        Main.cloud[j] = cloud2;
                    }
                }
            }
            if (num < Main.numClouds)
            {
                addCloud();
                return;
            }
            if (num > Main.numClouds)
            {
                var num2 = Main.rand.Next(num);
                var num3 = 0;
                while (Main.cloud[num2].kill && num3 < 100)
                {
                    num3++;
                    num2 = Main.rand.Next(num);
                }
                Main.cloud[num2].kill = true;
            }
        }

        public void Update()
        {
            if (Main.gameMenu)
            {
                position.X = position.X + Main.windSpeed*scale*3f;
            }
            else
            {
                if (scale == 1f)
                {
                    scale -= 0.0001f;
                }
                if (scale == 1.15)
                {
                    scale -= 0.0001f;
                }
                float num;
                if (scale < 1f)
                {
                    num = 0.07f;
                    var num2 = scale + 0.15f;
                    num2 = (num2 + 1f)/2f;
                    num2 *= num2;
                    num *= num2;
                }
                else
                {
                    if (scale <= 1.15)
                    {
                        num = 0.17f;
                        var num3 = scale - 0.075f;
                        num3 *= num3;
                        num *= num3;
                    }
                    else
                    {
                        num = 0.23f;
                        var num4 = scale - 0.15f - 0.075f;
                        num4 *= num4;
                        num *= num4;
                    }
                }
                position.X = position.X + Main.windSpeed*num*5f*Main.dayRate;
                var num5 = Main.screenPosition.X - Main.screenLastPosition.X;
                position.X = position.X - num5*num;
            }
            var num6 = 600f;
            if (!kill)
            {
                if (Alpha < 1f)
                {
                    Alpha += 0.001f*Main.dayRate;
                    if (Alpha > 1f)
                    {
                        Alpha = 1f;
                    }
                }
            }
            else
            {
                Alpha -= 0.001f*Main.dayRate;
                if (Alpha <= 0f)
                {
                    active = false;
                }
            }
            if (position.X + Main.cloudTexture[type].Width*scale < -num6 || position.X > Main.screenWidth + num6)
            {
                active = false;
            }
            rSpeed += rand.Next(-10, 11)*2E-05f;
            if (rSpeed > 0.0002)
            {
                rSpeed = 0.0002f;
            }
            if (rSpeed < -0.0002)
            {
                rSpeed = -0.0002f;
            }
            if (rotation > 0.02)
            {
                rotation = 0.02f;
            }
            if (rotation < -0.02)
            {
                rotation = -0.02f;
            }
            rotation += rSpeed;
            width = (int) (Main.cloudTexture[type].Width*scale);
            height = (int) (Main.cloudTexture[type].Height*scale);
            if (type >= 9 && type <= 13 && (Main.cloudAlpha > 0f || Main.cloudBGActive >= 1f))
            {
                kill = true;
            }
        }
    }
}