using System;

namespace Terraria
{
    public class Recipe
    {
        public static int maxRequirements = 15;
        public static int maxRecipes = 34;
        public static int numRecipes = 0;
        private static Recipe newRecipe = new Recipe();
        public Item createItem = new Item();
        public Item[] requiredItem = new Item[Recipe.maxRequirements];
        public int[] requiredTile = new int[Recipe.maxRequirements];
        public bool needHoney;
        public bool needWater;
        public bool anyWood;
        public bool anyIronBar;

        public Recipe()
        {
            for (int i = 0; i < Recipe.maxRequirements; i++)
            {
                this.requiredItem[i] = new Item();
                this.requiredTile[i] = -1;
            }
        }

        public void Create()
        {
            int num = 0;
            while (num < Recipe.maxRequirements && this.requiredItem[num].type != 0)
            {
                int num2 = this.requiredItem[num].stack;
                for (int i = 0; i < 58; i++)
                {
                    if (i >= 20 && i < 31)
                    {
                        if (Main.player[Main.myPlayer].armor[i - 20].IsTheSameAs(this.requiredItem[num]))
                        {
                            if (Main.player[Main.myPlayer].armor[i - 20].stack > num2)
                            {
                                Main.player[Main.myPlayer].armor[i - 20].stack -= num2;
                                num2 = 0;
                            }
                            else
                            {
                                num2 -= Main.player[Main.myPlayer].armor[i - 20].stack;
                                Main.player[Main.myPlayer].armor[i - 20] = new Item();
                            }
                        }
                    }
                    if (i == 32)
                    {
                        if (Main.mouseItem.IsTheSameAs(this.requiredItem[num]))
                        {
                            if (Main.mouseItem.stack > num2)
                            {
                                Main.mouseItem.stack -= num2;
                                num2 = 0;
                            }
                            else
                            {
                                num2 -= Main.mouseItem.stack;
                                Main.mouseItem = new Item();
                            }
                        }
                    }
                    else if (Main.player[Main.myPlayer].inventory[i].IsTheSameAs(this.requiredItem[num]) || this.useWood(Main.player[Main.myPlayer].inventory[i].type, this.requiredItem[num].type) || this.useIronBar(Main.player[Main.myPlayer].inventory[i].type, this.requiredItem[num].type))
                    {
                        if (Main.player[Main.myPlayer].inventory[i].stack > num2)
                        {
                            Main.player[Main.myPlayer].inventory[i].stack -= num2;
                            num2 = 0;
                        }
                        else
                        {
                            num2 -= Main.player[Main.myPlayer].inventory[i].stack;
                            Main.player[Main.myPlayer].inventory[i] = new Item();
                        }
                    }
                    if (num2 <= 0)
                    {
                        break;
                    }
                }
                num++;
            }
            Recipe.FindRecipes();
        }

        public bool useWood(int invType, int reqType)
        {
            return (reqType == 9 || reqType == 619 || reqType == 620 || reqType == 621 || reqType == 911) && (this.anyWood && (invType == 9 || invType == 619 || invType == 620 || invType == 621 || invType == 911));
        }

        public bool useIronBar(int invType, int reqType)
        {
            return (reqType == 22 || reqType == 704) && (this.anyIronBar && (invType == 22 || invType == 704));
        }

