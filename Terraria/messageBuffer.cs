﻿using Microsoft.Xna.Framework;
using System;
using System.Text;

namespace Terraria
{
    public class messageBuffer
    {
        public const int readBufferMax = 65535;
        public const int writeBufferMax = 65535;
        public bool broadcast;
        public byte[] readBuffer = new byte[65535];
        public byte[] writeBuffer = new byte[65535];
        public bool writeLocked;
        public int messageLength;
        public int totalData;
        public int whoAmI;
        public int spamCount;
        public int maxSpam;
        public bool checkBytes;

        public void Reset()
        {
            this.writeBuffer = new byte[65535];
            this.writeLocked = false;
            this.messageLength = 0;
            this.totalData = 0;
            this.spamCount = 0;
            this.broadcast = false;
            this.checkBytes = false;
        }

        public void GetData(int start, int length)
        {
            if (this.whoAmI < 256)
            {
                Netplay.serverSock[this.whoAmI].timeOut = 0;
            }
            else
            {
                Netplay.clientSock.timeOut = 0;
            }
            int num = start + 1;
            byte b = this.readBuffer[start];
            Main.rxMsg++;
            Main.rxData += length;
            Main.rxMsgType[(int) b]++;
            Main.rxDataType[(int) b] += length;
            if (Main.netMode == 1 && Netplay.clientSock.statusMax > 0)
            {
                Netplay.clientSock.statusCount++;
            }
            if (Main.verboseNetplay)
            {
                for (int i = start; i < start + length; i++)
                {
                }
                for (int j = start; j < start + length; j++)
                {
                    byte arg_CD_0 = this.readBuffer[j];
                }
            }
            if (Main.netMode == 2 && b != 38 && Netplay.serverSock[this.whoAmI].state == -1)
            {
                NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[1], 0, 0f, 0f, 0f, 0);
                return;
            }
            if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state < 10 && b > 12 && b != 16 && b != 42 && b != 50 && b != 38 && b != 68 && b < 100 && b != 49 && b != 56 && b != 57)
            {
                NetMessage.BootPlayer(this.whoAmI, Lang.mp[2]);
            }
            if (b == 1 && Main.netMode == 2)
            {
                if (Main.dedServ && Netplay.CheckBan(Netplay.serverSock[this.whoAmI].tcpClient.Client.RemoteEndPoint.ToString()))
                {
                    NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[3], 0, 0f, 0f, 0f, 0);
                    return;
                }
                if (Netplay.serverSock[this.whoAmI].state == 0)
                {
                    string @string = Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
                    if (!(@string == "Terraria" + Main.curRelease))
                    {
                        NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[4], 0, 0f, 0f, 0f, 0);
                        return;
                    }
                    if (Netplay.password == null || Netplay.password == "")
                    {
                        Netplay.serverSock[this.whoAmI].state = 1;
                        if (Main.autoChoose) NetMessage.buffer[this.whoAmI].broadcast = true;
                        NetMessage.SendData(3, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                        return;
                    }
                    Netplay.serverSock[this.whoAmI].state = -1;
                    NetMessage.SendData(37, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                    return;
                }
            }
            else
            {
                if (b == 2 && Main.netMode == 1)
                {
                    Netplay.disconnect = true;
                    Main.statusText = Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
                    return;
                }
                if (b == 3 && Main.netMode == 1)
                {
                    int num2 = (int) this.readBuffer[start + 1];
                    if (Main.autoChoose && !Main.lockedIn)
                    {
                        NetMessage.SendData(100, -1, -1, "", 0);
                        NetMessage.SendData(101, -1, -1, Main.nickName, Main.loadPlayer[Main.numLoadPlayers].hero, Main.loadPlayer[Main.numLoadPlayers].team);
                        return;
                    }
                    if (Netplay.clientSock.state == 1)
                    {
                        Netplay.clientSock.state = 2;
                    }
                    if (num2 != Main.myPlayer)
                    {
                        Main.player[num2] = (Player) Main.player[Main.myPlayer].Clone();
                        Main.player[Main.myPlayer] = new Player();
                        Main.player[num2].whoAmi = num2;
                        Main.myPlayer = num2;
                    }
                    NetMessage.SendData(4, -1, -1, Main.player[Main.myPlayer].name, Main.myPlayer, 0f, 0f, 0f, 0);
                    NetMessage.SendData(68, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
                    NetMessage.SendData(16, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
                    NetMessage.SendData(42, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
                    NetMessage.SendData(50, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
                    for (int k = 0; k < 59; k++)
                    {
                        NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].inventory[k].name, Main.myPlayer, (float) k, (float) Main.player[Main.myPlayer].inventory[k].prefix, 0f, 0);
                    }
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[0].name, Main.myPlayer, 59f, (float) Main.player[Main.myPlayer].armor[0].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[1].name, Main.myPlayer, 60f, (float) Main.player[Main.myPlayer].armor[1].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[2].name, Main.myPlayer, 61f, (float) Main.player[Main.myPlayer].armor[2].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[3].name, Main.myPlayer, 62f, (float) Main.player[Main.myPlayer].armor[3].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[4].name, Main.myPlayer, 63f, (float) Main.player[Main.myPlayer].armor[4].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[5].name, Main.myPlayer, 64f, (float) Main.player[Main.myPlayer].armor[5].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[6].name, Main.myPlayer, 65f, (float) Main.player[Main.myPlayer].armor[6].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[7].name, Main.myPlayer, 66f, (float) Main.player[Main.myPlayer].armor[7].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[8].name, Main.myPlayer, 67f, (float) Main.player[Main.myPlayer].armor[8].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[9].name, Main.myPlayer, 68f, (float) Main.player[Main.myPlayer].armor[9].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[10].name, Main.myPlayer, 69f, (float) Main.player[Main.myPlayer].armor[10].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].ammo[0].name, Main.myPlayer, 70f, (float) Main.player[Main.myPlayer].ammo[0].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].ammo[1].name, Main.myPlayer, 71f, (float) Main.player[Main.myPlayer].ammo[1].prefix, 0f, 0);
                    NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].ammo[2].name, Main.myPlayer, 72f, (float) Main.player[Main.myPlayer].ammo[2].prefix, 0f, 0);
                    NetMessage.SendData(6, -1, -1, "", 0, 0f, 0f, 0f, 0);

                    if (Main.autoChoose && Main.lockedIn)
                    {
                        NetMessage.SendData(100, -1, -1, "", 1);
                    }

                    if (Netplay.clientSock.state == 2)
                    {
                        Netplay.clientSock.state = 3;
                        return;
                    }
                }
                else
                {
                    if (b == 4)
                    {
                        bool flag = false;
                        int num3 = (int) this.readBuffer[start + 1];
                        if (Main.netMode == 2)
                        {
                            num3 = this.whoAmI;
                        }
                        if (num3 == Main.myPlayer && !Main.ServerSideCharacter)
                        {
                            return;
                        }
                        int num4 = (int) this.readBuffer[start + 2];
                        if (num4 >= 51)
                        {
                            num4 = 0;
                        }
                        Main.player[num3].hair = num4;
                        Main.player[num3].whoAmi = num3;
                        num += 2;
                        byte b2 = this.readBuffer[num];
                        num++;
                        if (b2 == 1)
                        {
                            Main.player[num3].male = true;
                        }
                        else
                        {
                            Main.player[num3].male = false;
                        }
                        Main.player[num3].hairColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].hairColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].hairColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].skinColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].skinColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].skinColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].eyeColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].eyeColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].eyeColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].shirtColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].shirtColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].shirtColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].underShirtColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].underShirtColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].underShirtColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].pantsColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].pantsColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].pantsColor.B = this.readBuffer[num];
                        num++;
                        Main.player[num3].shoeColor.R = this.readBuffer[num];
                        num++;
                        Main.player[num3].shoeColor.G = this.readBuffer[num];
                        num++;
                        Main.player[num3].shoeColor.B = this.readBuffer[num];
                        num++;
                        byte difficulty = this.readBuffer[num];
                        Main.player[num3].difficulty = difficulty;
                        num++;
                        Main.player[num3].hero = this.readBuffer[num];
                        num++;
                        string text = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                        text = text.Trim();
                        Main.player[num3].name = text.Trim();
                        if (Main.netMode == 2)
                        {
                            if (Netplay.serverSock[this.whoAmI].state < 10)
                            {
                                for (int l = 0; l < 255; l++)
                                {
                                    if (l != num3 && text == Main.player[l].name && Netplay.serverSock[l].active)
                                    {
                                        flag = true;
                                    }
                                }
                            }
                            if (flag)
                            {
                                NetMessage.SendData(2, this.whoAmI, -1, text + " " + Lang.mp[5], 0, 0f, 0f, 0f, 0);
                                return;
                            }
                            if (text.Length > Player.nameLen)
                            {
                                NetMessage.SendData(2, this.whoAmI, -1, "Name is too long.", 0, 0f, 0f, 0f, 0);
                                return;
                            }
                            if (text == "")
                            {
                                //NetMessage.SendData(2, this.whoAmI, -1, "Empty name.", 0, 0f, 0f, 0f, 0);
                                //return;
                            }
                            Netplay.serverSock[this.whoAmI].oldName = text;
                            Netplay.serverSock[this.whoAmI].name = text;
                            NetMessage.SendData(4, -1, this.whoAmI, text, num3, 0f, 0f, 0f, 0);
                            return;
                        }
                    }
                    else
                    {
                        if (b == 5)
                        {
                            int num5 = (int) this.readBuffer[start + 1];
                            if (Main.netMode == 2)
                            {
                                num5 = this.whoAmI;
                            }
                            if (num5 == Main.myPlayer && !Main.ServerSideCharacter)
                            {
                                return;
                            }
                            lock (Main.player[num5])
                            {
                                int num6 = (int) this.readBuffer[start + 2];
                                int stack = (int) BitConverter.ToInt16(this.readBuffer, start + 3);
                                byte b3 = this.readBuffer[start + 5];
                                int type = (int) BitConverter.ToInt16(this.readBuffer, start + 6);
                                if (num6 < 59)
                                {
                                    Main.player[num5].inventory[num6] = new Item();
                                    Main.player[num5].inventory[num6].netDefaults(type);
                                    Main.player[num5].inventory[num6].stack = stack;
                                    Main.player[num5].inventory[num6].Prefix((int) b3);
                                }
                                else
                                {
                                    if (num6 >= 70 && num6 <= 72)
                                    {
                                        int num7 = num6 - 58 - 12;
                                        Main.player[num5].ammo[num7] = new Item();
                                        Main.player[num5].ammo[num7].netDefaults(type);
                                        Main.player[num5].ammo[num7].stack = stack;
                                        Main.player[num5].ammo[num7].Prefix((int) b3);
                                    }
                                    else
                                    {
                                        Main.player[num5].armor[num6 - 58 - 1] = new Item();
                                        Main.player[num5].armor[num6 - 58 - 1].netDefaults(type);
                                        Main.player[num5].armor[num6 - 58 - 1].stack = stack;
                                        Main.player[num5].armor[num6 - 58 - 1].Prefix((int) b3);
                                    }
                                }
                                if (Main.netMode == 2 && num5 == this.whoAmI)
                                {
                                    NetMessage.SendData(5, -1, this.whoAmI, "", num5, (float) num6, (float) b3, 0f, 0);
                                }
                                return;
                            }
                        }
                        if (b == 6)
                        {
                            if (Main.netMode == 2)
                            {
                                if (Netplay.serverSock[this.whoAmI].state == 1)
                                {
                                    Netplay.serverSock[this.whoAmI].state = 2;
                                }
                                NetMessage.SendData(7, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                                return;
                            }
                        }
                        else
                        {
                            if (b == 7)
                            {
                                if (Main.netMode == 1 && (Main.lockedIn || !Main.autoChoose))
                                {
                                    Main.time = (double) BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.dayTime = false;
                                    if (this.readBuffer[num] == 1)
                                    {
                                        Main.dayTime = true;
                                    }
                                    num++;
                                    Main.moonPhase = (int) this.readBuffer[num];
                                    num++;
                                    int num8 = (int) this.readBuffer[num];
                                    num++;
                                    int num9 = (int) this.readBuffer[num];
                                    num++;
                                    if (num8 == 1)
                                    {
                                        Main.bloodMoon = true;
                                    }
                                    else
                                    {
                                        Main.bloodMoon = false;
                                    }
                                    if (num9 == 1)
                                    {
                                        Main.eclipse = true;
                                    }
                                    else
                                    {
                                        Main.eclipse = false;
                                    }
                                    Main.maxTilesX = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.maxTilesY = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.spawnTileX = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.spawnTileY = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.worldSurface = (double) BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.rockLayer = (double) BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.worldID = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.moonType = (int) this.readBuffer[num];
                                    num++;
                                    Main.treeX[0] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.treeX[1] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.treeX[2] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.treeStyle[0] = (int) this.readBuffer[num];
                                    num++;
                                    Main.treeStyle[1] = (int) this.readBuffer[num];
                                    num++;
                                    Main.treeStyle[2] = (int) this.readBuffer[num];
                                    num++;
                                    Main.treeStyle[3] = (int) this.readBuffer[num];
                                    num++;
                                    Main.caveBackX[0] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.caveBackX[1] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.caveBackX[2] = BitConverter.ToInt32(this.readBuffer, num);
                                    num += 4;
                                    Main.caveBackStyle[0] = (int) this.readBuffer[num];
                                    num++;
                                    Main.caveBackStyle[1] = (int) this.readBuffer[num];
                                    num++;
                                    Main.caveBackStyle[2] = (int) this.readBuffer[num];
                                    num++;
                                    Main.caveBackStyle[3] = (int) this.readBuffer[num];
                                    num++;
                                    byte style = this.readBuffer[num];
                                    num++;
                                    byte style2 = this.readBuffer[num];
                                    num++;
                                    byte style3 = this.readBuffer[num];
                                    num++;
                                    byte style4 = this.readBuffer[num];
                                    num++;
                                    byte style5 = this.readBuffer[num];
                                    num++;
                                    byte style6 = this.readBuffer[num];
                                    num++;
                                    byte style7 = this.readBuffer[num];
                                    num++;
                                    byte style8 = this.readBuffer[num];
                                    num++;
                                    WorldGen.setBG(0, (int) style);
                                    WorldGen.setBG(1, (int) style2);
                                    WorldGen.setBG(2, (int) style3);
                                    WorldGen.setBG(3, (int) style4);
                                    WorldGen.setBG(4, (int) style5);
                                    WorldGen.setBG(5, (int) style6);
                                    WorldGen.setBG(6, (int) style7);
                                    WorldGen.setBG(7, (int) style8);
                                    Main.iceBackStyle = (int) this.readBuffer[num];
                                    num++;
                                    Main.jungleBackStyle = (int) this.readBuffer[num];
                                    num++;
                                    Main.hellBackStyle = (int) this.readBuffer[num];
                                    num++;
                                    Main.windSpeedSet = BitConverter.ToSingle(this.readBuffer, num);
                                    num += 4;
                                    Main.numClouds = (int) this.readBuffer[num];
                                    num++;
                                    byte b4 = this.readBuffer[num];
                                    num++;
                                    byte b5 = this.readBuffer[num];
                                    num++;
                                    float num10 = BitConverter.ToSingle(this.readBuffer, num);
                                    num += 4;
                                    Main.maxRaining = num10;
                                    if (num10 > 0f)
                                    {
                                        Main.raining = true;
                                    }
                                    else
                                    {
                                        Main.raining = false;
                                    }
                                    bool flag3 = false;
                                    bool crimson = false;
                                    if ((b4 & 1) == 1)
                                    {
                                        WorldGen.shadowOrbSmashed = true;
                                    }
                                    if ((b4 & 2) == 2)
                                    {
                                        NPC.downedBoss1 = true;
                                    }
                                    if ((b4 & 4) == 4)
                                    {
                                        NPC.downedBoss2 = true;
                                    }
                                    if ((b4 & 8) == 8)
                                    {
                                        NPC.downedBoss3 = true;
                                    }
                                    if ((b4 & 16) == 16)
                                    {
                                        Main.hardMode = true;
                                    }
                                    if ((b4 & 32) == 32)
                                    {
                                        NPC.downedClown = true;
                                    }
                                    if ((b4 & 64) == 64)
                                    {
                                        Main.ServerSideCharacter = true;
                                    }
                                    if ((b5 & 1) == 1)
                                    {
                                        NPC.downedMechBoss1 = true;
                                    }
                                    if ((b5 & 2) == 2)
                                    {
                                        NPC.downedMechBoss2 = true;
                                    }
                                    if ((b5 & 4) == 4)
                                    {
                                        NPC.downedMechBoss3 = true;
                                    }
                                    if ((b5 & 8) == 8)
                                    {
                                        NPC.downedMechBossAny = true;
                                    }
                                    if ((b5 & 16) == 16)
                                    {
                                        flag3 = true;
                                    }
                                    if ((b5 & 32) == 32)
                                    {
                                        crimson = true;
                                    }
                                    if (flag3)
                                    {
                                        Main.cloudBGActive = 1f;
                                    }
                                    if (!flag3)
                                    {
                                        Main.cloudBGActive = 0f;
                                    }
                                    WorldGen.crimson = crimson;
                                    Main.worldName = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                    if (Netplay.clientSock.state == 3)
                                    {
                                        Netplay.clientSock.state = 4;
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                if (b == 8)
                                {
                                    if (Main.netMode == 2)
                                    {
                                        int num11 = BitConverter.ToInt32(this.readBuffer, num);
                                        num += 4;
                                        int num12 = BitConverter.ToInt32(this.readBuffer, num);
                                        num += 4;
                                        bool flag4 = true;
                                        if (num11 == -1 || num12 == -1)
                                        {
                                            flag4 = false;
                                        }
                                        else
                                        {
                                            if (num11 < 10 || num11 > Main.maxTilesX - 10)
                                            {
                                                flag4 = false;
                                            }
                                            else
                                            {
                                                if (num12 < 10 || num12 > Main.maxTilesY - 10)
                                                {
                                                    flag4 = false;
                                                }
                                            }
                                        }
                                        int num13 = 1350;
                                        if (flag4)
                                        {
                                            num13 *= 2;
                                        }
                                        if (Netplay.serverSock[this.whoAmI].state == 2)
                                        {
                                            Netplay.serverSock[this.whoAmI].state = 3;
                                        }
                                        NetMessage.SendData(9, this.whoAmI, -1, Lang.inter[44], num13, 0f, 0f, 0f, 0);
                                        Netplay.serverSock[this.whoAmI].statusText2 = "is receiving tile data";
                                        Netplay.serverSock[this.whoAmI].statusMax += num13;
                                        int sectionX = Netplay.GetSectionX(Main.spawnTileX);
                                        int sectionY = Netplay.GetSectionY(Main.spawnTileY);
                                        for (int m = sectionX - 2; m < sectionX + 3; m++)
                                        {
                                            for (int n = sectionY - 1; n < sectionY + 2; n++)
                                            {
                                                NetMessage.SendSection(this.whoAmI, m, n);
                                            }
                                        }
                                        if (flag4)
                                        {
                                            num11 = Netplay.GetSectionX(num11);
                                            num12 = Netplay.GetSectionY(num12);
                                            for (int num14 = num11 - 2; num14 < num11 + 3; num14++)
                                            {
                                                for (int num15 = num12 - 1; num15 < num12 + 2; num15++)
                                                {
                                                    NetMessage.SendSection(this.whoAmI, num14, num15);
                                                }
                                            }
                                            NetMessage.SendData(11, this.whoAmI, -1, "", num11 - 2, (float) (num12 - 1), (float) (num11 + 2), (float) (num12 + 1), 0);
                                        }
                                        NetMessage.SendData(11, this.whoAmI, -1, "", sectionX - 2, (float) (sectionY - 1), (float) (sectionX + 2), (float) (sectionY + 1), 0);
                                        for (int num16 = 0; num16 < 400; num16++)
                                        {
                                            if (Main.item[num16].active)
                                            {
                                                NetMessage.SendData(21, this.whoAmI, -1, "", num16, 0f, 0f, 0f, 0);
                                                NetMessage.SendData(22, this.whoAmI, -1, "", num16, 0f, 0f, 0f, 0);
                                            }
                                        }
                                        for (int num17 = 0; num17 < 200; num17++)
                                        {
                                            if (Main.npc[num17].active)
                                            {
                                                NetMessage.SendData(23, this.whoAmI, -1, "", num17, 0f, 0f, 0f, 0);
                                            }
                                        }
                                        for (int num18 = 0; num18 < 1000; num18++)
                                        {
                                            if (Main.projectile[num18].active && (Main.projPet[Main.projectile[num18].type] || Main.projectile[num18].netImportant))
                                            {
                                                NetMessage.SendData(27, this.whoAmI, -1, "", num18, 0f, 0f, 0f, 0);
                                            }
                                        }
                                        NetMessage.SendData(49, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(57, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 17, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 18, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 19, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 20, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 22, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 38, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 54, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 107, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 108, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 124, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 160, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 178, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 207, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 208, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 209, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 227, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 228, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(56, this.whoAmI, -1, "", 229, 0f, 0f, 0f, 0);
                                        NetMessage.SendData(7, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                                        return;
                                    }
                                }
                                else
                                {
                                    if (b == 9)
                                    {
                                        if (Main.netMode == 1)
                                        {
                                            int num19 = BitConverter.ToInt32(this.readBuffer, start + 1);
                                            string string2 = Encoding.UTF8.GetString(this.readBuffer, start + 5, length - 5);
                                            Netplay.clientSock.statusMax += num19;
                                            Netplay.clientSock.statusText = string2;
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        if (b == 10 && Main.netMode == 1)
                                        {
                                            short num20 = BitConverter.ToInt16(this.readBuffer, start + 1);
                                            int num21 = BitConverter.ToInt32(this.readBuffer, start + 3);
                                            int num22 = BitConverter.ToInt32(this.readBuffer, start + 7);
                                            num = start + 11;
                                            for (int num23 = num21; num23 < num21 + (int) num20; num23++)
                                            {
                                                if (Main.tile[num23, num22] == null)
                                                {
                                                    Main.tile[num23, num22] = new Tile();
                                                }
                                                byte b6 = this.readBuffer[num];
                                                num++;
                                                byte b7 = this.readBuffer[num];
                                                num++;
                                                bool flag5 = Main.tile[num23, num22].active();
                                                if ((b6 & 1) == 1)
                                                {
                                                    Main.tile[num23, num22].active(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].active(false);
                                                }
                                                byte arg_1BE8_0 = ((byte) (b6 & 2));
                                                if ((b6 & 4) == 4)
                                                {
                                                    Main.tile[num23, num22].wall = 1;
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].wall = 0;
                                                }
                                                if ((b6 & 8) == 8)
                                                {
                                                    Main.tile[num23, num22].liquid = 1;
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].liquid = 0;
                                                }
                                                if ((b6 & 16) == 16)
                                                {
                                                    Main.tile[num23, num22].wire(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].wire(false);
                                                }
                                                if ((b6 & 32) == 32)
                                                {
                                                    Main.tile[num23, num22].halfBrick(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].halfBrick(false);
                                                }
                                                if ((b6 & 64) == 64)
                                                {
                                                    Main.tile[num23, num22].actuator(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].actuator(false);
                                                }
                                                if ((b6 & 128) == 128)
                                                {
                                                    Main.tile[num23, num22].inActive(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].inActive(false);
                                                }
                                                if ((b7 & 1) == 1)
                                                {
                                                    Main.tile[num23, num22].wire2(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].wire2(false);
                                                }
                                                if ((b7 & 2) == 2)
                                                {
                                                    Main.tile[num23, num22].wire3(true);
                                                }
                                                else
                                                {
                                                    Main.tile[num23, num22].wire3(false);
                                                }
                                                if ((b7 & 4) == 4)
                                                {
                                                    Main.tile[num23, num22].color(this.readBuffer[num]);
                                                    num++;
                                                }
                                                if ((b7 & 8) == 8)
                                                {
                                                    Main.tile[num23, num22].wallColor(this.readBuffer[num]);
                                                    num++;
                                                }
                                                if (Main.tile[num23, num22].active())
                                                {
                                                    int type2 = (int) Main.tile[num23, num22].type;
                                                    Main.tile[num23, num22].type = this.readBuffer[num];
                                                    num++;
                                                    if (Main.tileFrameImportant[(int) Main.tile[num23, num22].type])
                                                    {
                                                        Main.tile[num23, num22].frameX = BitConverter.ToInt16(this.readBuffer, num);
                                                        num += 2;
                                                        Main.tile[num23, num22].frameY = BitConverter.ToInt16(this.readBuffer, num);
                                                        num += 2;
                                                    }
                                                    else
                                                    {
                                                        if (!flag5 || (int) Main.tile[num23, num22].type != type2)
                                                        {
                                                            Main.tile[num23, num22].frameX = -1;
                                                            Main.tile[num23, num22].frameY = -1;
                                                        }
                                                    }
                                                    byte b8 = 0;
                                                    if ((b7 & 16) == 16)
                                                    {
                                                        b8 += 1;
                                                    }
                                                    if ((b7 & 32) == 32)
                                                    {
                                                        b8 += 2;
                                                    }
                                                    Main.tile[num23, num22].slope(b8);
                                                }
                                                if (Main.tile[num23, num22].wall > 0)
                                                {
                                                    Main.tile[num23, num22].wall = this.readBuffer[num];
                                                    num++;
                                                }
                                                if (Main.tile[num23, num22].liquid > 0)
                                                {
                                                    Main.tile[num23, num22].liquid = this.readBuffer[num];
                                                    num++;
                                                    byte liquidType = this.readBuffer[num];
                                                    num++;
                                                    Main.tile[num23, num22].liquidType((int) liquidType);
                                                }
                                                short num24 = BitConverter.ToInt16(this.readBuffer, num);
                                                num += 2;
                                                int num25 = num23;
                                                while (num24 > 0)
                                                {
                                                    num25++;
                                                    num24 -= 1;
                                                    if (Main.tile[num25, num22] == null)
                                                    {
                                                        Main.tile[num25, num22] = new Tile();
                                                    }
                                                    Main.tile[num25, num22].active(Main.tile[num23, num22].active());
                                                    Main.tile[num25, num22].type = Main.tile[num23, num22].type;
                                                    Main.tile[num25, num22].wall = Main.tile[num23, num22].wall;
                                                    Main.tile[num25, num22].wire(Main.tile[num23, num22].wire());
                                                    if (Main.tileFrameImportant[(int) Main.tile[num25, num22].type])
                                                    {
                                                        Main.tile[num25, num22].frameX = Main.tile[num23, num22].frameX;
                                                        Main.tile[num25, num22].frameY = Main.tile[num23, num22].frameY;
                                                    }
                                                    else
                                                    {
                                                        Main.tile[num25, num22].frameX = -1;
                                                        Main.tile[num25, num22].frameY = -1;
                                                    }
                                                    Main.tile[num25, num22].liquid = Main.tile[num23, num22].liquid;
                                                    Main.tile[num25, num22].liquidType((int) Main.tile[num23, num22].liquidType());
                                                    Main.tile[num25, num22].halfBrick(Main.tile[num23, num22].halfBrick());
                                                    Main.tile[num25, num22].slope(Main.tile[num23, num22].slope());
                                                    Main.tile[num25, num22].actuator(Main.tile[num23, num22].actuator());
                                                    Main.tile[num25, num22].inActive(Main.tile[num23, num22].inActive());
                                                    Main.tile[num25, num22].wire2(Main.tile[num23, num22].wire2());
                                                    Main.tile[num25, num22].wire3(Main.tile[num23, num22].wire3());
                                                    Main.tile[num25, num22].color(Main.tile[num23, num22].color());
                                                    Main.tile[num25, num22].wallColor(Main.tile[num23, num22].wallColor());
                                                }
                                                num23 = num25;
                                            }
                                            if (Main.netMode == 2)
                                            {
                                                NetMessage.SendData((int) b, -1, this.whoAmI, "", (int) num20, (float) num21, (float) num22, 0f, 0);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (b == 11)
                                            {
                                                if (Main.netMode == 1)
                                                {
                                                    int startX = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                    num += 4;
                                                    int startY = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                    num += 4;
                                                    int endX = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                    num += 4;
                                                    int endY = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                    num += 4;
                                                    WorldGen.SectionTileFrame(startX, startY, endX, endY);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                if (b == 12)
                                                {
                                                    int num26 = (int) this.readBuffer[num];
                                                    if (Main.netMode == 2)
                                                    {
                                                        num26 = this.whoAmI;
                                                    }
                                                    num++;
                                                    Main.player[num26].SpawnX = BitConverter.ToInt32(this.readBuffer, num);
                                                    num += 4;
                                                    Main.player[num26].SpawnY = BitConverter.ToInt32(this.readBuffer, num);
                                                    num += 4;
                                                    Main.player[num26].Spawn();
                                                    if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state >= 3)
                                                    {
                                                        if (Netplay.serverSock[this.whoAmI].state == 3)
                                                        {
                                                            Netplay.serverSock[this.whoAmI].state = 10;
                                                            NetMessage.greetPlayer(this.whoAmI);
                                                            NetMessage.buffer[this.whoAmI].broadcast = true;
                                                            NetMessage.syncPlayers();
                                                            NetMessage.SendData(12, -1, this.whoAmI, "", this.whoAmI, 0f, 0f, 0f, 0);
                                                            return;
                                                        }
                                                        NetMessage.SendData(12, -1, this.whoAmI, "", this.whoAmI, 0f, 0f, 0f, 0);
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    if (b == 13)
                                                    {
                                                        int num27 = (int) this.readBuffer[num];
                                                        if (num27 == Main.myPlayer && !Main.ServerSideCharacter)
                                                        {
                                                            return;
                                                        }
                                                        if (Main.netMode == 1)
                                                        {
                                                            bool arg_2486_0 = Main.player[num27].active;
                                                        }
                                                        if (Main.netMode == 2)
                                                        {
                                                            num27 = this.whoAmI;
                                                        }
                                                        num++;
                                                        int num28 = (int) this.readBuffer[num];
                                                        num++;
                                                        int selectedItem = (int) this.readBuffer[num];
                                                        num++;
                                                        float x = BitConverter.ToSingle(this.readBuffer, num);
                                                        num += 4;
                                                        float num29 = BitConverter.ToSingle(this.readBuffer, num);
                                                        num += 4;
                                                        float x2 = BitConverter.ToSingle(this.readBuffer, num);
                                                        num += 4;
                                                        float y = BitConverter.ToSingle(this.readBuffer, num);
                                                        num += 4;
                                                        byte b9 = this.readBuffer[num];
                                                        num++;
                                                        Main.player[num27].selectedItem = selectedItem;
                                                        Main.player[num27].position.X = x;
                                                        Main.player[num27].position.Y = num29;
                                                        Main.player[num27].velocity.X = x2;
                                                        Main.player[num27].velocity.Y = y;
                                                        Main.player[num27].oldVelocity = Main.player[num27].velocity;
                                                        Main.player[num27].fallStart = (int) (num29/16f);
                                                        Main.player[num27].controlUp = false;
                                                        Main.player[num27].controlDown = false;
                                                        Main.player[num27].controlLeft = false;
                                                        Main.player[num27].controlRight = false;
                                                        Main.player[num27].controlJump = false;
                                                        Main.player[num27].controlUseItem = false;
                                                        Main.player[num27].direction = -1;
                                                        if ((num28 & 1) == 1)
                                                        {
                                                            Main.player[num27].controlUp = true;
                                                        }
                                                        if ((num28 & 2) == 2)
                                                        {
                                                            Main.player[num27].controlDown = true;
                                                        }
                                                        if ((num28 & 4) == 4)
                                                        {
                                                            Main.player[num27].controlLeft = true;
                                                        }
                                                        if ((num28 & 8) == 8)
                                                        {
                                                            Main.player[num27].controlRight = true;
                                                        }
                                                        if ((num28 & 16) == 16)
                                                        {
                                                            Main.player[num27].controlJump = true;
                                                        }
                                                        if ((num28 & 32) == 32)
                                                        {
                                                            Main.player[num27].controlUseItem = true;
                                                        }
                                                        if ((num28 & 64) == 64)
                                                        {
                                                            Main.player[num27].direction = 1;
                                                        }
                                                        if ((b9 & 1) == 1)
                                                        {
                                                            Main.player[num27].pulley = true;
                                                            if ((b9 & 2) == 2)
                                                            {
                                                                Main.player[num27].pulleyDir = 2;
                                                            }
                                                            else
                                                            {
                                                                Main.player[num27].pulleyDir = 1;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Main.player[num27].pulley = false;
                                                        }
                                                        if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state == 10)
                                                        {
                                                            NetMessage.SendData(13, -1, this.whoAmI, "", num27, 0f, 0f, 0f, 0);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (b == 14)
                                                        {
                                                            if (Main.netMode == 1)
                                                            {
                                                                int num30 = (int) this.readBuffer[num];
                                                                num++;
                                                                int num31 = (int) this.readBuffer[num];
                                                                if (num31 == 1)
                                                                {
                                                                    if (!Main.player[num30].active)
                                                                    {
                                                                        Main.player[num30] = new Player();
                                                                    }
                                                                    Main.player[num30].active = true;
                                                                    return;
                                                                }
                                                                Main.player[num30].active = false;
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (b == 15)
                                                            {
                                                                if (Main.netMode == 2)
                                                                {
                                                                    return;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (b == 16)
                                                                {
                                                                    int num32 = (int) this.readBuffer[num];
                                                                    num++;
                                                                    if (num32 == Main.myPlayer && !Main.ServerSideCharacter)
                                                                    {
                                                                        return;
                                                                    }
                                                                    int statLife = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                    num += 2;
                                                                    int statLifeMax = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                    num += 2;
                                                                    byte level = this.readBuffer[num];
                                                                    num++;
                                                                    byte invisCD = this.readBuffer[num];
                                                                    if (Main.netMode == 2)
                                                                    {
                                                                        num32 = this.whoAmI;
                                                                    }
                                                                    Main.player[num32].statLife = statLife;
                                                                    Main.player[num32].statLifeMax = statLifeMax;
                                                                    Main.player[num32].level = level;
                                                                    Main.player[num32].invisCD = invisCD;
                                                                    if (Main.player[num32].statLife <= 0)
                                                                    {
                                                                        Main.player[num32].dead = true;
                                                                    }
                                                                    if (Main.netMode == 2)
                                                                    {
                                                                        NetMessage.SendData(16, -1, this.whoAmI, "", num32, 0f, 0f, 0f, 0);
                                                                        return;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (b == 17)
                                                                    {
                                                                        byte b10 = this.readBuffer[num];
                                                                        num++;
                                                                        int num33 = BitConverter.ToInt32(this.readBuffer, num);
                                                                        num += 4;
                                                                        int num34 = BitConverter.ToInt32(this.readBuffer, num);
                                                                        num += 4;
                                                                        byte b11 = this.readBuffer[num];
                                                                        num++;
                                                                        int num35 = (int) this.readBuffer[num];
                                                                        bool flag6 = false;
                                                                        if (b11 == 1)
                                                                        {
                                                                            flag6 = true;
                                                                        }
                                                                        if (Main.tile[num33, num34] == null)
                                                                        {
                                                                            Main.tile[num33, num34] = new Tile();
                                                                        }
                                                                        if (Main.netMode == 2)
                                                                        {
                                                                            if (!flag6)
                                                                            {
                                                                                if (b10 == 0 || b10 == 2 || b10 == 4)
                                                                                {
                                                                                    Netplay.serverSock[this.whoAmI].spamDelBlock += 1f;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (b10 == 1 || b10 == 3)
                                                                                    {
                                                                                        Netplay.serverSock[this.whoAmI].spamAddBlock += 1f;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (!Netplay.serverSock[this.whoAmI].tileSection[Netplay.GetSectionX(num33), Netplay.GetSectionY(num34)])
                                                                            {
                                                                                flag6 = true;
                                                                            }
                                                                        }
                                                                        if (b10 == 0)
                                                                        {
                                                                            WorldGen.KillTile(num33, num34, flag6, false, false);
                                                                        }
                                                                        else
                                                                        {
                                                                            if (b10 == 1)
                                                                            {
                                                                                WorldGen.PlaceTile(num33, num34, (int) b11, false, true, -1, num35);
                                                                            }
                                                                            else
                                                                            {
                                                                                if (b10 == 2)
                                                                                {
                                                                                    WorldGen.KillWall(num33, num34, flag6);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (b10 == 3)
                                                                                    {
                                                                                        WorldGen.PlaceWall(num33, num34, (int) b11, false);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (b10 == 4)
                                                                                        {
                                                                                            WorldGen.KillTile(num33, num34, flag6, false, true);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (b10 == 5)
                                                                                            {
                                                                                                WorldGen.PlaceWire(num33, num34);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (b10 == 6)
                                                                                                {
                                                                                                    WorldGen.KillWire(num33, num34);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (b10 == 7)
                                                                                                    {
                                                                                                        WorldGen.PoundTile(num33, num34);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (b10 == 8)
                                                                                                        {
                                                                                                            WorldGen.PlaceActuator(num33, num34);
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (b10 == 9)
                                                                                                            {
                                                                                                                WorldGen.KillActuator(num33, num34);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (b10 == 10)
                                                                                                                {
                                                                                                                    WorldGen.PlaceWire2(num33, num34);
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (b10 == 11)
                                                                                                                    {
                                                                                                                        WorldGen.KillWire2(num33, num34);
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (b10 == 12)
                                                                                                                        {
                                                                                                                            WorldGen.PlaceWire3(num33, num34);
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (b10 == 13)
                                                                                                                            {
                                                                                                                                WorldGen.KillWire3(num33, num34);
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (b10 == 14)
                                                                                                                                {
                                                                                                                                    WorldGen.SlopeTile(num33, num34, (int) b11);
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
                                                                        if (Main.netMode == 2)
                                                                        {
                                                                            NetMessage.SendData(17, -1, this.whoAmI, "", (int) b10, (float) num33, (float) num34, (float) b11, num35);
                                                                            if (b10 == 1 && b11 == 53)
                                                                            {
                                                                                NetMessage.SendTileSquare(-1, num33, num34, 1);
                                                                                return;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (b == 18)
                                                                        {
                                                                            if (Main.netMode == 1)
                                                                            {
                                                                                byte b12 = this.readBuffer[num];
                                                                                num++;
                                                                                int num36 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                num += 4;
                                                                                short sunModY = BitConverter.ToInt16(this.readBuffer, num);
                                                                                num += 2;
                                                                                short moonModY = BitConverter.ToInt16(this.readBuffer, num);
                                                                                num += 2;
                                                                                if (b12 == 1)
                                                                                {
                                                                                    Main.dayTime = true;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Main.dayTime = false;
                                                                                }
                                                                                Main.time = (double) num36;
                                                                                Main.sunModY = sunModY;
                                                                                Main.moonModY = moonModY;
                                                                                if (Main.netMode == 2)
                                                                                {
                                                                                    NetMessage.SendData(18, -1, this.whoAmI, "", 0, 0f, 0f, 0f, 0);
                                                                                    return;
                                                                                }
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (b == 19)
                                                                            {
                                                                                byte b13 = this.readBuffer[num];
                                                                                num++;
                                                                                int num37 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                num += 4;
                                                                                int num38 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                num += 4;
                                                                                int num39 = (int) this.readBuffer[num];
                                                                                int direction = 0;
                                                                                if (num39 == 0)
                                                                                {
                                                                                    direction = -1;
                                                                                }
                                                                                if (b13 == 0)
                                                                                {
                                                                                    WorldGen.OpenDoor(num37, num38, direction);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (b13 == 1)
                                                                                    {
                                                                                        WorldGen.CloseDoor(num37, num38, true);
                                                                                    }
                                                                                }
                                                                                if (Main.netMode == 2)
                                                                                {
                                                                                    NetMessage.SendData(19, -1, this.whoAmI, "", (int) b13, (float) num37, (float) num38, (float) num39, 0);
                                                                                    return;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                if (b == 20)
                                                                                {
                                                                                    short num40 = BitConverter.ToInt16(this.readBuffer, start + 1);
                                                                                    int num41 = BitConverter.ToInt32(this.readBuffer, start + 3);
                                                                                    int num42 = BitConverter.ToInt32(this.readBuffer, start + 7);
                                                                                    num = start + 11;
                                                                                    for (int num43 = num41; num43 < num41 + (int) num40; num43++)
                                                                                    {
                                                                                        for (int num44 = num42; num44 < num42 + (int) num40; num44++)
                                                                                        {
                                                                                            if (Main.tile[num43, num44] == null)
                                                                                            {
                                                                                                Main.tile[num43, num44] = new Tile();
                                                                                            }
                                                                                            byte b14 = this.readBuffer[num];
                                                                                            num++;
                                                                                            byte b15 = this.readBuffer[num];
                                                                                            num++;
                                                                                            bool flag7 = Main.tile[num43, num44].active();
                                                                                            if ((b14 & 1) == 1)
                                                                                            {
                                                                                                Main.tile[num43, num44].active(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].active(false);
                                                                                            }
                                                                                            if ((b14 & 4) == 4)
                                                                                            {
                                                                                                Main.tile[num43, num44].wall = 1;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].wall = 0;
                                                                                            }
                                                                                            bool flag8 = false;
                                                                                            if ((b14 & 8) == 8)
                                                                                            {
                                                                                                flag8 = true;
                                                                                            }
                                                                                            if (Main.netMode != 2)
                                                                                            {
                                                                                                if (flag8)
                                                                                                {
                                                                                                    Main.tile[num43, num44].liquid = 1;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    Main.tile[num43, num44].liquid = 0;
                                                                                                }
                                                                                            }
                                                                                            if ((b14 & 16) == 16)
                                                                                            {
                                                                                                Main.tile[num43, num44].wire(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].wire(false);
                                                                                            }
                                                                                            if ((b14 & 32) == 32)
                                                                                            {
                                                                                                Main.tile[num43, num44].halfBrick(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].halfBrick(false);
                                                                                            }
                                                                                            if ((b14 & 64) == 64)
                                                                                            {
                                                                                                Main.tile[num43, num44].actuator(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].actuator(false);
                                                                                            }
                                                                                            if ((b14 & 128) == 128)
                                                                                            {
                                                                                                Main.tile[num43, num44].inActive(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].inActive(false);
                                                                                            }
                                                                                            if ((b15 & 1) == 1)
                                                                                            {
                                                                                                Main.tile[num43, num44].wire2(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].wire2(false);
                                                                                            }
                                                                                            if ((b15 & 2) == 2)
                                                                                            {
                                                                                                Main.tile[num43, num44].wire3(true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.tile[num43, num44].wire3(false);
                                                                                            }
                                                                                            if ((b15 & 4) == 4)
                                                                                            {
                                                                                                Main.tile[num43, num44].color(this.readBuffer[num]);
                                                                                                num++;
                                                                                            }
                                                                                            if ((b15 & 8) == 8)
                                                                                            {
                                                                                                Main.tile[num43, num44].wallColor(this.readBuffer[num]);
                                                                                                num++;
                                                                                            }
                                                                                            if (Main.tile[num43, num44].active())
                                                                                            {
                                                                                                int type3 = (int) Main.tile[num43, num44].type;
                                                                                                Main.tile[num43, num44].type = this.readBuffer[num];
                                                                                                num++;
                                                                                                if (Main.tileFrameImportant[(int) Main.tile[num43, num44].type])
                                                                                                {
                                                                                                    Main.tile[num43, num44].frameX = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                    num += 2;
                                                                                                    Main.tile[num43, num44].frameY = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                    num += 2;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (!flag7 || (int) Main.tile[num43, num44].type != type3)
                                                                                                    {
                                                                                                        Main.tile[num43, num44].frameX = -1;
                                                                                                        Main.tile[num43, num44].frameY = -1;
                                                                                                    }
                                                                                                }
                                                                                                byte b16 = 0;
                                                                                                if ((b15 & 16) == 16)
                                                                                                {
                                                                                                    b16 += 1;
                                                                                                }
                                                                                                if ((b15 & 32) == 32)
                                                                                                {
                                                                                                    b16 += 2;
                                                                                                }
                                                                                                Main.tile[num43, num44].slope(b16);
                                                                                            }
                                                                                            if (Main.tile[num43, num44].wall > 0)
                                                                                            {
                                                                                                Main.tile[num43, num44].wall = this.readBuffer[num];
                                                                                                num++;
                                                                                            }
                                                                                            if (flag8)
                                                                                            {
                                                                                                Main.tile[num43, num44].liquid = this.readBuffer[num];
                                                                                                num++;
                                                                                                byte liquidType2 = this.readBuffer[num];
                                                                                                num++;
                                                                                                Main.tile[num43, num44].liquidType((int) liquidType2);
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    WorldGen.RangeFrame(num41, num42, num41 + (int) num40, num42 + (int) num40);
                                                                                    if (Main.netMode == 2)
                                                                                    {
                                                                                        NetMessage.SendData((int) b, -1, this.whoAmI, "", (int) num40, (float) num41, (float) num42, 0f, 0);
                                                                                        return;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (b == 21)
                                                                                    {
                                                                                        short num45 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                        num += 2;
                                                                                        float num46 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                        num += 4;
                                                                                        float num47 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                        num += 4;
                                                                                        float x3 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                        num += 4;
                                                                                        float y2 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                        num += 4;
                                                                                        short stack2 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                        num += 2;
                                                                                        byte pre = this.readBuffer[num];
                                                                                        num++;
                                                                                        byte b17 = this.readBuffer[num];
                                                                                        num++;
                                                                                        short num48 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                        if (Main.netMode == 1)
                                                                                        {
                                                                                            if (num48 == 0)
                                                                                            {
                                                                                                Main.item[(int) num45].active = false;
                                                                                                return;
                                                                                            }
                                                                                            Main.item[(int) num45].netDefaults((int) num48);
                                                                                            Main.item[(int) num45].Prefix((int) pre);
                                                                                            Main.item[(int) num45].stack = (int) stack2;
                                                                                            Main.item[(int) num45].position.X = num46;
                                                                                            Main.item[(int) num45].position.Y = num47;
                                                                                            Main.item[(int) num45].velocity.X = x3;
                                                                                            Main.item[(int) num45].velocity.Y = y2;
                                                                                            Main.item[(int) num45].active = true;
                                                                                            Main.item[(int) num45].wet = Collision.WetCollision(Main.item[(int) num45].position, Main.item[(int) num45].width, Main.item[(int) num45].height);
                                                                                            return;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (num48 == 0)
                                                                                            {
                                                                                                if (num45 < 400)
                                                                                                {
                                                                                                    Main.item[(int) num45].active = false;
                                                                                                    NetMessage.SendData(21, -1, -1, "", (int) num45, 0f, 0f, 0f, 0);
                                                                                                    return;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool flag9 = false;
                                                                                                if (num45 == 400)
                                                                                                {
                                                                                                    flag9 = true;
                                                                                                }
                                                                                                if (flag9)
                                                                                                {
                                                                                                    Item item = new Item();
                                                                                                    item.netDefaults((int) num48);
                                                                                                    num45 = (short) Item.NewItem((int) num46, (int) num47, item.width, item.height, item.type, (int) stack2, true, 0, false);
                                                                                                }
                                                                                                Main.item[(int) num45].netDefaults((int) num48);
                                                                                                Main.item[(int) num45].Prefix((int) pre);
                                                                                                Main.item[(int) num45].stack = (int) stack2;
                                                                                                Main.item[(int) num45].position.X = num46;
                                                                                                Main.item[(int) num45].position.Y = num47;
                                                                                                Main.item[(int) num45].velocity.X = x3;
                                                                                                Main.item[(int) num45].velocity.Y = y2;
                                                                                                Main.item[(int) num45].active = true;
                                                                                                Main.item[(int) num45].owner = Main.myPlayer;
                                                                                                if (flag9)
                                                                                                {
                                                                                                    NetMessage.SendData(21, -1, -1, "", (int) num45, 0f, 0f, 0f, 0);
                                                                                                    if (b17 == 0)
                                                                                                    {
                                                                                                        Main.item[(int) num45].ownIgnore = this.whoAmI;
                                                                                                        Main.item[(int) num45].ownTime = 100;
                                                                                                    }
                                                                                                    Main.item[(int) num45].FindOwner((int) num45);
                                                                                                    return;
                                                                                                }
                                                                                                NetMessage.SendData(21, -1, this.whoAmI, "", (int) num45, 0f, 0f, 0f, 0);
                                                                                                return;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (b == 22)
                                                                                        {
                                                                                            short num49 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                            num += 2;
                                                                                            byte b18 = this.readBuffer[num];
                                                                                            if (Main.netMode == 2 && Main.item[(int) num49].owner != this.whoAmI)
                                                                                            {
                                                                                                return;
                                                                                            }
                                                                                            Main.item[(int) num49].owner = (int) b18;
                                                                                            if ((int) b18 == Main.myPlayer)
                                                                                            {
                                                                                                Main.item[(int) num49].keepTime = 15;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Main.item[(int) num49].keepTime = 0;
                                                                                            }
                                                                                            if (Main.netMode == 2)
                                                                                            {
                                                                                                Main.item[(int) num49].owner = 255;
                                                                                                Main.item[(int) num49].keepTime = 15;
                                                                                                NetMessage.SendData(22, -1, -1, "", (int) num49, 0f, 0f, 0f, 0);
                                                                                                return;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (b == 23 && Main.netMode == 1)
                                                                                            {
                                                                                                short num50 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                num += 2;
                                                                                                float x4 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                num += 4;
                                                                                                float y3 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                num += 4;
                                                                                                float x5 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                num += 4;
                                                                                                float y4 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                num += 4;
                                                                                                int target = (int) this.readBuffer[num];
                                                                                                num++;
                                                                                                byte b19 = this.readBuffer[num];
                                                                                                num++;
                                                                                                int direction2 = -1;
                                                                                                int directionY = -1;
                                                                                                if ((b19 & 1) == 1)
                                                                                                {
                                                                                                    direction2 = 1;
                                                                                                }
                                                                                                if ((b19 & 2) == 2)
                                                                                                {
                                                                                                    directionY = 1;
                                                                                                }
                                                                                                bool[] array = new bool[4];
                                                                                                if ((b19 & 4) == 4)
                                                                                                {
                                                                                                    array[3] = true;
                                                                                                }
                                                                                                if ((b19 & 8) == 8)
                                                                                                {
                                                                                                    array[2] = true;
                                                                                                }
                                                                                                if ((b19 & 16) == 16)
                                                                                                {
                                                                                                    array[1] = true;
                                                                                                }
                                                                                                if ((b19 & 32) == 32)
                                                                                                {
                                                                                                    array[0] = true;
                                                                                                }
                                                                                                int spriteDirection = -1;
                                                                                                if ((b19 & 64) == 64)
                                                                                                {
                                                                                                    spriteDirection = 1;
                                                                                                }
                                                                                                int num51 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                num += 4;
                                                                                                float[] array2 = new float[NPC.maxAI];
                                                                                                for (int num52 = 0; num52 < NPC.maxAI; num52++)
                                                                                                {
                                                                                                    if (array[num52])
                                                                                                    {
                                                                                                        array2[num52] = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                        num += 4;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        array2[num52] = 0f;
                                                                                                    }
                                                                                                }
                                                                                                int num53 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                int num54 = -1;
                                                                                                if (!Main.npc[(int) num50].active || Main.npc[(int) num50].netID != num53)
                                                                                                {
                                                                                                    if (Main.npc[(int) num50].active)
                                                                                                    {
                                                                                                        num54 = Main.npc[(int) num50].type;
                                                                                                    }
                                                                                                    Main.npc[(int) num50].active = true;
                                                                                                    Main.npc[(int)num50].netDefaults(num53);
                                                                                                    for (int buff = 0; buff < Main.npc[(int)num50].buffs.Length; buff++)
                                                                                                    {
                                                                                                        Main.npc[(int)num50].buffs[buff] = new Buff();
                                                                                                    }
                                                                                                }
                                                                                                Main.npc[(int) num50].position.X = x4;
                                                                                                Main.npc[(int) num50].position.Y = y3;
                                                                                                Main.npc[(int) num50].velocity.X = x5;
                                                                                                Main.npc[(int) num50].velocity.Y = y4;
                                                                                                Main.npc[(int) num50].target = target;
                                                                                                Main.npc[(int) num50].direction = direction2;
                                                                                                Main.npc[(int) num50].directionY = directionY;
                                                                                                Main.npc[(int) num50].spriteDirection = spriteDirection;
                                                                                                Main.npc[(int) num50].life = num51;
                                                                                                for (int num55 = 0; num55 < NPC.maxAI; num55++)
                                                                                                {
                                                                                                    Main.npc[(int) num50].ai[num55] = array2[num55];
                                                                                                }
                                                                                                if (num54 > -1 && num54 != Main.npc[(int) num50].type)
                                                                                                {
                                                                                                    Main.npc[(int) num50].xForm(num54, Main.npc[(int) num50].type);
                                                                                                }
                                                                                                if (num53 == 262)
                                                                                                {
                                                                                                    NPC.plantBoss = (int) num50;
                                                                                                }
                                                                                                if (num53 == 245)
                                                                                                {
                                                                                                    NPC.golemBoss = (int) num50;
                                                                                                    return;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (b == 24)
                                                                                                {
                                                                                                    short num56 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                    num += 2;
                                                                                                    byte b20 = this.readBuffer[num];
                                                                                                    if (Main.netMode == 2)
                                                                                                    {
                                                                                                        b20 = (byte) this.whoAmI;
                                                                                                    }
                                                                                                    Main.npc[(int) num56].StrikeNPC(Main.player[(int) b20].inventory[Main.player[(int) b20].selectedItem].damage, Main.player[(int) b20].inventory[Main.player[(int) b20].selectedItem].knockBack, Main.player[(int) b20].direction, false, false);
                                                                                                    if (Main.netMode == 2)
                                                                                                    {
                                                                                                        NetMessage.SendData(24, -1, this.whoAmI, "", (int) num56, (float) b20, 0f, 0f, 0);
                                                                                                        NetMessage.SendData(23, -1, -1, "", (int) num56, 0f, 0f, 0f, 0);
                                                                                                        return;
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (b == 25)
                                                                                                    {
                                                                                                        int num57 = (int) this.readBuffer[start + 1];
                                                                                                        if (Main.netMode == 2)
                                                                                                        {
                                                                                                            num57 = this.whoAmI;
                                                                                                        }
                                                                                                        byte b21 = this.readBuffer[start + 2];
                                                                                                        byte b22 = this.readBuffer[start + 3];
                                                                                                        byte b23 = this.readBuffer[start + 4];
                                                                                                        if (Main.netMode == 2)
                                                                                                        {
                                                                                                            b21 = 255;
                                                                                                            b22 = 255;
                                                                                                            b23 = 255;
                                                                                                        }
                                                                                                        string string3 = Encoding.UTF8.GetString(this.readBuffer, start + 5, length - 5);
                                                                                                        if (Main.netMode == 1)
                                                                                                        {
                                                                                                            string newText = string3;
                                                                                                            if (num57 < 255)
                                                                                                            {
                                                                                                                newText = "<" + Main.player[num57].name + "> " + string3;
                                                                                                                Main.player[num57].chatText = string3;
                                                                                                                Main.player[num57].chatShowTime = Main.chatLength/2;
                                                                                                            }
                                                                                                            Main.NewText(newText, b21, b22, b23, false);
                                                                                                            return;
                                                                                                        }
                                                                                                        if (Main.netMode == 2)
                                                                                                        {
                                                                                                            string text2 = string3.ToLower();
                                                                                                            if (text2 == Lang.mp[6] || text2 == Lang.mp[21])
                                                                                                            {
                                                                                                                string text3 = "";
                                                                                                                for (int num58 = 0; num58 < 255; num58
                                                                                                                    ++)
                                                                                                                {
                                                                                                                    if (Main.player[num58].active)
                                                                                                                    {
                                                                                                                        if (text3 == "")
                                                                                                                        {
                                                                                                                            text3 += Main.player[num58].name;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            text3 = text3 + ", " + Main.player[num58].name;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                NetMessage.SendData(25, this.whoAmI, -1, Lang.mp[7] + " " + text3 + ".", 255, 255f, 240f, 20f, 0);
                                                                                                                return;
                                                                                                            }
                                                                                                            if (text2.Length >= 4 && text2.Substring(0, 4) == "/me ")
                                                                                                            {
                                                                                                                NetMessage.SendData(25, -1, -1, "*" + Main.player[this.whoAmI].name + " " + string3.Substring(4), 255, 200f, 100f, 0f, 0);
                                                                                                                return;
                                                                                                            }
                                                                                                            if (text2 == Lang.mp[8])
                                                                                                            {
                                                                                                                NetMessage.SendData(25, -1, -1, string.Concat(new object[]
                                                                                                                {
                                                                                                                    "*",
                                                                                                                    Main.player[this.whoAmI].name,
                                                                                                                    " ",
                                                                                                                    Lang.mp[9],
                                                                                                                    " ",
                                                                                                                    Main.rand.Next(1, 101)
                                                                                                                }), 255, 255f, 240f, 20f, 0);
                                                                                                                return;
                                                                                                            }
                                                                                                            if (text2.Length >= 3 && text2.Substring(0, 3) == "/p ")
                                                                                                            {
                                                                                                                if (Main.player[this.whoAmI].team != 0)
                                                                                                                {
                                                                                                                    for (int num59 = 0; num59 < 255; num59
                                                                                                                        ++)
                                                                                                                    {
                                                                                                                        if (Main.player[num59].team == Main.player[this.whoAmI].team)
                                                                                                                        {
                                                                                                                            NetMessage.SendData(25, num59, -1, string3.Substring(3), num57, (float) Main.teamColor[Main.player[this.whoAmI].team].R, (float) Main.teamColor[Main.player[this.whoAmI].team].G, (float) Main.teamColor[Main.player[this.whoAmI].team].B, 0);
                                                                                                                        }
                                                                                                                    }
                                                                                                                    return;
                                                                                                                }
                                                                                                                NetMessage.SendData(25, this.whoAmI, -1, Lang.mp[10], 255, 255f, 240f, 20f, 0);
                                                                                                                return;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (Main.player[this.whoAmI].difficulty == 2)
                                                                                                                {
                                                                                                                    b21 = Main.hcColor.R;
                                                                                                                    b22 = Main.hcColor.G;
                                                                                                                    b23 = Main.hcColor.B;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (Main.player[this.whoAmI].difficulty == 1)
                                                                                                                    {
                                                                                                                        b21 = Main.mcColor.R;
                                                                                                                        b22 = Main.mcColor.G;
                                                                                                                        b23 = Main.mcColor.B;
                                                                                                                    }
                                                                                                                }
                                                                                                                NetMessage.SendData(25, -1, -1, string3, num57, (float) b21, (float) b22, (float) b23, 0);
                                                                                                                if (Main.dedServ)
                                                                                                                {
                                                                                                                    Console.WriteLine("<" + Main.player[this.whoAmI].name + "> " + string3);
                                                                                                                    return;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (b == 26)
                                                                                                        {
                                                                                                            byte target = this.readBuffer[num];
                                                                                                            if (Main.netMode == 2 && this.whoAmI != (int) target && (!Main.player[(int) target].hostile || !Main.player[this.whoAmI].hostile))
                                                                                                            {
                                                                                                                return;
                                                                                                            }
                                                                                                            num++;
                                                                                                            int hitDirection = (int) (this.readBuffer[num] - 1);
                                                                                                            num++;
                                                                                                            short damage = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                            num += 2;
                                                                                                            byte hero = this.readBuffer[num];
                                                                                                            num++;
                                                                                                            bool pvp = false;
                                                                                                            byte crit = this.readBuffer[num];
                                                                                                            num++;
                                                                                                            string deathText = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                            if (hero != byte.MaxValue)
                                                                                                            {
                                                                                                                pvp = true;
                                                                                                            }
                                                                                                            Main.player[(int) target].Hurt((int) damage, hitDirection, pvp, true, deathText, (crit != 0), Main.player[NetMessage.buffer[hero].whoAmI].whoAmi);
                                                                                                            if (Main.netMode == 2)
                                                                                                            {
                                                                                                                NetMessage.SendData(26, -1, this.whoAmI, deathText, (int) target, (float) hitDirection, (float) damage, (float) hero, (int) crit);
                                                                                                                return;
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (b == 27)
                                                                                                            {
                                                                                                                short num62 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                num += 2;
                                                                                                                float x6 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                num += 4;
                                                                                                                float y5 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                num += 4;
                                                                                                                float x7 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                num += 4;
                                                                                                                float y6 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                num += 4;
                                                                                                                float knockBack = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                num += 4;
                                                                                                                short damage = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                num += 2;
                                                                                                                byte b27 = this.readBuffer[num];
                                                                                                                num++;
                                                                                                                short num63 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                num += 2;
                                                                                                                float[] array3 = new float[Projectile.maxAI];
                                                                                                                if (Main.netMode == 2)
                                                                                                                {
                                                                                                                    b27 = (byte) this.whoAmI;
                                                                                                                    if (Main.projHostile[(int) num63])
                                                                                                                    {
                                                                                                                        return;
                                                                                                                    }
                                                                                                                }
                                                                                                                for (int num64 = 0; num64 < Projectile.maxAI; num64
                                                                                                                    ++)
                                                                                                                {
                                                                                                                    array3[num64] = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                    num += 4;
                                                                                                                }
                                                                                                                int num65 = 1000;
                                                                                                                for (int num66 = 0; num66 < 1000; num66
                                                                                                                    ++)
                                                                                                                {
                                                                                                                    if (Main.projectile[num66].owner == (int) b27 && Main.projectile[num66].identity == (int) num62 && Main.projectile[num66].active)
                                                                                                                    {
                                                                                                                        num65 = num66;
                                                                                                                        break;
                                                                                                                    }
                                                                                                                }
                                                                                                                if (num65 == 1000)
                                                                                                                {
                                                                                                                    for (int num67 = 0; num67 < 1000; num67
                                                                                                                        ++)
                                                                                                                    {
                                                                                                                        if (!Main.projectile[num67].active)
                                                                                                                        {
                                                                                                                            num65 = num67;
                                                                                                                            break;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                if (!Main.projectile[num65].active || Main.projectile[num65].type != (int) num63)
                                                                                                                {
                                                                                                                    Main.projectile[num65].SetDefaults((int) num63);
                                                                                                                    if (Main.netMode == 2)
                                                                                                                    {
                                                                                                                        Netplay.serverSock[this.whoAmI].spamProjectile += 1f;
                                                                                                                    }
                                                                                                                }
                                                                                                                Main.projectile[num65].identity = (int) num62;
                                                                                                                Main.projectile[num65].position.X = x6;
                                                                                                                Main.projectile[num65].position.Y = y5;
                                                                                                                Main.projectile[num65].velocity.X = x7;
                                                                                                                Main.projectile[num65].velocity.Y = y6;
                                                                                                                Main.projectile[num65].damage = (int) damage;
                                                                                                                Main.projectile[num65].type = (int) num63;
                                                                                                                Main.projectile[num65].owner = (int) b27;
                                                                                                                Main.projectile[num65].knockBack = knockBack;
                                                                                                                for (int num68 = 0; num68 < Projectile.maxAI; num68
                                                                                                                    ++)
                                                                                                                {
                                                                                                                    Main.projectile[num65].ai[num68] = array3[num68];
                                                                                                                }
                                                                                                                if (Main.netMode == 2)
                                                                                                                {
                                                                                                                    NetMessage.SendData(27, -1, this.whoAmI, "", num65, 0f, 0f, 0f, 0);
                                                                                                                    return;
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (b == 28)
                                                                                                                {
                                                                                                                    short num69 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                    num += 2;
                                                                                                                    short num70 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                    num += 2;
                                                                                                                    float num71 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                    num += 4;
                                                                                                                    int num72 = (int) (this.readBuffer[num] - 1);
                                                                                                                    num++;
                                                                                                                    int num73 = (int) this.readBuffer[num];
                                                                                                                    if (length == 12)
                                                                                                                    {
                                                                                                                        num++;
                                                                                                                        byte statusKiller = this.readBuffer[num];
                                                                                                                        Main.npc[(int) num69].StrikeNPC(9999, 0f, 0, false, false, statusKiller);
                                                                                                                    }
                                                                                                                    else if (num70 >= 0)
                                                                                                                    {
                                                                                                                        if (num73 == 1)
                                                                                                                        {
                                                                                                                            Main.npc[(int) num69].StrikeNPC((int) num70, num71, num72, true, false, Main.player[this.whoAmI].whoAmi, Main.player[Main.player[this.whoAmI].whoAmi].hero);
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (this.whoAmI == 256)
                                                                                                                            {
                                                                                                                                Main.npc[(int) num69].StrikeNPC((int) num70, num71, num72);
                                                                                                                            }
                                                                                                                            else Main.npc[(int) num69].StrikeNPC((int) num70, num71, num72, false, false, Main.player[this.whoAmI].whoAmi, Main.player[Main.player[this.whoAmI].whoAmi].hero);
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        Main.npc[(int) num69].life = 0;
                                                                                                                        Main.npc[(int) num69].HitEffect(0, 10.0);
                                                                                                                        Main.npc[(int) num69].active = false;
                                                                                                                    }
                                                                                                                    if (Main.netMode == 2)
                                                                                                                    {
                                                                                                                        if (Main.npc[(int) num69].life <= 0)
                                                                                                                        {
                                                                                                                            NetMessage.SendData(28, -1, this.whoAmI, "", (int) num69, (float) num70, num71, (float) num72, num73);
                                                                                                                            NetMessage.SendData(23, -1, -1, "", (int) num69, 0f, 0f, 0f, 0);
                                                                                                                            return;
                                                                                                                        }
                                                                                                                        NetMessage.SendData(28, -1, this.whoAmI, "", (int) num69, (float) num70, num71, (float) num72, num73);
                                                                                                                        Main.npc[(int) num69].netUpdate = true;
                                                                                                                        return;
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (b == 29)
                                                                                                                    {
                                                                                                                        short num74 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                        num += 2;
                                                                                                                        byte b28 = this.readBuffer[num];
                                                                                                                        if (Main.netMode == 2)
                                                                                                                        {
                                                                                                                            b28 = (byte) this.whoAmI;
                                                                                                                        }
                                                                                                                        for (int num75 = 0; num75 < 1000; num75
                                                                                                                            ++)
                                                                                                                        {
                                                                                                                            if (Main.projectile[num75].owner == (int) b28 && Main.projectile[num75].identity == (int) num74 && Main.projectile[num75].active)
                                                                                                                            {
                                                                                                                                Main.projectile[num75].Kill();
                                                                                                                                break;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        if (Main.netMode == 2)
                                                                                                                        {
                                                                                                                            NetMessage.SendData(29, -1, this.whoAmI, "", (int) num74, (float) b28, 0f, 0f, 0);
                                                                                                                            return;
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (b == 30)
                                                                                                                        {
                                                                                                                            byte b29 = this.readBuffer[num];
                                                                                                                            if (Main.netMode == 2)
                                                                                                                            {
                                                                                                                                b29 = (byte) this.whoAmI;
                                                                                                                            }
                                                                                                                            num
                                                                                                                                ++;
                                                                                                                            byte b30 = this.readBuffer[num];
                                                                                                                            if (b30 == 1)
                                                                                                                            {
                                                                                                                                Main.player[(int) b29].hostile = true;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                Main.player[(int) b29].hostile = true;
                                                                                                                            }
                                                                                                                            if (Main.netMode == 2)
                                                                                                                            {
                                                                                                                                NetMessage.SendData(30, -1, this.whoAmI, "", (int) b29, 0f, 0f, 0f, 0);
                                                                                                                                string str = " " + Lang.mp[11];
                                                                                                                                if (b30 == 0)
                                                                                                                                {
                                                                                                                                    str = " " + Lang.mp[12];
                                                                                                                                }
                                                                                                                                NetMessage.SendData(25, -1, -1, Main.player[(int) b29].name + str, 255, (float) Main.teamColor[Main.player[(int) b29].team].R, (float) Main.teamColor[Main.player[(int) b29].team].G, (float) Main.teamColor[Main.player[(int) b29].team].B, 0);
                                                                                                                                return;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (b == 31)
                                                                                                                            {
                                                                                                                                if (Main.netMode == 2)
                                                                                                                                {
                                                                                                                                    int x8 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                    num += 4;
                                                                                                                                    int y7 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                    num += 4;
                                                                                                                                    int num76 = Chest.FindChest(x8, y7);
                                                                                                                                    if (num76 > -1 && Chest.UsingChest(num76) == -1)
                                                                                                                                    {
                                                                                                                                        for (int num77 = 0; num77 < Chest.maxItems; num77
                                                                                                                                            ++)
                                                                                                                                        {
                                                                                                                                            NetMessage.SendData(32, this.whoAmI, -1, "", num76, (float) num77, 0f, 0f, 0);
                                                                                                                                        }
                                                                                                                                        NetMessage.SendData(33, this.whoAmI, -1, "", num76, 0f, 0f, 0f, 0);
                                                                                                                                        Main.player[this.whoAmI].chest = num76;
                                                                                                                                        return;
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (b == 32)
                                                                                                                                {
                                                                                                                                    int num78 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                    num += 2;
                                                                                                                                    int num79 = (int) this.readBuffer[num];
                                                                                                                                    num
                                                                                                                                        ++;
                                                                                                                                    int stack3 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                    num += 2;
                                                                                                                                    int pre2 = (int) this.readBuffer[num];
                                                                                                                                    num
                                                                                                                                        ++;
                                                                                                                                    int type4 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                    if (Main.chest[num78] == null)
                                                                                                                                    {
                                                                                                                                        Main.chest[num78] = new Chest();
                                                                                                                                    }
                                                                                                                                    if (Main.chest[num78].item[num79] == null)
                                                                                                                                    {
                                                                                                                                        Main.chest[num78].item[num79] = new Item();
                                                                                                                                    }
                                                                                                                                    Main.chest[num78].item[num79].netDefaults(type4);
                                                                                                                                    Main.chest[num78].item[num79].Prefix(pre2);
                                                                                                                                    Main.chest[num78].item[num79].stack = stack3;
                                                                                                                                    return;
                                                                                                                                }
                                                                                                                                if (b == 33)
                                                                                                                                {
                                                                                                                                    int num80 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                    num += 2;
                                                                                                                                    int chestX = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                    num += 4;
                                                                                                                                    int chestY = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                    {
                                                                                                                                        if (Main.player[Main.myPlayer].chest == -1)
                                                                                                                                        {
                                                                                                                                            Main.playerInventory = true;
                                                                                                                                            Main.PlaySound(10, -1, -1, 1);
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (Main.player[Main.myPlayer].chest != num80 && num80 != -1)
                                                                                                                                            {
                                                                                                                                                Main.playerInventory = true;
                                                                                                                                                Main.PlaySound(12, -1, -1, 1);
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (Main.player[Main.myPlayer].chest != -1 && num80 == -1)
                                                                                                                                                {
                                                                                                                                                    Main.PlaySound(11, -1, -1, 1);
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        Main.player[Main.myPlayer].chest = num80;
                                                                                                                                        Main.player[Main.myPlayer].chestX = chestX;
                                                                                                                                        Main.player[Main.myPlayer].chestY = chestY;
                                                                                                                                        return;
                                                                                                                                    }
                                                                                                                                    Main.player[this.whoAmI].chest = num80;
                                                                                                                                    return;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (b == 34)
                                                                                                                                    {
                                                                                                                                        if (Main.netMode == 2)
                                                                                                                                        {
                                                                                                                                            int num81 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                            num += 4;
                                                                                                                                            int num82 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                            if (Main.tile[num81, num82].type == 21)
                                                                                                                                            {
                                                                                                                                                WorldGen.KillTile(num81, num82, false, false, false);
                                                                                                                                                if (!Main.tile[num81, num82].active())
                                                                                                                                                {
                                                                                                                                                    NetMessage.SendData(17, -1, -1, "", 0, (float) num81, (float) num82, 0f, 0);
                                                                                                                                                    return;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (b == 35)
                                                                                                                                        {
                                                                                                                                            int num83 = (int) this.readBuffer[num];
                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                            {
                                                                                                                                                num83 = this.whoAmI;
                                                                                                                                            }
                                                                                                                                            num
                                                                                                                                                ++;
                                                                                                                                            int num84 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                            num += 2;
                                                                                                                                            if (num83 != Main.myPlayer || Main.ServerSideCharacter)
                                                                                                                                            {
                                                                                                                                                Main.player[num83].HealEffect(num84, true);
                                                                                                                                            }
                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                            {
                                                                                                                                                NetMessage.SendData(35, -1, this.whoAmI, "", num83, (float) num84, 0f, 0f, 0);
                                                                                                                                                return;
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (b == 36)
                                                                                                                                            {
                                                                                                                                                int num85 = (int) this.readBuffer[num];
                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                {
                                                                                                                                                    num85 = this.whoAmI;
                                                                                                                                                }
                                                                                                                                                num
                                                                                                                                                    ++;
                                                                                                                                                byte b31 = this.readBuffer[num];
                                                                                                                                                num
                                                                                                                                                    ++;
                                                                                                                                                if ((b31 & 1) == 1)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneEvil = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneEvil = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 2) == 2)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneMeteor = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneMeteor = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 4) == 4)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneDungeon = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneDungeon = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 8) == 8)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneJungle = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneJungle = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 16) == 16)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneHoly = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneHoly = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 32) == 32)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneSnow = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneSnow = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 64) == 64)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneBlood = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneBlood = false;
                                                                                                                                                }
                                                                                                                                                if ((b31 & 128) == 128)
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneCandle = true;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    Main.player[num85].zoneCandle = false;
                                                                                                                                                }
                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                {
                                                                                                                                                    NetMessage.SendData(36, -1, this.whoAmI, "", num85, 0f, 0f, 0f, 0);
                                                                                                                                                    return;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (b == 37)
                                                                                                                                                {
                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                    {
                                                                                                                                                        if (Main.autoPass)
                                                                                                                                                        {
                                                                                                                                                            NetMessage.SendData(38, -1, -1, Netplay.password, 0, 0f, 0f, 0f, 0);
                                                                                                                                                            Main.autoPass = false;
                                                                                                                                                            return;
                                                                                                                                                        }
                                                                                                                                                        Netplay.password = "";
                                                                                                                                                        Main.menuMode = 31;
                                                                                                                                                        return;
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (b == 38)
                                                                                                                                                    {
                                                                                                                                                        if (Main.netMode == 2)
                                                                                                                                                        {
                                                                                                                                                            string string5 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                            if (string5 == Netplay.password)
                                                                                                                                                            {
                                                                                                                                                                Netplay.serverSock[this.whoAmI].state = 1;
                                                                                                                                                                NetMessage.SendData(3, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
                                                                                                                                                                return;
                                                                                                                                                            }
                                                                                                                                                            NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[1], 0, 0f, 0f, 0f, 0);
                                                                                                                                                            return;
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (b == 39 && Main.netMode == 1)
                                                                                                                                                        {
                                                                                                                                                            short num86 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                            Main.item[(int) num86].owner = 255;
                                                                                                                                                            NetMessage.SendData(22, -1, -1, "", (int) num86, 0f, 0f, 0f, 0);
                                                                                                                                                            return;
                                                                                                                                                        }
                                                                                                                                                        if (b == 40)
                                                                                                                                                        {
                                                                                                                                                            byte b32 = this.readBuffer[num];
                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                            {
                                                                                                                                                                b32 = (byte) this.whoAmI;
                                                                                                                                                            }
                                                                                                                                                            num
                                                                                                                                                                ++;
                                                                                                                                                            int talkNPC = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                            num += 2;
                                                                                                                                                            Main.player[(int) b32].talkNPC = talkNPC;
                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                            {
                                                                                                                                                                NetMessage.SendData(40, -1, this.whoAmI, "", (int) b32, 0f, 0f, 0f, 0);
                                                                                                                                                                return;
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (b == 41)
                                                                                                                                                            {
                                                                                                                                                                byte b33 = this.readBuffer[num];
                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                {
                                                                                                                                                                    b33 = (byte) this.whoAmI;
                                                                                                                                                                }
                                                                                                                                                                num
                                                                                                                                                                    ++;
                                                                                                                                                                float itemRotation = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                num += 4;
                                                                                                                                                                int itemAnimation = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                Main.player[(int) b33].itemRotation = itemRotation;
                                                                                                                                                                Main.player[(int) b33].itemAnimation = itemAnimation;
                                                                                                                                                                Main.player[(int) b33].channel = Main.player[(int) b33].inventory[Main.player[(int) b33].selectedItem].channel;
                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                {
                                                                                                                                                                    NetMessage.SendData(41, -1, this.whoAmI, "", (int) b33, 0f, 0f, 0f, 0);
                                                                                                                                                                    return;
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (b == 42)
                                                                                                                                                                {
                                                                                                                                                                    int num87 = (int) this.readBuffer[num];
                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                    {
                                                                                                                                                                        num87 = this.whoAmI;
                                                                                                                                                                    }
                                                                                                                                                                    num
                                                                                                                                                                        ++;
                                                                                                                                                                    int statMana = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                    num += 2;
                                                                                                                                                                    int statManaMax = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                    num += 2;
                                                                                                                                                                    int manaShield = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                    {
                                                                                                                                                                        num87 = this.whoAmI;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (Main.myPlayer == num87 && !Main.ServerSideCharacter)
                                                                                                                                                                        {
                                                                                                                                                                            return;
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                    Main.player[num87].statMana = statMana;
                                                                                                                                                                    Main.player[num87].statManaMax = statManaMax;
                                                                                                                                                                    Main.player[num87].manaShield = manaShield;
                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                    {
                                                                                                                                                                        NetMessage.SendData(42, -1, this.whoAmI, "", num87, 0f, 0f, 0f, 0);
                                                                                                                                                                        return;
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (b == 43)
                                                                                                                                                                    {
                                                                                                                                                                        int num88 = (int) this.readBuffer[num];
                                                                                                                                                                        num
                                                                                                                                                                            ++;
                                                                                                                                                                        int num89 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                        num += 2;
                                                                                                                                                                        byte neg = this.readBuffer[num];
                                                                                                                                                                        if (Main.netMode == 2 && neg == 0)
                                                                                                                                                                        {
                                                                                                                                                                            num88 = this.whoAmI;
                                                                                                                                                                        }
                                                                                                                                                                        if (neg == 1)
                                                                                                                                                                        {
                                                                                                                                                                            Main.player[num88].statMana -= num89;
                                                                                                                                                                            CombatText.NewText(new Rectangle((int) Main.player[num88].position.X, (int) Main.player[num88].position.Y, Main.player[num88].width, Main.player[num88].height), new Color(200, 50, 255, 255), "-" + string.Concat(num89), false, false);
                                                                                                                                                                        }
                                                                                                                                                                        if (num88 != Main.myPlayer && neg == 0)
                                                                                                                                                                        {
                                                                                                                                                                            Main.player[num88].ManaEffect(num89, (neg == 1) ? true : false);
                                                                                                                                                                        }
                                                                                                                                                                        if (Main.netMode == 2)
                                                                                                                                                                        {
                                                                                                                                                                            NetMessage.SendData(43, -1, this.whoAmI, "", num88, (float) num89, neg, 0f, 0);
                                                                                                                                                                            return;
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (b == 44)
                                                                                                                                                                        {
                                                                                                                                                                            byte b34 = this.readBuffer[num];
                                                                                                                                                                            if ((int) b34 == Main.myPlayer)
                                                                                                                                                                            {
                                                                                                                                                                                return;
                                                                                                                                                                            }
                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                            {
                                                                                                                                                                                b34 = (byte) this.whoAmI;
                                                                                                                                                                            }
                                                                                                                                                                            num
                                                                                                                                                                                ++;
                                                                                                                                                                            int num90 = (int) (this.readBuffer[num] - 1);
                                                                                                                                                                            num
                                                                                                                                                                                ++;
                                                                                                                                                                            short num91 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                            num += 2;
                                                                                                                                                                            byte b35 = this.readBuffer[num];
                                                                                                                                                                            num
                                                                                                                                                                                ++;
                                                                                                                                                                            byte npcTeam = this.readBuffer[num];
                                                                                                                                                                            num
                                                                                                                                                                                ++;
                                                                                                                                                                            string string6 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                            bool pvp2 = false;
                                                                                                                                                                            if (b35 != 0)
                                                                                                                                                                            {
                                                                                                                                                                                pvp2 = true;
                                                                                                                                                                            }
                                                                                                                                                                            Main.player[(int) b34].KillMe((double) num91, num90, pvp2, string6, npcTeam);
                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                            {
                                                                                                                                                                                NetMessage.SendData(44, -1, this.whoAmI, string6, (int) b34, (float) num90, (float) num91, (float) b35, npcTeam);
                                                                                                                                                                                return;
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            if (b == 45)
                                                                                                                                                                            {
                                                                                                                                                                                int num92 = (int) this.readBuffer[num];
                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                {
                                                                                                                                                                                    num92 = this.whoAmI;
                                                                                                                                                                                }
                                                                                                                                                                                num
                                                                                                                                                                                    ++;
                                                                                                                                                                                int num93 = (int) this.readBuffer[num];
                                                                                                                                                                                num
                                                                                                                                                                                    ++;
                                                                                                                                                                                int team = Main.player[num92].team;
                                                                                                                                                                                Main.player[num92].team = num93;
                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                {
                                                                                                                                                                                    NetMessage.SendData(45, -1, this.whoAmI, "", num92, 0f, 0f, 0f, 0);
                                                                                                                                                                                    string str2 = "";
                                                                                                                                                                                    if (num93 == 0)
                                                                                                                                                                                    {
                                                                                                                                                                                        str2 = " " + Lang.mp[13];
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        if (num93 == 1)
                                                                                                                                                                                        {
                                                                                                                                                                                            str2 = " " + Lang.mp[14];
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            if (num93 == 2)
                                                                                                                                                                                            {
                                                                                                                                                                                                str2 = " " + Lang.mp[15];
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                if (num93 == 3)
                                                                                                                                                                                                {
                                                                                                                                                                                                    str2 = " " + Lang.mp[16];
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (num93 == 4)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        str2 = " " + Lang.mp[17];
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    for (int num94 = 0; num94 < 255; num94
                                                                                                                                                                                        ++)
                                                                                                                                                                                    {
                                                                                                                                                                                        if (num94 == this.whoAmI || (team > 0 && Main.player[num94].team == team) || (num93 > 0 && Main.player[num94].team == num93))
                                                                                                                                                                                        {
                                                                                                                                                                                            NetMessage.SendData(25, num94, -1, Main.player[num92].name + str2, 255, (float) Main.teamColor[num93].R, (float) Main.teamColor[num93].G, (float) Main.teamColor[num93].B, 0);
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    return;
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                if (b == 46)
                                                                                                                                                                                {
                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                    {
                                                                                                                                                                                        int i2 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                        num += 4;
                                                                                                                                                                                        int j2 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                        num += 4;
                                                                                                                                                                                        int num95 = Sign.ReadSign(i2, j2);
                                                                                                                                                                                        if (num95 >= 0)
                                                                                                                                                                                        {
                                                                                                                                                                                            NetMessage.SendData(47, this.whoAmI, -1, "", num95, 0f, 0f, 0f, 0);
                                                                                                                                                                                            return;
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    if (b == 47)
                                                                                                                                                                                    {
                                                                                                                                                                                        int num96 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                        num += 2;
                                                                                                                                                                                        int x9 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                        num += 4;
                                                                                                                                                                                        int y8 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                        num += 4;
                                                                                                                                                                                        string string7 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                                        Main.sign[num96] = new Sign();
                                                                                                                                                                                        Main.sign[num96].x = x9;
                                                                                                                                                                                        Main.sign[num96].y = y8;
                                                                                                                                                                                        Sign.TextSign(num96, string7);
                                                                                                                                                                                        if (Main.netMode == 1 && Main.sign[num96] != null && num96 != Main.player[Main.myPlayer].sign)
                                                                                                                                                                                        {
                                                                                                                                                                                            Main.playerInventory = false;
                                                                                                                                                                                            Main.player[Main.myPlayer].talkNPC = -1;
                                                                                                                                                                                            Main.editSign = false;
                                                                                                                                                                                            Main.PlaySound(10, -1, -1, 1);
                                                                                                                                                                                            Main.player[Main.myPlayer].sign = num96;
                                                                                                                                                                                            Main.npcChatText = Main.sign[num96].text;
                                                                                                                                                                                            return;
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        if (b == 48)
                                                                                                                                                                                        {
                                                                                                                                                                                            int num97 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                            num += 4;
                                                                                                                                                                                            int num98 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                            num += 4;
                                                                                                                                                                                            byte liquid = this.readBuffer[num];
                                                                                                                                                                                            num
                                                                                                                                                                                                ++;
                                                                                                                                                                                            byte liquidType3 = this.readBuffer[num];
                                                                                                                                                                                            num
                                                                                                                                                                                                ++;
                                                                                                                                                                                            if (Main.netMode == 2 && Netplay.spamCheck)
                                                                                                                                                                                            {
                                                                                                                                                                                                int num99 = this.whoAmI;
                                                                                                                                                                                                int num100 = (int) (Main.player[num99].position.X + (float) (Main.player[num99].width/2));
                                                                                                                                                                                                int num101 = (int) (Main.player[num99].position.Y + (float) (Main.player[num99].height/2));
                                                                                                                                                                                                int num102 = 10;
                                                                                                                                                                                                int num103 = num100 - num102;
                                                                                                                                                                                                int num104 = num100 + num102;
                                                                                                                                                                                                int num105 = num101 - num102;
                                                                                                                                                                                                int num106 = num101 + num102;
                                                                                                                                                                                                if (num100 < num103 || num100 > num104 || num101 < num105 || num101 > num106)
                                                                                                                                                                                                {
                                                                                                                                                                                                    NetMessage.BootPlayer(this.whoAmI, "Cheating attempt detected: Liquid spam");
                                                                                                                                                                                                    return;
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                            if (Main.tile[num97, num98] == null)
                                                                                                                                                                                            {
                                                                                                                                                                                                Main.tile[num97, num98] = new Tile();
                                                                                                                                                                                            }
                                                                                                                                                                                            lock (Main.tile[num97, num98])
                                                                                                                                                                                            {
                                                                                                                                                                                                Main.tile[num97, num98].liquid = liquid;
                                                                                                                                                                                                Main.tile[num97, num98].liquidType((int) liquidType3);
                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                {
                                                                                                                                                                                                    WorldGen.SquareTileFrame(num97, num98, true);
                                                                                                                                                                                                }
                                                                                                                                                                                                return;
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                        if (b == 49)
                                                                                                                                                                                        {
                                                                                                                                                                                            if (Netplay.clientSock.state == 6 || Main.autoChoose)
                                                                                                                                                                                            {
                                                                                                                                                                                                Netplay.clientSock.state = 10;
                                                                                                                                                                                                Main.player[Main.myPlayer].FindSpawn();
                                                                                                                                                                                                Main.player[Main.myPlayer].Spawn();
                                                                                                                                                                                                return;
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            if (b == 50)
                                                                                                                                                                                            {
                                                                                                                                                                                                int num107 = (int) this.readBuffer[num];
                                                                                                                                                                                                num
                                                                                                                                                                                                    ++;
                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                {
                                                                                                                                                                                                    num107 = this.whoAmI;
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (num107 == Main.myPlayer && !Main.ServerSideCharacter)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        return;
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                                for (int num108 = 0; num108 < 10; num108
                                                                                                                                                                                                    ++)
                                                                                                                                                                                                {
                                                                                                                                                                                                    int bufftype = (int) this.readBuffer[num];
                                                                                                                                                                                                    num
                                                                                                                                                                                                        ++;
                                                                                                                                                                                                    int bufftime = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                    int owner = (int) this.readBuffer[num];
                                                                                                                                                                                                    num
                                                                                                                                                                                                        ++;
                                                                                                                                                                                                    if (owner == byte.MaxValue) owner = -99;
                                                                                                                                                                                                    Main.player[num107].buffs[num108].setDefaults(bufftype, bufftime, owner);
                                                                                                                                                                                                    if (Main.player[num107].buffs[num108].type > 0 && Main.player[num107].buffs[num108].time <= 0)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        Main.player[num107].DelBuff(num108);
                                                                                                                                                                                                        //Main.player[num107].buffTime[num108] = 60;
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                    {
                                                                                                                                                                                                        //Main.player[num107].buffs[num108].time = 0;
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                {
                                                                                                                                                                                                    NetMessage.SendData(50, -1, this.whoAmI, "", num107, 0f, 0f, 0f, 0);
                                                                                                                                                                                                    return;
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                if (b == 51)
                                                                                                                                                                                                {
                                                                                                                                                                                                    byte b36 = this.readBuffer[num];
                                                                                                                                                                                                    num
                                                                                                                                                                                                        ++;
                                                                                                                                                                                                    byte b37 = this.readBuffer[num];
                                                                                                                                                                                                    if (b37 == 1)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        NPC.SpawnSkeletron();
                                                                                                                                                                                                        return;
                                                                                                                                                                                                    }
                                                                                                                                                                                                    if (b37 == 2)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (Main.netMode != 2)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            Main.PlaySound(2, (int) Main.player[(int) b36].position.X, (int) Main.player[(int) b36].position.Y, 1);
                                                                                                                                                                                                            return;
                                                                                                                                                                                                        }
                                                                                                                                                                                                        if (Main.netMode == 2)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            NetMessage.SendData(51, -1, this.whoAmI, "", (int) b36, (float) b37, 0f, 0f, 0);
                                                                                                                                                                                                            return;
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (b == 52)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        byte number = this.readBuffer[num];
                                                                                                                                                                                                        num
                                                                                                                                                                                                            ++;
                                                                                                                                                                                                        byte b38 = this.readBuffer[num];
                                                                                                                                                                                                        num
                                                                                                                                                                                                            ++;
                                                                                                                                                                                                        int num109 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                        num += 4;
                                                                                                                                                                                                        int num110 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                        num += 4;
                                                                                                                                                                                                        if (b38 == 1)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            Chest.Unlock(num109, num110);
                                                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                NetMessage.SendData(52, -1, this.whoAmI, "", (int) number, (float) b38, (float) num109, (float) num110, 0);
                                                                                                                                                                                                                NetMessage.SendTileSquare(-1, num109, num110, 2);
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                        if (b38 == 2)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            WorldGen.UnlockDoor(num109, num110);
                                                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                NetMessage.SendData(52, -1, this.whoAmI, "", (int) number, (float) b38, (float) num109, (float) num110, 0);
                                                                                                                                                                                                                NetMessage.SendTileSquare(-1, num109, num110, 2);
                                                                                                                                                                                                                return;
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (b == 53)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            short npc = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                            num += 2;
                                                                                                                                                                                                            byte type = this.readBuffer[num];
                                                                                                                                                                                                            num++;
                                                                                                                                                                                                            short time = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                            num += 2;
                                                                                                                                                                                                            byte owner = this.readBuffer[num];
                                                                                                                                                                                                            num++;
                                                                                                                                                                                                            Main.npc[(int) npc].AddBuff((int) type, (int) time, true, owner);
                                                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                //NetMessage.SendData(54, -1, -1, "", (int)num111, 0f, 0f, 0f, 0);
                                                                                                                                                                                                                NetMessage.SendData(53, -1, -1, "", (int) npc, (int) type, (int) time, (int) owner);
                                                                                                                                                                                                                return;
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (b == 54)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (Main.netMode == 1)
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    byte num112 = this.readBuffer[num];
                                                                                                                                                                                                                    num
                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                    for (int num113 = 0; num113 < 10; num113
                                                                                                                                                                                                                        ++)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        int bufftype = (int) this.readBuffer[num];
                                                                                                                                                                                                                        num
                                                                                                                                                                                                                            ++;
                                                                                                                                                                                                                        int bufftime = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                        num += 4;
                                                                                                                                                                                                                        int owner = (int) this.readBuffer[num];
                                                                                                                                                                                                                        num
                                                                                                                                                                                                                            ++;
                                                                                                                                                                                                                        if (owner == byte.MaxValue) owner = -99;
                                                                                                                                                                                                                        if (bufftype > 0 && bufftime > 0) Main.npc[num112].buffs[num113].setDefaults(bufftype, bufftime, owner);
                                                                                                                                                                                                                        if (Main.npc[num112].buffs[num113].time <= 0)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            Main.npc[num112].DelBuff(num113, true);
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (b == 55)
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    byte b39 = this.readBuffer[num];
                                                                                                                                                                                                                    num
                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                    byte b40 = this.readBuffer[num];
                                                                                                                                                                                                                    num
                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                    byte b41 = this.readBuffer[num];
                                                                                                                                                                                                                    num
                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                    short num114 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                    num += 2;
                                                                                                                                                                                                                    //if (Main.netMode == 2 && (int)b39 != this.whoAmI && !Main.pvpBuff[(int)b40])
                                                                                                                                                                                                                    //{
                                                                                                                                                                                                                    //    return;
                                                                                                                                                                                                                    //}
                                                                                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                                                                                        // && (int)b39 == Main.myPlayer)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        Main.player[(int) b39].AddBuff((int) b40, (int) num114, true, b41);
                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        NetMessage.SendData(55, -1
                                                                                                                                                                                                                            /*(int)b39*/, this.whoAmI, "", (int) b39, (float) b40, (float) num114, (float) b41, 0);
                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (b == 56)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (Main.netMode == 1)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            short num115 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                            num += 2;
                                                                                                                                                                                                                            string string8 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                                                                            Main.chrName[(int) num115] = string8;
                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (b == 57)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            if (Main.netMode == 1)
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                WorldGen.tGood = this.readBuffer[num];
                                                                                                                                                                                                                                num
                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                WorldGen.tEvil = this.readBuffer[num];
                                                                                                                                                                                                                                return;
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            if (b == 58)
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                byte b41 = this.readBuffer[num];
                                                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    b41 = (byte) this.whoAmI;
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                num
                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                float num116 = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                                                                                num += 4;
                                                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    NetMessage.SendData(58, -1, this.whoAmI, "", this.whoAmI, num116, 0f, 0f, 0);
                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                Main.harpNote = num116;
                                                                                                                                                                                                                                int style9 = 26;
                                                                                                                                                                                                                                if (Main.player[(int) b41].inventory[Main.player[(int) b41].selectedItem].type == 507)
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    style9 = 35;
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                Main.PlaySound(2, (int) Main.player[(int) b41].position.X, (int) Main.player[(int) b41].position.Y, style9);
                                                                                                                                                                                                                                return;
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                if (b == 59)
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    int num117 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                    int num118 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                    WorldGen.hitSwitch(num117, num118);
                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        NetMessage.SendData(59, -1, this.whoAmI, "", num117, (float) num118, 0f, 0f, 0);
                                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    if (b == 60)
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        short num119 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                                        num += 2;
                                                                                                                                                                                                                                        short num120 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                                        num += 2;
                                                                                                                                                                                                                                        short num121 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                                        num += 2;
                                                                                                                                                                                                                                        byte b42 = this.readBuffer[num];
                                                                                                                                                                                                                                        num
                                                                                                                                                                                                                                            ++;
                                                                                                                                                                                                                                        bool homeless = false;
                                                                                                                                                                                                                                        if (b42 == 1)
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            homeless = true;
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        if (Main.netMode == 1)
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            Main.npc[(int) num119].homeless = homeless;
                                                                                                                                                                                                                                            Main.npc[(int) num119].homeTileX = (int) num120;
                                                                                                                                                                                                                                            Main.npc[(int) num119].homeTileY = (int) num121;
                                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        if (b42 == 0)
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            WorldGen.kickOut((int) num119);
                                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        WorldGen.moveRoom((int) num120, (int) num121, (int) num119);
                                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        if (b == 61)
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            int plr = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                            num += 4;
                                                                                                                                                                                                                                            int num122 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                            num += 4;
                                                                                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                if (num122 == 4 || num122 == 13 || num122 == 50 || num122 == 125 || num122 == 126 || num122 == 134 || num122 == 127 || num122 == 128 || num122 == 222 || num122 == 245 || num122 == 266)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    bool flag11 = true;
                                                                                                                                                                                                                                                    for (int num123 = 0; num123 < 200; num123
                                                                                                                                                                                                                                                        ++)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        if (Main.npc[num123].active && Main.npc[num123].type == num122)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            flag11 = false;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    if (flag11)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        NPC.SpawnOnPlayer(plr, num122);
                                                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    if (num122 < 0)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        int num124 = -1;
                                                                                                                                                                                                                                                        if (num122 == -1)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            num124 = 1;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        if (num122 == -2)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            num124 = 2;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        if (num122 == -3)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            num124 = 3;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        if (num124 > 0 && Main.invasionType == 0)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            Main.invasionDelay = 0;
                                                                                                                                                                                                                                                            //Main.StartInvasion(num124);
                                                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            if (b == 62)
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                int num125 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                num += 4;
                                                                                                                                                                                                                                                int num126 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                num += 4;
                                                                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    //num125 = this.whoAmI;
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                if (num126 == 1)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    Main.player[num125].NinjaDodge();
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                if (num126 == 2)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    Main.player[num125].ShadowDodge();
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                if (Main.netMode == 2)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    NetMessage.SendData(62, -1, this.whoAmI, "", num125, (float) num126, 0f, 0f, 0);
                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                if (b == 63)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    int num127 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                    int num128 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                    byte b43 = this.readBuffer[num];
                                                                                                                                                                                                                                                    WorldGen.paintTile(num127, num128, b43, false);
                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        NetMessage.SendData(63, -1, this.whoAmI, "", num127, (float) num128, (float) b43, 0f, 0);
                                                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    if (b == 64)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        int num129 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                        num += 4;
                                                                                                                                                                                                                                                        int num130 = BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                        num += 4;
                                                                                                                                                                                                                                                        byte b44 = this.readBuffer[num];
                                                                                                                                                                                                                                                        WorldGen.paintWall(num129, num130, b44, false);
                                                                                                                                                                                                                                                        if (Main.netMode == 2)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            NetMessage.SendData(64, -1, this.whoAmI, "", num129, (float) num130, (float) b44, 0f, 0);
                                                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        if (b == 65)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            byte b45 = this.readBuffer[num];
                                                                                                                                                                                                                                                            num
                                                                                                                                                                                                                                                                ++;
                                                                                                                                                                                                                                                            short num131 = BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                                                            if (Main.netMode == 2)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num131 = (short) this.whoAmI;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            num += 2;
                                                                                                                                                                                                                                                            Vector2 newPos;
                                                                                                                                                                                                                                                            newPos.X = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                                                                                                            num += 4;
                                                                                                                                                                                                                                                            newPos.Y = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                                                                                                            num += 4;
                                                                                                                                                                                                                                                            int num132 = 0;
                                                                                                                                                                                                                                                            int num133 = 0;
                                                                                                                                                                                                                                                            if ((b45 & 1) == 1)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num132
                                                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            if ((b45 & 2) == 2)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num132 += 2;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            if ((b45 & 4) == 4)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num133
                                                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            if ((b45 & 8) == 8)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num133
                                                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            if (num132 == 0)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                Main.player[(int) num131].Teleport(newPos, num133);
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                if (num132 == 1)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    Main.npc[(int) num131].Teleport(newPos, num133);
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            if (Main.netMode == 2 && num132 == 0)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                NetMessage.SendData(65, -1, this.whoAmI, "", 0, (float) num131, newPos.X, newPos.Y, num133);
                                                                                                                                                                                                                                                                return;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            if (b == 66)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                int num134 = (int) this.readBuffer[num];
                                                                                                                                                                                                                                                                num
                                                                                                                                                                                                                                                                    ++;
                                                                                                                                                                                                                                                                int num135 = (int) BitConverter.ToInt16(this.readBuffer, num);
                                                                                                                                                                                                                                                                num += 2;
                                                                                                                                                                                                                                                                if (num135 > 0)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    Main.player[num134].statLife += num135;
                                                                                                                                                                                                                                                                    if (Main.player[num134].statLife > Main.player[num134].statLifeMax)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.player[num134].statLife = Main.player[num134].statLifeMax;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    Main.player[num134].HealEffect(num135, false);
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        NetMessage.SendData(66, -1, this.whoAmI, "", num134, (float) num135, 0f, 0f, 0);
                                                                                                                                                                                                                                                                        return;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                if (b == 67)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 68)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 70)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int gameTime = (int) BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.gameTime = gameTime;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 71)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int money = (int) BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    byte team = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (Main.player[Main.myPlayer].team == team)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            Main.player[Main.myPlayer].money += money;
                                                                                                                                                                                                                                                                            Main.player[Main.myPlayer].totalMoney += money;
                                                                                                                                                                                                                                                                            CombatText.NewText(new Rectangle((int) Main.player[Main.myPlayer].position.X, (int) Main.player[Main.myPlayer].position.Y, Main.player[Main.myPlayer].width, Main.player[Main.myPlayer].height), Color.Yellow, string.Concat("+" + money));
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 72)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int experience = (int) BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    byte team = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (Main.player[Main.myPlayer].team == team && !Main.player[Main.myPlayer].dead && Main.player[Main.myPlayer].level < 11)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            Main.player[Main.myPlayer].experience += experience;
                                                                                                                                                                                                                                                                            CombatText.NewText(new Rectangle((int) Main.player[Main.myPlayer].position.X, (int) Main.player[Main.myPlayer].position.Y, Main.player[Main.myPlayer].width, Main.player[Main.myPlayer].height), Color.Purple, string.Concat("+" + experience));
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 73)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int whoAmI = (int) BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    byte ability = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    Main.player[whoAmI].abilities[ability] = 50;
                                                                                                                                                                                                                                                                    CombatText.NewText(new Rectangle((int) Main.player[whoAmI].position.X, (int) Main.player[whoAmI].position.Y, Main.player[whoAmI].width, Main.player[whoAmI].height), Color.Cyan, string.Concat("Ability Learned!"));
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        NetMessage.SendData(73, -1, this.whoAmI, "", whoAmI, ability);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 74)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    if (Main.netMode != 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        int jCounter = (int) BitConverter.ToInt32(this.readBuffer, num);
                                                                                                                                                                                                                                                                        Main.jCounter = jCounter;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 75)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int owner = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    for (int i = 0; i < Main.projectile.Length; i
                                                                                                                                                                                                                                                                        ++)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (Main.projectile[i].owner == owner && Main.projectile[i].flail)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            Main.projectile[i].aiStyle = 14;
                                                                                                                                                                                                                                                                            Main.projectile[i].timeLeft = 480;
                                                                                                                                                                                                                                                                            if (Main.netMode == 2) NetMessage.SendData(b, -1, this.whoAmI, "", owner);
                                                                                                                                                                                                                                                                            return;
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 76)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int player = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    int mimicPre = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    int mimicSuf = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    Main.player[player].mimicPre = mimicPre;
                                                                                                                                                                                                                                                                    Main.player[player].mimicSuf = mimicSuf;
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        NetMessage.SendData(76, -1, this.whoAmI, "", player, mimicPre, mimicSuf);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 77)
                                                                                                                                                                                                                                                                 {
                                                                                                                                                                                                                                                                    float xpos = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    float ypos = BitConverter.ToSingle(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 4;
                                                                                                                                                                                                                                                                    int state = this.readBuffer[num];
                                                                                                                                                                                                                                                                    Main.gameState = state;
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    Main.bossLevel = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    int nextBoss = BitConverter.ToInt32(this.readBuffer, num);

                                                                                                                                                                                                                                                                    switch (nextBoss)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        case NPC.KING_SLIME:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[0];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.WAVE:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[1];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.SKELETRON_PRIME:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[2];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.GOLEM:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[3];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.BRAIN_OF_CTHULHU:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[4];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.DESTROYER:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[5];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.RETINAZER:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[6];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.QUEEN_BEE:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[7];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.WALL_OF_FLESH:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[8];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                        case NPC.PLANTERA:
                                                                                                                                                                                                                                                                            Main.nextBoss = Main.BOSS_NAMES[9];
                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                                    Main.player[Main.myPlayer].Teleport(new Vector2(xpos * 16, ypos * 16), 0);
                                                                                                                                                                                                                                                                    Main.player[Main.myPlayer].SpawnX = (int)xpos;
                                                                                                                                                                                                                                                                    Main.player[Main.myPlayer].SpawnY = (int)ypos;
                                                                                                                                                                                                                                                                    Main.player[Main.myPlayer].bossDamageAP = 0;
                                                                                                                                                                                                                                                                    Main.player[Main.myPlayer].bossDamage = 0;
                                                                                                                                                                                                                                                                    if (state == 0)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].bossPayout();
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    if (state == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].damageMult = 1.0f;
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].lastHitMult = 1.0f;
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].hurtMult = 2.0f;
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].PKMult = 1.0f;
                                                                                                                                                                                                                                                                        Main.player[Main.myPlayer].bonusMult = 1.0f;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 78)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    Main.wave_minions[0] = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    Main.wave_minions[1] = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    Main.wave_minions[2] = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 79)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    byte whoAmi = (byte)NetMessage.buffer[this.readBuffer[num]].whoAmI;
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    Main.player[whoAmi].lastHitMult = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 8;
                                                                                                                                                                                                                                                                    Main.player[whoAmi].damageMult = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 8;
                                                                                                                                                                                                                                                                    Main.player[whoAmi].hurtMult = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 8;
                                                                                                                                                                                                                                                                    Main.player[whoAmi].PKMult = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                    num += 8;

                                                                                                                                                                                                                                                                    double totalMult = (1 + (Main.player[whoAmi].lastHitMult - 1) + 
                                                                                                                                                                                                                                                                                            (Main.player[whoAmi].damageMult  - 1) +
                                                                                                                                                                                                                                                                                            (Main.player[whoAmi].hurtMult    - 1) +
                                                                                                                                                                                                                                                                                            (Main.player[whoAmi].PKMult      - 1) );
                                                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (Main.player[whoAmi].team == 1) Main.whitePoints += totalMult;
                                                                                                                                                                                                                                                                        else if (Main.player[whoAmi].team == 2) Main.blackPoints += totalMult;
                                                                                                                                                                                                                                                                        NetMessage.SendData(79, -1, -1, "", whoAmi);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.whitePoints = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                        num += 8;
                                                                                                                                                                                                                                                                        Main.blackPoints = BitConverter.ToDouble(this.readBuffer, num);
                                                                                                                                                                                                                                                                        num += 8;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 100 && Main.netMode == 2)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int newState = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    Netplay.serverSock[this.whoAmI].state = newState;
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 101)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    int hero = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    int team = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num++;
                                                                                                                                                                                                                                                                    String nickName = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                                                                                                                    if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (team == Main.loadPlayer[Main.numLoadPlayers].team)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            for (int i = 0; i < Main.maxAlliedPlayers; i
                                                                                                                                                                                                                                                                                ++)
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                if (!Main.alliedPlayers[i].active || Main.alliedPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    if (!Main.alliedPlayers[i].active)
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        Main.alliedPlayers[i].active = true;
                                                                                                                                                                                                                                                                                        Main.alliedPlayers[i].nickName = nickName;
                                                                                                                                                                                                                                                                                        NetMessage.SendData(101, -1, -1, Main.nickName, Main.loadPlayer[Main.numLoadPlayers].hero, Main.loadPlayer[Main.numLoadPlayers].team);
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    switch (hero)
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        case Main.JUGGERNAUT:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 16;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(220, 0, 95);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(220, 70, 95);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(170, 0, 60);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(170, 0, 60);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(125, 0, 40);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.SOUL_EATER:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 3;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(255, 50, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(255, 200, 200);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(255, 200, 200);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(255, 0, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.DRAGOON:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 18;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(200, 200, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(150, 125, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(255, 0, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.CELESTIAL_BEING:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 28;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.MECH:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 15;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.AEGIS:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 2;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(255, 200, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(0, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(0, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(150, 255, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(0, 75, 75);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.CLOAK:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 4;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.PYRO:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 31;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(255, 80, 80);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(255, 75, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(150, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.ZELSE:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 20;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(200, 150, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(175, 125, 90);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(100, 100, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(100, 0, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(100, 0, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(150, 0, 255);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.MARLBORO:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 23;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.EDGAR:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = 14;
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(170, 140, 140);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(100, 100, 100);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(20, 20, 20);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(20, 20, 20);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(160, 105, 60);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        case Main.MIMIC:
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hair = Main.rand.Next(Main.maxHair);
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].hairColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].skinColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shirtColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].underShirtColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].pantsColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].shoeColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            Main.alliedPlayers[i].eyeColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                        default:
                                                                                                                                                                                                                                                                                            break;
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    break;
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            for (int i = 0; i < Main.maxAlliedPlayers; i
                                                                                                                                                                                                                                                                                ++)
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                if (!Main.enemyPlayers[i].active || Main.enemyPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    if (!Main.enemyPlayers[i].active)
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].active = true;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].nickName = nickName;
                                                                                                                                                                                                                                                                                        NetMessage.SendData(101, -1, -1, Main.nickName, Main.loadPlayer[Main.numLoadPlayers].hero, Main.loadPlayer[Main.numLoadPlayers].team);
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    Main.enemyPlayers[i].hero = hero;
                                                                                                                                                                                                                                                                                    break;
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        NetMessage.SendData(101, -1, this.whoAmI, nickName, hero, team);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 102)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    String nickName = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Main.netPlayersReady
                                                                                                                                                                                                                                                                            ++;
                                                                                                                                                                                                                                                                        if (Main.netPlayersReady >= Main.maxNetPlayers && Main.gameTime < -3600)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            Main.gameTime = -3600;
                                                                                                                                                                                                                                                                            NetMessage.SendData(70, -1, this.whoAmI, "", Main.gameTime);
                                                                                                                                                                                                                                                                            //NetMessage.SendData(49, this.whoAmI);
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        NetMessage.SendData(102, -1, this.whoAmI, nickName);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        for (int i = 0; i < Main.maxAlliedPlayers; i
                                                                                                                                                                                                                                                                            ++)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            if (Main.alliedPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                Main.alliedPlayers[i].nickName = Main.alliedPlayers[i].nickName + " (Ready!)";
                                                                                                                                                                                                                                                                                return;
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        for (int i = 0; i < Main.maxAlliedPlayers; i
                                                                                                                                                                                                                                                                            ++)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            if (Main.enemyPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                Main.enemyPlayers[i].nickName = Main.enemyPlayers[i].nickName + " (Ready!)";
                                                                                                                                                                                                                                                                                switch (Main.enemyPlayers[i].hero)
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    case Main.JUGGERNAUT:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 16;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(220, 0, 95);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(220, 70, 95);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(170, 0, 60);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(170, 0, 60);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(125, 0, 40);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.SOUL_EATER:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 3;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(255, 50, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(255, 200, 200);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(255, 200, 200);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(255, 50, 40);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(255, 0, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.DRAGOON:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 18;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(200, 200, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(150, 125, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(0, 100, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(255, 0, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.CELESTIAL_BEING:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 28;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.MECH:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 15;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(150, 150, 150);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.AEGIS:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 2;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(255, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(255, 200, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(0, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(0, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(150, 255, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(0, 75, 75);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.CLOAK:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 4;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.PYRO:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 31;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(255, 80, 80);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(255, 75, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(150, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(255, 0, 0);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.ZELSE:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 20;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(200, 150, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(175, 125, 90);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(100, 100, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(100, 0, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(100, 0, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(150, 0, 255);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(0, 0, 255);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.MARLBORO:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 23;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(125, 160, 55);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.EDGAR:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = 14;
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(50, 50, 50);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(170, 140, 140);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(100, 100, 100);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(20, 20, 20);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(20, 20, 20);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(160, 105, 60);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(0, 0, 0);
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    case Main.MIMIC:
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hair = Main.rand.Next(Main.maxHair);
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].hairColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].skinColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shirtColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].underShirtColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].pantsColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].shoeColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        Main.enemyPlayers[i].eyeColor = new Color(Main.rand.Next(255), Main.rand.Next(255), Main.rand.Next(255));
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                    default:
                                                                                                                                                                                                                                                                                        break;
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    return;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                if (b == 103)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    byte lockedIn = this.readBuffer[num];
                                                                                                                                                                                                                                                                    num
                                                                                                                                                                                                                                                                        ++;
                                                                                                                                                                                                                                                                    String nickName = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
                                                                                                                                                                                                                                                                    if (Main.netMode == 2)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (lockedIn == 1)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            Main.netPlayersReady
                                                                                                                                                                                                                                                                                --;
                                                                                                                                                                                                                                                                            nickName += " (Ready!)";
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        NetMessage.SendData(103, -1, this.whoAmI, nickName, lockedIn);
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else if (Main.netMode == 1)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        for (int i = 0; i < Main.maxNetPlayers; i
                                                                                                                                                                                                                                                                            ++)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            if (Main.alliedPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                Main.alliedPlayers[i].active = false;
                                                                                                                                                                                                                                                                                Main.alliedPlayers[i] = new Player();
                                                                                                                                                                                                                                                                                break;
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                            if (Main.enemyPlayers[i].nickName.Equals(nickName))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                Main.enemyPlayers[i].active = false;
                                                                                                                                                                                                                                                                                Main.enemyPlayers[i] = new Player();
                                                                                                                                                                                                                                                                                break;
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