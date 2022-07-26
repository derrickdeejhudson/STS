// Type: Terraria.ProgramServer
// Assembly: TerrariaServer, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 54ECDB0E-7563-4F41-B08E-770E073C5F96
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\TerrariaServer.exe

using System;
using System.Diagnostics;

namespace Terraria
{
  internal class ProgramServer
  {
    private static Main Game;

    private static void Main(string[] args)
    {
      Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
      ProgramServer.Game = new Main();
      for (int index = 0; index < args.Length; ++index)
      {
        if (args[index].ToLower() == "-config")
        {
          ++index;
          ProgramServer.Game.LoadDedConfig(args[index]);
        }
        if (args[index].ToLower() == "-port")
        {
          ++index;
          try
          {
            Netplay.serverPort = Convert.ToInt32(args[index]);
          }
          catch
          {
          }
        }
        if (args[index].ToLower() == "-players" || args[index].ToLower() == "-maxplayers")
        {
          ++index;
          try
          {
            int mPlayers = Convert.ToInt32(args[index]);
            ProgramServer.Game.SetNetPlayers(mPlayers);
          }
          catch
          {
          }
        }
        if (args[index].ToLower() == "-pass" || args[index].ToLower() == "-password")
        {
          ++index;
          Netplay.password = args[index];
        }
        if (args[index].ToLower() == "-lang")
        {
          ++index;
          Lang.lang = Convert.ToInt32(args[index]);
        }
        if (args[index].ToLower() == "-world")
        {
          ++index;
          ProgramServer.Game.SetWorld(args[index]);
        }
        if (args[index].ToLower() == "-worldname")
        {
          ++index;
          ProgramServer.Game.SetWorldName(args[index]);
        }
        if (args[index].ToLower() == "-motd")
        {
          ++index;
          ProgramServer.Game.NewMOTD(args[index]);
        }
        if (args[index].ToLower() == "-banlist")
        {
          ++index;
          Netplay.banFile = args[index];
        }
        if (args[index].ToLower() == "-autoshutdown")
          ProgramServer.Game.autoShut();
        if (args[index].ToLower() == "-secure")
          Netplay.spamCheck = true;
        if (args[index].ToLower() == "-autocreate")
        {
          ++index;
          string newOpt = args[index];
          ProgramServer.Game.autoCreate(newOpt);
        }
        if (args[index].ToLower() == "-loadlib")
        {
          ++index;
          string path = args[index];
          ProgramServer.Game.loadLib(path);
        }
        if (args[index].ToLower() == "-noupnp")
          Netplay.uPNP = false;
      }
      ProgramServer.Game.DedServ();
    }
  }
}
