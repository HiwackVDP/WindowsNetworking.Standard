namespace WindowsNetworking.NetErrors
{
	public static class Errors
	{
		public const int NoError = 0;

		private const int AccessDenied = 5;
		private const int AlreadyAssigned = 85;
		private const int BadDevice = 1200;
		private const int BadNetName = 67;
		private const int BadProvider = 1204;
		private const int Cancelled = 1223;
		private const int ExtendedError = 1208;
		private const int InvalidAddress = 487;
		private const int InvalidParameter = 87;
		private const int InvalidPassword = 1216;
		private const int MoreData = 234;
		private const int NoMoreItems = 259;
		private const int NoNetOrBadPath = 1203;
		private const int NoNetwork = 1222;
		 
		private const int BadProfile = 1206;
		private const int CannotOpenProfile = 1205;
		private const int DeviceInUse = 2404;
		private const int NotConnected = 2250;
		private const int OpenFiles = 2401;
		private const int MultipleUserConnections = 1219;

		private static readonly ErrorClass[] ErrorList = new ErrorClass[] {
			new ErrorClass(AccessDenied, "Error: Access Denied"),
			new ErrorClass(AlreadyAssigned, "Error: Already Assigned"),
			new ErrorClass(BadDevice, "Error: Bad Device"),
			new ErrorClass(BadNetName, "Error: Bad Net Name"),
			new ErrorClass(BadProvider, "Error: Bad Provider"),
			new ErrorClass(Cancelled, "Error: Cancelled"),
			new ErrorClass(ExtendedError, "Error: Extended Error"),
			new ErrorClass(InvalidAddress, "Error: Invalid Address"),
			new ErrorClass(InvalidParameter, "Error: Invalid Parameter"),
			new ErrorClass(InvalidPassword, "Error: Invalid Password"),
			new ErrorClass(MoreData, "Error: More Data"),
			new ErrorClass(NoMoreItems, "Error: No More Items"),
			new ErrorClass(NoNetOrBadPath, "Error: No Net Or Bad Path"),
			new ErrorClass(NoNetwork, "Error: No Network"),
			new ErrorClass(BadProfile, "Error: Bad Profile"),
			new ErrorClass(CannotOpenProfile, "Error: Cannot Open Profile"),
			new ErrorClass(DeviceInUse, "Error: Device In Use"),
			new ErrorClass(NotConnected, "Error: Not Connected"),
			new ErrorClass(OpenFiles, "Error: Open Files"),
			new ErrorClass(MultipleUserConnections, "Error: Multiple User Connections"),
		};

		public static string GetErrorForNumber(int errNum)
		{
			foreach (ErrorClass er in ErrorList)
			{
				if (er.num == errNum) return er.message;
			}
			return "Error: Unknown, " + errNum;
		}
	}
}