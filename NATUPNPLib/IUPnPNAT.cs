// Type: NATUPNPLib.IUPnPNAT
// Assembly: TerrariaServer, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 54ECDB0E-7563-4F41-B08E-770E073C5F96
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\TerrariaServer.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NATUPNPLib
{
  [Guid("B171C812-CC76-485A-94D8-B6B3A2794E99")]
  [TypeIdentifier]
  [CompilerGenerated]
  [ComImport]
  public interface IUPnPNAT
  {
    IStaticPortMappingCollection StaticPortMappingCollection { [DispId(1)] get; }
  }
}