        public static void FindRecipes()
        {
            int num = Main.availableRecipe[Main.focusRecipe];
            float num2 = Main.availableRecipeY[Main.focusRecipe];
            for (int i = 0; i < Recipe.maxRecipes; i++)
            {
                Main.availableRecipe[i] = 0;
            }
            Main.numAvailableRecipes = 0;
            int num3 = 0;
            while (num3 < Recipe.maxRecipes && Main.recipe[num3].createItem.type != 0)
            {
                bool flag = true;
                bool flag2 = false;
                if (Main.guideItem.type > 0 && Main.guideItem.stack > 0 && Main.guideItem.name != "")
                {
                    flag2 = true;
                }
                if (flag2)
                {
                    for (int j = 0; j < Recipe.maxRequirements; j++)
                    {
                        if (Main.recipe[num3].requiredItem[j].type == 0)
                        {
                            break;
                        }
                        if (Main.guideItem.IsTheSameAs(Main.recipe[num3].requiredItem[j]) || Main.recipe[num3].useWood(Main.guideItem.type, Main.recipe[num3].requiredItem[j].type) || Main.recipe[num3].useIronBar(Main.guideItem.type, Main.recipe[num3].requiredItem[j].type))
                        {
                            Main.availableRecipe[Main.numAvailableRecipes] = num3;
                            Main.numAvailableRecipes++;
                            break;
                        }
                    }
                }
                else
                {
                    int num4 = 0;
                    while (num4 < Recipe.maxRequirements && Main.recipe[num3].requiredItem[num4].type != 0)
                    {
                        int num5 = Main.recipe[num3].requiredItem[num4].stack;
                        for (int k = 0; k < 58; k++)
                        {
                            if (k >= 20 && k < 31)
                            {
                                if (Main.player[Main.myPlayer].armor[k - 20].IsTheSameAs(Main.recipe[num3].requiredItem[num4]))
                                {
                                    num5 -= Main.player[Main.myPlayer].armor[k - 20].stack;
                                    if (num5 <= 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (Main.player[Main.myPlayer].inventory[k].IsTheSameAs(Main.recipe[num3].requiredItem[num4]) || Main.recipe[num3].useWood(Main.player[Main.myPlayer].inventory[k].type, Main.recipe[num3].requiredItem[num4].type) || Main.recipe[num3].useIronBar(Main.player[Main.myPlayer].inventory[k].type, Main.recipe[num3].requiredItem[num4].type))
                            {
                                num5 -= Main.player[Main.myPlayer].inventory[k].stack;
                            }
                            if (num5 <= 0)
                            {
                                break;
                            }
                        }
                        if (num5 > 0)
                        {
                            flag = false;
                            break;
                        }
                        num4++;
                    }
                    if (flag)
                    {
                        bool flag3 = true;
                        int num6 = 0;
                        while (num6 < Recipe.maxRequirements && Main.recipe[num3].requiredTile[num6] != -1)
                        {
                            if (!Main.player[Main.myPlayer].adjTile[Main.recipe[num3].requiredTile[num6]])
                            {
                                flag3 = false;
                                break;
                            }
                            num6++;
                        }
                        if (flag3 && (!Main.recipe[num3].needWater || Main.recipe[num3].needWater == Main.player[Main.myPlayer].adjWater) && (!Main.recipe[num3].needHoney || Main.recipe[num3].needHoney == Main.player[Main.myPlayer].adjHoney))
                        {
                            Main.availableRecipe[Main.numAvailableRecipes] = num3;
                            Main.numAvailableRecipes++;
                        }
                    }
                }
                num3++;
            }
            for (int l = 0; l < Main.numAvailableRecipes; l++)
            {
                if (num == Main.availableRecipe[l])
                {
                    Main.focusRecipe = l;
                    break;
                }
            }
            if (Main.focusRecipe >= Main.numAvailableRecipes)
            {
                Main.focusRecipe = Main.numAvailableRecipes - 1;
            }
            if (Main.focusRecipe < 0)
            {
                Main.focusRecipe = 0;
            }
            float num7 = Main.availableRecipeY[Main.focusRecipe] - num2;
            for (int m = 0; m < Recipe.maxRecipes; m++)
            {
                Main.availableRecipeY[m] -= num7;
            }
        }

        public static void SetupRecipes()
        {
            Recipe.newRecipe.createItem.SetDefaults(982, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(111, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(49, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1073, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1595, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(982, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1074, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(898, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(54, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(212, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(285, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(1075, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(399, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(53, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(159, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1076, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1247, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1132, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(532, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1171, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(540, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(1077, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(897, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(536, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(211, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1078, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(897, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(490, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1079, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1343, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1322, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1344, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(887, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1345, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(889, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1346, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(888, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1347, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(886, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1348, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(885, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1349, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(890, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1109, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1132, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(936, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1080, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1090, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(111, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(489, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(53, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1088, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1091, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(490, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1290, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1085, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1092, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(489, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1290, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1086, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1093, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(491, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1290, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1087, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1095, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(540, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(938, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1253, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1171, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(1083, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1094, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(54, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(977, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1101, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(285, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[5].SetDefaults(1084, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1098, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1094, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(963, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1099, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1100, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(982, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1103, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1089, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1360, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(491, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1300, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1081, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1361, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(491, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1321, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1082, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1364, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(49, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1363, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1096, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1365, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1364, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1097, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1108, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(54, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(159, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1101, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1554, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(1105, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1110, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(982, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(177, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1103, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1107, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(938, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(540, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(156, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1102, false);
            Recipe.newRecipe.requiredItem[3].SetDefaults(1171, false);
            Recipe.newRecipe.requiredItem[4].SetDefaults(1104, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1111, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1108, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1090, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1112, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(935, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(158, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(1103, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1113, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1366, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(49, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(540, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1368, false);
            Recipe.addRecipe();
            Recipe.newRecipe.createItem.SetDefaults(1367, false);
            Recipe.newRecipe.requiredItem[0].SetDefaults(1366, false);
            Recipe.newRecipe.requiredItem[1].SetDefaults(216, false);
            Recipe.newRecipe.requiredItem[2].SetDefaults(1369, false);
            Recipe.addRecipe();
            Recipe.wallReturn();
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                int num = 0;
                while (Main.recipe[i].requiredItem[num].type > 0)
                {
                    Main.recipe[i].requiredItem[num].checkMat();
                    num++;
                }
                Main.recipe[i].createItem.checkMat();
            }
        }

        private static void wallReturn()
        {
            int num = Recipe.numRecipes;
            for (int i = 0; i < num; i++)
            {
                if (Main.recipe[i].createItem.createWall > 0 && Main.recipe[i].requiredItem[1].type == 0)
                {
                    Recipe.newRecipe.createItem.SetDefaults(Main.recipe[i].requiredItem[0].type, false);
                    Recipe.newRecipe.createItem.stack = Main.recipe[i].requiredItem[0].stack;
                    Recipe.newRecipe.requiredItem[0].SetDefaults(Main.recipe[i].createItem.type, false);
                    Recipe.newRecipe.requiredItem[0].stack = Main.recipe[i].createItem.stack;
                    for (int j = 0; j < Recipe.newRecipe.requiredTile.Length; j++)
                    {
                        Recipe.newRecipe.requiredTile[j] = Main.recipe[i].requiredTile[j];
                    }
                    Recipe.addRecipe();
                    Recipe recipe = Main.recipe[Recipe.numRecipes - 1];
                    for (int k = Recipe.numRecipes - 2; k > i; k--)
                    {
                        Main.recipe[k + 1] = Main.recipe[k];
                    }
                    Main.recipe[i + 1] = recipe;
                }
            }
        }

        private static void addRecipe()
        {
            Main.recipe[Recipe.numRecipes] = Recipe.newRecipe;
            Recipe.newRecipe = new Recipe();
            Recipe.numRecipes++;
        }
    }
}