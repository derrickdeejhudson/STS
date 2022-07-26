using System;

namespace Terraria
{
    internal class Lang
    {
        public static int lang = 0;
        public static string[] misc = new string[31];
        public static string[] menu = new string[114];
        public static string[] gen = new string[73];
        public static string[] inter = new string[59];
        public static string[] tip = new string[56];
        public static string[] mp = new string[22];
        public static string[] dt = new string[3];
        public static string the;

        public static string dialog(int l, bool english = false)
        {
            string text = Main.chrName[18];
            string str = Main.chrName[17];
            string text2 = Main.chrName[19];
            string text3 = Main.chrName[20];
            string str2 = Main.chrName[38];
            string arg_36_0 = Main.chrName[54];
            string str3 = Main.chrName[22];
            string arg_49_0 = Main.chrName[108];
            string text4 = Main.chrName[107];
            string text5 = Main.chrName[124];
            string str4 = Main.chrName[160];
            string arg_76_0 = Main.chrName[178];
            string arg_82_0 = Main.chrName[207];
            string str5 = Main.chrName[208];
            string str6 = Main.chrName[209];
            string arg_A8_0 = Main.chrName[227];
            string arg_B4_0 = Main.chrName[228];
            string str7 = Main.chrName[229];
            if (!english && Lang.lang > 1)
            {
                return Lang.dialog(l, true);
            }
            return "";
        }

        public static string setBonus(int l, bool english = false)
        {
            if (Lang.lang <= 1 || english)
            {
                switch (l)
                {
                    case 0:
                        return "2 defense";
                    case 1:
                        return "3 defense";
                    case 2:
                        return "10% increased movement speed";
                    case 3:
                        return "Space Gun costs 0 mana";
                    case 4:
                        return "10% Increased Ranged Velocity"; //"20% chance to not consume ammo";
                    case 5:
                        return "16% reduced mana usage";
                    case 6:
                        return "17% extra melee damage";
                    case 7:
                        return "30% increased mining speed";
                    case 8:
                        return "14% reduced mana usage";
                    case 9:
                        return "15% increased melee speed";
                    case 10:
                        return "+10% ranged velocity";
                    case 11:
                        return "17% reduced mana usage";
                    case 12:
                        return "5% increased melee critical strike chance";
                    case 13:
                        return "10% Increased Ranged Velocity"; //"20% chance to not consume ammo";
                    case 14:
                        return "19% reduced mana usage";
                    case 15:
                        return "18% increased melee and movement speed";
                    case 16:
                        return "25% chance to not consume ammo";
                    case 17:
                        return "20% reduced mana usage";
                    case 18:
                        return "19% increased melee and movement speed";
                    case 19:
                        return "25% chance to not consume ammo";
                    case 20:
                        return "1 defense";
                    case 21:
                        return "Greatly increased life regen, 30% melee life steal";
                    case 22:
                        return "Melee and ranged attacks cause frostburn";
                    case 23:
                        return "Increases your max number of minions";
                    case 24:
                        return "Greatly increases life regeneration after striking an enemy";
                    case 25:
                        return "Flower petals will fall on your target for extra damage";
                    case 26:
                        return "Become immune after striking an enemy";
                    case 27:
                        return "Summons a powerful leaf crystal to shoot at nearby enemies";
                    case 28:
                        return "Increases damage and mana cost of all spells by 2";
                    case 29:
                        return "Attackers also take full damage";
                    case 30:
                        return "Magic damage done to enemies heals the player with lowest health";
                    case 31:
                        return "Not attacking puts you stealth, increasing ranged ability and reducing chance for enemies to target you";
                }
            }
            if (!english && Lang.lang > 1)
            {
                return Lang.setBonus(l, true);
            }
            return "";
        }

        public static string npcName(int l, bool english = false)
        {
            if (Lang.lang <= 1 || english)
            {
                switch (l)
                {
                    case -65:
                        return "Hornet";
                    case -64:
                        return "Hornet";
                    case -63:
                        return "Hornet";
                    case -62:
                        return "Hornet";
                    case -61:
                        return "Hornet";
                    case -60:
                        return "Hornet";
                    case -59:
                        return "Hornet";
                    case -58:
                        return "Hornet";
                    case -57:
                        return "Hornet";
                    case -56:
                        return "Hornet";
                    case -55:
                        return "Zombie";
                    case -54:
                        return "Zombie";
                    case -53:
                        return "Skeleton";
                    case -52:
                        return "Skeleton";
                    case -51:
                        return "Skeleton";
                    case -50:
                        return "Skeleton";
                    case -49:
                        return "Skeleton";
                    case -48:
                        return "Skeleton";
                    case -47:
                        return "Skeleton";
                    case -46:
                        return "Skeleton";
                    case -45:
                        return "Zombie";
                    case -44:
                        return "Zombie";
                    case -43:
                        return "Demon Eye";
                    case -42:
                        return "Demon Eye";
                    case -41:
                        return "Demon Eye";
                    case -40:
                        return "Demon Eye";
                    case -39:
                        return "Demon Eye";
                    case -38:
                        return "Demon Eye";
                    case -37:
                        return "Zombie";
                    case -36:
                        return "Zombie";
                    case -35:
                        return "Zombie";
                    case -34:
                        return "Zombie";
                    case -33:
                        return "Zombie";
                    case -32:
                        return "Zombie";
                    case -31:
                        return "Zombie";
                    case -30:
                        return "Zombie";
                    case -29:
                        return "Zombie";
                    case -28:
                        return "Zombie";
                    case -27:
                        return "Zombie";
                    case -26:
                        return "Zombie";
                    case -25:
                        return "Crimslime";
                    case -24:
                        return "Crimslime";
                    case -23:
                        return "Crimera";
                    case -22:
                        return "Crimera";
                    case -21:
                        return "Moss Hornet";
                    case -20:
                        return "Moss Hornet";
                    case -19:
                        return "Moss Hornet";
                    case -18:
                        return "Moss Hornet";
                    case -17:
                        return "Hornet";
                    case -16:
                        return "Hornet";
                    case -15:
                        return "Armored Skeleton";
                    case -14:
                        return "Angry Bones";
                    case -13:
                        return "Angry Bones";
                    case -12:
                        return "Eater of Souls";
                    case -11:
                        return "Eater of Souls";
                    case -10:
                        return "Jungle Slime";
                    case -9:
                        return "Yellow Slime";
                    case -8:
                        return "Red Slime";
                    case -7:
                        return "Purple Slime";
                    case -6:
                        return "Black Slime";
                    case -5:
                        return "Baby Slime";
                    case -4:
                        return "Pinky";
                    case -3:
                        return "Green Slime";
                    case -2:
                        return "Slimer";
                    case -1:
                        return "Slimeling";
                    case 1:
                        return "Blue Slime";
                    case 2:
                        return "Demon Eye";
                    case 3:
                        return "Zombie";
                    case 4:
                        return "Eye of Cthulhu";
                    case 5:
                        return "Servant of Cthulhu";
                    case 6:
                        return "Eater of Souls";
                    case 7:
                        return "Devourer";
                    case 8:
                        return "Devourer";
                    case 9:
                        return "Devourer";
                    case 10:
                        return "Giant Worm";
                    case 11:
                        return "Giant Worm";
                    case 12:
                        return "Giant Worm";
                    case 13:
                        return "Eater of Worlds";
                    case 14:
                        return "Eater of Worlds";
                    case 15:
                        return "Eater of Worlds";
                    case 16:
                        return "Mother Slime";
                    case 17:
                        return "Merchant";
                    case 18:
                        return "Nurse";
                    case 19:
                        return "Arms Dealer";
                    case 20:
                        return "Dryad";
                    case 21:
                        return "Skeleton";
                    case 22:
                        return "Guide";
                    case 23:
                        return "Meteor Head";
                    case 24:
                        return "Fire Imp";
                    case 25:
                        return "Burning Sphere";
                    case 26:
                        return "White Soldier"; //"Goblin Peon";
                    case 27:
                        return "Black Soldier"; //"Goblin Thief";
                    case 28:
                        return "Goblin Warrior";
                    case 29:
                        return "Goblin Sorcerer";
                    case 30:
                        return "Chaos Ball";
                    case 31:
                        return "Angry Bones";
                    case 32:
                        return "Dark Caster";
                    case 33:
                        return "Water Sphere";
                    case 34:
                        return "Cursed Skull";
                    case 35:
                        return "Skeletron";
                    case 36:
                        return "Skeletron";
                    case 37:
                        return "Old Man";
                    case 38:
                        return "Demolitionist";
                    case 39:
                        return "Bone Serpent";
                    case 40:
                        return "Bone Serpent";
                    case 41:
                        return "Bone Serpent";
                    case 42:
                        return "Hornet";
                    case 43:
                        return "Man Eater";
                    case 44:
                        return "Undead Miner";
                    case 45:
                        return "Tim";
                    case 46:
                        return "Bunny";
                    case 47:
                        return "Corrupt Bunny";
                    case 48:
                        return "Harpy";
                    case 49:
                        return "Cave Bat";
                    case 50:
                        return "King Slime";
                    case 51:
                        return "Black Boss";
                    case 52:
                        return "Doctor Bones";
                    case 53:
                        return "The Groom";
                    case 54:
                        return "Clothier";
                    case 55:
                        return "Goldfish";
                    case 56:
                        return "Snatcher";
                    case 57:
                        return "Corrupt Goldfish";
                    case 58:
                        return "Piranha";
                    case 59:
                        return "Lava Slime";
                    case 60:
                        return "Hellbat";
                    case 61:
                        return "Vulture";
                    case 62:
                        return "Demon";
                    case 63:
                        return "Blue Jellyfish";
                    case 64:
                        return "Pink Jellyfish";
                    case 65:
                        return "Shark";
                    case 66:
                        return "Voodoo Demon";
                    case 67:
                        return "Crab";
                    case 68:
                        return "Dungeon Guardian";
                    case 69:
                        return "White Tower"; //"Antlion";
                    case 70:
                        return "Black Tower"; //"Spike Ball";
                    case 71:
                        return "Dungeon Slime";
                    case 72:
                        return "Blazing Wheel";
                    case 73:
                        return "Goblin Scout";
                    case 74:
                        return "Bird";
                    case 75:
                        return "Pixie";
                    case 77:
                        return "Armored Skeleton";
                    case 78:
                        return "Mummy";
                    case 79:
                        return "Dark Mummy";
                    case 80:
                        return "Light Mummy";
                    case 81:
                        return "Corrupt Slime";
                    case 82:
                        return "Wraith";
                    case 83:
                        return "Cursed Hammer";
                    case 84:
                        return "Enchanted Sword";
                    case 85:
                        return "Mimic";
                    case 86:
                        return "Unicorn";
                    case 87:
                        return "Wyvern";
                    case 88:
                        return "Wyvern";
                    case 89:
                        return "Wyvern";
                    case 90:
                        return "Wyvern";
                    case 91:
                        return "Wyvern";
                    case 92:
                        return "Wyvern";
                    case 93:
                        return "Giant Bat";
                    case 94:
                        return "Corruptor";
                    case 95:
                        return "Digger";
                    case 96:
                        return "Digger";
                    case 97:
                        return "Digger";
                    case 98:
                        return "World Feeder";
                    case 99:
                        return "World Feeder";
                    case 100:
                        return "World Feeder";
                    case 101:
                        return "Clinger";
                    case 102:
                        return "Angler Fish";
                    case 103:
                        return "Green Jellyfish";
                    case 104:
                        return "Werewolf";
                    case 105:
                        return "Bound Goblin";
                    case 106:
                        return "Bound Wizard";
                    case 107:
                        return "Goblin Tinkerer";
                    case 108:
                        return "Wizard";
                    case 109:
                        return "Clown";
                    case 110:
                        return "Skeleton Archer";
                    case 111:
                        return "Goblin Archer";
                    case 112:
                        return "Vile Spit";
                    case 113:
                        return "Wall of Flesh";
                    case 114:
                        return "Wall of Flesh";
                    case 115:
                        return "The Hungry";
                    case 116:
                        return "The Hungry";
                    case 117:
                        return "Leech";
                    case 118:
                        return "Leech";
                    case 119:
                        return "Leech";
                    case 120:
                        return "Chaos Elemental";
                    case 121:
                        return "Slimer";
                    case 122:
                        return "Gastropod";
                    case 123:
                        return "Bound Mechanic";
                    case 124:
                        return "Mechanic";
                    case 125:
                        return "Retinazer";
                    case 126:
                        return "Spazmatism";
                    case 127:
                        return "Skeletron Prime";
                    case 128:
                        return "Prime Cannon";
                    case 129:
                        return "Prime Saw";
                    case 130:
                        return "Prime Vice";
                    case 131:
                        return "Prime Laser";
                    case 132:
                        return "Zombie";
                    case 133:
                        return "Wandering Eye";
                    case 134:
                        return "The Destroyer";
                    case 135:
                        return "The Destroyer";
                    case 136:
                        return "The Destroyer";
                    case 137:
                        return "Illuminant Bat";
                    case 138:
                        return "Illuminant Slime";
                    case 139:
                        return "Probe";
                    case 140:
                        return "Probe";
                    case 141:
                        return "Toxic Sludge";
                    case 142:
                        return "Santa Claus";
                    case 143:
                        return "Snowman Gangsta";
                    case 144:
                        return "Mister Stabby";
                    case 145:
                        return "Snow Balla";
                    case 147:
                        return "Ice Slime";
                    case 148:
                        return "Penguin";
                    case 149:
                        return "Penguin";
                    case 150:
                        return "Ice Bat";
                    case 151:
                        return "Lava Bat";
                    case 152:
                        return "Giant Flying Fox";
                    case 153:
                        return "Giant Tortoise";
                    case 154:
                        return "Ice Tortoise";
                    case 155:
                        return "Wolf";
                    case 156:
                        return "Red Devil";
                    case 157:
                        return "Arapaima";
                    case 158:
                        return "Vampire";
                    case 159:
                        return "Vampire";
                    case 160:
                        return "Truffle";
                    case 161:
                        return "Zombie Eskimo";
                    case 162:
                        return "Frankenstein";
                    case 163:
                        return "Black Recluse";
                    case 164:
                        return "Wall Creeper";
                    case 165:
                        return "Wall Creeper";
                    case 166:
                        return "Swamp Thing";
                    case 167:
                        return "Undead Viking";
                    case 168:
                        return "Corrupt Penguin";
                    case 169:
                        return "Ice Elemental";
                    case 170:
                        return "Pigron";
                    case 171:
                        return "Pigron";
                    case 172:
                        return "Rune Wizard";
                    case 173:
                        return "Crimera";
                    case 174:
                        return "Herpling";
                    case 175:
                        return "Angry Trapper";
                    case 176:
                        return "Moss Hornet";
                    case 177:
                        return "Derpling";
                    case 178:
                        return "Steampunker";
                    case 179:
                        return "Crimson Axe";
                    case 180:
                        return "Pigron";
                    case 181:
                        return "Face Monster";
                    case 182:
                        return "Floaty Gross";
                    case 183:
                        return "Crimslime";
                    case 184:
                        return "Spiked Ice Slime";
                    case 185:
                        return "Snow Flinx";
                    case 186:
                        return "Zombie";
                    case 187:
                        return "Zombie";
                    case 188:
                        return "Zombie";
                    case 189:
                        return "Zombie";
                    case 190:
                        return "Demon Eye";
                    case 191:
                        return "Demon Eye";
                    case 192:
                        return "Demon Eye";
                    case 193:
                        return "Demon Eye";
                    case 194:
                        return "Demon Eye";
                    case 195:
                        return "Lost Girl";
                    case 196:
                        return "Nymph";
                    case 197:
                        return "Armored Viking";
                    case 198:
                        return "Lihzahrd";
                    case 199:
                        return "Lihzahrd";
                    case 200:
                        return "Zombie";
                    case 201:
                        return "Skeleton";
                    case 202:
                        return "Skeleton";
                    case 203:
                        return "Skeleton";
                    case 204:
                        return "Spiked Jungle Slime";
                    case 205:
                        return "Moth";
                    case 206:
                        return "Icy Merman";
                    case 207:
                        return "Dye Trader";
                    case 208:
                        return "Party Girl";
                    case 209:
                        return "Cyborg";
                    case 210:
                        return "Bee";
                    case 211:
                        return "Bee";
                    case 212:
                        return "Pirate Deckhand";
                    case 213:
                        return "Pirate Corsair";
                    case 214:
                        return "Pirate Deadeye";
                    case 215:
                        return "Pirate Crossbower";
                    case 216:
                        return "Pirate Captain";
                    case 217:
                        return "Cochineal Beetle";
                    case 218:
                        return "Cyan Beetle";
                    case 219:
                        return "Lac Beetle";
                    case 220:
                        return "Sea Snail";
                    case 221:
                        return "Squid";
                    case 222:
                        return "Queen Bee";
                    case 223:
                        return "Zombie";
                    case 224:
                        return "Flying Fish";
                    case 225:
                        return "Umbrella Slime";
                    case 226:
                        return "Flying Snake";
                    case 227:
                        return "Painter";
                    case 228:
                        return "Witch Doctor";
                    case 229:
                        return "Pirate";
                    case 230:
                        return "Goldfish";
                    case 231:
                        return "Hornet";
                    case 232:
                        return "Hornet";
                    case 233:
                        return "Hornet";
                    case 234:
                        return "Hornet";
                    case 235:
                        return "Hornet";
                    case 236:
                        return "Jungle Creeper";
                    case 237:
                        return "Jungle Creeper";
                    case 238:
                        return "Black Recluse";
                    case 239:
                        return "Blood Crawler";
                    case 240:
                        return "Blood Crawler";
                    case 241:
                        return "Blood Feeder";
                    case 242:
                        return "Blood Jelly";
                    case 243:
                        return "Ice Golem";
                    case 244:
                        return "Rainbow Slime";
                    case 245:
                        return "Golem";
                    case 246:
                        return "Golem Head";
                    case 247:
                        return "Golem Fist";
                    case 248:
                        return "Golem Fist";
                    case 249:
                        return "Golem Head";
                    case 250:
                        return "Angry Nimbus";
                    case 251:
                        return "Eyezor";
                    case 252:
                        return "Parrot";
                    case 253:
                        return "Reaper";
                    case 254:
                        return "Zombie";
                    case 255:
                        return "Zombie";
                    case 256:
                        return "Fungo Fish";
                    case 257:
                        return "Anomura Fungus";
                    case 258:
                        return "Mushi Ladybug";
                    case 259:
                        return "Fungi Bulb";
                    case 260:
                        return "Giant Fungi Bulb";
                    case 261:
                        return "Fungi Spore";
                    case 262:
                        return "Plantera";
                    case 263:
                        return "Plantera's Hook";
                    case 264:
                        return "Plantera's Tentacle";
                    case 265:
                        return "Spore";
                    case 266:
                        return "Brain of Cthulhu";
                    case 267:
                        return "Creeper";
                    case 268:
                        return "Ichor Sticker";
                    case 269:
                        return "Rusty Armored Bones";
                    case 270:
                        return "Rusty Armored Bones";
                    case 271:
                        return "Rusty Armored Bones";
                    case 272:
                        return "Rusty Armored Bones";
                    case 273:
                        return "Blue Armored Bones";
                    case 274:
                        return "Blue Armored Bones";
                    case 275:
                        return "Blue Armored Bones";
                    case 276:
                        return "White Paladin"; //"Blue Armored Bones";
                    case 277:
                        return "Black Paladin"; //"Hell Armored Bones";
                    case 278:
                        return "Hell Armored Bones";
                    case 279:
                        return "Hell Armored Bones";
                    case 280:
                        return "Hell Armored Bones";
                    case 281:
                        return "Ragged Caster";
                    case 282:
                        return "Ragged Caster";
                    case 283:
                        return "Necromancer";
                    case 284:
                        return "Necromancer";
                    case 285:
                        return "Diabolist";
                    case 286:
                        return "Diabolist";
                    case 287:
                        return "Bone Lee";
                    case 288:
                        return "Dungeon Spirit";
                    case 289:
                        return "Giant Cursed Skull";
                    case 290:
                        return "Paladin";
                    case 291:
                        return "Skeleton Sniper";
                    case 292:
                        return "Tactical Skeleton";
                    case 293:
                        return "Skeleton Commando";
                    case 294:
                        return "Angry Bones";
                    case 295:
                        return "Angry Bones";
                    case 296:
                        return "Angry Bones";
                }
            }
            if (!english && Lang.lang > 1)
            {
                return Lang.npcName(l, true);
            }
            return "";
        }

        public static void tTip()
        {
            for (int i = 1; i < 1615; i++)
            {
                Item item = new Item();
                item.SetDefaults(i, false);
                if (!string.IsNullOrEmpty(item.toolTip2))
                {
                    string.Concat(new object[]
                    {
                        "case ",
                        i,
                        ": return \"",
                        item.toolTip2,
                        "\";"
                    });
                }
            }
        }

