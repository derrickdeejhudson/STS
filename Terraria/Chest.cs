using Microsoft.Xna.Framework;

namespace Terraria
{
    public class Chest
    {
        public static int maxItems = 287; //was 40
        public Item[] item = new Item[maxItems];
        public int x;
        public int y;

        static Chest()
        {
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public static void Unlock(int X, int Y)
        {
            Main.PlaySound(22, X*16, Y*16, 1);
            for (int index1 = X; index1 <= X + 1; ++index1)
            {
                for (int index2 = Y; index2 <= Y + 1; ++index2)
                {
                    if (Main.tile[index1, index2] == null) Main.tile[index1, index2] = new Tile();
                    if (Main.tile[index1, index2].frameX >= 72 && Main.tile[index1, index2].frameX <= 106 || Main.tile[index1, index2].frameX >= 144 && Main.tile[index1, index2].frameX <= 178)
                    {
                        Main.tile[index1, index2].frameX -= 36;
                        for (int index3 = 0; index3 < 4; ++index3) Dust.NewDust(new Vector2(index1*16, index2*16), 16, 16, 11, 0.0f, 0.0f, 0, new Color(), 1f);
                    }
                    else if (Main.tile[index1, index2].frameX >= 828 && Main.tile[index1, index2].frameX <= 990)
                    {
                        Main.tile[index1, index2].frameX -= 180;
                        for (int index3 = 0; index3 < 4; ++index3) Dust.NewDust(new Vector2(index1*16, index2*16), 16, 16, 11, 0.0f, 0.0f, 0, new Color(), 1f);
                    }
                }
            }
        }

        public static int UsingChest(int i)
        {
            if (Main.chest[i] != null)
            {
                for (int index = 0; index < (int) byte.MaxValue; ++index)
                {
                    if (Main.player[index].active && Main.player[index].chest == i) return index;
                }
            }
            return -1;
        }

        public static int FindChest(int X, int Y)
        {
            for (int index = 0; index < 1000; ++index)
            {
                if (Main.chest[index] != null && Main.chest[index].x == X && Main.chest[index].y == Y) return index;
            }
            return -1;
        }

        public static int CreateChest(int X, int Y)
        {
            for (int index = 0; index < 1000; ++index)
            {
                if (Main.chest[index] != null && Main.chest[index].x == X && Main.chest[index].y == Y) return -1;
            }
            for (int index1 = 0; index1 < 1000; ++index1)
            {
                if (Main.chest[index1] == null)
                {
                    Main.chest[index1] = new Chest();
                    Main.chest[index1].x = X;
                    Main.chest[index1].y = Y;
                    for (int index2 = 0; index2 < maxItems; ++index2) Main.chest[index1].item[index2] = new Item();
                    return index1;
                }
            }
            return -1;
        }

        public static bool DestroyChest(int X, int Y)
        {
            for (int index1 = 0; index1 < 1000; ++index1)
            {
                if (Main.chest[index1] != null && Main.chest[index1].x == X && Main.chest[index1].y == Y)
                {
                    for (int index2 = 0; index2 < maxItems; ++index2)
                    {
                        if (Main.chest[index1].item[index2].type > 0 && Main.chest[index1].item[index2].stack > 0) return false;
                    }
                    Main.chest[index1] = null;
                    return true;
                }
            }
            return true;
        }

        public void AddShop(Item newItem)
        {
            for (int index = 0; index < 39; ++index)
            {
                if (item[index] == null || item[index].type == 0)
                {
                    item[index] = (Item) newItem.Clone();
                    item[index].buyOnce = true;
                    if (item[index].value <= 0) break;
                    item[index].value = item[index].value/2;
                    if (item[index].value >= 1) break;
                    item[index].value = 1;
                    break;
                }
            }
        }

        public void SetupShop(int type)
        {
            /**
         * 1 = merchant (ranged weapons good side)
         * 2 = gun salesman (ranged weapons bad side)
         * 3 = dryad (magic weapons good side)
         * 4 = demolitionist (accessories bad side)
         * 5 = clothier (armor good side)
         * 6 = goblin tinkerer
         * 7 = wizard (magic weapons bad side)
         * 8 = mechanic (recipes good side)
         * 9 = santa
         * 10 = truffle (armor bad side)
         * 11 = steampunker (melee weapons good side)
         * 12 = dye trader (accessories good side)
         * 13 = party girl (recipes bad side)
         * 14 = cyborg (secret shop good side)
         * 15 = painter
         * 16 = witch doctor (secret shop bad side)
         * 17 = pirate (melee weapons good side)
        **/


            for (int index = 0; index < maxItems; ++index) item[index] = new Item();
            int index1 = 0;
            int shopIndex = 0;
            if (type == 17 || type == 11)
            {
                item[shopIndex].SetDefaults("Iron Broadsword");
                shopIndex++;
                item[shopIndex].SetDefaults("Wooden Boomerang");
                shopIndex++;
                item[shopIndex].SetDefaults("Trident");
                shopIndex++;
                item[shopIndex].SetDefaults("Ball O' Hurt");
                shopIndex++;
                item[shopIndex].SetDefaults("Blood Butcherer");
                shopIndex++;
                item[shopIndex].SetDefaults("Blade of Grass");
                shopIndex++;
                item[shopIndex].SetDefaults("Enchanted Boomerang");
                shopIndex++;
                item[shopIndex].SetDefaults("Ice Boomerang");
                shopIndex++;
                item[shopIndex].SetDefaults("The Rotted Fork");
                shopIndex++;
                item[shopIndex].SetDefaults("Vjaya");
                shopIndex++;
                item[shopIndex].SetDefaults("The Meatball");
                shopIndex++;
                item[shopIndex].SetDefaults("Beam Sword");
                shopIndex++;
                item[shopIndex].SetDefaults("Fiery Greatsword");
                shopIndex++;
                item[shopIndex].SetDefaults("Flamarang");
                shopIndex++;
                item[shopIndex].SetDefaults("Dark Lance");
                shopIndex++;
                item[shopIndex].SetDefaults("Blue Moon");
                shopIndex++;
                item[shopIndex].SetDefaults("Night's Edge");
                shopIndex++;
                item[shopIndex].SetDefaults("Icemourne");
                shopIndex++;
                item[shopIndex].SetDefaults("Thorn Chakram");
                shopIndex++;
                item[shopIndex].SetDefaults("Mushroom Spear");
                shopIndex++;
                item[shopIndex].SetDefaults("Death's Design");
                shopIndex++;
                item[shopIndex].SetDefaults("Sunfury");
                shopIndex++;
                item[shopIndex].SetDefaults("Magic Dagger");
                shopIndex++;
            }
            else if (type == 1 || type == 2)
            {
                item[shopIndex].SetDefaults("Iron Bow");
                shopIndex++;
                item[shopIndex].SetDefaults("Flintlock Pistol");
                shopIndex++;
                item[shopIndex].SetDefaults("Shuriken");
                shopIndex++;
                item[shopIndex].SetDefaults("Boomstick");
                shopIndex++;
                item[shopIndex].SetDefaults("Demon Bow");
                shopIndex++;
                item[shopIndex].SetDefaults("Composite Bow");
                shopIndex++;
                item[shopIndex].SetDefaults("Musket");
                shopIndex++;
                item[shopIndex].SetDefaults("Uzi");
                shopIndex++;
                item[shopIndex].SetDefaults("Molten Fury");
                shopIndex++;
                item[shopIndex].SetDefaults("Celestial Bow");
                shopIndex++;
                item[shopIndex].SetDefaults("Shotgun");
                shopIndex++;
                item[shopIndex].SetDefaults("Clockwork Assault Rifle");
                shopIndex++;
                item[shopIndex].SetDefaults("Ice Bow");
                shopIndex++;
                item[shopIndex].SetDefaults("Wooden Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Bullet");
                shopIndex++;
                item[shopIndex].SetDefaults("Flaming Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Meteor Shot");
                shopIndex++;
                item[shopIndex].SetDefaults("Frostburn Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Unholy Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Exploding Bullet");
                shopIndex++;
                item[shopIndex].SetDefaults("Hellfire Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Jester's Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Crystal Bullet");
                shopIndex++;
                item[shopIndex].SetDefaults("Golden Bullet");
            }
            else if (type == 3 || type == 7)
            {
                item[shopIndex].SetDefaults("Amethyst Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Vilethorn");
                shopIndex++;
                item[shopIndex].SetDefaults("Crimson Rod");
                shopIndex++;
                item[shopIndex].SetDefaults("Topaz Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Space Gun");
                shopIndex++;
                item[shopIndex].SetDefaults("Nettle Burst");
                shopIndex++;
                item[shopIndex].SetDefaults("Emerald Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Magic Missile");
                shopIndex++;
                item[shopIndex].SetDefaults("Leaf Blower");
                shopIndex++;
                item[shopIndex].SetDefaults("Flare Missile");
                shopIndex++;
                item[shopIndex].SetDefaults("Nimbus Rod");
                shopIndex++;
                item[shopIndex].SetDefaults("Skull Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Laser Rifle");
            }
            else if (type == 5 || type == 10)
            {
                item[shopIndex].SetDefaults("Iron Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Iron Chainmail");
                shopIndex++;
                item[shopIndex].SetDefaults("Iron Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Wizard Hat");
                shopIndex++;
                item[shopIndex].SetDefaults("Amethyst Robe");
                shopIndex++;
                item[shopIndex].SetDefaults("Shadow Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Shadow Scalemail");
                shopIndex++;
                item[shopIndex].SetDefaults("Shadow Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Jungle Hat");
                shopIndex++;
                item[shopIndex].SetDefaults("Jungle Shirt");
                shopIndex++;
                item[shopIndex].SetDefaults("Jungle Pants");
                shopIndex++;
                item[shopIndex].SetDefaults("Necro Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Necro Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Necro Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Cobalt Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Cobalt Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Cobalt Leggings");
                shopIndex++;
                item[shopIndex].SetDefaults("Palladium Mask");
                shopIndex++;
                item[shopIndex].SetDefaults("Palladium Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Palladium Leggings");
                shopIndex++;
                item[shopIndex].SetDefaults("Mythril Hood");
                shopIndex++;
                item[shopIndex].SetDefaults("Mythril Chainmail");
                shopIndex++;
                item[shopIndex].SetDefaults("Mythril Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Orichalcum Headgear");
                shopIndex++;
                item[shopIndex].SetDefaults("Orichalcum Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Orichalcum Leggings");
                shopIndex++;
                item[shopIndex].SetDefaults("Adamantite Mask");
                shopIndex++;
                item[shopIndex].SetDefaults("Adamantite Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Adamantite Leggings");
                shopIndex++;
                item[shopIndex].SetDefaults("Titanium Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Titanium Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Titanium Leggings");
            }
            else if (type == 4 || type == 12)
            {
                item[0].SetDefaults("Armband");
                item[1].SetDefaults("Circlet");
                item[2].SetDefaults("Aglet");
                item[3].SetDefaults("Shackle");

                item[10].SetDefaults("Cobalt Bracer");
                item[11].SetDefaults("Enchanted Jewel");
                item[12].SetDefaults("Anklet of the Wind");
                item[13].SetDefaults("Idol");

                item[20].SetDefaults("Warrior Emblem");
                item[21].SetDefaults("Sorcerer Emblem");
                item[22].SetDefaults("Ranger Emblem");
                item[23].SetDefaults("Lexicon");

                item[30].SetDefaults("Band of the Giant");
                item[31].SetDefaults("Band of Starpower");
                item[32].SetDefaults("Band of the Agile");

                item[4].SetDefaults("Cloud in a Bottle");
                item[5].SetDefaults("Shiny Red Balloon");
                item[6].SetDefaults("Hermes Boots");
                item[7].SetDefaults("Tabi");
                item[8].SetDefaults("Rod of Discord");
                if (type == 12)
                {
                    item[9].SetDefaults("Sapphire Hook");
                }
                else if (type == 4)
                {
                    item[9].SetDefaults("Ruby Hook");
                }
                item[14].SetDefaults("Cobalt Shield");
                item[15].SetDefaults("Honey Comb");
                item[16].SetDefaults("Star Cloak");
                item[17].SetDefaults("Panic Necklace");
                item[18].SetDefaults("Black Belt");
                item[19].SetDefaults("Frozen Turtle Shell");
                item[24].SetDefaults("Bezoar");
                item[25].SetDefaults("Magma Stone");
                item[26].SetDefaults("Fast Clock");
                item[27].SetDefaults("Blindfold");
                item[28].SetDefaults("Adhesive Bandage");
                item[29].SetDefaults("Armor Polish");
                item[33].SetDefaults("Megaphone");

                item[34].SetDefaults("Feral Claws");
                item[35].SetDefaults("Titan Glove");
                item[36].SetDefaults("Magic Quiver");
                item[37].SetDefaults("Rifle Scope");

                item[40].SetDefaults("Mushroom");
                item[41].SetDefaults("Lesser Healing Potion");
                item[42].SetDefaults("Healing Potion");
                item[43].SetDefaults("Greater Healing Potion");
                item[44].SetDefaults("Fairy Bell");
            }
            else if (type == 14 || type == 16)
            {
                item[shopIndex].SetDefaults("Dao of Pow");
                shopIndex++;
                item[shopIndex].SetDefaults("Gungnir");
                shopIndex++;
                item[shopIndex].SetDefaults("Breaker Blade");
                shopIndex++;
                item[shopIndex].SetDefaults("Paladin's Hammer");
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Claymore");
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Partisan");
                shopIndex++;
                item[shopIndex].SetDefaults("Possessed Hatchet");
                shopIndex++;
                item[shopIndex].SetDefaults("Flower Pow");
                shopIndex++;
                item[shopIndex].SetDefaults("Staff of Earth");
                shopIndex++;
                item[shopIndex].SetDefaults("Rainbow Missile");
                shopIndex++;
                item[shopIndex].SetDefaults("Frost Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Heat Ray");
                shopIndex++;
                item[shopIndex].SetDefaults("Shadowbeam Staff");
                shopIndex++;
                item[shopIndex].SetDefaults("Inferno Missile");
                shopIndex++;
                item[shopIndex].SetDefaults("Rainbow Gun");
                shopIndex++;
                item[shopIndex].SetDefaults("Minishark");
                shopIndex++;
                item[shopIndex].SetDefaults("Tactical Shotgun");
                shopIndex++;
                item[shopIndex].SetDefaults("Sniper Rifle");
                shopIndex++;
                item[shopIndex].SetDefaults("Marrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Cursed Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Cursed Bullet");
                shopIndex++;
                item[shopIndex].SetDefaults("Piranha Gun");
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Shotbow");
                shopIndex++;
                item[shopIndex].SetDefaults("Venom Bullet");
                shopIndex++;
                item[shopIndex].SetDefaults("Venom Arrow");
                shopIndex++;
                item[shopIndex].SetDefaults("Turtle Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Turtle Scale Mail");
                shopIndex++;
                item[shopIndex].SetDefaults("Turtle Leggings");
                shopIndex++;
                item[shopIndex].SetDefaults("Crimson Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Crimson Scalemail");
                shopIndex++;
                item[shopIndex].SetDefaults("Crimson Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Hallowed Headgear");
                shopIndex++;
                item[shopIndex].SetDefaults("Hallowed Plate Mail");
                shopIndex++;
                item[shopIndex].SetDefaults("Hallowed Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults(1503, false); //spectre set
                shopIndex++;
                item[shopIndex].SetDefaults(1504, false);
                shopIndex++;
                item[shopIndex].SetDefaults(1505, false);
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Plate Mail");
                shopIndex++;
                item[shopIndex].SetDefaults("Chlorophyte Greaves");
                shopIndex++;
                item[shopIndex].SetDefaults("Shroomite Helmet");
                shopIndex++;
                item[shopIndex].SetDefaults("Shroomite Breastplate");
                shopIndex++;
                item[shopIndex].SetDefaults("Shroomite Leggings");
            }
            else if (type == 13 || type == 8) //recipe shop
            {
                item[0].SetDefaults(1073, false);
                item[1].SetDefaults(1074, false);
                item[10].SetDefaults(1096, false);
                item[11].SetDefaults(1097, false);

                item[2].SetDefaults(1084, false);
                item[3].SetDefaults(1099, false);
                item[12].SetDefaults(1105, false);
                item[14].SetDefaults(1075, false);


                item[4].SetDefaults(1083, false);
                item[5].SetDefaults(1104, false);

                item[6].SetDefaults(1078, false);
                item[7].SetDefaults(1079, false);
                item[8].SetDefaults(1080, false);
                item[9].SetDefaults(1085, false);

                item[15].SetDefaults(1088, false);
                item[17].SetDefaults(1089, false);
                item[18].SetDefaults(1107, false);
                item[19].SetDefaults(1086, false);

                item[27].SetDefaults(1081, false);
                item[28].SetDefaults(1082, false);
                item[29].SetDefaults(1087, false);

                item[13].SetDefaults(1112, false);
                item[16].SetDefaults(1076, false);
                item[26].SetDefaults(1077, false);
            }
            else if (type == 20) //big shop of tricks
            {
                item[0].SetDefaults("Iron Broadsword");
                item[1] = new Item();
                item[2].SetDefaults("Trident");
                item[3] = new Item();
                item[4].SetDefaults("Wooden Boomerang");
                item[5] = new Item();
                item[6].SetDefaults("Ball O' Hurt");
                item[7] = new Item();
                item[8].SetDefaults("Iron Hammer");
                item[9].SetDefaults("Amethyst Staff");
                item[10].SetDefaults("Vilethorn");
                item[11] = new Item();
                item[12] = new Item();
                item[13] = new Item();
                item[14] = new Item();
                item[15].SetDefaults("Iron Bow");
                item[16] = new Item();
                item[17].SetDefaults("Wooden Arrow");
                item[18] = new Item();
                item[19].SetDefaults("Shuriken");
                item[20].SetDefaults("Flintlock Pistol");
                item[21].SetDefaults("Bullet");

                item[22].SetDefaults("Blade of Grass");
                item[23].SetDefaults("Blood Butcherer");
                item[24].SetDefaults("The Rotted Fork");
                item[25].SetDefaults("Vjaya");
                item[26].SetDefaults("Ice Boomerang");
                item[27].SetDefaults("Enchanted Boomerang");
                item[28].SetDefaults("The Meatball");
                item[29].SetDefaults("Daze Hammer");
                item[30].SetDefaults("Turbo Hammer");
                item[31].SetDefaults("Topaz Staff");
                item[32] = new Item();
                item[33].SetDefaults("Drain");
                item[34].SetDefaults("Space Gun");
                item[35].SetDefaults("Magic Missile");
                item[36].SetDefaults("Crimson Rod");
                item[37].SetDefaults("Demon Bow");
                item[38].SetDefaults("Composite Bow");
                item[39].SetDefaults("Unholy Arrow");
                item[40].SetDefaults("Flaming Arrow");
                item[41].SetDefaults("Musket");
                item[42].SetDefaults("Boomstick");
                item[43].SetDefaults("Crystal Bullet");

                item[44].SetDefaults("Beam Sword");
                item[45].SetDefaults("Fiery Greatsword");
                item[46].SetDefaults("Dark Lance");
                item[47] = new Item();
                item[48].SetDefaults("Magic Dagger");
                item[49].SetDefaults("Ancient Flail");
                item[50].SetDefaults("Blue Moon");
                item[51].SetDefaults("Pwnhammer");
                item[52].SetDefaults("The Breaker");
                item[53].SetDefaults("Emerald Staff");
                item[54].SetDefaults("Nettle Burst");
                item[55] = new Item();
                item[56] = new Item();
                item[57].SetDefaults("Void Missile");
                item[58].SetDefaults("Nimbus Rod");
                item[59].SetDefaults("Celestial Bow");
                item[60].SetDefaults("Molten Fury");
                item[61].SetDefaults("Jester's Arrow");
                item[62].SetDefaults("Frostburn Arrow");
                item[63].SetDefaults("Hamstringer");
                item[64].SetDefaults("Uzi");
                item[65].SetDefaults("Golden Bullet");

                item[66].SetDefaults("Night's Edge");
                item[67].SetDefaults("Icemourne");
                item[68].SetDefaults("Death's Design");
                item[69].SetDefaults("Mushroom Spear");
                item[70].SetDefaults("Thorn Chakram");
                item[71].SetDefaults("Flamarang");
                item[72].SetDefaults("Sunfury");
                item[73].SetDefaults("Molten Hammer");
                item[74].SetDefaults("Flesh Grinder");
                item[75].SetDefaults("Skull Staff");
                item[76].SetDefaults("Leaf Blower");
                item[77].SetDefaults("Doom");
                item[78].SetDefaults("Laser Rifle");
                item[79].SetDefaults("Flare Missile");
                item[80] = new Item();
                item[81].SetDefaults("Ice Bow");
                item[82] = new Item();
                item[83].SetDefaults("Hellfire Arrow");
                item[84].SetDefaults("Clockwork Assault Rifle");
                item[85].SetDefaults("Shotgun");
                item[86].SetDefaults("Meteor Shot");
                item[87].SetDefaults("Exploding Bullet");

                item[88].SetDefaults("Breaker Blade");
                item[89] = new Item();
                item[90].SetDefaults("Gungnir");
                item[91] = new Item();
                item[92].SetDefaults("Light Disc");
                item[93] = new Item();
                item[94].SetDefaults("Dao of Pow");
                item[95] = new Item();
                item[96].SetDefaults("Spectre Hammer");
                item[97].SetDefaults("Frost Staff");
                item[98].SetDefaults("Staff of Earth");
                item[99] = new Item();
                item[100] = new Item();
                item[101].SetDefaults("Rainbow Missile");
                item[102].SetDefaults("Cloud Nine");
                item[103].SetDefaults("Marrow");
                item[104] = new Item();
                item[105].SetDefaults("Cursed Arrow");
                item[106].SetDefaults("Sniper Rifle");
                item[107].SetDefaults("Minishark");
                item[108].SetDefaults("Tactical Shotgun");
                item[109].SetDefaults("Cursed Bullet");

                item[110].SetDefaults("Chlorophyte Claymore");
                item[111] = new Item();
                item[112].SetDefaults("Chlorophyte Partisan");
                item[113] = new Item();
                item[114].SetDefaults("Possessed Hatchet");
                item[115] = new Item();
                item[116].SetDefaults("Flower Pow");
                item[117] = new Item();
                item[118].SetDefaults("Chlorophyte Warhammer");
                item[119].SetDefaults("Shadowbeam Staff");
                item[120] = new Item();
                item[121].SetDefaults("Rainbow Gun");
                item[122].SetDefaults("Heat Ray");
                item[123].SetDefaults("Inferno Missile");
                item[124] = new Item();
                item[125].SetDefaults("Chlorophyte Shotbow");
                item[126] = new Item();
                item[127].SetDefaults("Venom Arrow");
                item[128] = new Item();
                item[129] = new Item();
                item[130].SetDefaults("Piranha Gun");
                item[131].SetDefaults("Venom Bullet");

                item[132].SetDefaults("Iron Helmet");
                item[133].SetDefaults("Shadow Helmet");
                item[134].SetDefaults("Cobalt Helmet");
                item[135].SetDefaults("Palladium Mask");
                item[136].SetDefaults("Turtle Helmet");
                item[137].SetDefaults("Crimson Helmet");
                item[138] = new Item();
                item[139] = new Item();
                item[140] = new Item();
                item[141].SetDefaults("Wizard Hat");
                item[142].SetDefaults("Jungle Hat");
                item[143].SetDefaults("Mythril Hood");
                item[144].SetDefaults("Orichalcum Headgear");
                item[145].SetDefaults("Hallowed Headgear");
                item[146].SetDefaults(1503, false);
                item[147] = new Item();
                item[148].SetDefaults("Necro Helmet");
                item[149].SetDefaults("Adamantite Mask");
                item[150].SetDefaults("Titanium Helmet");
                item[151].SetDefaults("Chlorophyte Helmet");
                item[152].SetDefaults("Shroomite Helmet");
                item[153] = new Item();

                item[154].SetDefaults("Iron Chainmail");
                item[155].SetDefaults("Shadow Scalemail");
                item[156].SetDefaults("Cobalt Breastplate");
                item[157].SetDefaults("Palladium Breastplate");
                item[158].SetDefaults("Turtle Scale Mail");
                item[159].SetDefaults("Crimson Scalemail");
                item[160] = new Item();
                item[161] = new Item();
                item[162] = new Item();
                item[163].SetDefaults("Amethyst Robe");
                item[164].SetDefaults("Jungle Shirt");
                item[165].SetDefaults("Mythril Chainmail");
                item[166].SetDefaults("Orichalcum Breastplate");
                item[167].SetDefaults("Hallowed Plate Mail");
                item[168].SetDefaults(1504, false);
                item[169] = new Item();
                item[170].SetDefaults("Necro Breastplate");
                item[171].SetDefaults("Adamantite Breastplate");
                item[172].SetDefaults("Titanium Breastplate");
                item[173].SetDefaults("Chlorophyte Plate Mail");
                item[174].SetDefaults("Shroomite Breastplate");
                item[175] = new Item();

                item[176].SetDefaults("Iron Greaves");
                item[177].SetDefaults("Shadow Greaves");
                item[178].SetDefaults("Cobalt Leggings");
                item[179].SetDefaults("Palladium Leggings");
                item[180].SetDefaults("Turtle Leggings");
                item[181].SetDefaults("Crimson Greaves");
                item[182] = new Item();
                item[183] = new Item();
                item[184] = new Item();
                item[185] = new Item();
                item[186].SetDefaults("Jungle Pants");
                item[187].SetDefaults("Mythril Greaves");
                item[188].SetDefaults("Orichalcum Leggings");
                item[189].SetDefaults("Hallowed Greaves");
                item[190].SetDefaults(1505, false);
                item[191] = new Item();
                item[192].SetDefaults("Necro Greaves");
                item[193].SetDefaults("Adamantite Leggings");
                item[194].SetDefaults("Titanium Leggings");
                item[195].SetDefaults("Chlorophyte Greaves");
                item[196].SetDefaults("Shroomite Leggings");
                item[197] = new Item();

                item[198].SetDefaults("Armband");
                item[199].SetDefaults("Circlet");
                item[200].SetDefaults("Aglet");
                item[201].SetDefaults("Shackle");
                item[202] = new Item();
                item[203] = new Item();
                item[204].SetDefaults("Cloud in a Bottle");
                item[205].SetDefaults("Hermes Boots");
                item[206].SetDefaults("Rifle Scope");
                item[207].SetDefaults("Magic Quiver");
                item[208].SetDefaults("Lucky Horseshoe");
                item[209] = new Item();
                item[210].SetDefaults("Swift Mushroom");
                item[211].SetDefaults("Goblin's Blood");
                item[212] = new Item();
                item[213].SetDefaults("Recipe - Lucky Emblem");
                item[214].SetDefaults("Recipe - Band of the Elder");
                item[215].SetDefaults("Recipe - Hermes Tabi");
                item[216].SetDefaults("Recipe - Silent Steppers");
                item[217].SetDefaults("Recipe - Lightning Boots");
                item[218].SetDefaults("Recipe - Blood Gem");
                item[219].SetDefaults("Recipe - Refreshing Orb");

                item[220].SetDefaults("Cobalt Bracer");
                item[221].SetDefaults("Enchanted Jewel");
                item[222].SetDefaults("Anklet of the Wind");
                item[223].SetDefaults("Idol");
                item[224] = new Item();
                item[225] = new Item();
                item[226].SetDefaults("Shiny Red Balloon");
                item[227].SetDefaults("Tabi");
                item[228].SetDefaults("Feral Claws");
                item[229].SetDefaults("Titan Glove");
                item[230] = new Item();
                item[231] = new Item();
                item[232].SetDefaults("Focus Flask");
                item[233].SetDefaults("Ectoplasm");
                item[234] = new Item();
                item[235].SetDefaults("Recipe - Band of the Knight");
                item[236].SetDefaults("Recipe - Band of the Eagle");
                item[237].SetDefaults("Recipe - Shiny Red Boots");
                item[238].SetDefaults("Recipe - Arcane Boots");
                item[239].SetDefaults("Recipe - Bee Cloak");
                item[240].SetDefaults("Recipe - Chlorophyte Scope");
                item[241].SetDefaults("Recipe - Chlorophyte Quiver");

                item[242].SetDefaults("Warrior Emblem");
                item[243].SetDefaults("Sorcerer Emblem");
                item[244].SetDefaults("Ranger Emblem");
                item[245].SetDefaults("Lexicon");
                item[246].SetDefaults("Cobalt Shield");
                item[247].SetDefaults("Panic Necklace");
                item[248].SetDefaults("Honey Comb");
                item[249].SetDefaults("Star Cloak");
                item[250].SetDefaults("Black Belt");
                item[251].SetDefaults("Frozen Turtle Shell");
                item[252] = new Item();
                item[253] = new Item();
                item[254].SetDefaults("Rod of Discord");
                item[255].SetDefaults("Fairy Bell");
                item[256] = new Item();
                item[257] = new Item();
                item[258].SetDefaults("Recipe - Magic Cuffs");
                item[259].SetDefaults("Recipe - Cloud in a Balloon");
                item[260].SetDefaults("Recipe - Arcane Cloud Emblem");
                item[261].SetDefaults("Recipe - Brute Instincts");
                item[262].SetDefaults("Recipe - Daring Instincts");
                item[263].SetDefaults("Recipe - Calm Instincts");

                item[264].SetDefaults("Band of the Giant");
                item[265].SetDefaults("Band of Starpower");
                item[266].SetDefaults("Band of the Agile");
                item[267].SetDefaults("Metal Scrap");
                item[268].SetDefaults("Bezoar");
                item[269].SetDefaults("Adhesive Bandage");
                item[270].SetDefaults("Magma Stone");
                item[271].SetDefaults("Armor Polish");
                item[272].SetDefaults("Fast Clock");
                item[273].SetDefaults("Blindfold");
                item[274].SetDefaults("Megaphone");
                item[275] = new Item();
                item[276] = new Item();
                item[277] = new Item();
                item[278] = new Item();
                item[279].SetDefaults("Recipe - Knight's Cuffs");
                item[280].SetDefaults("Recipe - Eagle Cuffs");
                item[281].SetDefaults("Recipe - Paladin's Shield");
                item[282].SetDefaults("Recipe - Cryogenic Shield");
                item[283].SetDefaults("Recipe - Power Glove");
                item[284].SetDefaults("Recipe - Mechanical Glove");
                item[285].SetDefaults("Recipe - Status Gauntlet");
            }
            else if (type == 8)
            {
                item[index1].SetDefaults(509, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(850, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(851, false);
                int index4 = index3 + 1;
                item[index4].SetDefaults(510, false);
                int index5 = index4 + 1;
                item[index5].SetDefaults(530, false);
                int index6 = index5 + 1;
                item[index6].SetDefaults(513, false);
                int index7 = index6 + 1;
                item[index7].SetDefaults(538, false);
                int index8 = index7 + 1;
                item[index8].SetDefaults(529, false);
                int index9 = index8 + 1;
                item[index9].SetDefaults(541, false);
                int index10 = index9 + 1;
                item[index10].SetDefaults(542, false);
                int index11 = index10 + 1;
                item[index11].SetDefaults(543, false);
                int index12 = index11 + 1;
                item[index12].SetDefaults(852, false);
                int index13 = index12 + 1;
                item[index13].SetDefaults(853, false);
                int index14 = index13 + 1;
                item[index14].SetDefaults(849, false);
                index1 = index14 + 1;
            }
            else if (type == 9)
            {
                item[index1].SetDefaults(588, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(589, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(590, false);
                int index4 = index3 + 1;
                item[index4].SetDefaults(597, false);
                int index5 = index4 + 1;
                item[index5].SetDefaults(598, false);
                int index6 = index5 + 1;
                item[index6].SetDefaults(596, false);
                index1 = index6 + 1;
            }
            else if (type == 10)
            {
                item[index1].SetDefaults(756, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(787, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(868, false);
                int index4 = index3 + 1;
                item[index4].SetDefaults(1551, false);
                int index5 = index4 + 1;
                item[index5].SetDefaults(1181, false);
                int index6 = index5 + 1;
                item[index6].SetDefaults(783, false);
                index1 = index6 + 1;
            }
            else if (type == 11)
            {
                item[index1].SetDefaults(779, false);
                int index2 = index1 + 1;
                int index3;
                if (Main.moonPhase >= 4)
                {
                    item[index2].SetDefaults(748, false);
                    index3 = index2 + 1;
                }
                else
                {
                    item[index2].SetDefaults(839, false);
                    int index4 = index2 + 1;
                    item[index4].SetDefaults(840, false);
                    int index5 = index4 + 1;
                    item[index5].SetDefaults(841, false);
                    index3 = index5 + 1;
                }
                int index6;
                if (Main.dayTime)
                {
                    item[index3].SetDefaults(998, false);
                    index6 = index3 + 1;
                }
                else
                {
                    item[index3].SetDefaults(995, false);
                    index6 = index3 + 1;
                }
                item[index6].SetDefaults(1263, false);
                int index7 = index6 + 1;
                int index8;
                if (Main.eclipse || Main.bloodMoon)
                {
                    if (WorldGen.crimson)
                    {
                        item[index7].SetDefaults(784, false);
                        index8 = index7 + 1;
                    }
                    else
                    {
                        item[index7].SetDefaults(782, false);
                        index8 = index7 + 1;
                    }
                }
                else if (Main.player[Main.myPlayer].zoneHoly)
                {
                    item[index7].SetDefaults(781, false);
                    index8 = index7 + 1;
                }
                else
                {
                    item[index7].SetDefaults(780, false);
                    index8 = index7 + 1;
                }
                if (Main.hardMode) item[index8].SetDefaults(1344, false);
                index1 = index8 + 1;
            }
            else if (type == 12)
            {
                item[index1].SetDefaults(1037, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(1120, false);
                index1 = index2 + 1;
            }
            else if (type == 13)
            {
                item[index1].SetDefaults(1000, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(1168, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(1449, false);
                int index4 = index3 + 1;
                item[index4].SetDefaults(1345, false);
                index1 = index4 + 1;
                if (Main.hardMode)
                {
                    item[index1].SetDefaults(970, false);
                    int index5 = index1 + 1;
                    item[index5].SetDefaults(971, false);
                    int index6 = index5 + 1;
                    item[index6].SetDefaults(972, false);
                    int index7 = index6 + 1;
                    item[index7].SetDefaults(973, false);
                    index1 = index7 + 1;
                }
            }
            else if (type == 14)
            {
                item[index1].SetDefaults(771, false);
                ++index1;
                if (Main.bloodMoon)
                {
                    item[index1].SetDefaults(772, false);
                    ++index1;
                }
                if (!Main.dayTime || Main.eclipse)
                {
                    item[index1].SetDefaults(773, false);
                    ++index1;
                }
                if (Main.eclipse)
                {
                    item[index1].SetDefaults(774, false);
                    ++index1;
                }
                if (Main.hardMode)
                {
                    item[index1].SetDefaults(760, false);
                    ++index1;
                }
                if (Main.hardMode)
                {
                    item[index1].SetDefaults(1346, false);
                    ++index1;
                }
            }
            else if (type == 15)
            {
                item[index1].SetDefaults(1071, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(1072, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(1100, false);
                int index4 = index3 + 1;
                for (int Type = 1073; Type <= 1084; ++Type)
                {
                    item[index4].SetDefaults(Type, false);
                    ++index4;
                }
                item[index4].SetDefaults(1097, false);
                int index5 = index4 + 1;
                item[index5].SetDefaults(1099, false);
                int index6 = index5 + 1;
                item[index6].SetDefaults(1098, false);
                int index7 = index6 + 1;
                item[index7].SetDefaults(1490, false);
                int index8 = index7 + 1;
                if (Main.moonPhase <= 1)
                {
                    item[index8].SetDefaults(1481, false);
                    index1 = index8 + 1;
                }
                else if (Main.moonPhase <= 3)
                {
                    item[index8].SetDefaults(1482, false);
                    index1 = index8 + 1;
                }
                else if (Main.moonPhase <= 5)
                {
                    item[index8].SetDefaults(1483, false);
                    index1 = index8 + 1;
                }
                else
                {
                    item[index8].SetDefaults(1484, false);
                    index1 = index8 + 1;
                }
                if (Main.player[Main.myPlayer].zoneBlood)
                {
                    item[index1].SetDefaults(1492, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].zoneEvil)
                {
                    item[index1].SetDefaults(1488, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].zoneHoly)
                {
                    item[index1].SetDefaults(1489, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].zoneJungle)
                {
                    item[index1].SetDefaults(1486, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].zoneSnow)
                {
                    item[index1].SetDefaults(1487, false);
                    ++index1;
                }
                if (Main.sandTiles > 1000)
                {
                    item[index1].SetDefaults(1491, false);
                    ++index1;
                }
                if (Main.bloodMoon)
                {
                    item[index1].SetDefaults(1493, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].position.Y/16.0 < Main.worldSurface*0.349999994039536)
                {
                    item[index1].SetDefaults(1485, false);
                    ++index1;
                }
                if (Main.player[Main.myPlayer].position.Y/16.0 < Main.worldSurface*0.349999994039536 && Main.hardMode)
                {
                    item[index1].SetDefaults(1494, false);
                    ++index1;
                }
            }
            else if (type == 16)
            {
                item[index1].SetDefaults(1430, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(986, false);
                index1 = index2 + 1;
                if (Main.hardMode && NPC.downedPlantBoss)
                {
                    if (Main.player[Main.myPlayer].HasItem(1157))
                    {
                        item[index1].SetDefaults(1159, false);
                        int index3 = index1 + 1;
                        item[index3].SetDefaults(1160, false);
                        int index4 = index3 + 1;
                        item[index4].SetDefaults(1161, false);
                        index1 = index4 + 1;
                        if (!Main.dayTime)
                        {
                            item[index1].SetDefaults(1158, false);
                            ++index1;
                        }
                        if (Main.player[Main.myPlayer].zoneJungle)
                        {
                            item[index1].SetDefaults(1167, false);
                            ++index1;
                        }
                    }
                    item[index1].SetDefaults(1339, false);
                    ++index1;
                }
                if (Main.hardMode && Main.player[Main.myPlayer].zoneJungle)
                {
                    item[index1].SetDefaults(1171, false);
                    ++index1;
                    if (!Main.dayTime)
                    {
                        item[index1].SetDefaults(1162, false);
                        ++index1;
                    }
                }
                if (Main.hardMode && NPC.downedGolemBoss)
                {
                    item[index1].SetDefaults(909, false);
                    int index3 = index1 + 1;
                    item[index3].SetDefaults(910, false);
                    int index4 = index3 + 1;
                    item[index4].SetDefaults(940, false);
                    int index5 = index4 + 1;
                    item[index5].SetDefaults(941, false);
                    int index6 = index5 + 1;
                    item[index6].SetDefaults(942, false);
                    int index7 = index6 + 1;
                    item[index7].SetDefaults(943, false);
                    int index8 = index7 + 1;
                    item[index8].SetDefaults(944, false);
                    int index9 = index8 + 1;
                    item[index9].SetDefaults(945, false);
                    index1 = index9 + 1;
                }
                if (Main.player[Main.myPlayer].HasItem(1258))
                {
                    item[index1].SetDefaults(1261, false);
                    ++index1;
                }
            }
            else if (type == 17)
            {
                item[index1].SetDefaults(928, false);
                int index2 = index1 + 1;
                item[index2].SetDefaults(929, false);
                int index3 = index2 + 1;
                item[index3].SetDefaults(876, false);
                int index4 = index3 + 1;
                item[index4].SetDefaults(877, false);
                int index5 = index4 + 1;
                item[index5].SetDefaults(878, false);
                index1 = index5 + 1;
                var num = (int) ((Main.screenPosition.X + (double) (Main.screenWidth/2))/16.0);
                if (Main.screenPosition.Y/16.0 < Main.worldSurface + 10.0 && (num < 380 || num > Main.maxTilesX - 380))
                {
                    item[index1].SetDefaults(1180, false);
                    ++index1;
                }
                if (Main.hardMode && NPC.downedMechBossAny && NPC.AnyNPCs(208))
                {
                    item[index1].SetDefaults(1337, false);
                    int index6 = index1 + 1;
                    item[index6].SetDefaults(1338, false);
                    index1 = index6 + 1;
                }
            }
            if (!Main.player[Main.myPlayer].discount) return;
            for (int index2 = 0; index2 < index1; ++index2) item[index2].value = (int) (item[index2].value*0.800000011920929);
        }
    }
}