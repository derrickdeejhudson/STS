using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria
{
    public class Buff
    {
        public String name;
        public bool debuff;
        public bool active;
        public int stacks;
        public int owner;
        public int type;
        public int time;
        public float damagerate;
        public float damageCounter;

        public const int STOICISM = 1;
        public const int REGENERATION = 2;
        public const int SWIFTNESS = 3;
        public const int HAMSTRING = 4;
        public const int SHARK_TOOTH = 5;
        public const int NETTLES = 6;
        public const int MAGIC_POWER = 7;
        public const int FEATHERFALL = 8;
        public const int SPELUNKER = 9;
        public const int INVISIBILITY = 10;
        public const int SHINE = 11;
        public const int NIGHT_OWL = 12;
        public const int BATTLE = 13;
        public const int THORNS = 14;
        public const int WATER_WALKING = 15;
        public const int ARCHERY = 16;
        public const int HUNTER = 17;
        public const int GRAVITATION = 18;
        public const int SHADOW_ORB = 19;
        public const int POISONED = 20;
        public const int POTION_SICKNESS = 21;
        public const int DARKNESS = 22;
        public const int CURSED = 23;
        public const int ON_FIRE = 24;
        public const int DISORIENTED = 25;
        public const int WELL_FED = 26;
        public const int FAIRY = 27;
        public const int WEREWOLF = 28;
        public const int CLAIRVOYANCE = 29;
        public const int BLEEDING = 30;
        public const int CONFUSED = 31;
        public const int SLOW = 32;
        public const int WEAK = 33;
        public const int MERFOLK = 34;
        public const int SILENCED = 35;
        public const int BROKEN_ARMOR = 36;
        public const int HORRIFIED = 37;
        public const int THE_TONGUE = 38;
        public const int CURSED_INFERNO = 39;
        public const int PET_BUNNY = 40;
        public const int BABY_PENGUIN = 41;
        public const int PET_TURTLE = 42;
        public const int PALADINS_SHIELD = 43;
        public const int FROSTBURN = 44;
        public const int BABY_EATER = 45;
        public const int CHILLED = 46;
        public const int FROZEN = 47;
        public const int HONEY = 48;
        public const int PYGMIES = 49;
        public const int BABY_SKELETRON_HEAD = 50;
        public const int BABY_HORNET = 51;
        public const int TIKI_SPIRIT = 52;
        public const int PET_LIZARD = 53;
        public const int PET_PARROT = 54;
        public const int BABY_TRUFFLE = 55;
        public const int PET_SAPLING = 56;
        public const int WISP = 57;
        public const int RAPID_HEALING = 58;
        public const int SHADOW_DODGE = 59;
        public const int LEAF_CRYSTAL = 60;
        public const int BABY_DINOSAUR = 61;
        public const int ICE_BARRIER = 62;
        public const int PANIC = 63;
        public const int BABY_SLIME = 64;
        public const int EYEBALL_SPRING = 65;
        public const int BABY_SNOWMAN = 66;
        public const int BURNING = 67;
        public const int DOOM = 68;
        public const int DRAIN = 69;
        public const int VENOM = 70;
        public const int WEAPON_IMBUE_VENOM = 71;
        public const int MIDAS = 72;
        public const int WEAPON_IMBUE_CURSED_FLAMES = 73;
        public const int WEAPON_IMBUE_FIRE = 74;
        public const int WEAPON_IMBUE_GOLD = 75;
        public const int WEAPON_IMBUE_ICHOR = 76;
        public const int WEAPON_IMBUE_NANITES = 77;
        public const int WEAPON_IMBUE_CONFETTI = 78;
        public const int NEVERMORE = 80;

        public void setDefaults(int type, int time, int owner = byte.MaxValue)
        {
            this.active = true;
            this.time = time;
            this.owner = owner;
            this.type = type;
            this.name = Main.buffName[this.type];
            this.debuff = Main.debuff[this.type];
            switch (this.type)
            {
                case STOICISM:
                    this.stacks = 6*60;
                    break;
                case SHARK_TOOTH:
                    this.stacks = 20*60;
                    break;
                case NETTLES:
                    this.stacks = 10*60;
                    break;
                case POISONED:
                    this.damagerate = 15;
                    break;
                case ON_FIRE:
                    this.damagerate = 10;
                    break;
                case BLEEDING:
                    this.damagerate = 2.5f;
                    break;
                case CURSED_INFERNO:
                    this.damagerate = 7.5f;
                    break;
                case FROSTBURN:
                    this.damagerate = 15;
                    break;
                case BURNING:
                    this.damagerate = 5;
                    break;
                case DRAIN:
                    this.damagerate = 6;
                    break;
                case VENOM:
                    this.damagerate = 5;
                    break;
                default:
                    this.damagerate = 0;
                    this.stacks = 0;
                    break;
            }
            return;
        }

        public Buff()
        {
            this.name = "";
            this.debuff = false;
            this.active = false;
            this.stacks = 0;
            this.owner = byte.MaxValue;
            this.type = 0;
            this.time = 0;
            this.damagerate = 0;
            this.damageCounter = 0;
        }
    }
}