        public static string toolTip(int l, bool english = false)
        {
            if (l == 5)
            {
                return "Grants +10 agility and doubles your movement speed bonus from agility for 2 seconds.";
            }
            if (l == 28)
            {
                return "Grants +2 Ability Points to your selected weapon.";
            }
            if (l == 188)
            {
                return "Automatically Consumed on Death";
            }
            if (l == 499)
            {
                return "Heals your entire team for 150 health on use.";
            }
            if (l == 1090)
            {
                return "Increases Maximum Mana by 20";
            }
            if (l == 1091)
            {
                return ""; //"Increases Melee Damage by 12%";
            }
            if (l == 1092)
            {
                return ""; //"Increases Magic Damage by 12%";
            }
            if (l == 1093)
            {
                return ""; //"Increases Ranged Damage by 12%";
            }
            if (l == 1095)
            {
                return "Grants immunity to knockback, and bonus defence when below 35% health.  Automatically block every 4th attack.";
            }
            if (l == 1073)
            {
                return "Requires: Band of the Giant, Band of Starpower";
            }
            if (l == 1074)
            {
                return "Requires: Band of the elder, Shackle";
            }
            if (l == 1075)
            {
                return "Requires: Hermes Boots, Aglet, Anklet of the Wind, Shackle";
            }
            if (l == 1076)
            {
                return "Requires: Cloud in a Bottle, Shiny Red Balloon, Shackle";
            }
            if (l == 1077)
            {
                return "Requires: Star Cloak, Honey Comb, Idol, Metal Scrap";
            }
            if (l == 1078)
            {
                return "Requires: Feral Claws, Titan's Glove";
            }
            if (l == 1079)
            {
                return "Requires: Power Glove, Warrior Emblem";
            }
            if (l == 1080)
            {
                return "Requires: Mechanical Glove, Status Resisting Accessory or Honey Comb";
            }
            if (l == 1081)
            {
                return "Requires: Rifle Scope, Ranger Emblem";
            }
            if (l == 1082)
            {
                return "Requires: Magic Quiver, Ranger Emblem";
            }
            if (l == 1083)
            {
                return "Requires: Paladin's Shield, Metal Scrap, Frozen Turtle Shell, Idol";
            }
            if (l == 1084)
            {
                return "Requires: Hermes Boots, Tabi, Armband, Aglet, Shackle";
            }
            if (l == 1085)
            {
                return "Requires: Panic Necklace, Warrior Emblem";
            }
            if (l == 1086)
            {
                return "Requires: Panic Necklace, Sorcerer Emblem";
            }
            if (l == 1087)
            {
                return "Requires: Panic Necklace, Ranger Emblem";
            }
            if (l == 1088)
            {
                return "Requires: Band of Starpower, Cloud in a Bottle, Sorcerer Emblem";
            }
            if (l == 1089)
            {
                return "Requires: Lexicon, Band of the Elder";
            }
            if (l == 1100)
            {
                return "Increases Maximum HP by 20";
            }
            if (l == 1096)
            {
                return "Requires: Band of the Giant, Band of the Agile";
            }
            if (l == 1097)
            {
                return "Requires: Band of the Eagle, Shackle";
            }
            if (l == 1099)
            {
                return "Requires: Hermes Tabi, Black Belt";
            }
            if (l == 1094 || l == 1098)
            {
                return "Allows the wearer to run very fast";
            }
            if (l == 1104)
            {
                return "Requires: Cobalt Shield, Metal Scrap, Cobalt Bracer, Idol";
            }
            if (l == 1105)
            {
                return "Requires: Hermes Boots, Shiny Red Balloon, Circlet, Armband";
            }
            if (l == 1107)
            {
                return "Requires: Lexicon, Band of the Elder, Enchanted Jewel";
            }
            if (l == 1111)
            {
                return "Increases Maximum Mana by 20, Double Jumps fire 2 arcane bolts";
            }
            if (l == 1112)
            {
                return "Requires: Arcane Cloud Emblem, Shiny Red Boots";
            }
            if (l == 1113)
            {
                return "Requires: Lucky Horseshoe, Lexicon";
            }
            if (l == 1360)
            {
                return "Right-click to increase viewing range.  Increases bullet damage by 8";
            }
            if (l == 1361)
            {
                return "Increases arrow velocity and reduces heat cost by 15%.  Increases arrow damage by 8";
            }
            if (l == 1363)
            {
                return "Increases Maximum Heat by 20";
            }
            if (l == 1364 || l == 1365)
            {
                return "Increases Maximum Heat and Maximum HP by 20";
            }
            if (l == 682)
            {
                return "has 20% lifesteal";
            }
            if (l == 1366 || l == 1367)
            {
                return "Increases Maximum HP by 20";
            }
            if (l == 1368)
            {
                return "Requires: Band of the Giant, Metal Scrap";
            }
            if (l == 1369)
            {
                return "Requires: Band of the Knight, Shackle";
            }
            if (l == 1372)
            {
                return "'W. Garner'";
            }
            if (l == 1373)
            {
                return "'W. Garner'";
            }
            if (l == 1374)
            {
                return "'W. Garner'";
            }
            if (l == 1375)
            {
                return "'W. Garner'";
            }
            if (l == 1419)
            {
                return "'W. Garner'";
            }
            if (l == 1420)
            {
                return "'W. Garner'";
            }
            if (l == 1421)
            {
                return "'W. Garner'";
            }
            if (l == 1425)
            {
                return "'W. Garner'";
            }
            if (l == 1426)
            {
                return "'W. Garner'";
            }
            if (l == 1427)
            {
                return "'W. Garner'";
            }
            if (l == 1428)
            {
                return "'W. Garner'";
            }
            if (l == 1443)
            {
                return "'W. Garner'";
            }
            if (l == 1501)
            {
                return "'W. Garner'";
            }
            if (l == 1573)
            {
                return "'W. Garner'";
            }
            if (l == 1574)
            {
                return "'W. Garner'";
            }
            if (l == 1575)
            {
                return "'W. Garner'";
            }
            if (l == 1422)
            {
                return "'R. Moosdijk'";
            }
            if (l == 1423)
            {
                return "'R. Moosdijk'";
            }
            if (l == 1435)
            {
                return "'R. Moosdijk'";
            }
            if (l == 1424)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1436)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1437)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1438)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1439)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1440)
            {
                return "'V. Costa Moura'";
            }
            if (l == 1442)
            {
                return "'V. Costa Moura'";
            }
            if (l >= 1481 && l <= 1494)
            {
                return "'V. Costa Moura'";
            }
            if (l >= 1476 && l <= 1480)
            {
                return "'J. T. Myhre'";
            }
            if (l >= 1496 && l <= 1499)
            {
                return "'J. T. Myhre'";
            }
            if (l == 1538)
            {
                return "'J. T. Myhre'";
            }
            if (l >= 1539 && l <= 1542)
            {
                return "'A. Craig'";
            }
            if (l == 1433)
            {
                return "'K. Wright'";
            }
            if (l == 1441)
            {
                return "'A. G. Kolf'";
            }
            if (l == 1500)
            {
                return "'A. G. Kolf'";
            }
            if (l == 1495)
            {
                return "'A. G. Kolf'";
            }
            if (l == 1576)
            {
                return "'D. Phelps'";
            }
            if (l == 1577)
            {
                return "'M. J. Duncan'";
            }
            if (l == 1434)
            {
                return "'C. J. Ness'";
            }
            if (l == 1502)
            {
                return "'C. Burczyk'";
            }
            if (Lang.lang <= 1 || english)
            {
                if (l <= 329)
                {
                    if (l <= 88)
                    {
                        if (l <= 23)
                        {
                            if (l <= -37)
                            {
                                if (l == -43)
                                {
                                    return "Can mine Meteorite";
                                }
                                if (l == -37)
                                {
                                    return "Can mine Meteorite";
                                }
                            }
                            else
                            {
                                if (l == -1)
                                {
                                    return "Can mine Meteorite";
                                }
                                if (l == 8)
                                {
                                    return "Provides light";
                                }
                                switch (l)
                                {
                                    case 15:
                                        return "Tells the time";
                                    case 16:
                                        return "Tells the time";
                                    case 17:
                                        return "Tells the time";
                                    case 18:
                                        return "Shows depth";
                                    case 23:
                                        return "'Both tasty and flammable'";
                                }
                            }
                        }
                        else
                        {
                            if (l <= 43)
                            {
                                if (l == 29)
                                {
                                    return "Permanently increases maximum life by 20";
                                }
                                switch (l)
                                {
                                    case 33:
                                        return "Used for smelting ore";
                                    case 34:
                                        break;
                                    case 35:
                                        return "Used to craft items from metal bars";
                                    case 36:
                                        return "Used for basic crafting";
                                    default:
                                        if (l == 43)
                                        {
                                            return "Summons the Eye of Cthulhu";
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 47:
                                        return "Penetrates 5 times";
                                    case 49:
                                        return "Increases Max HP by 20"; //"Slowly regenerates life";
                                    case 50:
                                        return "Gaze in the mirror to return home";
                                    case 51:
                                        return "Pierces infinitely, and is unaffected by gravity";
                                    case 52:
                                    case 55:
                                    case 58:
                                    case 59:
                                    case 60:
                                    case 61:
                                    case 62:
                                    case 63:
                                    case 69:
                                        break;
                                    case 53:
                                        return "Allows the holder to double jump";
                                    case 54:
                                        return "The wearer can run super fast";
                                    case 56:
                                        return "'Pulsing with dark energy'";
                                    case 57:
                                        return "'Pulsing with dark energy'";
                                    case 64:
                                        return "Summons a vile thorn";
                                    case 65:
                                        return "Causes stars to rain from the sky";
                                    case 66:
                                        return "Cleanses the corruption";
                                    case 67:
                                        return "Removes the Hallow";
                                    case 68:
                                        return "'Looks tasty!'";
                                    case 70:
                                        return "Summons the Eater of Worlds";
                                    default:
                                        if (l == 75)
                                        {
                                            return "Disappears after the sunrise";
                                        }
                                        switch (l)
                                        {
                                            case 84:
                                                return "'Get over here!'";
                                            case 85:
                                                return "Can be climbed on";
                                            case 88:
                                                return "Provides light when worn";
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (l <= 197)
                        {
                            if (l <= 175)
                            {
                                switch (l)
                                {
                                    case 98:
                                        return "Applies shark tooth, which is a stacking debuff that lowers defense";
                                    case 100:
                                        return "7% increased melee speed";
                                    case 101:
                                        return "7% increased melee speed";
                                    case 102:
                                        return "7% increased melee speed";
                                    case 103:
                                        return "Able to mine Hellstone";
                                    case 109:
                                        return "Permanently increases maximum mana by 20";
                                    case 111:
                                        return "Increases maximum mana by 20";
                                    case 112:
                                        return "Throws balls of fire";
                                    case 113:
                                        return "Casts a controllable missile";
                                    case 114:
                                        return "Magically moves dirt";
                                    case 115:
                                        return "Creates a magical shadow orb";
                                    case 117:
                                        return "'Warm to the touch'";
                                    case 118:
                                        return "Sometimes dropped by Skeletons and Piranha";
                                    case 120:
                                        return "";
                                    case 121:
                                        return "'Has a Chance to inflict On Fire'";
                                    case 123:
                                        return "7% increased magic damage";
                                    case 124:
                                        return "7% increased magic damage";
                                    case 125:
                                        return "7% increased magic damage";
                                    case 128:
                                        return "Allows flight";
                                    default:
                                        switch (l)
                                        {
                                            case 148:
                                                return "Holding this may attract unwanted attention";
                                            case 149:
                                                return "'It contains strange symbols'";
                                            case 151:
                                                return "5 Increased max Heat"; //"4% increased ranged damage.";
                                            case 152:
                                                return "5 Increased max Heat"; //"4% increased ranged damage.";
                                            case 153:
                                                return "5 Increased max Heat"; //"4% increased ranged damage.";
                                            case 156:
                                                return "Grants immunity to knockback";
                                            case 157:
                                                return "Sprays out a shower of water";
                                            case 158:
                                                return "Increases Critical Strike Chance by 5%";
                                            case 159:
                                                return "Increases jump height";
                                            case 165:
                                                return "Casts a slow moving bolt of water";
                                            case 166:
                                                return "A small explosion that will destroy some tiles";
                                            case 167:
                                                return "A large explosion that will destroy most tiles";
                                            case 168:
                                                return "A small explosion that will not destroy tiles";
                                            default:
                                                if (l == 175)
                                                {
                                                    return "'Hot to the touch'";
                                                }
                                                break;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 186:
                                        return "Increases breath time and allows breathing in water";
                                    case 187:
                                        return "Grants the ability to swim";
                                    case 190:
                                        return "Has a chance to poison enemies";
                                    case 191:
                                        return "Has a chance to poison enemies";
                                    default:
                                        if (l == 193)
                                        {
                                            return "Grants immunity to fire blocks";
                                        }
                                        if (l == 197)
                                        {
                                            return "Shoots fallen stars";
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (l <= 238)
                            {
                                switch (l)
                                {
                                    case 208:
                                        return "'It's pretty, oh so pretty'";
                                    case 216:
                                        return "";
                                    case 217:
                                        break;
                                    case 211:
                                        return "12% increased melee speed";
                                    case 212:
                                        return ""; //"10% increased movement speed";
                                    case 213:
                                        return "Creates grass on dirt";
                                    case 215:
                                        return "'May annoy others'";
                                    case 218:
                                        return "Summons a controllable ball of fire";
                                    default:
                                        switch (l)
                                        {
                                            case 222:
                                                return "Grows plants";
                                            case 223:
                                                return "6% reduced mana usage";
                                            case 228:
                                                return "Increases maximum mana by 10";
                                            case 229:
                                                return "Increases maximum mana by 10";
                                            case 230:
                                                return "Increases maximum mana by 10";
                                            default:
                                                switch (l)
                                                {
                                                    case 235:
                                                        return "'Tossing may be difficult.'";
                                                    case 237:
                                                        return "'Makes you look cool!'";
                                                    case 238:
                                                        return ""; //"5% increased magic damage";
                                                }
                                                break;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 261:
                                        return "'It's smiling, might be a good snack'";
                                    case 265:
                                        return "Has a 1/3 chance to pierce knockback immunity";
                                    case 266:
                                        return "'This is a good idea!'";
                                    case 267:
                                        return "'You are a terrible person.'";
                                    case 268:
                                        return "Greatly extends underwater breathing";
                                    case 272:
                                        return "Casts a demon scythe";
                                    case 281:
                                        return "Allows the collection of seeds for ammo";
                                    case 282:
                                        return "Works when wet";
                                    case 283:
                                        return "For use with Blowpipe";
                                    case 285:
                                        return ""; //"5% increased movement speed";
                                    case 288:
                                        return "Provides immunity to lava";
                                    case 289:
                                        return "Provides life regeneration";
                                    case 290:
                                        return "25% increased movement speed";
                                    case 291:
                                        return "Breathe water instead of air";
                                    case 292:
                                        return "Increase defense by 8";
                                    case 293:
                                        return "Increased mana regeneration";
                                    case 294:
                                        return "20% increased magic damage";
                                    case 295:
                                        return "Slows falling speed";
                                    case 296:
                                        return "Shows the location of treasure and ore";
                                    case 297:
                                        return "Grants invisibility";
                                    case 298:
                                        return "Emits an aura of light";
                                    case 299:
                                        return "Increases night vision";
                                    case 300:
                                        return "Increases enemy spawn rate";
                                    case 301:
                                        return "Attackers also take damage";
                                    case 302:
                                        return "Allows the ability to walk on water";
                                    case 303:
                                        return "20% increased arrow speed and damage";
                                    case 304:
                                        return "Shows the location of enemies";
                                    case 305:
                                        return "Allows the control of gravity";
                                    default:
                                        if (l == 324)
                                        {
                                            return "'Banned in most places'";
                                        }
                                        switch (l)
                                        {
                                            case 327:
                                                return "Opens one Gold Chest";
                                            case 329:
                                                return "Opens all Shadow Chests";
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (l <= 726)
                    {
                        if (l <= 603)
                        {
                            if (l <= 407)
                            {
                                if (l == 332)
                                {
                                    return "Used for crafting cloth";
                                }
                                if (l == 352)
                                {
                                    return "Used for brewing ale";
                                }
                                switch (l)
                                {
                                    case 357:
                                        return "Minor improvements to all stats";
                                    case 361:
                                        return "Summons a Goblin Army";
                                    case 363:
                                        return "Used for advanced wood crafting";
                                    case 367:
                                        return "Strong enough to destroy Demon Altars";
                                    case 371:
                                        return "Increases maximum mana by 40";
                                    case 372:
                                        return "3% increased Melee Crit";
                                    case 373:
                                        return "10% increased ranged damage";
                                    case 374:
                                        return "3% increased Melee Crit";
                                    case 375:
                                        return "3% increased Melee Crit";
                                    case 376:
                                        return "Increases maximum mana by 15";
                                    case 377:
                                        return "5% increased melee critical strike chance";
                                    case 378:
                                        return "12% increased ranged damage";
                                    case 379:
                                        return "Increases maximum mana by 15";
                                    case 380:
                                        return "Increases maximum mana by 15";
                                    case 385:
                                        return "Can mine Mythril and Orichalcum";
                                    case 386:
                                        return "Can mine Adamantite and Titanium";
                                    case 389:
                                        return "Has a chance to confuse";
                                    case 393:
                                        return "Shows horizontal position";
                                    case 394:
                                        return "Grants the ability to swim";
                                    case 395:
                                        return "Shows position";
                                    case 396:
                                        return "Negates fall damage";
                                    case 397:
                                        return "Grants immunity to knockback";
                                    case 398:
                                        return "Allows the combining of some accessories";
                                    case 399:
                                        return "Allows the holder to double jump";
                                    case 400:
                                        return "Increases maximum mana by 80";
                                    case 401:
                                        return "7% increased melee critical strike chance";
                                    case 402:
                                        return "";
                                    case 403:
                                        return "";
                                    case 404:
                                        return "";
                                    case 405:
                                        return "Allows flight";
                                    case 407:
                                        return "Increases block placement range";
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 422:
                                        return "Spreads the Hallow to some blocks";
                                    case 423:
                                        return "Spreads the corruption to some blocks";
                                    case 424:
                                        break;
                                    case 425:
                                        return "Summons a magical fairy that dispells all debuffs";
                                    default:
                                        if (l == 434)
                                        {
                                            return "Three round burst";
                                        }
                                        switch (l)
                                        {
                                            case 485:
                                                return "Turns the holder into a werewolf at night";
                                            case 486:
                                                return "Creates a grid on screen for block placement";
                                            case 489:
                                                return ""; //"15% increased magic damage";
                                            case 490:
                                                return ""; //"15% increased melee damage";
                                            case 491:
                                                return ""; //"15% increased ranged damage";
                                            case 492:
                                                return "Allows flight and slow fall";
                                            case 493:
                                                return "Allows flight and slow fall";
                                            case 495:
                                                return "Casts a controllable rainbow";
                                            case 496:
                                                return "Summons a block of ice";
                                            case 497:
                                                return "Transforms the holder into merfolk when entering water";
                                            case 506:
                                                return "Uses gel for ammo";
                                            case 509:
                                                return "Places red wire";
                                            case 510:
                                                return "Removes wire";
                                            case 515:
                                                return "Creates several crystal shards on impact";
                                            case 516:
                                                return "Summons falling stars on impact";
                                            case 517:
                                                return "A magical returning dagger";
                                            case 518:
                                                return "Summons rapid fire crystal shards";
                                            case 519:
                                                return "Summons unholy fire balls";
                                            case 520:
                                                return "'The essence of light creatures'";

                                                return "'The essence of dark creatures'";
                                            case 522:
                                                return "'Not even water can put the flame out'";
                                            case 523:
                                                return "Can be placed in water";
                                            case 524:
                                                return "Used to smelt adamantite and titanium ore";
                                            case 525:
                                                return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
                                            case 526:
                                                return "'Sharp and magical!'";
                                            case 527:
                                                return "'Sometimes carried by creatures in corrupt deserts'";
                                            case 528:
                                                return "'Sometimes carried by creatures in light deserts'";
                                            case 529:
                                                return "Activates when stepped on";
                                            case 531:
                                                return "Can be enchanted";
                                            case 532:
                                                return "Causes stars to fall when injured";
                                            case 533:
                                                return "50% chance to not consume ammo";
                                            case 534:
                                                return "Fires a spread of bullets";
                                            case 535:
                                                return "Reduces the cooldown of healing potions";
                                            case 536:
                                                return "Gives melee weapons a 1/4 chance to pierce knockback resistance";
                                            case 541:
                                                return "Activates when stepped on";
                                            case 542:
                                                return "Activates when a player steps on it on";
                                            case 543:
                                                return "Activates when a player steps on it on";
                                            case 544:
                                                return "Summons The Twins";
                                            case 547:
                                                return "'The essence of pure terror'";
                                            case 548:
                                                return "'The essence of the destroyer'";
                                            case 549:
                                                return "'The essence of omniscient watchers'";
                                            case 551:
                                                return "Increases maximum mana by 20";
                                            case 552:
                                                return "Increases maximum mana by 20";
                                            case 553:
                                                return "15% increased ranged damage";
                                            case 554:
                                                return "Increases length of invincibility after taking damage";
                                            case 555:
                                                return "8% reduced mana usage";
                                            case 556:
                                                return "Summons Destroyer";
                                            case 557:
                                                return "Summons Skeletron Prime";
                                            case 558:
                                                return "Increases maximum mana by 20";
                                            case 559:
                                                return "10% increased melee damage and critical strike chance";
                                            case 560:
                                                return "Summons King Slime";
                                            case 561:
                                                return "";
                                            case 575:
                                                return "'The essence of powerful flying creatures'";
                                            case 576:
                                                return "Has a chance to record songs";
                                            case 579:
                                                return "'Not to be confused with a picksaw'";
                                            case 580:
                                                return "Explodes when activated";
                                            case 581:
                                                return "Sends water to outlet pumps";
                                            case 582:
                                                return "Receives water from inlet pumps";
                                            case 583:
                                                return "Activates every second";
                                            case 584:
                                                return "Activates every 3 seconds";
                                            case 585:
                                                return "Activates every 5 seconds";
                                            case 599:
                                                return "Right click to open";
                                            case 600:
                                                return "Right click to open";
                                            case 601:
                                                return "Right click to open";
                                            case 602:
                                                return "Summons the Frost Legion";
                                            case 603:
                                                return "Summons a pet bunny";
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (l <= 686)
                            {
                                switch (l)
                                {
                                    case 665:
                                        return "You shouldn't have this";
                                    case 666:
                                        return "You shouldn't have this";
                                    case 667:
                                        return "You shouldn't have this";
                                    case 668:
                                        return "You shouldn't have this";
                                    case 669:
                                        return "Summons a baby penguin";
                                    default:
                                        if (l == 676)
                                        {
                                            return "Shoots an icy bolt";
                                        }
                                        switch (l)
                                        {
                                            case 683:
                                                return "Summons the Devil's trident";
                                            case 684:
                                                return "16% increased melee and ranged damage";
                                            case 685:
                                                return "11% increased melee and ranged critical strike chance";
                                            case 686:
                                                return "8% increased movement speed";
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 707:
                                        return "Tells the time";
                                    case 708:
                                        return "Tells the time";
                                    case 709:
                                        return "Tells the time";
                                    default:
                                        if (l == 716)
                                        {
                                            return "Used to craft items from metal bars";
                                        }
                                        switch (l)
                                        {
                                            case 723:
                                                return "Shoots a beam of light";
                                            case 724:
                                                return "Shoots an icy bolt";
                                            case 725:
                                                return "";
                                            case 726:
                                                return "Shoots a stream of frost";
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (l <= 832)
                        {
                            if (l <= 761)
                            {
                                switch (l)
                                {
                                    case 748:
                                        return "Allows flight and slow fall";
                                    case 749:
                                        return "Allows flight and slow fall";
                                    default:
                                        if (l == 753)
                                        {
                                            return "Summons a pet turtle";
                                        }
                                        if (l == 761)
                                        {
                                            return "Allows flight and slow fall";
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (l)
                                {
                                    case 779:
                                        return "Creates and destroys biomes when sprayed";
                                    case 780:
                                        return "Used by the Clentaminator";
                                    case 781:
                                        return "Used by the Clentaminator";
                                    case 782:
                                        return "Used by the Clentaminator";
                                    case 783:
                                        return "Used by the Clentaminator";
                                    case 784:
                                        return "Used by the Clentaminator";
                                    case 785:
                                        return "Allows flight and slow fall";
                                    case 786:
                                        return "Allows flight and slow fall";
                                    case 787:
                                        return "Strong enough to destroy Demon Altars";
                                    case 788:
                                        return "Summons a thorn spear";
                                    case 789:
                                    case 790:
                                    case 791:
                                    case 795:
                                    case 796:
                                    case 797:
                                        break;
                                    case 792:
                                        return "15% increased Melee Speed";
                                    case 793:
                                        return "15% increased Melee Speed";
                                    case 794:
                                        return "15% increased Melee Speed";
                                    case 798:
                                        return "Able to mine Hellstone";
                                    default:
                                        switch (l)
                                        {
                                            case 821:
                                                return "Allows flight and slow fall";
                                            case 822:
                                                return "Allows flight and slow fall";
                                            case 823:
                                                return "Allows flight and slow fall";
                                            default:
                                                if (l == 832)
                                                {
                                                    return "Places living wood";
                                                }
                                                break;
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            //if (l <= 1343)
                            {
                                switch (l)
                                {
                                    case 849:
                                        return "Enables solid blocks to be toggled on and off";
                                    case 850:
                                        return "Places blue wire";
                                    case 851:
                                        return "Places green wire";
                                    case 852:
                                        return "Activates when a player steps on it on";
                                    case 853:
                                        return "Activates when anything but a player steps on it on";
                                    case 854:
                                        return "Shops have lower prices";
                                    case 855:
                                        return "Hitting enemies will sometimes drop extra coins";
                                    case 856:
                                        return "'Having a wonderful time!'";
                                    case 857:
                                        return "Allows the holder to do an improved double jump";
                                    case 858:
                                    case 859:
                                    case 864:
                                    case 865:
                                    case 866:
                                    case 867:
                                    case 868:
                                    case 869:
                                    case 870:
                                    case 871:
                                    case 872:
                                    case 873:
                                    case 874:
                                    case 875:
                                    case 876:
                                    case 877:
                                    case 878:
                                    case 879:
                                    case 880:
                                    case 881:
                                    case 882:
                                    case 883:
                                    case 884:
                                    case 894:
                                    case 895:
                                    case 896:
                                    case 909:
                                    case 910:
                                    case 911:
                                    case 912:
                                    case 913:
                                    case 914:
                                    case 915:
                                    case 916:
                                    case 917:
                                    case 918:
                                    case 919:
                                    case 920:
                                    case 921:
                                    case 922:
                                    case 923:
                                    case 924:
                                    case 925:
                                    case 926:
                                    case 927:
                                    case 928:
                                    case 929:
                                    case 930:
                                    case 931:
                                    case 939:
                                    case 940:
                                    case 941:
                                    case 942:
                                    case 943:
                                    case 944:
                                    case 945:
                                    case 949:
                                    case 952:
                                    case 954:
                                    case 955:
                                    case 970:
                                    case 971:
                                    case 972:
                                    case 973:
                                    case 974:
                                    case 979:
                                    case 980:
                                    case 981:
                                    case 988:
                                    case 992:
                                    case 993:
                                    case 999:
                                        break;
                                    case 860:
                                        return "Provides life regeneration and reduces the cooldown of healing potions";
                                    case 861:
                                        return "Turns the holder into a werewolf at night and a merfolk when entering water";
                                    case 862:
                                        return "Causes stars to fall and increases length of invincibility after taking damage";
                                    case 863:
                                        return "Provides the ability to walk on water";
                                    case 885:
                                        return "Immunity to Venom";
                                    case 886:
                                        return "Immunity to Broken Armor";
                                    case 887:
                                        return "Immunity to Poison";
                                    case 888:
                                        return "Immunity to Darkness";
                                    case 889:
                                        return "Immunity to Slow";
                                    case 890:
                                        return "Immunity to Silence";
                                    case 891:
                                        return "Immunity to Curse";
                                    case 892:
                                        return "Immunity to Weakness";
                                    case 893:
                                        return "Immunity to Confusion";
                                    case 897:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance";
                                    case 898:
                                        return ""; //"increases Movespeed by 15%"; //"Allows flight";
                                    case 899:
                                        return "Increases all stats if worn during the day";
                                    case 900:
                                        return "Increases all stats if worn during the night";
                                    case 901:
                                        return "Immunity to Weakness and Broken Armor";
                                    case 902:
                                        return "Immunity to Poison and Bleeding";
                                    case 903:
                                        return "Immunity to Slow and Confusion";
                                    case 904:
                                        return "Immunity to Silence and Curse";
                                    case 905:
                                        return "Uses coins for ammo";
                                    case 906:
                                        return "Provides 7 seconds of immunity to lava";
                                    case 907:
                                        return "Provides the ability to walk on water";
                                    case 908:
                                        return "Provides the ability to walk on water and lava";
                                    case 932:
                                        return "Places bone";
                                    case 934:
                                        return "Allows the owner to float for a few seconds";
                                    case 935:
                                        return "10% increased critical hit chance";
                                    case 936:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance";
                                    case 937:
                                        return "Explodes when stepped on";
                                    case 938:
                                        return "Provides knockback immunity.  Absorbs 25% of damage done to players on your team";
                                    case 946:
                                        return "You will fall slower while holding this";
                                    case 947:
                                        return "Reacts to the light";
                                    case 948:
                                        return "Allows flight and slowfall";
                                    case 950:
                                        return "Provides extra mobility on ice";
                                    case 951:
                                        return "Rapidly launches snowballs";
                                    case 953:
                                        return "Allows the ability to slide down walls";
                                    case 956:
                                        return "7% increased melee speed";
                                    case 957:
                                        return "7% increased melee speed";
                                    case 958:
                                        return "7% increased melee speed";
                                    case 959:
                                        return "4% increased ranged damage.";
                                    case 960:
                                        return "Increases maximum mana by 20";
                                    case 961:
                                        return "Increases maximum mana by 20";
                                    case 962:
                                        return "Increases maximum mana by 20";
                                    case 963:
                                        return "Gives a chance to dodge attacks";
                                    case 964:
                                        return "Fires a spread of bullets";
                                    case 965:
                                        return "Can be climbed on";
                                    case 966:
                                        return "Life regen is increased when near a campfire";
                                    case 967:
                                        return "Put it on a stick and roast over a campfire";
                                    case 968:
                                        return "Roast it over a campfire!";
                                    case 969:
                                        return "Minor improvements to all stats";
                                    case 975:
                                        return "Allows the ability to slide down walls";
                                    case 976:
                                        return "Allows the ability to climb walls";
                                    case 977:
                                        return "Allows the ability to dash";
                                    case 982:
                                        return "Increases maximum mana by 20";
                                    case 983:
                                        return "Allows the holder to double jump";
                                    case 984:
                                        return "Allows the ability to climb walls and dash";
                                    case 985:
                                        return "Throw to create a climbable line of rope";
                                    case 986:
                                        return "Allows the collection of seeds for ammo";
                                    case 987:
                                        return "Allows the holder to double jump";
                                    case 989:
                                        return "Shoots an enchanted sword beam";
                                    case 990:
                                        return "'Not to be confused with a hamdrill'";
                                    case 994:
                                        return "Summons a Baby Eater of Souls";
                                    case 995:
                                        return "Used to craft objects";
                                    case 996:
                                        return "Used to craft objects";
                                    case 997:
                                        return "Turns silt/slush into something more useful";
                                    case 998:
                                        return "Used to craft objects";
                                    case 1000:
                                        return "Shoots confetti everywhere!";
                                    case 1001:
                                        return "16% increased melee damage";
                                    case 1002:
                                        return ""; //"8% increased ranged damage";
                                    case 1003:
                                        return "Increases maximum mana by 80 and reduces mana usage by 17%";
                                    case 1004:
                                        return ""; //"8% increased ranged damage";
                                    case 1005:
                                        return ""; //"8% increased ranged damage";
                                    case 1006:
                                        return "Reacts to the light";
                                            case 1071:
                                                return "Used with paint to color blocks";
                                            case 1072:
                                                return "Used with paint to color walls";
                                            default:
                                                switch (l)
                                                {
                                                    case 1100:
                                                        return "Used to remove paint";
                                                    case 1107:
                                                        return "Used to make Teal Dye";
                                                    case 1108:
                                                        return "Allows the wearer to run and jump very quickly";
                                                    case 1109:
                                                        return "Melee Attacks spawn bees when hitting enemy units";
                                                    case 1110:
                                                        return "Heals wearer for 50% of mana cost when spending mana";
                                                    case 1111:
                                                        return "Allows the wearer to run and jump very quickly";
                                                    case 1112:
                                                        return "";
                                                    case 1113:
                                                        return "Used to make Pink Dye";
                                                    case 1114:
                                                        return "";
                                                    case 1115:
                                                        return "Used to make Red Dye";
                                                    case 1116:
                                                        return "Used to make Cyan Dye";
                                                    case 1117:
                                                        return "Used to make Violet Dye";
                                                    case 1118:
                                                        return "Used to make Purple Dye";
                                                    case 1119:
                                                        return "Used to make Black Dye";
                                                    case 1120:
                                                        return "Used to Craft Dyes";
                                                    case 1121:
                                                        return "Shoots bees that will chase your enemy";
                                                    case 1122:
                                                        return "Chases after your enemy";
                                                    case 1123:
                                                        return "Summons killer bees after striking your foe";
                                                    case 1129:
                                                        return "Places Hives";
                                                    case 1130:
                                                        return "Explodes into a swarm of bees";
                                                    case 1131:
                                                        return "Allows the holder to reverse gravity";
                                                    case 1132:
                                                        return "Releases bees when damaged";
                                                    case 1133:
                                                        return "Summons the Queen Bee";
                                                    case 1141:
                                                        return "Opens the jungle temple door";
                                                    case 1145:
                                                        return "Used for basic crafting";
                                                    case 1151:
                                                        return "Activates when a player steps on it on";
                                                    case 1156:
                                                        return "Latches on to enemies for continuous damage";
                                                    case 1157:
                                                        return "Summons a Pygmy to fight for you";
                                                    case 1158:
                                                        return "Increases your max number of minions";
                                                    case 1159:
                                                        return "Increases your max number of minions";
                                                    case 1160:
                                                        return "Increases your max number of minions";
                                                    case 1161:
                                                        return "Increases your max number of minions";
                                                    case 1162:
                                                        return "Allows flight and slow fall";
                                                    case 1163:
                                                        return "Allows the holder to double jump";
                                                    case 1164:
                                                        return "Allows the holder to quadruple jump";
                                                    case 1165:
                                                        return "Allows flight and slow fall";
                                                    case 1167:
                                                        return "Increases the damage of your minions by 15";
                                                    case 1169:
                                                        return "Summons a Baby Skeletron Head";
                                                    case 1170:
                                                        return "Summons a Baby Hornet";
                                                    case 1171:
                                                        return ""; //"Summons a Tiki Spirit";
                                                    case 1172:
                                                        return "Summons a Pet Lizard";
                                                    case 1178:
                                                        return "Rapidly shoots razor sharp leaves";
                                                    case 1179:
                                                        return "Chases after your enemy";
                                                    case 1180:
                                                        return "Summons a Pet Parrot";
                                                    case 1181:
                                                        return "Summons a Baby Truffle";
                                                    case 1182:
                                                        return "Summons a Pet Sapling";
                                                    case 1183:
                                                        return "Summons a Wisp to provide light";
                                                    case 1188:
                                                        return "Can mine Mythril, Orichalcum, Adamantite, and Titanium";
                                                    case 1189:
                                                        return "Can mine Mythril, Orichalcum, Adamantite, and Titanium";
                                                    case 1195:
                                                        return "Can mine Adamantite and Titanium";
                                                    case 1196:
                                                        return "Can mine Adamantite and Titanium";
                                                    case 1205:
                                                        return "12% increased melee speed";
                                                    case 1208:
                                                        return "12% increased melee speed";
                                                    case 1209:
                                                        return "12% increased melee speed";
                                                    case 1206:
                                                        return "9% increased ranged damage";
                                                    case 1207:
                                                        return "7% increased magic damage and critical strike chance";
                                                    case 1210:
                                                    case 1211:
                                                        return "15% increased ranged critical strike chance";
                                                    case 1215:
                                                        return "8% increased melee damage and critical strike chance";
                                                    case 1216:
                                                        return ""; //"8% increased movement speed";
                                                        return "16% increased magic damage and 7% increased magic critical strike chance";
                                                    case 1218:
                                                        return ""; //"8% increased movement speed";
                                                    case 1219:
                                                        return ""; //"8% increased movement speed";
                                                    case 1220:
                                                        return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
                                                    case 1221:
                                                        return "Used to smelt adamantite and titanium ore";
                                                    case 1226:
                                                        return "Shoots a powerful orb";
                                                    case 1227:
                                                        return "Shoots a spore cloud";
                                                    case 1228:
                                                        return "Shoots a spore cloud";
                                                    case 1235:
                                                        return "Bounces back after hitting a wall";
                                                    case 1238:
                                                        return "Press E to shoot a grappling hook";
                                                    case 1240:
                                                        return "Press E to shoot a grappling hook";
                                                    case 1242:
                                                        return "Summons a Baby Dinosaur";
                                                    case 1244:
                                                        return "Summons a cloud to rain down on your foes";
                                                    case 1247:
                                                        return "Causes stars to fall and releases bees when injured";
                                                    case 1248:
                                                        return "10% increased critical strike chance";
                                                    case 1249:
                                                        return "increases jump height";
                                                    case 1250:
                                                        return "Allows the holder to double jump";
                                                    case 1251:
                                                        return "Allows the holder to double jump";
                                                    case 1252:
                                                        return "Allows the holder to double jump";
                                                    case 1253:
                                                        return "Puts a shell around the owner when below 35% life that reduces damage";
                                                    case 1254:
                                                        return "Shoots a powerful, high velocity bullet";
                                                    case 1255:
                                                        return "Shoots a powerful, high velocity bullet";
                                                    case 1256:
                                                        return "Summons a cloud to rain blood on your foes";
                                                    case 1258:
                                                        return "Shoots an explosive bolt";
                                                    case 1259:
                                                        return "Shoots razor sharp flower petals at nearby enemies";
                                                    case 1260:
                                                        return "Shoots a rainbow that does continuous damage";
                                                    case 1261:
                                                        return "Explodes into deadly shrapnel";
                                                    case 1264:
                                                        return "Shoots a ball of frost";
                                                    case 1265:
                                                        return "Shoots a powerful, high velocity bullet";
                                                    case 1282:
                                                        return ""; //"Increases maximum mana by 20";
                                                    case 1283:
                                                        return "Increases maximum mana by 40";
                                                    case 1284:
                                                        return "Increases maximum mana by 40";
                                                    case 1285:
                                                        return "Increases maximum mana by 60";
                                                    case 1286:
                                                        return "Increases maximum mana by 60";
                                                    case 1287:
                                                        return "Increases maximum mana by 80";
                                                    case 1290:
                                                        return "Increases movement speed when below 35% HP";
                                                    case 1291:
                                                        return "Permanently increases maximum life by 5";
                                                    case 1293:
                                                        return "Used at the Lihzahrd Altar";
                                                    case 1294:
                                                        return "Capable of mining Lihzahrd Bricks";
                                                    case 1295:
                                                        return "Shoots a piercing ray of heat";
                                                    case 1296:
                                                        return "Summons a powerful boulder";
                                                    case 1297:
                                                        return "Punches with the force of a golem";
                                                    case 1299:
                                                        return "Increases view range when held";
                                                    case 1300:
                                                        return "Right-click to increase viewing range";
                                                    case 1301:
                                                        return "10% increased damage";
                                                    case 1303:
                                                        return "Provides light under water";
                                                    case 1306:
                                                        return "Shoots an icy sickle";
                                                    case 1307:
                                                        return "'You are a terrible person'";
                                                    case 1308:
                                                        return "Shoots a poison fang that pierces multiple enemies";
                                                    case 1309:
                                                        return "Summons a baby slime to fight for you";
                                                    case 1310:
                                                        return "Inflicts poison on enemies";
                                                    case 1311:
                                                        return "Summons an eyeball spring";
                                                    case 1312:
                                                        return "Summons a baby snowman";
                                                    case 1313:
                                                        return "Shoots a skull";
                                                    case 1314:
                                                        return "Shoots a boxing glove";
                                                    case 1315:
                                                        return "summons a pirate invasion";
                                                    case 1316:
                                                        return ""; //"5% increased melee damage";
                                                    case 1317:
                                                        return ""; //"5% increased melee damage";
                                                    case 1318:
                                                        return ""; //"5% increased melee damage";
                                                    case 1321:
                                                        return "Increases arrow speed by 10% and reduces heat cost by 15%";
                                                    case 1322:
                                                        return "Immunity to On Fire"; //"Inflicts fire damage on attack";
                                                    case 1323:
                                                        return "Reduces damage from touching lava";
                                                    case 1326:
                                                        return "Press Q to teleport to the position of the mouse";
                                                    case 1327:
                                                        return "Shoots a deathly sickle";
                                                    case 1331:
                                                        return "Summons the Brain of Cthulhu";
                                                    case 1332:
                                                        return "'The blood of gods'";
                                                    case 1334:
                                                        return "Decreases target's defense";
                                                    case 1335:
                                                        return "Decreases target's defense";
                                                    case 1336:
                                                        return "Sprays a shower of ichor";
                                                    case 1343:
                                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts fire on attack";
                                        }
                                        break;
                                }
                                switch (l)
                                {
                                    case 1344:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts poison on attack";
                                    case 1345:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts slow on attack";
                                    case 1346:
                                        return "Give melee weapons a 1/4 chance to pierce knockback resistance and inflicts darkness on attack";
                                    case 1347:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts broken armor on attack";
                                    case 1348:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts venom on attack";
                                    case 1349:
                                        return "Gives melee weapons a 1/4 chance to pierce knockback resistance and inflicts silence on attack";
                                    case 1430:
                                        return "Used to craft weapon imbuement flasks";
                                    case 1431:
                                        break;
                                    case 1432:
                                        return "Used to craft various types of ammo";
                                    default:
                                        switch (l)
                                        {
                                            case 1444:
                                                return "Creates a shadow beam that bounces off walls";
                                            case 1445:
                                                return "Launches a ball of fire that explodes into a raging inferno";
                                            case 1446:
                                                return "Summons up to 3 purple clouds that rain down on foes";
                                            case 1447:
                                            case 1448:
                                                break;
                                            case 1449:
                                                return "Blows bubbles";
                                            case 1450:
                                                return "Blows bubbles";
                                            default:
                                                switch (l)
                                                {
                                                    case 1503:
                                                        return "5% increased magic crit";
                                                    case 1504:
                                                        return "5% increased magic crit";
                                                    case 1505:
                                                        return "5% increased magic crit";
                                                    case 1513:
                                                        return "A powerful returning hammer";
                                                    case 1515:
                                                        return "Allows flight and slow fall";
                                                    case 1522:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1523:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1524:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1525:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1526:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1527:
                                                        return "For Capture the Gem. It drops when you die";
                                                    case 1533:
                                                        return "Unlocks a Jungle Chest in the dungeon";
                                                    case 1534:
                                                        return "Unlocks a Corruption Chest in the dungeon";
                                                    case 1535:
                                                        return "Unlocks a Crimson Chest in the dungeon";
                                                    case 1536:
                                                        return "Unlocks a Hallowed Chest in the dungeon";
                                                    case 1537:
                                                        return "Unlocks a Frozen Chest in the dungeon";
                                                    case 1543:
                                                        return "Used with paint to color blocks";
                                                    case 1544:
                                                        return "Used with paint to color walls";
                                                    case 1545:
                                                        return "Used to remove paint";
                                                    case 1546:
                                                        return "15% increased arrow damage";
                                                    case 1547:
                                                        return "15% increased bullet damage";
                                                    case 1548:
                                                        return "8% increased ranged crit";
                                                    case 1549:
                                                        return "8% increased ranged crit";
                                                    case 1550:
                                                        return "8% increased ranged crit";
                                                    case 1551:
                                                        return "Converts Chlorophyte Bars into Shroomite Bars";
                                                    case 1553:
                                                        return "50% chance to not consume ammo";
                                                    case 1554:
                                                        return ""; //"You shouldn't have this";
                                                    case 1555:
                                                        return "You shouldn't have this";
                                                    case 1556:
                                                        return "You shouldn't have this";
                                                    case 1557:
                                                        return "You shouldn't have this";
                                                    case 1558:
                                                        return "You shouldn't have this";
                                                    case 1559:
                                                        return "You shouldn't have this";
                                                    case 1560:
                                                        return "You shouldn't have this";
                                                    case 1561:
                                                        return "You shouldn't have this";
                                                    case 1562:
                                                        return "You shouldn't have this";
                                                    case 1563:
                                                        return "You shouldn't have this";
                                                    case 1564:
                                                        return "You shouldn't have this";
                                                    case 1565:
                                                        return "You shouldn't have this";
                                                    case 1566:
                                                        return "You shouldn't have this";
                                                    case 1567:
                                                        return "You shouldn't have this";
                                                    case 1568:
                                                        return "You shouldn't have this";
                                                    case 1569:
                                                        return "Rapidly throw life stealing daggers";
                                                    case 1571:
                                                        return "A powerful javelin that unleashes tiny eaters";
                                                    case 1572:
                                                        return "Summons a powerful frost hydra to spit ice at your enemies";
                                                    case 1578:
                                                        return "Releases bees and increases movement speed when damaged";
                                                    case 1579:
                                                        return "The wearer can run super fast";
                                                    case 1580:
                                                        return "You shouldn't have this";
                                                    case 1581:
                                                        return "You shouldn't have this";
                                                    case 1582:
                                                        return "You shouldn't have this";
                                                    case 1583:
                                                        return "You shouldn't have this";
                                                    case 1584:
                                                        return "You shouldn't have this";
                                                    case 1585:
                                                        return "You shouldn't have this";
                                                    case 1586:
                                                        return "You shouldn't have this";
                                                    case 1587:
                                                        return "You shouldn't have this";
                                                    case 1588:
                                                        return "You shouldn't have this";
                                                    case 1595:
                                                        return "Increases maximum mana and HP by 20";
                                                    case 1612:
                                                        return "Grants immunity to most debuffs";
                                                    case 1613:
                                                        return "Grants immunity to knockback and fire blocks";
                                                    default:
                                                        return "";
                                                }
                                        }
                                        break;
                                }
                                return "";
                            }
                        }
                    }
                }
            }
            return "";
        }

        public static string toolTip2(int l, bool english = false)
        {
            if (Lang.lang <= 1 || english)
            {
                if (l == 654) return "Applies confusion, which swaps your directional controls";
                if (l == 517) return "hold shift to spend 40 mana and teleport to the dagger on hit";
                if (l == 887 || l == 190 || l == 191) return "Poison deals low damage over time and reduces your damage output by 10%";
                if (l == 888 || l == 273) return "Darkness gives you a 1/2 chance to miss enemy heroes with attacks";
                if (l == 889) return "Slow cuts your movement speed in half";
                if (l == 890) return "Silence prevents you from using magic weapons, and disables arcane bolts";
                if (l == 886 || l == 1347) return "Broken Armor cuts your defense in half";
                if (l == 885 || l == 1341 || l == 1342) return "Venom deals very high damage over time";
                if (l == 220) return "applies burning, which deals heavy damage over time and halves movement speed";
                if (l == 670 || l == 7) return "applies chilled, which disables the ability to jump";
                if (l == 725 || l == 367) return "applies frozen, which disables movement and attacking";
                if (l == 988 || l == 673 || l == 657) return "applies frostburn, which deals low damage over time and reduces movement speed by 30%";
                if (l == 546 || l == 545) return "applies cursed flames, which deals moderate damage over time and reduces defense by 8";
                if (l == 66) return "applies drain, which deals moderate damage over time and heals you for the same amount";
                if (l == 67) return "applies doom, which damages enemy heroes for half of their max health when it ends";
                if (l == 1322 || l == 121 || l == 119 || l == 218 || l == 1445 || l == 41) return "'On Fire' deals light damage over time and reduces your defense by 6";
                if (l == 1234) return "When you trigger 2 or more hammer abilities, you also throw a hammer.";
                if (l <= 962)
                {
                    if (l <= 405)
                    {
                        if (l <= 98)
                        {
                            if (l == 65)
                            {
                                return "'Forged with the fury of heaven'";
                            }
                            if (l == 98)
                            {
                                return "'Half shark, half gun, completely awesome.'";
                            }
                        }
                        else
                        {
                            if (l == 156) return "Automatically block every 6th attack";
                            switch (l)
                            {
                                case 228:
                                    return "3% increased magic critical strike chance";
                                case 229:
                                    return "3% increased magic critical strike chance";
                                case 230:
                                    return "3% increased magic critical strike chance";
                                default:
                                    switch (l)
                                    {
                                        case 371:
                                            return "9% increased magic critical strike chance";
                                        case 372:
                                            return ""; //"10% increased movement speed";
                                        case 373:
                                            return "6% increased ranged critical strike chance";
                                        case 374:
                                            return ""; //"10% increased movement speed";
                                        case 375:
                                            return ""; //"10% increased movement speed";
                                        case 376:
                                            return "4% increased magic crit";
                                            ;
                                        case 377:
                                            return "10% increased melee damage";
                                        case 378:
                                            return "7% increased ranged critical strike chance";
                                        case 379:
                                            return "4% increased magic crit";
                                        case 380:
                                            return "4% increased magic crit";
                                        case 389:
                                            return "'Find your inner pieces'";
                                        case 394:
                                            return "Greatly extends underwater breathing";
                                        case 395:
                                            return "Tells the time";
                                        case 396:
                                            return "Grants immunity to fire blocks";
                                        case 397:
                                            return "Grants immunity to fire blocks";
                                        case 399:
                                            return "Increases jump height";
                                        case 400:
                                            return "11% increased magic damage and critical strike chance";
                                        case 401:
                                            return "14% increased melee damage";
                                        case 405:
                                            return "The wearer can run super fast";
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (l <= 533)
                        {
                            if (l == 434)
                            {
                                return "Only the first shot consumes ammo";
                            }
                            if (l == 533)
                            {
                                return "'Minishark's older brother'";
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 551:
                                    return ""; //"8% increased magic damage";
                                case 552:
                                    return ""; //"8% increased magic damage";
                                case 553:
                                    return "8% increased ranged critical strike chance";
                                case 554:
                                case 556:
                                case 557:
                                    break;
                                case 555:
                                    return "Automatically use mana potions when needed";
                                case 558:
                                    return ""; //"8% increased magic damage";
                                case 559:
                                    return "10% increased melee haste";
                                default:
                                    if (l == 686)
                                    {
                                        return "7% increased melee attack speed";
                                    }
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    if (l <= 908)
                    {
                        if (l <= 784)
                        {
                            if (l == 748)
                            {
                                return "Hold up to rocket faster";
                            }
                            switch (l)
                            {
                                case 771:
                                    return "Small blast radius. Will not destroy tiles";
                                case 772:
                                    return "Small blast radius. Will destroy tiles";
                                case 773:
                                    return "Large blast radius. Will not destroy tiles";
                                case 774:
                                    return "Large blast radius. Will destroy tiles";
                                case 775:
                                    return "Increases running speed";
                                case 776:
                                    return "Can mine Mythril and Orichalcum";
                                case 777:
                                    return "Can mine Adamantite and Titanium";
                                case 779:
                                    return "Uses colored solution";
                                case 780:
                                    return "Spreads the Purity";
                                case 781:
                                    return "Spreads the Hallow";
                                case 782:
                                    return "Spreads the Corruption";
                                case 783:
                                    return "Spreads Glowing Mushrooms";
                                case 784:
                                    return "Spreads the Crimson";
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 897:
                                case 898:
                                    return "The wearer can run incredibly fast";
                                default:
                                    switch (l)
                                    {
                                        case 905:
                                            return "Higher valued coins do more damage";
                                        case 907:
                                            return "Grants immunity to fire blocks";
                                        case 908:
                                            return "Grants immunity to fire blocks and 7 seconds of immunity to lava";
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (l <= 938)
                        {
                            if (l == 929)
                            {
                                return "For use with cannon";
                            }
                            switch (l)
                            {
                                case 935:
                                    return "20% lifesteal on Critical Hits";
                                case 936:
                                    return "16% increased melee speed";
                                case 938:
                                    return "Only active above 25% life.  Automatically block every 5th attack.";
                            }
                        }
                        else
                        {
                            if (l == 950)
                            {
                                return "Ice will not break when you fall on it";
                            }
                            if (l == 953)
                            {
                                return "Improved ability if combined with Shoe Spikes";
                            }
                            switch (l)
                            {
                                case 960:
                                    return "3% increased magic critical strike chance";
                                case 961:
                                    return "3% increased magic critical strike chance";
                                case 962:
                                    return "3% increased magic critical strike chance";
                            }
                        }
                    }
                }
            //else
            {
                if (l <= 1254)
                {
                    if (l <= 1123)
                    {
                        if (l <= 984)
                        {
                            switch (l)
                            {
                                case 975:
                                    return "Improved ability if combined with Climbing Claws";
                                case 976:
                                    break;
                                case 977:
                                    return "Double tap a direction";
                                default:
                                    switch (l)
                                    {
                                        case 982:
                                            return "Increases max HP by 20";
                                        case 983:
                                            return "Increases jump height";
                                        case 984:
                                            return "Gives a chance to dodge attacks";
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 997:
                                    return "'To use: Place silt/slush in the extractinator'";
                                case 998:
                                case 999:
                                case 1000:
                                    break;
                                case 1001:
                                    return "6% increased melee critical strike chance";
                                case 1090:
                                    return "Double Jumps fire 2 arcane bolts";
                                case 1091:
                                    return "Increases movement speed and increases your damage based on your maximum HP when below 35% HP";
                                case 1092:
                                    return "Increases movement speed and 50% of damage is taken from mana before life when below 35% HP";
                                case 1093:
                                    return "Increases movement speed and ranged firing rate when below 35% HP";
                                case 1094:
                                    return "Double tap a direction to dash in that direction";
                                case 1095:
                                    return "Absorbs 25% of damage done to players on your team when above 25% life";
                                case 1098:
                                    return "Double tap a direction to dash and dodge in that direction";
                                case 1100:
                                    return "If above 25% health, use health instead of mana or heat at twice the cost";
                            }
                        }
                    }
                    else
                    {
                        if (l <= 1167)
                        {
                            if (l == 1131)
                            {
                                return "Press UP to change gravity";
                            }
                            switch (l)
                            {
                                case 1159:
                                    return "Increases minion damage by 10%";
                                case 1160:
                                    return "Increases minion damage by 10%";
                                case 1161:
                                    return "Increases minion damage by 10%";
                                case 1163:
                                    return "Increases jump height";
                                case 1164:
                                    return "Increases jump height";
                                case 1167:
                                    return "Increases the knockback of your minions";
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 1206:
                                    return "9% increased ranged critical strike chance";
                                case 1207:
                                    return "Increases maximum mana by 60";
                                case 1210:
                                    return "7% increased movement and melee speed";
                                case 1211:
                                    return "8% increased movement speed";
                                case 1212:
                                    return "10% reduced mana cost for spells";
                                case 1213:
                                    return "10% reduced mana cost for spells";
                                case 1214:
                                    return "10% reduced mana cost for spells";
                                case 1215:
                                    return "8% increased melee speed";
                                case 1216:
                                    return "5% increased ranged crit";
                                case 1217:
                                    return "Increases maximum mana by 100";
                                case 1218:
                                    return "5% increased ranged crit";
                                case 1219:
                                    return "5% increased ranged crit";
                                default:
                                    switch (l)
                                    {
                                        case 1249:
                                            return "Releases bees when damaged";
                                        case 1250:
                                            return "Increases jump height and negates fall damage";
                                        case 1251:
                                            return "Increases jump height and negates fall damage";
                                        case 1252:
                                            return "Increases jump height and negates fall damage";
                                        case 1254:
                                            return "Right click to zoom out";
                                    }
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    if (l <= 1321)
                    {
                        if (l <= 1295)
                        {
                            switch (l)
                            {
                                case 1282:
                                    return ""; //"Reduces mana usage by 5%";
                                case 1283:
                                    return "Reduces mana usage by 7%";
                                case 1284:
                                    return "Reduces mana usage by 9%";
                                case 1285:
                                    return "Reduces mana usage by 11%";
                                case 1286:
                                    return "Reduces mana usage by 13%";
                                case 1287:
                                    return "Reduces mana usage by 15%";
                                default:
                                    if (l == 1295)
                                    {
                                        return "'Oolaa!!'";
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 1300:
                                    return "Increases Bullet Damage by 4";
                                case 1301:
                                    return "8% increased critical strike chance";
                                case 1321:
                                    return "Increases Arrow Damage by 4";
                                default:
                                    //switch (l)
                                    //{
                                    //case 1321:
                                    //    return "20% chance to not consume arrow";
                                    //}
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (l <= 1505)
                        {
                            switch (l)
                            {
                                case 1336:
                                    return "Decreases target's defense";
                                case 1337:
                                    break;
                                case 1338:
                                    return "For use with bunny cannon";
                                case 1339:
                                    return "'Extremely toxic'";
                                case 1340:
                                    return "Melee attacks inflict Venom on enemies";
                                case 1341:
                                    return "Inflicts target with Venom";
                                case 1342:
                                    return "Inflicts target with Venom";
                                case 1343:
                                    return "16% increased melee speed";
                                case 1344:
                                    return "16% increased melee speed";
                                case 1345:
                                    return "16% increased melee speed";
                                case 1346:
                                    return "16% increased melee speed";
                                case 1347:
                                    return "16% increased melee speed";
                                case 1348:
                                    return "16% increased melee speed";
                                case 1349:
                                    return "16% increased melee speed";
                                case 1350:
                                    return "Causes confusion";
                                case 1351:
                                    return "Has a 1/5 chance of piercing knockback immunity";
                                case 1352:
                                    return "Enemies killed will drop more money";
                                case 1353:
                                    return "Melee attacks inflict enemies with cursed flames";
                                case 1354:
                                    return "Melee attacks set enemies on fire";
                                case 1355:
                                    return "Melee attacks make enemies drop more gold";
                                case 1356:
                                    return "Melee attacks decrease enemies defense";
                                case 1357:
                                    return "Melee attacks confuse enemies";
                                case 1358:
                                    return "Melee attacks cause confetti to appear";
                                case 1359:
                                    return "Melee attacks poison enemies";
                                case 1360:
                                    return "Guns have a 1 in 10 chance to fire a homing Chlorophyte Bullet";
                                case 1361:
                                    return "Creates a Crystal Leaf above your head that fires at enemies";
                                case 1365:
                                    return "Removes 20 heat when the wearer takes damage";
                                case 1367:
                                    return "Increases your defense temporarily when quickly taking damage";
                                case 1446:
                                    return "Has 20% lifesteal";
                                default:
                                    switch (l)
                                    {
                                        case 1503:
                                            return "increases jump height";
                                        case 1504:
                                            return "increases jump height";
                                        case 1505:
                                            return "increases jump height";
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (l)
                            {
                                case 1546:
                                    return "5% increased ranged critical strike chance";
                                case 1547:
                                    return "5% increased ranged critical strike chance";
                                case 1551:
                                case 1552:
                                    break;
                                case 1553:
                                    return "'It came from the edge of space'";
                                default:
                                    if (l == 1595)
                                    {
                                        return "Restores mana when damaged";
                                    }
                                    if (l == 1613)
                                    {
                                        return "Grants immunity to most debuffs";
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            }
            if (!english && Lang.lang > 1)
            {
                return Lang.toolTip2(l, true);
            }
            return "";
        }

        public static string itemName(int l, bool english = false)
        {
            if (Lang.lang <= 1 || english)
            {
                switch (l)
                {
                    case -48:
                        return "Platinum Bow";
                    case -47:
                        return "Platinum Hammer";
                    case -46:
                        return "Platinum Axe";
                    case -45:
                        return "Platinum Shortsword";
                    case -44:
                        return "Platinum Broadsword";
                    case -43:
                        return "Platinum Pickaxe";
                    case -42:
                        return "Tungsten Bow";
                    case -41:
                        return "Tungsten Hammer";
                    case -40:
                        return "Tungsten Axe";
                    case -39:
                        return "Tungsten Shortsword";
                    case -38:
                        return "Tungsten Broadsword";
                    case -37:
                        return "Tungsten Pickaxe";
                    case -36:
                        return "Lead Bow";
                    case -35:
                        return "Lead Hammer";
                    case -34:
                        return "Lead Axe";
                    case -33:
                        return "Lead Shortsword";
                    case -32:
                        return "Lead Broadsword";
                    case -31:
                        return "Lead Pickaxe";
                    case -30:
                        return "Tin Bow";
                    case -29:
                        return "Tin Hammer";
                    case -28:
                        return "Tin Axe";
                    case -27:
                        return "Tin Shortsword";
                    case -26:
                        return "Tin Broadsword";
                    case -25:
                        return "Tin Pickaxe";
                    case -24:
                        return "Yellow Phasesaber";
                    case -23:
                        return "White Phasesaber";
                    case -22:
                        return "Purple Phasesaber";
                    case -21:
                        return "Green Phasesaber";
                    case -20:
                        return "Red Phasesaber";
                    case -19:
                        return "Blue Phasesaber";
                    case -18:
                        return "Copper Bow";
                    case -17:
                        return "Copper Hammer";
                    case -16:
                        return "Copper Axe";
                    case -15:
                        return "Copper Shortsword";
                    case -14:
                        return "Copper Broadsword";
                    case -13:
                        return "Copper Pickaxe";
                    case -12:
                        return "Silver Bow";
                    case -11:
                        return "Silver Hammer";
                    case -10:
                        return "Silver Axe";
                    case -9:
                        return "Silver Shortsword";
                    case -8:
                        return "Silver Broadsword";
                    case -7:
                        return "Silver Pickaxe";
                    case -6:
                        return "Gold Bow";
                    case -5:
                        return "Gold Hammer";
                    case -4:
                        return "Gold Axe";
                    case -3:
                        return "Gold Shortsword";
                    case -2:
                        return "Gold Broadsword";
                    case -1:
                        return "Gold Pickaxe";
                    case 1:
                        return "Iron Pickaxe";
                    case 2:
                        return "Dirt Block";
                    case 3:
                        return "Stone Block";
                    case 4:
                        return "Iron Broadsword";
                    case 5:
                        return "Swift Mushroom"; //"Mushroom";
                    case 6:
                        return "Iron Shortsword";
                    case 7:
                        return "Iron Hammer";
                    case 8:
                        return "Torch";
                    case 9:
                        return "Wood";
                    case 10:
                        return "Iron Axe";
                    case 11:
                        return "Iron Ore";
                    case 12:
                        return "Copper Ore";
                    case 13:
                        return "Gold Ore";
                    case 14:
                        return "Silver Ore";
                    case 15:
                        return "Copper Watch";
                    case 16:
                        return "Silver Watch";
                    case 17:
                        return "Gold Watch";
                    case 18:
                        return "Depth Meter";
                    case 19:
                        return "Gold Bar";
                    case 20:
                        return "Copper Bar";
                    case 21:
                        return "Silver Bar";
                    case 22:
                        return "Iron Bar";
                    case 23:
                        return "Gel";
                    case 24:
                        return "Wooden Sword";
                    case 25:
                        return "Wooden Door";
                    case 26:
                        return "Stone Wall";
                    case 27:
                        return "Acorn";
                    case 28:
                        return "Goblin's Blood"; //"Lesser Healing Potion";
                    case 29:
                        return "Life Crystal";
                    case 30:
                        return "Dirt Wall";
                    case 31:
                        return "Bottle";
                    case 32:
                        return "Wooden Table";
                    case 33:
                        return "Furnace";
                    case 34:
                        return "Wooden Chair";
                    case 35:
                        return "Iron Anvil";
                    case 36:
                        return "Work Bench";
                    case 37:
                        return "Goggles";
                    case 38:
                        return "Lens";
                    case 39:
                        return "Wooden Bow";
                    case 40:
                        return "Wooden Arrow";
                    case 41:
                        return "Flaming Arrow";
                    case 42:
                        return "Shuriken";
                    case 43:
                        return "Suspicious Looking Eye";
                    case 44:
                        return "Demon Bow";
                    case 45:
                        return "War Axe of the Night";
                    case 46:
                        return "Light's Bane";
                    case 47:
                        return "Unholy Arrow";
                    case 48:
                        return "Chest";
                    case 49:
                        return "Band of the Giant"; //band of regeneration
                    case 50:
                        return "Magic Mirror";
                    case 51:
                        return "Jester's Arrow";
                    case 52:
                        return "Angel Statue";
                    case 53:
                        return "Cloud in a Bottle";
                    case 54:
                        return "Hermes Boots";
                    case 55:
                        return "Enchanted Boomerang";
                    case 56:
                        return "Demonite Ore";
                    case 57:
                        return "Demonite Bar";
                    case 58:
                        return "Heart";
                    case 59:
                        return "Corrupt Seeds";
                    case 60:
                        return "Vile Mushroom";
                    case 61:
                        return "Ebonstone Block";
                    case 62:
                        return "Grass Seeds";
                    case 63:
                        return "Sunflower";
                    case 64:
                        return "Vilethorn";
                    case 65:
                        return "Starfury";
                    case 66:
                        return "Drain"; //"Purification Powder";
                    case 67:
                        return "Doom"; //"Vile Powder";
                    case 68:
                        return "Rotten Chunk";
                    case 69:
                        return "Worm Tooth";
                    case 70:
                        return "Worm Food";
                    case 71:
                        return "Copper Coin";
                    case 72:
                        return "Silver Coin";
                    case 73:
                        return "Gold Coin";
                    case 74:
                        return "Platinum Coin";
                    case 75:
                        return "Fallen Star";
                    case 76:
                        return "Copper Greaves";
                    case 77:
                        return "Iron Greaves";
                    case 78:
                        return "Silver Greaves";
                    case 79:
                        return "Gold Greaves";
                    case 80:
                        return "Copper Chainmail";
                    case 81:
                        return "Iron Chainmail";
                    case 82:
                        return "Silver Chainmail";
                    case 83:
                        return "Gold Chainmail";
                    case 84:
                        return "Grappling Hook";
                    case 85:
                        return "Chain";
                    case 86:
                        return "Shadow Scale";
                    case 87:
                        return "Piggy Bank";
                    case 88:
                        return "Mining Helmet";
                    case 89:
                        return "Copper Helmet";
                    case 90:
                        return "Iron Helmet";
                    case 91:
                        return "Silver Helmet";
                    case 92:
                        return "Gold Helmet";
                    case 93:
                        return "Wood Wall";
                    case 94:
                        return "Wood Platform";
                    case 95:
                        return "Flintlock Pistol";
                    case 96:
                        return "Musket";
                    case 97:
                        return "Bullet";
                    case 98:
                        return "Minishark";
                    case 99:
                        return "Iron Bow";
                    case 100:
                        return "Shadow Greaves";
                    case 101:
                        return "Shadow Scalemail";
                    case 102:
                        return "Shadow Helmet";
                    case 103:
                        return "Nightmare Pickaxe";
                    case 104:
                        return "The Breaker";
                    case 105:
                        return "Candle";
                    case 106:
                        return "Copper Chandelier";
                    case 107:
                        return "Silver Chandelier";
                    case 108:
                        return "Gold Chandelier";
                    case 109:
                        return "Mana Crystal";
                    case 110:
                        return "Lesser Mana Potion";
                    case 111:
                        return "Band of Starpower";
                    case 112:
                        return "Flower of Fire";
                    case 113:
                        return "Magic Missile";
                    case 114:
                        return "Dirt Rod";
                    case 115:
                        return "Shadow Orb";
                    case 116:
                        return "Meteorite";
                    case 117:
                        return "Meteorite Bar";
                    case 118:
                        return "Hook";
                    case 119:
                        return "Flamarang";
                    case 120:
                        return "Molten Fury";
                    case 121:
                        return "Fiery Greatsword";
                    case 122:
                        return "Molten Pickaxe";
                    case 123:
                        return "Meteor Helmet";
                    case 124:
                        return "Meteor Suit";
                    case 125:
                        return "Meteor Leggings";
                    case 126:
                        return "Bottled Water";
                    case 127:
                        return "Space Gun";
                    case 128:
                        return "Rocket Boots";
                    case 129:
                        return "Gray Brick";
                    case 130:
                        return "Gray Brick Wall";
                    case 131:
                        return "Red Brick";
                    case 132:
                        return "Red Brick Wall";
                    case 133:
                        return "Clay Block";
                    case 134:
                        return "Blue Brick";
                    case 135:
                        return "Blue Brick Wall";
                    case 136:
                        return "Chain Lantern";
                    case 137:
                        return "Green Brick";
                    case 138:
                        return "Green Brick Wall";
                    case 139:
                        return "Pink Brick";
                    case 140:
                        return "Pink Brick Wall";
                    case 141:
                        return "Gold Brick";
                    case 142:
                        return "Gold Brick Wall";
                    case 143:
                        return "Silver Brick";
                    case 144:
                        return "Silver Brick Wall";
                    case 145:
                        return "Copper Brick";
                    case 146:
                        return "Copper Brick Wall";
                    case 147:
                        return "Spike";
                    case 148:
                        return "Water Candle";
                    case 149:
                        return "Book";
                    case 150:
                        return "Cobweb";
                    case 151:
                        return "Necro Helmet";
                    case 152:
                        return "Necro Breastplate";
                    case 153:
                        return "Necro Greaves";
                    case 154:
                        return "Bone";
                    case 155:
                        return "Muramasa";
                    case 156:
                        return "Cobalt Shield";
                    case 157:
                        return "Aqua Scepter";
                    case 158:
                        return "Lucky Horseshoe";
                    case 159:
                        return "Shiny Red Balloon";
                    case 160:
                        return "Harpoon";
                    case 161:
                        return "Spiky Ball";
                    case 162:
                        return "Ball O' Hurt";
                    case 163:
                        return "Blue Moon";
                    case 164:
                        return "Handgun";
                    case 165:
                        return "Water Bolt";
                    case 166:
                        return "Bomb";
                    case 167:
                        return "Dynamite";
                    case 168:
                        return "Grenade";
                    case 169:
                        return "Sand Block";
                    case 170:
                        return "Glass";
                    case 171:
                        return "Sign";
                    case 172:
                        return "Ash Block";
                    case 173:
                        return "Obsidian";
                    case 174:
                        return "Hellstone";
                    case 175:
                        return "Hellstone Bar";
                    case 176:
                        return "Mud Block";
                    case 177:
                        return "Enchanted Jewel"; //"Sapphire";
                    case 178:
                        return "Ruby";
                    case 179:
                        return "Emerald";
                    case 180:
                        return "Topaz";
                    case 181:
                        return "Amethyst";
                    case 182:
                        return "Diamond";
                    case 183:
                        return "Glowing Mushroom";
                    case 184:
                        return "Star";
                    case 185:
                        return "Ivy Whip";
                    case 186:
                        return "Breathing Reed";
                    case 187:
                        return "Flipper";
                    case 188:
                        return "Focus Flask"; //"Healing Potion";
                    case 189:
                        return "Mana Potion";
                    case 190:
                        return "Blade of Grass";
                    case 191:
                        return "Thorn Chakram";
                    case 192:
                        return "Obsidian Brick";
                    case 193:
                        return "Obsidian Skull";
                    case 194:
                        return "Mushroom Grass Seeds";
                    case 195:
                        return "Jungle Grass Seeds";
                    case 196:
                        return "Wooden Hammer";
                    case 197:
                        return "Star Cannon";
                    case 198:
                        return "Blue Phaseblade";
                    case 199:
                        return "Red Phaseblade";
                    case 200:
                        return "Green Phaseblade";
                    case 201:
                        return "Purple Phaseblade";
                    case 202:
                        return "White Phaseblade";
                    case 203:
                        return "Yellow Phaseblade";
                    case 204:
                        return "Meteor Hamaxe";
                    case 205:
                        return "Empty Bucket";
                    case 206:
                        return "Water Bucket";
                    case 207:
                        return "Lava Bucket";
                    case 208:
                        return "Jungle Rose";
                    case 209:
                        return "Stinger";
                    case 210:
                        return "Vine";
                    case 211:
                        return "Feral Claws";
                    case 212:
                        return "Anklet of the Wind";
                    case 213:
                        return "Staff of Regrowth";
                    case 214:
                        return "Hellstone Brick";
                    case 215:
                        return "Whoopie Cushion";
                    case 216:
                        return "Shackle";
                    case 217:
                        return "Molten Hammer";
                    case 218:
                        return "Flare Missile"; //"Flamelash";
                    case 219:
                        return "Phoenix Blaster";
                    case 220:
                        return "Sunfury";
                    case 221:
                        return "Hellforge";
                    case 222:
                        return "Clay Pot";
                    case 223:
                        return "Nature's Gift";
                    case 224:
                        return "Bed";
                    case 225:
                        return "Silk";
                    case 226:
                        return "Lesser Restoration Potion";
                    case 227:
                        return "Jeremy's Nightcap"; //"Restoration Potion";
                    case 228:
                        return "Jungle Hat";
                    case 229:
                        return "Jungle Shirt";
                    case 230:
                        return "Jungle Pants";
                    case 231:
                        return "Molten Helmet";
                    case 232:
                        return "Molten Breastplate";
                    case 233:
                        return "Molten Greaves";
                    case 234:
                        return "Meteor Shot";
                    case 235:
                        return "Sticky Bomb";
                    case 236:
                        return "Black Lens";
                    case 237:
                        return "Sunglasses";
                    case 238:
                        return "Wizard Hat";
                    case 239:
                        return "Top Hat";
                    case 240:
                        return "Tuxedo Shirt";
                    case 241:
                        return "Tuxedo Pants";
                    case 242:
                        return "Summer Hat";
                    case 243:
                        return "Bunny Hood";
                    case 244:
                        return "Plumber's Hat";
                    case 245:
                        return "Plumber's Shirt";
                    case 246:
                        return "Plumber's Pants";
                    case 247:
                        return "Hero's Hat";
                    case 248:
                        return "Hero's Shirt";
                    case 249:
                        return "Hero's Pants";
                    case 250:
                        return "Fish Bowl";
                    case 251:
                        return "Archaeologist's Hat";
                    case 252:
                        return "Archaeologist's Jacket";
                    case 253:
                        return "Archaeologist's Pants";
                    case 254:
                        return "Black Thread";
                    case 255:
                        return "Green Thread";
                    case 256:
                        return "Ninja Hood";
                    case 257:
                        return "Ninja Shirt";
                    case 258:
                        return "Ninja Pants";
                    case 259:
                        return "Leather";
                    case 260:
                        return "Red Hat";
                    case 261:
                        return "Goldfish";
                    case 262:
                        return "Robe";
                    case 263:
                        return "Robot Hat";
                    case 264:
                        return "Gold Crown";
                    case 265:
                        return "Hellfire Arrow";
                    case 266:
                        return "Sandgun";
                    case 267:
                        return "Guide Voodoo Doll";
                    case 268:
                        return "Diving Helmet";
                    case 269:
                        return "Familiar Shirt";
                    case 270:
                        return "Familiar Pants";
                    case 271:
                        return "Familiar Wig";
                    case 272:
                        return "Demon Scythe";
                    case 273:
                        return "Night's Edge";
                    case 274:
                        return "Dark Lance";
                    case 275:
                        return "Coral";
                    case 276:
                        return "Cactus";
                    case 277:
                        return "Trident";
                    case 278:
                        return "Silver Bullet";
                    case 279:
                        return "Throwing Knife";
                    case 280:
                        return "Spear";
                    case 281:
                        return "Blowpipe";
                    case 282:
                        return "Glowstick";
                    case 283:
                        return "Seed";
                    case 284:
                        return "Wooden Boomerang";
                    case 285:
                        return "Aglet";
                    case 286:
                        return "Sticky Glowstick";
                    case 287:
                        return "Poisoned Knife";
                    case 288:
                        return "Obsidian Skin Potion";
                    case 289:
                        return "Regeneration Potion";
                    case 290:
                        return "Swiftness Potion";
                    case 291:
                        return "Gills Potion";
                    case 292:
                        return "Ironskin Potion";
                    case 293:
                        return "Mana Regeneration Potion";
                    case 294:
                        return "Magic Power Potion";
                    case 295:
                        return "Featherfall Potion";
                    case 296:
                        return "Spelunker Potion";
                    case 297:
                        return "Invisibility Potion";
                    case 298:
                        return "Shine Potion";
                    case 299:
                        return "Night Owl Potion";
                    case 300:
                        return "Battle Potion";
                    case 301:
                        return "Thorns Potion";
                    case 302:
                        return "Water Walking Potion";
                    case 303:
                        return "Archery Potion";
                    case 304:
                        return "Hunter Potion";
                    case 305:
                        return "Gravitation Potion";
                    case 306:
                        return "Gold Chest";
                    case 307:
                        return "Daybloom Seeds";
                    case 308:
                        return "Moonglow Seeds";
                    case 309:
                        return "Blinkroot Seeds";
                    case 310:
                        return "Deathweed Seeds";
                    case 311:
                        return "Waterleaf Seeds";
                    case 312:
                        return "Fireblossom Seeds";
                    case 313:
                        return "Daybloom";
                    case 314:
                        return "Moonglow";
                    case 315:
                        return "Blinkroot";
                    case 316:
                        return "Deathweed";
                    case 317:
                        return "Waterleaf";
                    case 318:
                        return "Fireblossom";
                    case 319:
                        return "Shark Fin";
                    case 320:
                        return "Feather";
                    case 321:
                        return "Tombstone";
                    case 322:
                        return "Mime Mask";
                    case 323:
                        return "Antlion Mandible";
                    case 324:
                        return "Illegal Gun Parts";
                    case 325:
                        return "The Doctor's Shirt";
                    case 326:
                        return "The Doctor's Pants";
                    case 327:
                        return "Golden Key";
                    case 328:
                        return "Shadow Chest";
                    case 329:
                        return "Shadow Key";
                    case 330:
                        return "Obsidian Brick Wall";
                    case 331:
                        return "Jungle Spores";
                    case 332:
                        return "Loom";
                    case 333:
                        return "Piano";
                    case 334:
                        return "Dresser";
                    case 335:
                        return "Bench";
                    case 336:
                        return "Bathtub";
                    case 337:
                        return "Red Banner";
                    case 338:
                        return "Green Banner";
                    case 339:
                        return "Blue Banner";
                    case 340:
                        return "Yellow Banner";
                    case 341:
                        return "Lamp Post";
                    case 342:
                        return "Tiki Torch";
                    case 343:
                        return "Barrel";
                    case 344:
                        return "Chinese Lantern";
                    case 345:
                        return "Cooking Pot";
                    case 346:
                        return "Safe";
                    case 347:
                        return "Skull Lantern";
                    case 348:
                        return "Trash Can";
                    case 349:
                        return "Candelabra";
                    case 350:
                        return "Pink Vase";
                    case 351:
                        return "Mug";
                    case 352:
                        return "Keg";
                    case 353:
                        return "Ale";
                    case 354:
                        return "Bookcase";
                    case 355:
                        return "Throne";
                    case 356:
                        return "Bowl";
                    case 357:
                        return "Bowl of Soup";
                    case 358:
                        return "Toilet";
                    case 359:
                        return "Grandfather Clock";
                    case 360:
                        return "Armor Statue";
                    case 361:
                        return "Goblin Battle Standard";
                    case 362:
                        return "Tattered Cloth";
                    case 363:
                        return "Sawmill";
                    case 364:
                        return "Cobalt Ore";
                    case 365:
                        return "Mythril Ore";
                    case 366:
                        return "Adamantite Ore";
                    case 367:
                        return "Pwnhammer";
                    case 368:
                        return "Excalibur";
                    case 369:
                        return "Hallowed Seeds";
                    case 370:
                        return "Ebonsand Block";
                    case 371:
                        return "Cobalt Hat";
                    case 372:
                        return "Cobalt Helmet";
                    case 373:
                        return "Cobalt Mask";
                    case 374:
                        return "Cobalt Breastplate";
                    case 375:
                        return "Cobalt Leggings";
                    case 376:
                        return "Mythril Hood";
                    case 377:
                        return "Mythril Helmet";
                    case 378:
                        return "Mythril Hat";
                    case 379:
                        return "Mythril Chainmail";
                    case 380:
                        return "Mythril Greaves";
                    case 381:
                        return "Cobalt Bar";
                    case 382:
                        return "Mythril Bar";
                    case 383:
                        return "Cobalt Chainsaw";
                    case 384:
                        return "Mythril Chainsaw";
                    case 385:
                        return "Cobalt Drill";
                    case 386:
                        return "Mythril Drill";
                    case 387:
                        return "Adamantite Chainsaw";
                    case 388:
                        return "Adamantite Drill";
                    case 389:
                        return "Dao of Pow";
                    case 390:
                        return "Mythril Halberd";
                    case 391:
                        return "Adamantite Bar";
                    case 392:
                        return "Glass Wall";
                    case 393:
                        return "Compass";
                    case 394:
                        return "Diving Gear";
                    case 395:
                        return "GPS";
                    case 396:
                        return "Obsidian Horseshoe";
                    case 397:
                        return "Obsidian Shield";
                    case 398:
                        return "Tinkerer's Workshop";
                    case 399:
                        return "Cloud in a Balloon";
                    case 400:
                        return "Adamantite Headgear";
                    case 401:
                        return "Adamantite Helmet";
                    case 402:
                        return "Adamantite Mask";
                    case 403:
                        return "Adamantite Breastplate";
                    case 404:
                        return "Adamantite Leggings";
                    case 405:
                        return "Spectre Boots";
                    case 406:
                        return "Adamantite Glaive";
                    case 407:
                        return "Toolbelt";
                    case 408:
                        return "Pearlsand Block";
                    case 409:
                        return "Pearlstone Block";
                    case 410:
                        return "Mining Shirt";
                    case 411:
                        return "Mining Pants";
                    case 412:
                        return "Pearlstone Brick";
                    case 413:
                        return "Iridescent Brick";
                    case 414:
                        return "Mudstone Block";
                    case 415:
                        return "Cobalt Brick";
                    case 416:
                        return "Mythril Brick";
                    case 417:
                        return "Pearlstone Brick Wall";
                    case 418:
                        return "Iridescent Brick Wall";
                    case 419:
                        return "Mudstone Brick Wall";
                    case 420:
                        return "Cobalt Brick Wall";
                    case 421:
                        return "Mythril Brick Wall";
                    case 422:
                        return "Holy Water";
                    case 423:
                        return "Unholy Water";
                    case 424:
                        return "Silt Block";
                    case 425:
                        return "Fairy Bell";
                    case 426:
                        return "Breaker Blade";
                    case 427:
                        return "Blue Torch";
                    case 428:
                        return "Red Torch";
                    case 429:
                        return "Green Torch";
                    case 430:
                        return "Purple Torch";
                    case 431:
                        return "White Torch";
                    case 432:
                        return "Yellow Torch";
                    case 433:
                        return "Demon Torch";
                    case 434:
                        return "Clockwork Assault Rifle";
                    case 435:
                        return "Celestial Bow"; //"Cobalt Repeater";
                    case 436:
                        return "Mythril Repeater";
                    case 437:
                        return "Dual Hook";
                    case 438:
                        return "Star Statue";
                    case 439:
                        return "Sword Statue";
                    case 440:
                        return "Slime Statue";
                    case 441:
                        return "Goblin Statue";
                    case 442:
                        return "Shield Statue";
                    case 443:
                        return "Bat Statue";
                    case 444:
                        return "Fish Statue";
                    case 445:
                        return "Bunny Statue";
                    case 446:
                        return "Skeleton Statue";
                    case 447:
                        return "Reaper Statue";
                    case 448:
                        return "Woman Statue";
                    case 449:
                        return "Imp Statue";
                    case 450:
                        return "Gargoyle Statue";
                    case 451:
                        return "Gloom Statue";
                    case 452:
                        return "Hornet Statue";
                    case 453:
                        return "Bomb Statue";
                    case 454:
                        return "Crab Statue";
                    case 455:
                        return "Hammer Statue";
                    case 456:
                        return "Potion Statue";
                    case 457:
                        return "Spear Statue";
                    case 458:
                        return "Cross Statue";
                    case 459:
                        return "Jellyfish Statue";
                    case 460:
                        return "Bow Statue";
                    case 461:
                        return "Boomerang Statue";
                    case 462:
                        return "Boot Statue";
                    case 463:
                        return "Chest Statue";
                    case 464:
                        return "Bird Statue";
                    case 465:
                        return "Axe Statue";
                    case 466:
                        return "Corrupt Statue";
                    case 467:
                        return "Tree Statue";
                    case 468:
                        return "Anvil Statue";
                    case 469:
                        return "Pickaxe Statue";
                    case 470:
                        return "Mushroom Statue";
                    case 471:
                        return "Eyeball Statue";
                    case 472:
                        return "Pillar Statue";
                    case 473:
                        return "Heart Statue";
                    case 474:
                        return "Pot Statue";
                    case 475:
                        return "Sunflower Statue";
                    case 476:
                        return "King Statue";
                    case 477:
                        return "Queen Statue";
                    case 478:
                        return "Pirahna Statue";
                    case 479:
                        return "Planked Wall";
                    case 480:
                        return "Wooden Beam";
                    case 481:
                        return "Adamantite Repeater";
                    case 482:
                        return "Adamantite Sword";
                    case 483:
                        return "Cobalt Sword";
                    case 484:
                        return "Mythril Sword";
                    case 485:
                        return "Moon Charm";
                    case 486:
                        return "Ruler";
                    case 487:
                        return "Crystal Ball";
                    case 488:
                        return "Disco Ball";
                    case 489:
                        return "Sorcerer Emblem";
                    case 490:
                        return "Warrior Emblem";
                    case 491:
                        return "Ranger Emblem";
                    case 492:
                        return "Demon Wings";
                    case 493:
                        return "Angel Wings";
                    case 494:
                        return "Magical Harp";
                    case 495:
                        return "Rainbow Missile"; //"Rainbow Rod";
                    case 496:
                        return "Void Missile"; //"Ice Rod";
                    case 497:
                        return "Neptune's Shell";
                    case 498:
                        return "Mannequin";
                    case 499:
                        return "Ectoplasm"; //"Greater Healing Potion";
                    case 500:
                        return "Greater Mana Potion";
                    case 501:
                        return "Pixie Dust";
                    case 502:
                        return "Crystal Shard";
                    case 503:
                        return "Clown Hat";
                    case 504:
                        return "Clown Shirt";
                    case 505:
                        return "Clown Pants";
                    case 506:
                        return "Flamethrower";
                    case 507:
                        return "Bell";
                    case 508:
                        return "Harp";
                    case 509:
                        return "Wrench";
                    case 510:
                        return "Wire Cutter";
                    case 511:
                        return "Active Stone Block";
                    case 512:
                        return "Inactive Stone Block";
                    case 513:
                        return "Lever";
                    case 514:
                        return "Laser Rifle";
                    case 515:
                        return "Crystal Bullet";
                    case 516:
                        return "Holy Arrow";
                    case 517:
                        return "Magic Dagger";
                    case 518:
                        return "Crystal Storm";
                    case 519:
                        return "Cursed Flames";
                    case 520:
                        return "Soul of Light";
                    case 521:
                        return "Soul of Night";
                    case 522:
                        return "Cursed Flame";
                    case 523:
                        return "Cursed Torch";
                    case 524:
                        return "Adamantite Forge";
                    case 525:
                        return "Mythril Anvil";
                    case 526:
                        return "Unicorn Horn";
                    case 527:
                        return "Dark Shard";
                    case 528:
                        return "Light Shard";
                    case 529:
                        return "Red Pressure Plate";
                    case 530:
                        return "Wire";
                    case 531:
                        return "Spell Tome";
                    case 532:
                        return "Star Cloak";
                    case 533:
                        return "Megashark";
                    case 534:
                        return "Shotgun";
                    case 535:
                        return "Philosopher's Stone";
                    case 536:
                        return "Titan Glove";
                    case 537:
                        return "Vjaya"; //"Cobalt Naginata";
                    case 538:
                        return "Switch";
                    case 539:
                        return "Dart Trap";
                    case 540:
                        return "Metal Scrap"; //"Boulder";
                    case 541:
                        return "Green Pressure Plate";
                    case 542:
                        return "Gray Pressure Plate";
                    case 543:
                        return "Brown Pressure Plate";
                    case 544:
                        return "Mechanical Eye";
                    case 545:
                        return "Cursed Arrow";
                    case 546:
                        return "Cursed Bullet";
                    case 547:
                        return "Soul of Fright";
                    case 548:
                        return "Soul of Might";
                    case 549:
                        return "Soul of Sight";
                    case 550:
                        return "Gungnir";
                    case 551:
                        return "Hallowed Plate Mail";
                    case 552:
                        return "Hallowed Greaves";
                    case 553:
                        return "Hallowed Helmet";
                    case 554:
                        return "Cross Necklace";
                    case 555:
                        return "Mana Flower";
                    case 556:
                        return "Mechanical Worm";
                    case 557:
                        return "Mechanical Skull";
                    case 558:
                        return "Hallowed Headgear";
                    case 559:
                        return "Hallowed Mask";
                    case 560:
                        return "Slime Crown";
                    case 561:
                        return "Light Disc";
                    case 562:
                        return "Music Box (Overworld Day)";
                    case 563:
                        return "Music Box (Eerie)";
                    case 564:
                        return "Music Box (Night)";
                    case 565:
                        return "Music Box (Title)";
                    case 566:
                        return "Music Box (Underground)";
                    case 567:
                        return "Music Box (Boss 1)";
                    case 568:
                        return "Music Box (Jungle)";
                    case 569:
                        return "Music Box (Corruption)";
                    case 570:
                        return "Music Box (Underground Corruption)";
                    case 571:
                        return "Music Box (The Hallow)";
                    case 572:
                        return "Music Box (Boss 2)";
                    case 573:
                        return "Music Box (Underground Hallow)";
                    case 574:
                        return "Music Box (Boss 3)";
                    case 575:
                        return "Soul of Flight";
                    case 576:
                        return "Music Box";
                    case 577:
                        return "Demonite Brick";
                    case 578:
                        return "Hallowed Repeater";
                    case 579:
                        return "Drax";
                    case 580:
                        return "Explosives";
                    case 581:
                        return "Inlet Pump";
                    case 582:
                        return "Outlet Pump";
                    case 583:
                        return "1 Second Timer";
                    case 584:
                        return "3 Second Timer";
                    case 585:
                        return "5 Second Timer";
                    case 586:
                        return "Candy Cane Block";
                    case 587:
                        return "Candy Cane Wall";
                    case 588:
                        return "Santa Hat";
                    case 589:
                        return "Santa Shirt";
                    case 590:
                        return "Santa Pants";
                    case 591:
                        return "Green Candy Cane Block";
                    case 592:
                        return "Green Candy Cane Wall";
                    case 593:
                        return "Snow Block";
                    case 594:
                        return "Snow Brick";
                    case 595:
                        return "Snow Brick Wall";
                    case 596:
                        return "Blue Light";
                    case 597:
                        return "Red Light";
                    case 598:
                        return "Green Light";
                    case 599:
                        return "Blue Present";
                    case 600:
                        return "Green Present";
                    case 601:
                        return "Yellow Present";
                    case 602:
                        return "Snow Globe";
                    case 603:
                        return "Carrot";
                    case 604:
                        return "Adamantite Beam";
                    case 605:
                        return "Adamantite Beam Wall";
                    case 606:
                        return "Demonite Brick Wall";
                    case 607:
                        return "Sandstone Brick";
                    case 608:
                        return "Sandstone Brick Wall";
                    case 609:
                        return "Ebonstone Brick";
                    case 610:
                        return "Ebonstone Brick Wall";
                    case 611:
                        return "Red Stucco";
                    case 612:
                        return "Yellow Stucco";
                    case 613:
                        return "Green Stucco";
                    case 614:
                        return "Gray Stucco";
                    case 615:
                        return "Red Stucco Wall";
                    case 616:
                        return "Yellow Stucco Wall";
                    case 617:
                        return "Green Stucco Wall";
                    case 618:
                        return "Gray Stucco Wall";
                    case 619:
                        return "Ebonwood";
                    case 620:
                        return "Rich Mahogany";
                    case 621:
                        return "Pearlwood";
                    case 622:
                        return "Ebonwood Wall";
                    case 623:
                        return "Rich Mahogany Wall";
                    case 624:
                        return "Pearlwood Wall";
                    case 625:
                        return "Ebonwood Chest";
                    case 626:
                        return "Rich Mahogany Chest";
                    case 627:
                        return "Pearlwood Chest";
                    case 628:
                        return "Ebonwood Chair";
                    case 629:
                        return "Rich Mahogany Chair";
                    case 630:
                        return "Pearlwood Chair";
                    case 631:
                        return "Ebonwood Platform";
                    case 632:
                        return "Rich Mahogany Platform";
                    case 633:
                        return "Pearlwood Platform";
                    case 634:
                        return "Bone Platform";
                    case 635:
                        return "Ebonwood Work Bench";
                    case 636:
                        return "Rich Mahogany Work Bench";
                    case 637:
                        return "Pearlwood Work Bench";
                    case 638:
                        return "Ebonwood Table";
                    case 639:
                        return "Rich Mahogany Table";
                    case 640:
                        return "Pearlwood Table";
                    case 641:
                        return "Ebonwood Piano";
                    case 642:
                        return "Rich Mahogany Piano";
                    case 643:
                        return "Pearlwood Piano";
                    case 644:
                        return "Ebonwood Bed";
                    case 645:
                        return "Rich Mahogany Bed";
                    case 646:
                        return "Pearlwood Bed";
                    case 647:
                        return "Ebonwood Dresser";
                    case 648:
                        return "Rich Mahogany Dresser";
                    case 649:
                        return "Pearlwood Dresser";
                    case 650:
                        return "Ebonwood Door";
                    case 651:
                        return "Rich Mahogany Door";
                    case 652:
                        return "Pearlwood Door";
                    case 653:
                        return "Ebonwood Sword";
                    case 654:
                        return "Daze Hammer";
                    case 655:
                        return "Ebonwood Bow";
                    case 656:
                        return "Rich Mahogany Sword";
                    case 657:
                        return "Turbo Hammer";
                    case 658:
                        return "Rich Mahogany Bow";
                    case 659:
                        return "Pearlwood Sword";
                    case 660:
                        return "Pearlwood Hammer";
                    case 661:
                        return "Pearlwood Bow";
                    case 662:
                        return "Rainbow Brick";
                    case 663:
                        return "Rainbow Brick Wall";
                    case 664:
                        return "Ice Block";
                    case 665:
                        return "Red's Wings";
                    case 666:
                        return "Red's Helmet";
                    case 667:
                        return "Red's Breastplate";
                    case 668:
                        return "Red's Leggings";
                    case 669:
                        return "Fish";
                    case 670:
                        return "Ice Boomerang";
                    case 671:
                        return "Keybrand";
                    case 672:
                        return "Cutlass";
                    case 673:
                        return "Icemourne";
                    case 674:
                        return "True Excalibur";
                    case 675:
                        return "True Night's Edge";
                    case 676:
                        return "Frostbrand";
                    case 677:
                        return "Scythe";
                    case 678:
                        return "Soul Scythe";
                    case 679:
                        return "Tactical Shotgun";
                    case 680:
                        return "Ivy Chest";
                    case 681:
                        return "Ice Chest";
                    case 682:
                        return "Marrow";
                    case 683:
                        return "Unholy Trident";
                    case 684:
                        return "Frost Helmet";
                    case 685:
                        return "Frost Breastplate";
                    case 686:
                        return "Frost Leggings";
                    case 687:
                        return "Tin Helmet";
                    case 688:
                        return "Tin Chainmail";
                    case 689:
                        return "Tin Greaves";
                    case 690:
                        return "Lead Helmet";
                    case 691:
                        return "Lead Chainmail";
                    case 692:
                        return "Lead Greaves";
                    case 693:
                        return "Tungsten Helmet";
                    case 694:
                        return "Tungsten Chainmail";
                    case 695:
                        return "Tungsten Greaves";
                    case 696:
                        return "Platinum Helmet";
                    case 697:
                        return "Platinum Chainmail";
                    case 698:
                        return "Platinum Greaves";
                    case 699:
                        return "Tin Ore";
                    case 700:
                        return "Lead Ore";
                    case 701:
                        return "Tungsten Ore";
                    case 702:
                        return "Platinum Ore";
                    case 703:
                        return "Tin Bar";
                    case 704:
                        return "Lead Bar";
                    case 705:
                        return "Tungsten Bar";
                    case 706:
                        return "Platinum Bar";
                    case 707:
                        return "Tin Watch";
                    case 708:
                        return "Tungsten Watch";
                    case 709:
                        return "Platinum Watch";
                    case 710:
                        return "Tin Chandelier";
                    case 711:
                        return "Tungsten Chandelier";
                    case 712:
                        return "Platinum Chandelier";
                    case 713:
                        return "Platinum Candle";
                    case 714:
                        return "Platinum Candelabra";
                    case 715:
                        return "Platinum Crown";
                    case 716:
                        return "Lead Anvil";
                    case 717:
                        return "Tin Brick";
                    case 718:
                        return "Tungsten Brick";
                    case 719:
                        return "Platinum Brick";
                    case 720:
                        return "Tin Brick Wall";
                    case 721:
                        return "Tungsten Brick Wall";
                    case 722:
                        return "Platinum Brick Wall";
                    case 723:
                        return "Beam Sword";
                    case 724:
                        return "Ice Blade";
                    case 725:
                        return "Ice Bow";
                    case 726:
                        return "Frost Staff";
                    case 727:
                        return "Wood Helmet";
                    case 728:
                        return "Wood Breastplate";
                    case 729:
                        return "Wood Greaves";
                    case 730:
                        return "Ebonwood Helmet";
                    case 731:
                        return "Ebonwood Breastplate";
                    case 732:
                        return "Ebonwood Greaves";
                    case 733:
                        return "Rich Mahogany Helmet";
                    case 734:
                        return "Rich Mahogany Breastplate";
                    case 735:
                        return "Rich Mahogany Greaves";
                    case 736:
                        return "Pearlwood Helmet";
                    case 737:
                        return "Pearlwood Breastplate";
                    case 738:
                        return "Pearlwood Greaves";
                    case 739:
                        return "Amethyst Staff";
                    case 740:
                        return "Topaz Staff";
                    case 741:
                        return "Sapphire Staff";
                    case 742:
                        return "Emerald Staff";
                    case 743:
                        return "Ruby Staff";
                    case 744:
                        return "Diamond Staff";
                    case 745:
                        return "Grass Wall";
                    case 746:
                        return "Jungle Wall";
                    case 747:
                        return "Flower Wall";
                    case 748:
                        return "Jetpack";
                    case 749:
                        return "Butterfly Wings";
                    case 750:
                        return "Cactus Wall";
                    case 751:
                        return "Cloud";
                    case 752:
                        return "Cloud Wall";
                    case 753:
                        return "Seaweed";
                    case 754:
                        return "Rune Hat";
                    case 755:
                        return "Rune Robe";
                    case 756:
                        return "Mushroom Spear";
                    case 757:
                        return "Terra Blade";
                    case 758:
                        return "Grenade Launcher";
                    case 759:
                        return "Rocket Launcher";
                    case 760:
                        return "Proximity Mine Launcher";
                    case 761:
                        return "Fairy Wings";
                    case 762:
                        return "Slime Block";
                    case 763:
                        return "Flesh Block";
                    case 764:
                        return "Mushroom Wall";
                    case 765:
                        return "Rain Cloud";
                    case 766:
                        return "Bone Block";
                    case 767:
                        return "Frozen Slime Block";
                    case 768:
                        return "Bone Block Wall";
                    case 769:
                        return "Slime Block Wall";
                    case 770:
                        return "Flesh Block Wall";
                    case 771:
                        return "Rocket I";
                    case 772:
                        return "Rocket II";
                    case 773:
                        return "Rocket III";
                    case 774:
                        return "Rocket IV";
                    case 775:
                        return "Asphalt Block";
                    case 776:
                        return "Cobalt Pickaxe";
                    case 777:
                        return "Mythril Pickaxe";
                    case 778:
                        return "Adamantite Pickaxe";
                    case 779:
                        return "Clentaminator";
                    case 780:
                        return "Green Solution";
                    case 781:
                        return "Blue Solution";
                    case 782:
                        return "Purple Solution";
                    case 783:
                        return "Dark Blue Solution";
                    case 784:
                        return "Red Solution";
                    case 785:
                        return "Harpy Wings";
                    case 786:
                        return "Bone Wings";
                    case 787:
                        return "Hammush";
                    case 788:
                        return "Nettle Burst";
                    case 789:
                        return "Ankh Banner";
                    case 790:
                        return "Snake Banner";
                    case 791:
                        return "Omega Banner";
                    case 792:
                        return "Crimson Helmet";
                    case 793:
                        return "Crimson Scalemail";
                    case 794:
                        return "Crimson Greaves";
                    case 795:
                        return "Blood Butcherer";
                    case 796:
                        return "Composite Bow"; //"Tendon Bow";
                    case 797:
                        return "Flesh Grinder";
                    case 798:
                        return "Deathbringer Pickaxe";
                    case 799:
                        return "Blood Lust Cluster";
                    case 800:
                        return "Hamstringer"; //"The Undertaker";
                    case 801:
                        return "The Meatball";
                    case 802:
                        return "The Rotted Fork";
                    case 803:
                        return "Eskimo Hood";
                    case 804:
                        return "Eskimo Coat";
                    case 805:
                        return "Eskimo Pants";
                    case 806:
                        return "Living Wood Chair";
                    case 807:
                        return "Cactus Chair";
                    case 808:
                        return "Bone Chair";
                    case 809:
                        return "Flesh Chair";
                    case 810:
                        return "Mushroom Chair";
                    case 811:
                        return "Bone Work Bench";
                    case 812:
                        return "Cactus Work Bench";
                    case 813:
                        return "Flesh Work Bench";
                    case 814:
                        return "Mushroom Work Bench";
                    case 815:
                        return "Slime Work Bench";
                    case 816:
                        return "Cactus Door";
                    case 817:
                        return "Flesh Door";
                    case 818:
                        return "Mushroom Door";
                    case 819:
                        return "Living Wood Door";
                    case 820:
                        return "Bone Door";
                    case 821:
                        return "Flame Wings";
                    case 822:
                        return "Frozen Wings";
                    case 823:
                        return "Ghost Wings";
                    case 824:
                        return "Sunplate Block";
                    case 825:
                        return "Disc Wall";
                    case 826:
                        return "Skyware Chair";
                    case 827:
                        return "Bone Table";
                    case 828:
                        return "Flesh Table";
                    case 829:
                        return "Living Wood Table";
                    case 830:
                        return "Skyware Table";
                    case 831:
                        return "Living Wood Chest";
                    case 832:
                        return "Living Wood Wand";
                    case 833:
                        return "Purple Ice Block";
                    case 834:
                        return "Pink Ice Block";
                    case 835:
                        return "Red Ice Block";
                    case 836:
                        return "Crimstone Block";
                    case 837:
                        return "Skyware Door";
                    case 838:
                        return "Skyware Chest";
                    case 839:
                        return "Steampunk Hat";
                    case 840:
                        return "Steampunk Shirt";
                    case 841:
                        return "Steampunk Pants";
                    case 842:
                        return "Bee Hat";
                    case 843:
                        return "Bee Shirt";
                    case 844:
                        return "Bee Pants";
                    case 845:
                        return "World Banner";
                    case 846:
                        return "Sun Banner";
                    case 847:
                        return "Gravity Banner";
                    case 848:
                        return "Pharaoh's Mask";
                    case 849:
                        return "Actuator";
                    case 850:
                        return "Blue Wrench";
                    case 851:
                        return "Green Wrench";
                    case 852:
                        return "Blue Pressure Plate";
                    case 853:
                        return "Yellow Pressure Plate";
                    case 854:
                        return "Discount Card";
                    case 855:
                        return "Lucky Coin";
                    case 856:
                        return "Unicorn on a Stick";
                    case 857:
                        return "Sandstorm in a Bottle";
                    case 858:
                        return "bl";
                    case 859:
                        return "Beach Ball";
                    case 860:
                        return "Charm of Myths";
                    case 861:
                        return "Moon Shell";
                    case 862:
                        return "Star Veil";
                    case 863:
                        return "Water Walking Boots";
                    case 864:
                        return "Tiara";
                    case 865:
                        return "Princess Dress";
                    case 866:
                        return "Pharaoh's Robe";
                    case 867:
                        return "Green Cap";
                    case 868:
                        return "Mushroom Cap";
                    case 869:
                        return "Tam O' Shanter";
                    case 870:
                        return "Mummy Mask";
                    case 871:
                        return "Mummy Shirt";
                    case 872:
                        return "Mummy Pants";
                    case 873:
                        return "Cowboy Hat";
                    case 874:
                        return "Cowboy Jacket";
                    case 875:
                        return "Cowboy Pants";
                    case 876:
                        return "Pirate Hat";
                    case 877:
                        return "Pirate Shirt";
                    case 878:
                        return "Pirate Pants";
                    case 879:
                        return "Viking Helmet";
                    case 880:
                        return "Crimtane Ore";
                    case 881:
                        return "Cactus Sword";
                    case 882:
                        return "Cactus Pickaxe";
                    case 883:
                        return "Ice Brick";
                    case 884:
                        return "Ice Brick Wall";
                    case 885:
                        return "Adhesive Bandage";
                    case 886:
                        return "Armor Polish";
                    case 887:
                        return "Bezoar";
                    case 888:
                        return "Blindfold";
                    case 889:
                        return "Fast Clock";
                    case 890:
                        return "Megaphone";
                    case 891:
                        return "Nazar";
                    case 892:
                        return "Vitamins";
                    case 893:
                        return "Trifold Map";
                    case 894:
                        return "Cactus Helmet";
                    case 895:
                        return "Cactus Breastplate";
                    case 896:
                        return "Cactus Leggings";
                    case 897:
                        return "Power Glove";
                    case 898:
                        return "Lightning Boots";
                    case 899:
                        return "Sun Stone";
                    case 900:
                        return "Moon Stone";
                    case 901:
                        return "Armor Bracing";
                    case 902:
                        return "Medicated Bandage";
                    case 903:
                        return "The Plan";
                    case 904:
                        return "Countercurse Mantra";
                    case 905:
                        return "Coin Gun";
                    case 906:
                        return "Lava Charm";
                    case 907:
                        return "Obsidian Water Walking Boots";
                    case 908:
                        return "Lava Waders";
                    case 909:
                        return "Pure Water Fountain";
                    case 910:
                        return "Desert Water Fountain";
                    case 911:
                        return "Shadewood";
                    case 912:
                        return "Shadewood Door";
                    case 913:
                        return "Shadewood Platform";
                    case 914:
                        return "Shadewood Chest";
                    case 915:
                        return "Shadewood Chair";
                    case 916:
                        return "Shadewood Work Bench";
                    case 917:
                        return "Shadewood Table";
                    case 918:
                        return "Shadewood Dresser";
                    case 919:
                        return "Shadewood Piano";
                    case 920:
                        return "Shadewood Bed";
                    case 921:
                        return "Shadewood Sword";
                    case 922:
                        return "Shadewood Hammer";
                    case 923:
                        return "Shadewood Bow";
                    case 924:
                        return "Shadewood Helmet";
                    case 925:
                        return "Shadewood Breastplate";
                    case 926:
                        return "Shadewood Greaves";
                    case 927:
                        return "Shadewood Wall";
                    case 928:
                        return "Cannon";
                    case 929:
                        return "Cannonball";
                    case 930:
                        return "Flare Gun";
                    case 931:
                        return "Flare";
                    case 932:
                        return "Bone Wand";
                    case 933:
                        return "Leaf Wand";
                    case 934:
                        return "Flying Carpet";
                    case 935:
                        return "Lucky Emblem"; //"Avenger Emblem";
                    case 936:
                        return "Mechanical Glove";
                    case 937:
                        return "Land Mine";
                    case 938:
                        return "Paladin's Shield";
                    case 939:
                        return "Web Slinger";
                    case 940:
                        return "Jungle Water Fountain";
                    case 941:
                        return "Icy Water Fountain";
                    case 942:
                        return "Corrupt Water Fountain";
                    case 943:
                        return "Crimson Water Fountain";
                    case 944:
                        return "Hallowed Water Fountain";
                    case 945:
                        return "Blood Water Fountain";
                    case 946:
                        return "Umbrella";
                    case 947:
                        return "Chlorophyte Ore";
                    case 948:
                        return "Steampunk Wings";
                    case 949:
                        return "Snowball";
                    case 950:
                        return "Ice Skates";
                    case 951:
                        return "Snowball Launcher";
                    case 952:
                        return "Web Covered Chest";
                    case 953:
                        return "Climbing Claws";
                    case 954:
                        return "Ancient Iron Helmet";
                    case 955:
                        return "Ancient Gold Helmet";
                    case 956:
                        return "Ancient Shadow Helmet";
                    case 957:
                        return "Ancient Shadow Scalemail";
                    case 958:
                        return "Ancient Shadow Greaves";
                    case 959:
                        return "Ancient Necro Helmet";
                    case 960:
                        return "Ancient Cobalt Helmet";
                    case 961:
                        return "Ancient Cobalt Breastplate";
                    case 962:
                        return "Ancient Cobalt Leggings";
                    case 963:
                        return "Black Belt";
                    case 964:
                        return "Boomstick";
                    case 965:
                        return "Rope";
                    case 966:
                        return "Campfire";
                    case 967:
                        return "Marshmellow";
                    case 968:
                        return "Marshmellow on a Stick";
                    case 969:
                        return "Cooked Marshmellow";
                    case 970:
                        return "Red Rocket";
                    case 971:
                        return "Green Rocket";
                    case 972:
                        return "Blue Rocket";
                    case 973:
                        return "Yellow Rocket";
                    case 974:
                        return "Ice Torch";
                    case 975:
                        return "Shoe Spikes";
                    case 976:
                        return "Tiger Climbing Gear";
                    case 977:
                        return "Tabi";
                    case 978:
                        return "Pink Eskimo Hood";
                    case 979:
                        return "Pink Eskimo Coat";
                    case 980:
                        return "Pink Eskimo Pants";
                    case 981:
                        return "Pink Thread";
                    case 982:
                        return "Band of the Elder"; //"Mana Regeneration Band";
                    case 983:
                        return "Sandstorm in a Balloon";
                    case 984:
                        return "Master Ninja Gear";
                    case 985:
                        return "Rope Coil";
                    case 986:
                        return "Blowgun";
                    case 987:
                        return "Blizzard in a Bottle";
                    case 988:
                        return "Frostburn Arrow";
                    case 989:
                        return "Enchanted Sword";
                    case 990:
                        return "Pickaxe Axe";
                    case 991:
                        return "Cobalt Waraxe";
                    case 992:
                        return "Mythril Waraxe";
                    case 993:
                        return "Adamantite Waraxe";
                    case 994:
                        return "Eater's Bone";
                    case 995:
                        return "Blend-O-Matic";
                    case 996:
                        return "Meat Grinder";
                    case 997:
                        return "Extractinator";
                    case 998:
                        return "Solidifier";
                    case 999:
                        return "Amber";
                    case 1000:
                        return "Confetti Gun";
                    case 1001:
                        return "Chlorophyte Mask";
                    case 1002:
                        return "Chlorophyte Helmet";
                    case 1003:
                        return "Chlorophyte Headgear";
                    case 1004:
                        return "Chlorophyte Plate Mail";
                    case 1005:
                        return "Chlorophyte Greaves";
                    case 1006:
                        return "Chlorophyte Bar";
                    case 1007:
                        return "Red Dye";
                    case 1008:
                        return "Orange Dye";
                    case 1009:
                        return "Yellow Dye";
                    case 1010:
                        return "Lime Dye";
                    case 1011:
                        return "Green Dye";
                    case 1012:
                        return "Teal Dye";
                    case 1013:
                        return "Cyan Dye";
                    case 1014:
                        return "Sky Blue Dye";
                    case 1015:
                        return "Blue Dye";
                    case 1016:
                        return "Purple Dye";
                    case 1017:
                        return "Violet Dye";
                    case 1018:
                        return "Pink Dye";
                    case 1019:
                        return "Red and Black Dye";
                    case 1020:
                        return "Orange and Black Dye";
                    case 1021:
                        return "Yellow and Black Dye";
                    case 1022:
                        return "Lime and Black Dye";
                    case 1023:
                        return "Green and Black Dye";
                    case 1024:
                        return "Teal and Black Dye";
                    case 1025:
                        return "Cyan and Black Dye";
                    case 1026:
                        return "Sky Blue and Black Dye";
                    case 1027:
                        return "Blue and Black Dye";
                    case 1028:
                        return "Purple and Black Dye";
                    case 1029:
                        return "Violet and Black Dye";
                    case 1030:
                        return "Pink and Black Dye";
                    case 1031:
                        return "Flame Dye";
                    case 1032:
                        return "Flame and Black Dye";
                    case 1033:
                        return "Green Flame Dye";
                    case 1034:
                        return "Green Flame and Black Dye";
                    case 1035:
                        return "Blue Flame Dye";
                    case 1036:
                        return "Blue Flame and Black Dye";
                    case 1037:
                        return "Silver Dye";
                    case 1038:
                        return "Bright Red Dye";
                    case 1039:
                        return "Bright Orange Dye";
                    case 1040:
                        return "Bright Yellow Dye";
                    case 1041:
                        return "Bright Lime Dye";
                    case 1042:
                        return "Bright Green Dye";
                    case 1043:
                        return "Bright Teal Dye";
                    case 1044:
                        return "Bright Cyan Dye";
                    case 1045:
                        return "Bright Sky Blue Dye";
                    case 1046:
                        return "Bright Blue Dye";
                    case 1047:
                        return "Bright Purple Dye";
                    case 1048:
                        return "Bright Violet Dye";
                    case 1049:
                        return "Bright Pink Dye";
                    case 1050:
                        return "Black Dye";
                    case 1051:
                        return "Red and Silver Dye";
                    case 1052:
                        return "Orange and Silver Dye";
                    case 1053:
                        return "Yellow and Silver Dye";
                    case 1054:
                        return "Lime and Silver Dye";
                    case 1055:
                        return "Green and Silver Dye";
                    case 1056:
                        return "Teal and Silver Dye";
                    case 1057:
                        return "Cyan and Silver Dye";
                    case 1058:
                        return "Sky Blue and Silver Dye";
                    case 1059:
                        return "Blue and Silver Dye";
                    case 1060:
                        return "Purple and Silver Dye";
                    case 1061:
                        return "Violet and Silver Dye";
                    case 1062:
                        return "Pink and Silver Dye";
                    case 1063:
                        return "Intense Flame Dye";
                    case 1064:
                        return "Intense Green Flame Dye";
                    case 1065:
                        return "Intense Blue Flame Dye";
                    case 1066:
                        return "Rainbow Dye";
                    case 1067:
                        return "Intense Rainbow Dye";
                    case 1068:
                        return "Yellow Gradient Dye";
                    case 1069:
                        return "Cyan Gradient Dye";
                    case 1070:
                        return "Violet Gradient Dye";
                    case 1071:
                        return "Paintbrush";
                    case 1072:
                        return "Paint Roller";
                    case 1073:
                        return "Recipe - Band of the Elder"; //"Red Paint";
                    case 1074:
                        return "Recipe - Magic Cuffs"; //"Orange Paint";
                    case 1075:
                        return "Recipe - Lightning Boots"; //"Yellow Paint";
                    case 1076:
                        return "Recipe - Cloud in a Balloon"; //"Lime Paint";
                    case 1077:
                        return "Recipe - Bee Cloak"; //"Green Paint";
                    case 1078:
                        return "Recipe - Power Glove"; //"Teal Paint";
                    case 1079:
                        return "Recipe - Mechanical Glove"; //"Cyan Paint";
                    case 1080:
                        return "Recipe - Status Gauntlet"; //"Sky Blue Paint";
                    case 1081:
                        return "Recipe - Chlorophyte Scope"; //"Blue Paint";
                    case 1082:
                        return "Recipe - Chlorophyte Quiver"; //"Purple Paint";
                    case 1083:
                        return "Recipe - Cryogenic Shield"; //"Violet Paint";
                    case 1084:
                        return "Recipe - Hermes Tabi"; //"Pink Paint";
                    case 1085:
                        return "Recipe - Brute Instincts"; //"Deep Red Paint";
                    case 1086:
                        return "Recipe - Calm Instincts"; //"Deep Orange Paint";
                    case 1087:
                        return "Recipe - Daring Instincts"; //"Deep Yellow Paint";
                    case 1088:
                        return "Recipe - Arcane Cloud Emblem"; //"Deep Lime Paint";
                    case 1089:
                        return "Recipe - Blood Gem"; //"Deep Green Paint";
                    case 1090:
                        return "Arcane Cloud Emblem"; //"Deep Teal Paint";
                    case 1091:
                        return "Brute Instincts";
                    case 1092:
                        return "Calm Instincts";
                    case 1093:
                        return "Daring Instincts";
                    case 1094:
                        return "Hermes Tabi";
                    case 1095:
                        return "Cryogenic Shield";
                    case 1096:
                        return "Recipe - Band of the Eagle";
                    case 1097:
                        return "Recipe - Eagle Cuffs";
                    case 1098:
                        return "Silent Steppers";
                    case 1099:
                        return "Recipe - Silent Steppers";
                    case 1100:
                        return "Blood Gem"; //"Paint Scraper";
                    case 1101:
                        return "Armband"; //"Lihzahrd Brick";
                    case 1102:
                        return "Cobalt Bracer"; //"Lihzahrd Brick Wall";
                    case 1103:
                        return "Lexicon"; //"Slush Block";
                    case 1104:
                        return "Recipe - Paladin's Shield"; //"Palladium Ore";
                    case 1105:
                        return "Recipe - Shiny Red Boots"; //"Orichalcum Ore";
                    case 1106:
                        return "Recipe - Honey Comb Gauntlet"; //""Titanium Ore";
                    case 1107:
                        return "Recipe - Refreshing Orb"; //"Teal Mushroom";
                    case 1108:
                        return "Shiny Red Boots"; //"Green Mushroom";
                    case 1109:
                        return "Honey Comb Gauntlet"; //Sky Blue Flower";
                    case 1110:
                        return "Refreshing Orb"; //"Yellow Marigold";
                    case 1111:
                        return "Arcane Boots"; //"Blue Berries";
                    case 1112:
                        return "Recipe - Arcane Boots"; //"Lime Kelp";
                    case 1113:
                        return "Recipe - Lucky Emblem"; //"Pink Prickly Pear";
                    case 1114:
                        return "Ancient Flail"; //"Orange Bloodroot";
                    case 1115:
                        return "Red Husk";
                    case 1116:
                        return "Cyan Husk";
                    case 1117:
                        return "Violet Husk";
                    case 1118:
                        return "Purple Mucos";
                    case 1119:
                        return "Black Ink";
                    case 1120:
                        return "Dye Vat";
                    case 1121:
                        return "Bee Gun";
                    case 1122:
                        return "Possessed Hatchet";
                    case 1123:
                        return "Bee Keeper";
                    case 1124:
                        return "Hive";
                    case 1125:
                        return "Honey Block";
                    case 1126:
                        return "Hive Wall";
                    case 1127:
                        return "Crispy Honey Block";
                    case 1128:
                        return "Honey Bucket";
                    case 1129:
                        return "Hive Wand";
                    case 1130:
                        return "Beenade";
                    case 1131:
                        return "Gravity Globe";
                    case 1132:
                        return "Honey Comb";
                    case 1133:
                        return "Abeemination";
                    case 1134:
                        return "Bottled Honey";
                    case 1135:
                        return "Rain Hat";
                    case 1136:
                        return "Rain Coat";
                    case 1137:
                        return "Lihzahrd Door";
                    case 1138:
                        return "Dungeon Door";
                    case 1139:
                        return "Lead Door";
                    case 1140:
                        return "Iron Door";
                    case 1141:
                        return "Temple Key";
                    case 1142:
                        return "Lihzahrd Chest";
                    case 1143:
                        return "Lihzahrd Chair";
                    case 1144:
                        return "Lihzahrd Table";
                    case 1145:
                        return "Lihzahrd Work Bench";
                    case 1146:
                        return "Super Dart Trap";
                    case 1147:
                        return "Flame Trap";
                    case 1148:
                        return "Spiky Ball Trap";
                    case 1149:
                        return "Spear Trap";
                    case 1150:
                        return "Wooden Spike";
                    case 1151:
                        return "Lihzahrd Pressure Plate";
                    case 1152:
                        return "Lihzahrd Statue";
                    case 1153:
                        return "Lihzahrd Watcher Statue";
                    case 1154:
                        return "Lihzahrd Guardian Statue";
                    case 1155:
                        return "Wasp Gun";
                    case 1156:
                        return "Piranha Gun";
                    case 1157:
                        return "Pygmy Staff";
                    case 1158:
                        return "Pygmy Necklace";
                    case 1159:
                        return "Tiki Mask";
                    case 1160:
                        return "Tiki Shirt";
                    case 1161:
                        return "Tiki Pants";
                    case 1162:
                        return "Leaf Wings";
                    case 1163:
                        return "Blizzard in a Balloon";
                    case 1164:
                        return "Bundle of Balloons";
                    case 1165:
                        return "Bat Wings";
                    case 1166:
                        return "Bone Sword";
                    case 1167:
                        return "Hercules Beetle";
                    case 1168:
                        return "Smoke Bomb";
                    case 1169:
                        return "Bone Key";
                    case 1170:
                        return "Nectar";
                    case 1171:
                        return "Idol"; //"Tiki Totem";
                    case 1172:
                        return "Lizard Egg";
                    case 1173:
                        return "Grave Marker";
                    case 1174:
                        return "Cross Grave Marker";
                    case 1175:
                        return "Headstone";
                    case 1176:
                        return "Gravestone";
                    case 1177:
                        return "Obelisk";
                    case 1178:
                        return "Leaf Blower";
                    case 1179:
                        return "Chlorophyte Bullet";
                    case 1180:
                        return "Parrot Cracker";
                    case 1181:
                        return "Strange Glowing Mushroom";
                    case 1182:
                        return "Seedling";
                    case 1183:
                        return "Wisp in a Bottle";
                    case 1184:
                        return "Palladium Bar";
                    case 1185:
                        return "Palladium Sword";
                    case 1186:
                        return "Palladium Pike";
                    case 1187:
                        return "Palladium Repeater";
                    case 1188:
                        return "Palladium Pickaxe";
                    case 1189:
                        return "Palladium Drill";
                    case 1190:
                        return "Palladium Chainsaw";
                    case 1191:
                        return "Orichalcum Bar";
                    case 1192:
                        return "Orichalcum Sword";
                    case 1193:
                        return "Orichalcum Halberd";
                    case 1194:
                        return "Orichalcum Repeater";
                    case 1195:
                        return "Orichalcum Pickaxe";
                    case 1196:
                        return "Orichalcum Drill";
                    case 1197:
                        return "Orichalcum Chainsaw";
                    case 1198:
                        return "Titanium Bar";
                    case 1199:
                        return "Titanium Sword";
                    case 1200:
                        return "Death's Design"; //"Titanium Trident";
                    case 1201:
                        return "Titanium Repeater";
                    case 1202:
                        return "Titanium Pickaxe";
                    case 1203:
                        return "Titanium Drill";
                    case 1204:
                        return "Titanium Chainsaw";
                    case 1205:
                        return "Palladium Mask";
                    case 1206:
                        return "Palladium Helmet";
                    case 1207:
                        return "Palladium Headgear";
                    case 1208:
                        return "Palladium Breastplate";
                    case 1209:
                        return "Palladium Leggings";
                    case 1210:
                        return "Orichalcum Mask";
                    case 1211:
                        return "Orichalcum Helmet";
                    case 1212:
                        return "Orichalcum Headgear";
                    case 1213:
                        return "Orichalcum Breastplate";
                    case 1214:
                        return "Orichalcum Leggings";
                    case 1215:
                        return "Titanium Mask";
                    case 1216:
                        return "Titanium Helmet";
                    case 1217:
                        return "Titanium Headgear";
                    case 1218:
                        return "Titanium Breastplate";
                    case 1219:
                        return "Titanium Leggings";
                    case 1220:
                        return "Orichalcum Anvil";
                    case 1221:
                        return "Titanium Forge";
                    case 1222:
                        return "Palladium Waraxe";
                    case 1223:
                        return "Orichalcum Waraxe";
                    case 1224:
                        return "Titanium Waraxe";
                    case 1225:
                        return "Hallowed Bar";
                    case 1226:
                        return "Chlorophyte Claymore";
                    case 1227:
                        return "Chlorophyte Saber";
                    case 1228:
                        return "Chlorophyte Partisan";
                    case 1229:
                        return "Chlorophyte Shotbow";
                    case 1230:
                        return "Chlorophyte Pickaxe";
                    case 1231:
                        return "Chlorophyte Drill";
                    case 1232:
                        return "Chlorophyte Chainsaw";
                    case 1233:
                        return "Chlorophyte Greataxe";
                    case 1234:
                        return "Chlorophyte Warhammer";
                    case 1235:
                        return "Chlorophyte Arrow";
                    case 1236:
                        return "Amethyst Hook";
                    case 1237:
                        return "Topaz Hook";
                    case 1238:
                        return "Sapphire Hook";
                    case 1239:
                        return "Emerald Hook";
                    case 1240:
                        return "Ruby Hook";
                    case 1241:
                        return "Diamond Hook";
                    case 1242:
                        return "Amber Mosquito";
                    case 1243:
                        return "Umbrella Hat";
                    case 1244:
                        return "Nimbus Rod";
                    case 1245:
                        return "Orange Torch";
                    case 1246:
                        return "Crimsand Block";
                    case 1247:
                        return "Bee Cloak";
                    case 1248:
                        return "Eye of the Golem";
                    case 1249:
                        return "Honey Balloon";
                    case 1250:
                        return "Blue Horseshoe Balloon";
                    case 1251:
                        return "White Horseshoe Balloon";
                    case 1252:
                        return "Yellow Horseshoe Balloon";
                    case 1253:
                        return "Frozen Turtle Shell";
                    case 1254:
                        return "Sniper Rifle";
                    case 1255:
                        return "Venus Magnum";
                    case 1256:
                        return "Crimson Rod";
                    case 1257:
                        return "Crimtane Bar";
                    case 1258:
                        return "Stynger";
                    case 1259:
                        return "Flower Pow";
                    case 1260:
                        return "Rainbow Gun";
                    case 1261:
                        return "Stynger Bolt";
                    case 1262:
                        return "Chlorophyte Jackhammer";
                    case 1263:
                        return "Teleporter";
                    case 1264:
                        return "Flower of Frost";
                    case 1265:
                        return "Uzi";
                    case 1266:
                        return "Magnet Sphere";
                    case 1267:
                        return "Purple Stained Glass";
                    case 1268:
                        return "Yellow Stained Glass";
                    case 1269:
                        return "Blue Stained Glass";
                    case 1270:
                        return "Green Stained Glass";
                    case 1271:
                        return "Red Stained Glass";
                    case 1272:
                        return "Multicolored Stained Glass";
                    case 1273:
                        return "Skeletron Hand";
                    case 1274:
                        return "Skull";
                    case 1275:
                        return "Balla Hat";
                    case 1276:
                        return "Gangsta Hat";
                    case 1277:
                        return "Sailor Hat";
                    case 1278:
                        return "Eye Patch";
                    case 1279:
                        return "Sailor Shirt";
                    case 1280:
                        return "Sailor Pants";
                    case 1281:
                        return "Skeletron Mask";
                    case 1282:
                        return "Amethyst Robe";
                    case 1283:
                        return "Topaz Robe";
                    case 1284:
                        return "Sapphire Robe";
                    case 1285:
                        return "Emerald Robe";
                    case 1286:
                        return "Ruby Robe";
                    case 1287:
                        return "Diamond Robe";
                    case 1288:
                        return "White Tuxedo Shirt";
                    case 1289:
                        return "White Tuxedo Pants";
                    case 1290:
                        return "Panic Necklace";
                    case 1291:
                        return "Life Fruit";
                    case 1292:
                        return "Lihzahrd Altar";
                    case 1293:
                        return "Lihzahrd Power Cell";
                    case 1294:
                        return "Picksaw";
                    case 1295:
                        return "Heat Ray";
                    case 1296:
                        return "Staff of Earth";
                    case 1297:
                        return "Golem Fist";
                    case 1298:
                        return "Water Chest";
                    case 1299:
                        return "Binoculars";
                    case 1300:
                        return "Rifle Scope";
                    case 1301:
                        return "Destroyer Emblem";
                    case 1302:
                        return "High Velocity Bullet";
                    case 1303:
                        return "Jellyfish Necklace";
                    case 1304:
                        return "Zombie Arm";
                    case 1305:
                        return "The Axe";
                    case 1306:
                        return "Ice Sickle";
                    case 1307:
                        return "Clothier Voodoo Doll";
                    case 1308:
                        return "Poison Staff";
                    case 1309:
                        return "Slime Staff";
                    case 1310:
                        return "Poison Dart";
                    case 1311:
                        return "Eye Spring";
                    case 1312:
                        return "Toy Sled";
                    case 1313:
                        return "Skull Staff"; //"Book of Skulls";
                    case 1314:
                        return "KO Cannon";
                    case 1315:
                        return "Pirate Map";
                    case 1316:
                        return "Turtle Helmet";
                    case 1317:
                        return "Turtle Scale Mail";
                    case 1318:
                        return "Turtle Leggings";
                    case 1319:
                        return "Snowball Cannon";
                    case 1320:
                        return "Bone Pickaxe";
                    case 1321:
                        return "Magic Quiver";
                    case 1322:
                        return "Magma Stone";
                    case 1323:
                        return "Obsidian Rose";
                    case 1324:
                        return "Bananarang";
                    case 1325:
                        return "Chain Knife";
                    case 1326:
                        return "Rod of Discord";
                    case 1327:
                        return "Death Sickle";
                    case 1328:
                        return "Turtle Shell";
                    case 1329:
                        return "Tissue Sample";
                    case 1330:
                        return "Vertebrae";
                    case 1331:
                        return "Bloody Spine";
                    case 1332:
                        return "Ichor";
                    case 1333:
                        return "Ichor Torch";
                    case 1334:
                        return "Ichor Arrow";
                    case 1335:
                        return "Ichor Bullet";
                    case 1336:
                        return "Golden Shower";
                    case 1337:
                        return "Bunny Cannon";
                    case 1338:
                        return "Explosive Bunny";
                    case 1339:
                        return "Vial of Venom";
                    case 1340:
                        return "Flask of Venom";
                    case 1341:
                        return "Venom Arrow";
                    case 1342:
                        return "Venom Bullet";
                    case 1343:
                        return "Fire Gauntlet";
                    case 1344:
                        return "Poisonous Gauntlet";
                    case 1345:
                        return "Crippling Gauntlet";
                    case 1346:
                        return "Darkness Gauntlet";
                    case 1347:
                        return "Piercing Gauntlet";
                    case 1348:
                        return "Venomous Gauntlet";
                    case 1349:
                        return "Runed Gauntlet";
                    case 1350:
                        return "Nano Bullet";
                    case 1351:
                        return "Exploding Bullet";
                    case 1352:
                        return "Golden Bullet";
                    case 1353:
                        return "Flask of Cursed Flames";
                    case 1354:
                        return "Flask of Fire";
                    case 1355:
                        return "Flask of Gold";
                    case 1356:
                        return "Flask of Ichor";
                    case 1357:
                        return "Flask of Nanites";
                    case 1358:
                        return "Flask of Party";
                    case 1359:
                        return "Flask of Poison";
                    case 1360:
                        return "Chlorophyte Scope"; //"Eye of Cthulhu Trophy";
                    case 1361:
                        return "Chlorophyte Quiver"; //"Eater of Worlds Trophy";
                    case 1362:
                        return "Paladin's Shield";
                    case 1363:
                        return "Band of the Agile";
                    case 1364:
                        return "Band of the Eagle";
                    case 1365:
                        return "Eagle Cuffs";
                    case 1366:
                        return "Band of the Knight";
                    case 1367:
                        return "Knight's Cuffs";
                    case 1368:
                        return "Recipe - Band of the Knight";
                    case 1369:
                        return "Recipe - Knight's Cuffs";
                    case 1370:
                        return "Plantera Trophy";
                    case 1371:
                        return "Golem Trophy";
                    case 1372:
                        return "Blood Moon Rising";
                    case 1373:
                        return "The Hanged Man";
                    case 1374:
                        return "Glory of the Fire";
                    case 1375:
                        return "Bone Warp";
                    case 1376:
                        return "Wall Skeleton";
                    case 1377:
                        return "Hanging Skeleton";
                    case 1378:
                        return "Blue Slab Wall";
                    case 1379:
                        return "Blue Tiled Wall";
                    case 1380:
                        return "Pink Slab Wall";
                    case 1381:
                        return "Pink Tiled Wall";
                    case 1382:
                        return "Green Slab Wall";
                    case 1383:
                        return "Green Tiled Wall";
                    case 1384:
                        return "Blue Brick Platform";
                    case 1385:
                        return "Pink Brick Platform";
                    case 1386:
                        return "Green Brick Platform";
                    case 1387:
                        return "Metal Shelf";
                    case 1388:
                        return "Brass Shelf";
                    case 1389:
                        return "Wood Shelf";
                    case 1390:
                        return "Brass Lantern";
                    case 1391:
                        return "Caged Lantern";
                    case 1392:
                        return "Carriage Lantern";
                    case 1393:
                        return "Alchemy Lantern";
                    case 1394:
                        return "Diablost Lamp";
                    case 1395:
                        return "Oil Rag Sconse";
                    case 1396:
                        return "Blue Dungeon Chair";
                    case 1397:
                        return "Blue Dungeon Table";
                    case 1398:
                        return "Blue Dungeon Work Bench";
                    case 1399:
                        return "Green Dungeon Chair";
                    case 1400:
                        return "Green Dungeon Table";
                    case 1401:
                        return "Green Dungeon Work Bench";
                    case 1402:
                        return "Pink Dungeon Chair";
                    case 1403:
                        return "Pink Dungeon Table";
                    case 1404:
                        return "Pink Dungeon Work Bench";
                    case 1405:
                        return "Blue Dungeon Candle";
                    case 1406:
                        return "Green Dungeon Candle";
                    case 1407:
                        return "Pink Dungeon Candle";
                    case 1408:
                        return "Blue Dungeon Vase";
                    case 1409:
                        return "Green Dungeon Vase";
                    case 1410:
                        return "Pink Dungeon Vase";
                    case 1411:
                        return "Blue Dungeon Door";
                    case 1412:
                        return "Green Dungeon Door";
                    case 1413:
                        return "Pink Dungeon Door";
                    case 1414:
                        return "Blue Dungeon Bookcase";
                    case 1415:
                        return "Green Dungeon Bookcase";
                    case 1416:
                        return "Pink Dungeon Bookcase";
                    case 1417:
                        return "Catacomb";
                    case 1418:
                        return "Dungeon Shelf";
                    case 1419:
                        return "Skellington J Skellingsworth";
                    case 1420:
                        return "The Cursed Man";
                    case 1421:
                        return "The Eye Sees the End";
                    case 1422:
                        return "Something Evil is Watching You";
                    case 1423:
                        return "The Twins Have Awoken";
                    case 1424:
                        return "The Screamer";
                    case 1425:
                        return "Goblins Playing Poker";
                    case 1426:
                        return "Dryadisque";
                    case 1427:
                        return "Sunflowers";
                    case 1428:
                        return "Terrarian Gothic";
                    case 1429:
                        return "Beanie";
                    case 1430:
                        return "Imbuing Station";
                    case 1431:
                        return "Star in a Bottle";
                    case 1432:
                        return "Empty Bullet";
                    case 1433:
                        return "Impact";
                    case 1434:
                        return "Powered by Birds";
                    case 1435:
                        return "The Destroyer";
                    case 1436:
                        return "The Persistency of Eyes";
                    case 1437:
                        return "Unicorn Crossing the Hallows";
                    case 1438:
                        return "Great Wave";
                    case 1439:
                        return "Starry Night";
                    case 1440:
                        return "Guide Picasso";
                    case 1441:
                        return "The Guardian's Gaze";
                    case 1442:
                        return "Father of Someone";
                    case 1443:
                        return "Nurse Lisa";
                    case 1444:
                        return "Shadowbeam Staff";
                    case 1445:
                        return "Inferno Missile"; //"Inferno Fork";
                    case 1446:
                        return "Cloud Nine";
                    case 1447:
                        return "Wooden Fence";
                    case 1448:
                        return "Metal Fence";
                    case 1449:
                        return "Bubble Machine";
                    case 1450:
                        return "Bubble Wand";
                    case 1451:
                        return "Marching Bones Banner";
                    case 1452:
                        return "Necromantic Sign";
                    case 1453:
                        return "Rusted Company Standard";
                    case 1454:
                        return "Ragged Brotherhood Sigil";
                    case 1455:
                        return "Molten Legion Flag";
                    case 1456:
                        return "Diabolic Sigil";
                    case 1457:
                        return "Obsidian Platform";
                    case 1458:
                        return "Obsidian Door";
                    case 1459:
                        return "Obsidian Chair";
                    case 1460:
                        return "Obsidian Table";
                    case 1461:
                        return "Obsidian Work Bench";
                    case 1462:
                        return "Obsidian Vase";
                    case 1463:
                        return "Obsidian Bookcase";
                    case 1464:
                        return "Hellbound Banner";
                    case 1465:
                        return "Hell Hammer Banner";
                    case 1466:
                        return "Helltower Banner";
                    case 1467:
                        return "Lost Hopes of Man Banner";
                    case 1468:
                        return "Obsidian Watcher Banner";
                    case 1469:
                        return "Lava Erupts Banner";
                    case 1470:
                        return "Blue Dungeon Bed";
                    case 1471:
                        return "Green Dungeon Bed";
                    case 1472:
                        return "Red Dungeon Bed";
                    case 1473:
                        return "Obsidian Bed";
                    case 1474:
                        return "Waldo";
                    case 1475:
                        return "Darkness";
                    case 1476:
                        return "Dark Soul Reaper";
                    case 1477:
                        return "Land";
                    case 1478:
                        return "Trapped Ghost";
                    case 1479:
                        return "Demon's Eye";
                    case 1480:
                        return "Finding Gold";
                    case 1481:
                        return "First Encounter";
                    case 1482:
                        return "Good Morning";
                    case 1483:
                        return "Underground Reward";
                    case 1484:
                        return "Through the Window";
                    case 1485:
                        return "Place Above the Clouds";
                    case 1486:
                        return "Do Not Step on the Grass";
                    case 1487:
                        return "Cold Waters in the White Land";
                    case 1488:
                        return "Lightless Chasms";
                    case 1489:
                        return "The Land of Deceiving Looks";
                    case 1490:
                        return "Daylight";
                    case 1491:
                        return "Secret of the Sands";
                    case 1492:
                        return "Deadland Comes Alive";
                    case 1493:
                        return "Evil Presence";
                    case 1494:
                        return "Sky Guardian";
                    case 1495:
                        return "American Explosive";
                    case 1496:
                        return "Discover";
                    case 1497:
                        return "Hand Earth";
                    case 1498:
                        return "Old Miner";
                    case 1499:
                        return "Skelehead";
                    case 1500:
                        return "Facing the Cerebral Mastermind";
                    case 1501:
                        return "Lake of Fire";
                    case 1502:
                        return "Trio Super Heroes";
                    case 1503:
                        return "Spectre Hood";
                    case 1504:
                        return "Spectre Robe";
                    case 1505:
                        return "Spectre Pants";
                    case 1506:
                        return "Spectre Pickaxe";
                    case 1507:
                        return "Spectre Hammer";
                    case 1508:
                        return "Ectoplasm";
                    case 1509:
                        return "Gothic Chair";
                    case 1510:
                        return "Gothic Table";
                    case 1511:
                        return "Gothic Work Bench";
                    case 1512:
                        return "Gothic Bookcase";
                    case 1513:
                        return "Paladin's Hammer";
                    case 1514:
                        return "SWAT Helmet";
                    case 1515:
                        return "Bee Wings";
                    case 1516:
                        return "Giant Harpey Feather";
                    case 1517:
                        return "Bone Feather";
                    case 1518:
                        return "Fire Feather";
                    case 1519:
                        return "Ice Feather";
                    case 1520:
                        return "Broken Bat Wing";
                    case 1521:
                        return "Tattered Bee Wing";
                    case 1522:
                        return "Large Amethyst";
                    case 1523:
                        return "Large Topaz";
                    case 1524:
                        return "Large Sapphire";
                    case 1525:
                        return "Large Emerald";
                    case 1526:
                        return "Large Ruby";
                    case 1527:
                        return "Large Diamond";
                    case 1528:
                        return "Jungle Chest";
                    case 1529:
                        return "Corruption Chest";
                    case 1530:
                        return "Crimson Chest";
                    case 1531:
                        return "Hallowed Chest";
                    case 1532:
                        return "Frozen Chest";
                    case 1533:
                        return "Jungle Key";
                    case 1534:
                        return "Corruption Key";
                    case 1535:
                        return "Crimson Key";
                    case 1536:
                        return "Hallowed Key";
                    case 1537:
                        return "Frozen Key";
                    case 1538:
                        return "Imp Face";
                    case 1539:
                        return "Ominous Presence";
                    case 1540:
                        return "Shining Moon";
                    case 1541:
                        return "Living Gore";
                    case 1542:
                        return "Flowing Magma";
                    case 1543:
                        return "Spectre Paintbrush";
                    case 1544:
                        return "Spectre Paint Roller";
                    case 1545:
                        return "Spectre Paint Scraper";
                    case 1546:
                        return "Shroomite Headgear";
                    case 1547:
                        return "Shroomite Mask";
                    case 1548:
                        return "Shroomite Helmet";
                    case 1549:
                        return "Shroomite Breastplate";
                    case 1550:
                        return "Shroomite Leggings";
                    case 1551:
                        return "Autohammer";
                    case 1552:
                        return "Shroomite Bar";
                    case 1553:
                        return "S.D.M.G.";
                    case 1554:
                        return "Circlet"; //"Cenx's Tiara";
                    case 1555:
                        return "Cenx's Breastplate";
                    case 1556:
                        return "Cenx's Leggings";
                    case 1557:
                        return "Crowno's Mask";
                    case 1558:
                        return "Crowno's Breastplate";
                    case 1559:
                        return "Crowno's Leggings";
                    case 1560:
                        return "Will's Helmet";
                    case 1561:
                        return "Will's Breastplate";
                    case 1562:
                        return "Will's Leggings";
                    case 1563:
                        return "Jim's Helmet";
                    case 1564:
                        return "Jim's Breastplate";
                    case 1565:
                        return "Jim's Leggings";
                    case 1566:
                        return "Aaron's Helmet";
                    case 1567:
                        return "Aaron's Breastplate";
                    case 1568:
                        return "Aaron's Leggings";
                    case 1569:
                        return "Vampire Knives";
                    case 1570:
                        return "Broken Hero Sword";
                    case 1571:
                        return "Scourge of the Corruptor";
                    case 1572:
                        return "Staff of the Frost Hydra";
                    case 1573:
                        return "The Creation of the Guide";
                    case 1574:
                        return "The Merchant";
                    case 1575:
                        return "Crowno Devours His Lunch";
                    case 1576:
                        return "Rare Enchantment";
                    case 1577:
                        return "Glorious Night";
                    case 1578:
                        return "Sweetheart Necklace";
                    case 1579:
                        return "Flurry Boots";
                    case 1580:
                        return "D-Town's Helmet";
                    case 1581:
                        return "D-Town's Breastplate";
                    case 1582:
                        return "D-Town's Leggings";
                    case 1583:
                        return "D-Town's Wings";
                    case 1584:
                        return "Will's Wings";
                    case 1585:
                        return "Crowno's Wings";
                    case 1586:
                        return "Cenx's Wings";
                    case 1587:
                        return "Cenx's Dress";
                    case 1588:
                        return "Cenx's Dress Pants";
                    case 1589:
                        return "Palladium Column";
                    case 1590:
                        return "Palladium Column Wall";
                    case 1591:
                        return "Bubblegum Block";
                    case 1592:
                        return "Bubblegum Block Wall";
                    case 1593:
                        return "Titanstone Block";
                    case 1594:
                        return "Titanstone Block Wall";
                    case 1595:
                        return "Magic Cuffs";
                    case 1596:
                        return "Music Box (Snow)";
                    case 1597:
                        return "Music Box (Space)";
                    case 1598:
                        return "Music Box (Crimson)";
                    case 1599:
                        return "Music Box (Boss 4)";
                    case 1600:
                        return "Music Box (Alt Overworld Day)";
                    case 1601:
                        return "Music Box (Rain)";
                    case 1602:
                        return "Music Box (Ice)";
                    case 1603:
                        return "Music Box (Desert)";
                    case 1604:
                        return "Music Box (Ocean)";
                    case 1605:
                        return "Music Box (Dungeon)";
                    case 1606:
                        return "Music Box (Plantera)";
                    case 1607:
                        return "Music Box (Boss 5)";
                    case 1608:
                        return "Music Box (Temple)";
                    case 1609:
                        return "Music Box (Eclipse)";
                    case 1610:
                        return "Music Box (Mushrooms)";
                    case 1611:
                        return "Butterfly Dust";
                    case 1612:
                        return "Ankh Charm";
                    case 1613:
                        return "Ankh Shield";
                    case 1614:
                        return "Blue Flare";
                }
            }
            if (!english && Lang.lang > 1)
            {
                return Lang.itemName(l, true);
            }
            return "";
        }

        public static string evilGood()
        {
            if (Lang.lang <= 1)
            {
                string text;
                if (WorldGen.tGood == 0)
                {
                    text = string.Concat(new object[]
                    {
                        Main.worldName,
                        " is ",
                        WorldGen.tEvil,
                        "% corrupt."
                    });
                }
                else
                {
                    if (WorldGen.tEvil == 0)
                    {
                        text = string.Concat(new object[]
                        {
                            Main.worldName,
                            " is ",
                            WorldGen.tGood,
                            "% hallow."
                        });
                    }
                    else
                    {
                        text = string.Concat(new object[]
                        {
                            Main.worldName,
                            " is ",
                            WorldGen.tGood,
                            "% hallow, and ",
                            WorldGen.tEvil,
                            "% corrupt."
                        });
                    }
                }
                if (WorldGen.tGood > WorldGen.tEvil)
                {
                    text += " Keep up the good work!";
                }
                else
                {
                    if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
                    {
                        text += " Things are grim indeed.";
                    }
                    else
                    {
                        text += " You should try harder.";
                    }
                }
                return text;
            }
            return "";
        }

        public static string title()
        {
            switch (Main.rand.Next(13))
            {
                case 0:
                    return "STS: What's a tooltip?";
                case 1:
                    return "STS: That's a known bug";
                case 2:
                    return "STS: Everything's OP, Fix it";
                case 3:
                    return "STS: Soul Eater with swords, the movie, the game";
                case 4:
                    return "STS: God has come to reap the sinners";
                case 5:
                    return "STS: 3v3 on a 1v1 map?";
                case 6:
                    return "STS: Now featuring the new gun, Hamslinger";
                case 7:
                    return "STS: Relentless Optimism";
                case 8:
                    return "STS: Now with more 1's and less 0's";
                case 9:
                    return "STS: I formal Joey";
                case 10:
                    return "STS: A game about skill, not just DPS";
                case 11:
                    return "STS: Banned in most places";
                case 12:
                    return "STS: I could not think of a more perfect duet";
                default:
                    return "STS: How did I get here?";
            }
        }

        public static void setLang(bool english = false)
        {
            Main.chTitle = true;
            if (Lang.lang <= 1 || english)
            {
                Lang.misc[0] = "A goblin army has been defeated!";
                Lang.misc[1] = "A goblin army is approaching from the west!";
                Lang.misc[2] = "A goblin army is approaching from the east!";
                Lang.misc[3] = "A goblin army has arrived!";
                Lang.misc[4] = "The Frost Legion has been defeated!";
                Lang.misc[5] = "The Frost Legion is approaching from the west!";
                Lang.misc[6] = "The Frost Legion is approaching from the east!";
                Lang.misc[7] = "The Frost Legion has arrived!";
                Lang.misc[8] = "The Blood Moon is rising...";
                Lang.misc[9] = "You feel an evil presence watching you...";
                Lang.misc[10] = "A horrible chill goes down your spine...";
                Lang.misc[11] = "Screams echo around you...";
                Lang.misc[12] = "Your world has been blessed with Cobalt!";
                Lang.misc[13] = "Your world has been blessed with Mythril!";
                Lang.misc[14] = "Your world has been blessed with Adamantite!";
                Lang.misc[15] = "The ancient spirits of light and dark have been released.";
                Lang.misc[16] = "has awoken!";
                Lang.misc[17] = "has been defeated!";
                Lang.misc[18] = "has arrived!";
                Lang.misc[19] = " was slain...";
                Lang.misc[20] = "A solar eclipse is happening!";
                Lang.misc[21] = "Your world has been blessed with Palladium!";
                Lang.misc[22] = "Your world has been blessed with Orichalcum!";
                Lang.misc[23] = "Your world has been blessed with Titanium!";
                Lang.misc[24] = "The pirates have been defeated!";
                Lang.misc[25] = "Pirates are approaching from the west!";
                Lang.misc[26] = "Pirates are approaching from the east!";
                Lang.misc[27] = "The pirates have arrived!";
                Lang.misc[28] = "You feel vibrations from deep below...";
                Lang.misc[29] = "This is going to be a terrible night...";
                Lang.misc[30] = "The air is getting colder around you...";
                Lang.menu[0] = "Start a new instance of Terraria to join!";
                Lang.menu[1] = "Running on port ";
                Lang.menu[2] = "Disconnect";
                Lang.menu[3] = "Server Requires Password:";
                Lang.menu[4] = "Accept";
                Lang.menu[5] = "Back";
                Lang.menu[6] = "Cancel";
                Lang.menu[7] = "Enter Server Password:";
                Lang.menu[8] = "Starting server...";
                Lang.menu[9] = "Load failed!";
                Lang.menu[10] = "Load Backup";
                Lang.menu[11] = "No backup found";
                Lang.menu[12] = "Single Player";
                Lang.menu[13] = "Multiplayer";
                Lang.menu[14] = "Settings";
                Lang.menu[15] = "Exit";
                Lang.menu[16] = "Create Character";
                Lang.menu[17] = "Delete";
                Lang.menu[18] = "Hero"; // "Hair";
                Lang.menu[19] = ""; // "Eyes";
                Lang.menu[20] = ""; //"Skin";
                Lang.menu[21] = ""; //"Clothes";
                Lang.menu[22] = "White Team";
                Lang.menu[23] = "Black Team";
                Lang.menu[24] = "Spectator"; //"Hardcore";
                Lang.menu[25] = ""; //"Mediumcore";
                Lang.menu[26] = ""; //"Softcore";
                Lang.menu[27] = ""; //"Random";
                Lang.menu[28] = "Create";
                Lang.menu[29] = "Hardcore characters die for good";
                Lang.menu[30] = "Mediumcore characters drop items on death";
                Lang.menu[31] = "Softcore characters drop money on death";
                Lang.menu[32] = "Select difficulty";
                Lang.menu[33] = "Shirt";
                Lang.menu[34] = "Undershirt";
                Lang.menu[35] = "Pants";
                Lang.menu[36] = "Shoes";
                Lang.menu[37] = "Hair";
                Lang.menu[38] = ""; // "Hair Color";
                Lang.menu[39] = "Eye Color";
                Lang.menu[40] = "Skin Color";
                Lang.menu[41] = "Shirt Color";
                Lang.menu[42] = "Undershirt Color";
                Lang.menu[43] = "Pants Color";
                Lang.menu[44] = "Shoe Color";
                Lang.menu[45] = "Enter Character Name:";
                Lang.menu[46] = "Delete";
                Lang.menu[47] = "Create World";
                Lang.menu[48] = "Enter World Name:";
                Lang.menu[49] = "Go Windowed";
                Lang.menu[50] = "Go Fullscreen";
                Lang.menu[51] = "Resolution";
                Lang.menu[52] = "Parallax";
                Lang.menu[53] = "Frame Skip Off (Not Recommended)";
                Lang.menu[54] = "Frame Skip On (Recommended)";
                Lang.menu[55] = "Lighting: Color";
                Lang.menu[56] = "Lighting: White";
                Lang.menu[57] = "Lighting: Retro";
                Lang.menu[58] = "Lighting: Trippy";
                Lang.menu[59] = "Quality: Auto";
                Lang.menu[60] = "Quality: High";
                Lang.menu[61] = "Quality: Medium";
                Lang.menu[62] = "Quality: Low";
                Lang.menu[63] = "Video";
                Lang.menu[64] = "Cursor Color";
                Lang.menu[65] = "Volume";
                Lang.menu[66] = "Controls";
                Lang.menu[67] = "Autosave On";
                Lang.menu[68] = "Autosave Off";
                Lang.menu[69] = "Autopause On";
                Lang.menu[70] = "Autopause Off";
                Lang.menu[71] = "Pickup Text On";
                Lang.menu[72] = "Pickup Text Off";
                Lang.menu[73] = "Fullscreen Resolution";
                Lang.menu[74] = "Up             ";
                Lang.menu[75] = "Down          ";
                Lang.menu[76] = "Left            ";
                Lang.menu[77] = "Right          ";
                Lang.menu[78] = "Jump          ";
                Lang.menu[79] = "Throw         ";
                Lang.menu[80] = "Inventory      ";
                Lang.menu[81] = "Quick Heal    ";
                Lang.menu[82] = "Shop    "; //Quick Mana   ";
                Lang.menu[83] = "Quick Buff    ";
                Lang.menu[84] = "Grapple        ";
                Lang.menu[85] = "Auto Select    ";
                Lang.menu[86] = "Reset to Default";
                Lang.menu[87] = "Join (White Team)";
                Lang.menu[88] = "Join (Black Team)";
                Lang.menu[89] = "Enter Server IP Address:";
                Lang.menu[90] = "Enter Server Port:";
                Lang.menu[91] = "Rejoin";
                Lang.menu[92] = "Small";
                Lang.menu[93] = "Medium";
                Lang.menu[94] = "Large";
                Lang.menu[95] = "Red:";
                Lang.menu[96] = "Green:";
                Lang.menu[97] = "Blue:";
                Lang.menu[98] = "Sound:";
                Lang.menu[99] = "Music:";
                Lang.menu[100] = "Background On";
                Lang.menu[101] = "Background Off";
                Lang.menu[102] = "Select language";
                Lang.menu[103] = "Language";
                Lang.menu[104] = "Yes";
                Lang.menu[105] = "No";
                Lang.menu[106] = "Toggle Map Style           ";
                Lang.menu[107] = "Toggle Fullscreen           ";
                Lang.menu[108] = "Zoom In                      ";
                Lang.menu[109] = "Zoom Out                    ";
                Lang.menu[110] = "Decrease Transparency     ";
                Lang.menu[111] = "Increase Transparency      ";
                Lang.menu[112] = "Map Enabled";
                Lang.menu[113] = "Map Disabled";
                Lang.gen[0] = "Generating world terrain:";
                Lang.gen[1] = "Adding sand...";
                Lang.gen[2] = "Generating hills...";
                Lang.gen[3] = "Puttin dirt behind dirt:";
                Lang.gen[4] = "Placing rocks in the dirt...";
                Lang.gen[5] = "Placing dirt in the rocks...";
                Lang.gen[6] = "Adding clay...";
                Lang.gen[7] = "Making random holes:";
                Lang.gen[8] = "Generating small caves:";
                Lang.gen[9] = "Generating large caves:";
                Lang.gen[10] = "Generating surface caves...";
                Lang.gen[11] = "Generating jungle:";
                Lang.gen[12] = "Generating floating islands...";
                Lang.gen[13] = "Adding mushroom patches...";
                Lang.gen[14] = "Placing mud in the dirt...";
                Lang.gen[15] = "Adding silt...";
                Lang.gen[16] = "Adding shinies...";
                Lang.gen[17] = "Adding webs...";
                Lang.gen[18] = "Creating underworld:";
                Lang.gen[19] = "Adding water bodies:";
                Lang.gen[20] = "Making the world evil:";
                Lang.gen[21] = "Generating mountain caves...";
                Lang.gen[22] = "Creating beaches...";
                Lang.gen[23] = "Adding gems...";
                Lang.gen[24] = "Gravitating sand:";
                Lang.gen[25] = "Cleaning up dirt backgrounds:";
                Lang.gen[26] = "Placing altars:";
                Lang.gen[27] = "Settling liquids:";
                Lang.gen[28] = "Placing life crystals:";
                Lang.gen[29] = "Placing statues:";
                Lang.gen[30] = "Hiding treasure:";
                Lang.gen[31] = "Hiding more treasure:";
                Lang.gen[32] = "Hiding jungle treasure:";
                Lang.gen[33] = "Hiding water treasure:";
                Lang.gen[34] = "Placing traps:";
                Lang.gen[35] = "Placing breakables:";
                Lang.gen[36] = "Placing hellforges:";
                Lang.gen[37] = "Spreading grass...";
                Lang.gen[38] = "Growing cacti...";
                Lang.gen[39] = "Planting sunflowers...";
                Lang.gen[40] = "Planting trees...";
                Lang.gen[41] = "Planting herbs...";
                Lang.gen[42] = "Planting weeds...";
                Lang.gen[43] = "Growing vines...";
                Lang.gen[44] = "Planting flowers...";
                Lang.gen[45] = "Planting mushrooms...";
                Lang.gen[46] = "Freeing unused resources:";
                Lang.gen[47] = "Resetting game objects:";
                Lang.gen[48] = "Setting hard mode...";
                Lang.gen[49] = "Saving world data:";
                Lang.gen[50] = "Backing up world file...";
                Lang.gen[51] = "Loading world data:";
                Lang.gen[52] = "Checking tile alignment:";
                Lang.gen[53] = "Load failed!";
                Lang.gen[54] = "No backup found.";
                Lang.gen[55] = "Finding tile frames:";
                Lang.gen[56] = "Adding snow...";
                Lang.gen[57] = "World";
                Lang.gen[58] = "Creating dungeon:";
                Lang.gen[59] = "A meteorite has landed!";
                Lang.gen[60] = "Smoothing the world:";
                Lang.gen[61] = "Mossification:";
                Lang.gen[62] = "Gemification:";
                Lang.gen[63] = "Making cave walls:";
                Lang.gen[64] = "Growing spider caves:";
                Lang.gen[65] = "Clearing map data:";
                Lang.gen[66] = "Saving map data:";
                Lang.gen[67] = "Loading map data:";
                Lang.gen[68] = "Drawing map:";
                Lang.gen[69] = "Creating waterfalls:";
                Lang.gen[70] = "Creating jungle ruins...";
                Lang.gen[71] = "Creating hornet nests...";
                Lang.gen[72] = "Making the world bloody:";
                Lang.inter[0] = "Life:";
                Lang.inter[1] = "Breath";
                Lang.inter[2] = "Mana";
                Lang.inter[3] = "Trash Can";
                Lang.inter[4] = "Inventory";
                Lang.inter[5] = "Hotbar unlocked";
                Lang.inter[6] = "Hotbar locked";
                Lang.inter[7] = "Housing";
                Lang.inter[8] = "Housing Query";
                Lang.inter[9] = "Accessories";
                Lang.inter[10] = "Defense";
                Lang.inter[11] = ""; // "Social";
                Lang.inter[12] = "Helmet";
                Lang.inter[13] = "Shirt";
                Lang.inter[14] = "Pants";
                Lang.inter[15] = "platinum";
                Lang.inter[16] = "GP"; //"gold";
                Lang.inter[17] = "silver";
                Lang.inter[18] = "GP"; // "copper";
                Lang.inter[19] = "Reforge";
                Lang.inter[20] = "Place an item here to reforge";
                Lang.inter[21] = "Showing recipes that use";
                Lang.inter[22] = "Required objects:";
                Lang.inter[23] = "None";
                Lang.inter[24] = "Place a material here";
                Lang.inter[25] = "Crafting";
                Lang.inter[26] = "Coins";
                Lang.inter[27] = "Ammo";
                Lang.inter[28] = "";
                Lang.inter[29] = "Loot All";
                Lang.inter[30] = "Deposit All";
                Lang.inter[31] = "Quick Stack";
                Lang.inter[32] = "Piggy Bank";
                Lang.inter[33] = "Safe";
                Lang.inter[34] = "Time:";
                Lang.inter[35] = "Save & Exit";
                Lang.inter[36] = "Disconnect";
                Lang.inter[37] = "Items";
                Lang.inter[38] = "Time until respawn: "; //"You were slain...";
                Lang.inter[39] = "This housing is suitable.";
                Lang.inter[40] = "This is not valid housing.";
                Lang.inter[41] = "This housing is already occupied.";
                Lang.inter[42] = "This housing is corrupted.";
                Lang.inter[43] = "Connection timed out";
                Lang.inter[44] = "Receiving tile data";
                Lang.inter[45] = "Equip";
                Lang.inter[46] = "Cost";
                Lang.inter[47] = "Save";
                Lang.inter[48] = "Edit";
                Lang.inter[49] = "Status";
                Lang.inter[50] = "Curse";
                Lang.inter[51] = "Help";
                Lang.inter[52] = "Close";
                Lang.inter[53] = "Water";
                Lang.inter[54] = "Heal";
                Lang.inter[55] = "This housing does not meet the requirements for a";
                Lang.inter[56] = "Lava";
                Lang.inter[57] = "Ammo";
                Lang.inter[58] = "Honey";
                Lang.tip[0] = "Equipped in social slot";
                Lang.tip[1] = "No stats will be gained";
                Lang.tip[2] = " melee damage";
                Lang.tip[3] = " ranged damage";
                Lang.tip[4] = " magic damage";
                Lang.tip[5] = "% critical strike chance";
                Lang.tip[6] = "Insanely fast speed";
                Lang.tip[7] = "Very fast speed";
                Lang.tip[8] = "Fast speed";
                Lang.tip[9] = "Average speed";
                Lang.tip[10] = "Slow speed";
                Lang.tip[11] = "Very slow speed";
                Lang.tip[12] = "Extremely slow speed";
                Lang.tip[13] = "Snail speed";
                Lang.tip[14] = "No knockback";
                Lang.tip[15] = "Extremely weak knockback";
                Lang.tip[16] = "Very weak knockback";
                Lang.tip[17] = "Weak knockback";
                Lang.tip[18] = "Average knockback";
                Lang.tip[19] = "Strong knockback";
                Lang.tip[20] = "Very strong knockback";
                Lang.tip[21] = "Extremely strong knockback";
                Lang.tip[22] = "Insane knockback";
                Lang.tip[23] = "Equipable";
                Lang.tip[24] = "Vanity Item";
                Lang.tip[25] = " defense";
                Lang.tip[26] = "% pickaxe power";
                Lang.tip[27] = "% axe power";
                Lang.tip[28] = "% hammer power";
                Lang.tip[29] = "Restores";
                Lang.tip[30] = "life";
                Lang.tip[31] = "mana";
                Lang.tip[32] = "Uses";
                Lang.tip[33] = "Can be placed";
                Lang.tip[34] = "Ammo";
                Lang.tip[35] = "Consumable";
                Lang.tip[36] = "Material";
                Lang.tip[37] = " minute duration";
                Lang.tip[38] = " second duration";
                Lang.tip[39] = "% damage";
                Lang.tip[40] = "% speed";
                Lang.tip[41] = "% critical strike chance";
                Lang.tip[42] = "% mana cost";
                Lang.tip[43] = "% size";
                Lang.tip[44] = "% velocity";
                Lang.tip[45] = "% knockback";
                Lang.tip[46] = "% movement speed";
                Lang.tip[47] = "% melee speed";
                Lang.tip[48] = "Set bonus:";
                Lang.tip[49] = "Sell price:";
                Lang.tip[50] = "Buy price:";
                Lang.tip[51] = "No value";
                Lang.tip[52] = "Consumes ";
                Lang.tip[53] = " summon damage";
                Lang.tip[54] = " range";
                Lang.tip[55] = " damage";
                Lang.mp[0] = "Recieve:";
                Lang.mp[1] = "Incorrect password.";
                Lang.mp[2] = "Invalid operation at this state.";
                Lang.mp[3] = "You are banned from this server.";
                Lang.mp[4] = "You are not using the same version as this server.";
                Lang.mp[5] = "is already on this server.";
                Lang.mp[6] = "/playing";
                Lang.mp[7] = "Current players:";
                Lang.mp[8] = "/roll";
                Lang.mp[9] = "rolls a";
                Lang.mp[10] = "You are not in a party!";
                Lang.mp[11] = "has enabled PvP!";
                Lang.mp[12] = "has disabled PvP!";
                Lang.mp[13] = "is no longer on a party.";
                Lang.mp[14] = "has joined the white party.";
                Lang.mp[15] = "has joined the black party.";
                Lang.mp[16] = "has joined the blue party.";
                Lang.mp[17] = "has joined the yellow party.";
                Lang.mp[18] = "Welcome to";
                Lang.mp[19] = "has joined.";
                Lang.mp[20] = "has left.";
                Lang.mp[21] = "/players";
                Lang.the = "the ";
                Lang.dt[0] = "couldn't find the antidote";
                Lang.dt[1] = "couldn't put the fire out";
                Lang.dt[2] = "couldn't breathe";
                //buff names
                Main.buffName[1] = "Stoicism";
                Main.buffTip[1] = "Increased Defense based on remaining time.";
                Main.buffName[2] = "Regeneration";
                Main.buffTip[2] = "Provides life regeneration";
                Main.buffName[3] = "Swiftness";
                Main.buffTip[3] = "+10 agility.  Double movement speed bonus from agility";
                Main.buffName[4] = "Gills";
                Main.buffTip[4] = "Breathe water instead of air";
                Main.buffName[5] = "Shark Tooth";
                Main.buffTip[5] = "Reduced Defense based on duration.";
                Main.buffName[6] = "Nettles";
                Main.buffTip[6] = "Reduced damage output based on duration";
                Main.buffName[7] = "Magic Power";
                Main.buffTip[7] = "20% increased magic damage";
                Main.buffName[8] = "Featherfall";
                Main.buffTip[8] = "Press UP or DOWN to control speed of descent";
                Main.buffName[9] = "Spelunker";
                Main.buffTip[9] = "Shows the location of treasure and ore";
                Main.buffName[10] = "Invisibility";
                Main.buffTip[10] = "Grants invisibility";
                Main.buffName[11] = "Shine";
                Main.buffTip[11] = "Emitting light";
                Main.buffName[12] = "Night Owl";
                Main.buffTip[12] = "Increased night vision";
                Main.buffName[13] = "Battle";
                Main.buffTip[13] = "Increased enemy spawn rate";
                Main.buffName[14] = "Thorns";
                Main.buffTip[14] = "Attackers also take damage";
                Main.buffName[15] = "Water Walking";
                Main.buffTip[15] = "Press DOWN to enter water";
                Main.buffName[16] = "Archery";
                Main.buffTip[16] = "20% increased arrow damage and speed";
                Main.buffName[17] = "Hunter";
                Main.buffTip[17] = "Shows the location of enemies";
                Main.buffName[18] = "Gravitation";
                Main.buffTip[18] = "Press UP to reverse gravity";
                Main.buffName[19] = "Shadow Orb";
                Main.buffTip[19] = "A magical orb that provides light";
                Main.buffName[20] = "Poisoned";
                Main.buffTip[20] = "Slowly losing life. -10% damage output.";
                Main.buffName[21] = "Potion Sickness";
                Main.buffTip[21] = "Cannot consume anymore healing items";
                Main.buffName[22] = "Darkness";
                Main.buffTip[22] = "Decreased light vision. 1/4 chance to miss enemy heroes.";
                Main.buffName[23] = "Cursed";
                Main.buffTip[23] = "Cannot use any items";
                Main.buffName[24] = "On Fire!";
                Main.buffTip[24] = "Slowly losing life. -6 defense.";
                Main.buffName[25] = "Disoriented";
                Main.buffTip[25] = "You probably shouldn't teleport again for a while...";
                Main.buffName[26] = "Well Fed";
                Main.buffTip[26] = "Minor improvements to all stats";
                Main.buffName[27] = "Fairy";
                Main.buffTip[27] = "A fairy is following you";
                Main.buffName[28] = "Werewolf";
                Main.buffTip[28] = "Physical abilities are increased";
                Main.buffName[29] = "Clairvoyance";
                Main.buffTip[29] = "Magic powers are increased";
                Main.buffName[30] = "Bleeding";
                Main.buffTip[30] = "Rapidly losing life.";
                Main.buffName[31] = "Confused";
                Main.buffTip[31] = "Movement is reversed";
                Main.buffName[32] = "Slow";
                Main.buffTip[32] = "Movement speed is reduced";
                Main.buffName[33] = "Weak";
                Main.buffTip[33] = "Physical abilities are decreased";
                Main.buffName[34] = "Merfolk";
                Main.buffTip[34] = "Can breathe and move easily underwater";
                Main.buffName[35] = "Silenced";
                Main.buffTip[35] = "Cannot use items that require mana";
                Main.buffName[36] = "Broken Armor";
                Main.buffTip[36] = "Defense is cut in half";
                Main.buffName[37] = "Horrified";
                Main.buffTip[37] = "You have seen something nasty, there is no escape.";
                Main.buffName[38] = "The Tongue";
                Main.buffTip[38] = "You are being sucked into the mouth";
                Main.buffName[39] = "Cursed Inferno";
                Main.buffTip[39] = "Losing life. -8 Defense";
                Main.buffName[40] = "Pet Bunny";
                Main.buffTip[40] = "I think it wants your carrot";
                Main.buffName[41] = "Baby Penguin";
                Main.buffTip[41] = "I think it wants your fish";
                Main.buffName[42] = "Pet Turtle";
                Main.buffTip[42] = "Happy turtle time!";
                Main.buffName[43] = "Paladin's Shield";
                Main.buffTip[43] = "25% of damage taken will be redirected to another player";
                Main.buffName[44] = "Frostburn";
                Main.buffTip[44] = "Slowly losing life.  Reduced Movement speed.";
                Main.buffName[45] = "Baby Eater";
                Main.buffTip[45] = "A baby Eater of Souls is following you";
                Main.buffName[46] = "Chilled";
                Main.buffTip[46] = "Your movement speed has been reduced";
                Main.buffName[47] = "Frozen";
                Main.buffTip[47] = "You can't move!";
                Main.buffName[48] = "Honey";
                Main.buffTip[48] = "Life regeneration is increased";
                Main.buffName[49] = "Pygmies";
                Main.buffTip[49] = "The pygmies will fight for you";
                Main.buffName[50] = "Baby Skeletron Head";
                Main.buffTip[50] = "Don't even ask...";
                Main.buffName[51] = "Baby Hornet";
                Main.buffTip[51] = "It thinks you are its mother";
                Main.buffName[52] = "Tiki Spirit";
                Main.buffTip[52] = "A friendly spirit is following you";
                Main.buffName[53] = "Pet Lizard";
                Main.buffTip[53] = "Chillin' like a reptilian";
                Main.buffName[54] = "Pet Parrot";
                Main.buffTip[54] = "Polly want's the cracker";
                Main.buffName[55] = "Baby Truffle";
                Main.buffTip[55] = "Isn't this just soooo cute?";
                Main.buffName[56] = "Pet Sapling";
                Main.buffTip[56] = "A little sapling is following you";
                Main.buffName[57] = "Wisp";
                Main.buffTip[57] = "A wisp is following you";
                Main.buffName[58] = "Rapid Healing";
                Main.buffTip[58] = "Life regeneration is greatly increased";
                Main.buffName[59] = "Shadow Dodge";
                Main.buffTip[59] = "You will dodge the next attack";
                Main.buffName[60] = "Leaf Crystal";
                Main.buffTip[60] = "Shoots crystal leaves at nearby enemies";
                Main.buffName[61] = "Baby Dinosaur";
                Main.buffTip[61] = "A baby dinosaur is following you";
                Main.buffName[62] = "Ice Barrier";
                Main.buffTip[62] = "Defense is increased by 30";
                Main.buffName[63] = "Panic!";
                Main.buffTip[63] = "Movement speed is increased";
                Main.buffName[64] = "Baby Slime";
                Main.buffTip[64] = "The baby slime will fight for you";
                Main.buffName[65] = "Eyeball Spring";
                Main.buffTip[65] = "An eyeball spring is following you";
                Main.buffName[66] = "Baby Snowman";
                Main.buffTip[66] = "A baby snowman is following you";
                Main.buffName[67] = "Burning";
                Main.buffTip[67] = "Losing life and slowed movement";
                Main.buffName[68] = "Suffocation";
                Main.buffTip[68] = "Losing life";
                Main.buffName[69] = "Ichor";
                Main.buffTip[69] = "Reduced defense";
                Main.buffName[70] = "Venom";
                Main.buffTip[70] = "Rapidly Losing life";
                Main.buffName[72] = "Midas";
                Main.buffTip[72] = "Drop more money on death";
                Main.buffName[80] = "Nevermore"; //"Blackout";
                Main.buffTip[80] = "All debuff immunity is lost.";
                Main.buffName[71] = "Weapon Imbue: Venom";
                Main.buffTip[71] = "Melee attacks inflict venom on your targets";
                Main.buffName[73] = "Weapon Imbue: Cursed Flames";
                Main.buffTip[73] = "Melee attacks inflict enemies with cursed flames";
                Main.buffName[74] = "Weapon Imbue: Fire";
                Main.buffTip[74] = "Melee attacks set enemies on fire";
                Main.buffName[75] = "Weapon Imbue: Gold";
                Main.buffTip[75] = "Melee attacks make enemies drop more gold";
                Main.buffName[76] = "Weapon Imbue: Ichor";
                Main.buffTip[76] = "Melee attacks decrease enemies defense";
                Main.buffName[77] = "Weapon Imbue: Nanites";
                Main.buffTip[77] = "Melee attacks confuse enemies";
                Main.buffName[78] = "Weapon Imbue: Confetti";
                Main.buffTip[78] = "Melee attacks cause confetti to appear";
                Main.buffName[79] = "Weapon Imbue: Poison";
                Main.buffTip[79] = "Melee attacks poison enemies";
                Main.tileName[4] = "Torch";
                Main.tileName[5] = "Tree";
                Main.tileName[6] = "Iron";
                Main.tileName[7] = "Copper";
                Main.tileName[8] = "Gold";
                Main.tileName[9] = "Silver";
                Main.tileName[10] = "Door";
                Main.tileName[11] = "Door";
                Main.tileName[12] = "Heart Crystal";
                Main.tileName[13] = "Bottle";
                Main.tileName[14] = "Table";
                Main.tileName[15] = "Chair";
                Main.tileName[16] = "Anvil";
                Main.tileName[17] = "Furnace";
                Main.tileName[18] = "Work Bench";
                Main.tileName[21] = "Chest";
                Main.tileName[22] = "Demonite";
                Main.tileName[26] = "Demon Altar";
                Main.tileName[27] = "Sunflower";
                Main.tileName[28] = "Pot";
                Main.tileName[29] = "Piggy Bank";
                Main.tileName[31] = "Shadow Orb";
                Main.tileName[32] = "Thorns";
                Main.tileName[33] = "Candle";
                Main.tileName[34] = "Copper Chandelier";
                Main.tileName[35] = "Silver Chandelier";
                Main.tileName[36] = "Gold Chandelier";
                Main.tileName[42] = "Lantern";
                Main.tileName[48] = "Spike";
                Main.tileName[49] = "Water Candle";
                Main.tileName[50] = "Book";
                Main.tileName[51] = "Web";
                Main.tileName[55] = "Sign";
                Main.tileName[63] = "Sapphire";
                Main.tileName[64] = "Ruby";
                Main.tileName[65] = "Emerald";
                Main.tileName[66] = "Topaz";
                Main.tileName[67] = "Amethyst";
                Main.tileName[68] = "Diamond";
                Main.tileName[69] = "Thorn";
                Main.tileName[72] = "Giant Mushroom";
                Main.tileName[77] = "Hellforge";
                Main.tileName[78] = "Clay Pot";
                Main.tileName[79] = "Bed";
                Main.tileName[80] = "Cactus";
                Main.tileName[81] = "Coral";
                Main.tileName[85] = "Tombstone";
                Main.tileName[86] = "Loom";
                Main.tileName[87] = "Piano";
                Main.tileName[88] = "Dresser";
                Main.tileName[89] = "Bench";
                Main.tileName[90] = "Bathtub";
                Main.tileName[91] = "Banner";
                Main.tileName[92] = "Lamp Post";
                Main.tileName[93] = "Tiki Torch";
                Main.tileName[94] = "Keg";
                Main.tileName[95] = "Chinese Lantern";
                Main.tileName[96] = "Cooking Pot";
                Main.tileName[97] = "Safe";
                Main.tileName[98] = "Skull Lantern";
                Main.tileName[100] = "Candelabra";
                Main.tileName[101] = "Bookcase";
                Main.tileName[102] = "Throne";
                Main.tileName[103] = "Bowl";
                Main.tileName[104] = "Grandfather Clock";
                Main.tileName[105] = "Statue";
                Main.tileName[106] = "Sawmill";
                Main.tileName[107] = "Cobalt";
                Main.tileName[108] = "Mythril";
                Main.tileName[111] = "Adamantite";
                Main.tileName[112] = "Workshop";
                Main.tileName[125] = "Crystal Ball";
                Main.tileName[128] = "Mannequin";
                Main.tileName[129] = "Crystal Shard";
                Main.tileName[132] = "Lever";
                Main.tileName[133] = "Adamantite or Titanium Forge";
                Main.tileName[134] = "Mythril or Orichalcum Anvil";
                Main.tileName[136] = "Switch";
                Main.tileName[137] = "Trap";
                Main.tileName[138] = "Boulder";
                Main.tileName[139] = "Music Box";
                Main.tileName[142] = "Inlet Pump";
                Main.tileName[143] = "Outlet Pump";
                Main.tileName[144] = "Timer";
                Main.tileName[149] = "Christmas Light";
                Main.tileName[166] = "Tin";
                Main.tileName[167] = "Lead";
                Main.tileName[168] = "Tungsten";
                Main.tileName[169] = "Platinum";
                Main.tileName[170] = "Tin Chandelier";
                Main.tileName[171] = "Tungsten Chandelier";
                Main.tileName[172] = "Platinum Chandelier";
                Main.tileName[173] = "Candelabra";
                Main.tileName[174] = "Platinum Candle";
                Main.tileName[207] = "Crimtane";
                Main.tileName[207] = "Water Fountain";
                Main.tileName[209] = "Cannon";
                Main.tileName[211] = "Chlorophyte";
                Main.tileName[212] = "Turret";
                Main.tileName[213] = "Rope";
                Main.tileName[214] = "Chain";
                Main.tileName[215] = "Campfire";
                Main.tileName[216] = "Rocket";
                Main.tileName[217] = "Blend-O-Matic";
                Main.tileName[218] = "Meat Grinder";
                Main.tileName[219] = "Silt Extractinator";
                Main.tileName[220] = "Solidifier";
                Main.tileName[221] = "Palladium";
                Main.tileName[222] = "Orichalcum";
                Main.tileName[223] = "Titanium";
                Main.tileName[228] = "Dye Vat";
                Main.tileName[231] = "Larva";
                Main.tileName[232] = "Wooden Spike";
                Main.tileName[235] = "Teleporter";
                Main.tileName[236] = "Life Fruit";
                Main.tileName[237] = "Lihzahrd Altar";
                Main.tileName[238] = "Plantera's Bulb";
                Main.tileName[239] = "Metal Bar";
                Main.tileName[240] = "Picture";
                Main.tileName[241] = "Picture";
                Main.tileName[242] = "Picture";
                Main.tileName[243] = "Imbuing Station";
                Main.tileName[244] = "Bubble Machine";
                Main.tileName[245] = "Picture";
                Main.tileName[246] = "Picture";
                Main.tileName[247] = "Autohammer";
            }
            for (int i = 0; i < Main.recipe.Length; i++)
            {
                if (Main.recipe[i].createItem.name != null && Main.recipe[i].createItem.name != "" && Main.recipe[i].createItem.netID != 0)
                {
                    Main.recipe[i].createItem.name = Lang.itemName(Main.recipe[i].createItem.netID, false);
                    Main.recipe[i].createItem.CheckTip();
                    for (int j = 0; j < Main.recipe[j].requiredItem.Length; j++)
                    {
                        Main.recipe[i].requiredItem[j].name = Lang.itemName(Main.recipe[i].requiredItem[j].netID, false);
                        Main.recipe[i].requiredItem[j].CheckTip();
                    }
                }
            }
        }

        public static string deathMsg(int plr = -1, int npc = -1, int proj = -1, int other = -1, int debuff = -1)
        {
            if (Lang.lang <= 1)
            {
                string result = "";
                int num = Main.rand.Next(26);
                string text = "";
                if (num == 0)
                {
                    text = " was slain";
                }
                else
                {
                    if (num == 1)
                    {
                        text = " was eviscerated";
                    }
                    else
                    {
                        if (num == 2)
                        {
                            text = " was murdered";
                        }
                        else
                        {
                            if (num == 3)
                            {
                                text = "'s face was torn off";
                            }
                            else
                            {
                                if (num == 4)
                                {
                                    text = "'s entrails were ripped out";
                                }
                                else
                                {
                                    if (num == 5)
                                    {
                                        text = " was destroyed";
                                    }
                                    else
                                    {
                                        if (num == 6)
                                        {
                                            text = "'s skull was crushed";
                                        }
                                        else
                                        {
                                            if (num == 7)
                                            {
                                                text = " got massacred";
                                            }
                                            else
                                            {
                                                if (num == 8)
                                                {
                                                    text = " got impaled";
                                                }
                                                else
                                                {
                                                    if (num == 9)
                                                    {
                                                        text = " was torn in half";
                                                    }
                                                    else if (num == 10)
                                                    {
                                                        text = " was decapitated";
                                                    }
                                                    else
                                                    {
                                                        if (num == 11)
                                                        {
                                                            text = " got dumpstered";
                                                            {
                                                                if (num == 12)
                                                                {
                                                                    text = " watched their innards become outards";
                                                                }
                                                                else
                                                                {
                                                                    if (num == 13)
                                                                    {
                                                                        text = " was brutally dissected";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (num == 14)
                                                                        {
                                                                            text = "'s extremities were detached";
                                                                        }
                                                                        else if (num == 15)
                                                                        {
                                                                            text = "'s body was mangled";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (num == 14)
                                                                            {
                                                                                text = "'s vital organs were ruptured";
                                                                            }
                                                                            else
                                                                            {
                                                                                if (num == 17)
                                                                                {
                                                                                    text = " was turned into a pile of flesh";
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (num == 18)
                                                                                    {
                                                                                        text = " was removed from " + Main.worldName;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (num == 19)
                                                                                        {
                                                                                            text = " got dumpstered";
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (num == 20)
                                                                                            {
                                                                                                text = "got dumpstered";
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (num == 21)
                                                                                                {
                                                                                                    text = " was chopped up";
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (num == 22)
                                                                                                    {
                                                                                                        text = "'s plead for death was answered";
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (num == 23)
                                                                                                        {
                                                                                                            text = "'s meat was ripped off the bone";
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (num == 24)
                                                                                                            {
                                                                                                                text = "'s flailing about was finally stopped";
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (num == 25)
                                                                                                                {
                                                                                                                    text = " had their head removed";
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (plr >= 0 && plr < 255)
                {
                    if (debuff >= 0)
                    {
                        Buff buff = new Buff();
                        buff.setDefaults(debuff, 0, plr);
                        result = string.Concat(new string[]
                        {
                            text,
                            " by ",
                            Main.player[plr].name,
                            "'s ",
                            buff.name,
                            "."
                        });
                    }
                    else if (proj >= 0 && Main.projectile[proj].name != "")
                    {
                        result = string.Concat(new string[]
                        {
                            text,
                            " by ",
                            Main.player[plr].name,
                            "'s ",
                            Main.projectile[proj].name,
                            "."
                        });
                    }
                    else
                    {
                        result = string.Concat(new string[]
                        {
                            text,
                            " by ",
                            Main.player[plr].name,
                            "'s ",
                            Main.player[plr].inventory[Main.player[plr].selectedItem].name,
                            "."
                        });
                    }
                }
                else
                {
                    if (npc >= 0 && Main.npc[npc].displayName != "")
                    {
                        result = text + " by " + Main.npc[npc].displayName + ".";
                    }
                    else
                    {
                        if (proj >= 0 && Main.projectile[proj].name != "")
                        {
                            result = text + " by " + Main.projectile[proj].name + ".";
                        }
                        else
                        {
                            if (other >= 0)
                            {
                                if (other == 0)
                                {
                                    if (Main.rand.Next(2) == 0)
                                    {
                                        result = " fell to their death.";
                                    }
                                    else
                                    {
                                        result = " didn't bounce.";
                                    }
                                }
                                else
                                {
                                    if (other == 1)
                                    {
                                        int num2 = Main.rand.Next(4);
                                        if (num2 == 0)
                                        {
                                            result = " forgot to breathe.";
                                        }
                                        else
                                        {
                                            if (num2 == 1)
                                            {
                                                result = " is sleeping with the fish.";
                                            }
                                            else
                                            {
                                                if (num2 == 2)
                                                {
                                                    result = " drowned.";
                                                }
                                                else
                                                {
                                                    if (num2 == 3)
                                                    {
                                                        result = " is shark food.";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (other == 2)
                                        {
                                            int num3 = Main.rand.Next(4);
                                            if (num3 == 0)
                                            {
                                                result = " got melted.";
                                            }
                                            else
                                            {
                                                if (num3 == 1)
                                                {
                                                    result = " was incinerated.";
                                                }
                                                else
                                                {
                                                    if (num3 == 2)
                                                    {
                                                        result = " tried to swim in lava.";
                                                    }
                                                    else
                                                    {
                                                        if (num3 == 3)
                                                        {
                                                            result = " likes to play in magma.";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (other == 3)
                                            {
                                                result = text + ".";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return result;
            }
            return "";
        }
    }
}