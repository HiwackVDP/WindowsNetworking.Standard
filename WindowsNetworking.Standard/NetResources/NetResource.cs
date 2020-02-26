using System.Runtime.InteropServices;

namespace WindowsNetworking.NetResources
{
	[StructLayout(LayoutKind.Sequential)]
	public class NetResource
	{
		public int Scope = 0;
		public int Type = 0;
		public int DisplayType = 0;
		public int Usage = 0;
		public string LocalName = "";
		public string RemoteName = "";
		public string Comment = "";
		public string Provider = "";
	}
}
