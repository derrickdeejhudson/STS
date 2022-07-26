using System;
using System.IO;
using System.Windows.Forms;

namespace Terraria
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (Main main = new Main())
            {
                try
                {
                    for (int index = 0; index < args.Length; ++index)
                    {
                        if (args[index].ToLower() == "-port" || args[index].ToLower() == "-p")
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
                        if (args[index].ToLower() == "-join" || args[index].ToLower() == "-j")
                        {
                            ++index;
                            try
                            {
                                main.AutoJoin(args[index]);
                            }
                            catch
                            {
                            }
                        }
                        if (args[index].ToLower() == "-pass" || args[index].ToLower() == "-password")
                        {
                            ++index;
                            Netplay.password = args[index];
                            main.AutoPass();
                        }
                        if (args[index].ToLower() == "-host") main.AutoHost();
                        if (args[index].ToLower() == "-loadlib")
                        {
                            ++index;
                            string path = args[index];
                            main.loadLib(path);
                        }
                    }
                    //Steam.Init();
                    //if (!Steam.SteamInit) // ! = false, so If Steam is not initialized, then start game. Meaning you don't have to run it through steam.
                    //{                     //If you want to change it back to normal, uncomment everything here, and remove the '!' in the line above.
                    main.Run();
                    //}
                    //else
                    //{
                    //  int num = (int) MessageBox.Show("Please launch the game from your Steam client.", "Error");
                    //}
                }
                catch (Exception ex)
                {
                    try
                    {
                        using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
                        {
                            streamWriter.WriteLine(DateTime.Now);
                            streamWriter.WriteLine(ex);
                            streamWriter.WriteLine("/n");
                        }
                        int num = (int) MessageBox.Show((ex).ToString(), "Terraria: Error");
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}