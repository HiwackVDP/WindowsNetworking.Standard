using System;
using System.Runtime.InteropServices;
using WindowsNetworking.NetErrors;
using WindowsNetworking.NetResources;

namespace WindowsNetworking
{
	public static class PinvokeWindowsNetworking
	{
		public static string ConnectToRemote(string remoteUNC, string username, string password, bool promptUser)
		{
			var nr = new NetResource
			{
				Type = Types.Disk,
				RemoteName = remoteUNC
			};

			int ret;
			if (promptUser)
			{
				ret = WNetUseConnection(IntPtr.Zero, nr, "", "", ConnectionTypes.Interactive | ConnectionTypes.Prompt, null, null, null);
			}
			else
				ret = WNetUseConnection(IntPtr.Zero, nr, password, username, 0, null, null, null);

			if (ret == Errors.NoError)
				return null;

			return Errors.GetErrorForNumber(ret);
		}

		public static string DisconnectRemote(string remoteUNC)
		{
			int ret = WNetCancelConnection2(remoteUNC, 0, false);
			if (ret == Errors.NoError) return null;
			return Errors.GetErrorForNumber(ret);
		}

		[DllImport("Mpr.dll", CharSet = CharSet.Unicode)]
		private static extern int WNetUseConnection(
			IntPtr hwndOwner,
			NetResource lpNetResource,
			string lpPassword,
			string lpUserID,
			int dwFlags,
			string lpAccessName,
			string lpBufferSize,
			string lpResult
		);

		[DllImport("Mpr.dll", CharSet = CharSet.Unicode)]
		private static extern int WNetCancelConnection2(
			string name,
			int flags,
			bool force
		);
	}
}
