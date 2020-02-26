namespace WindowsNetworking
{
	public static class ConnectionTypes
    {
		public const int Interactive = 0x00000008;
		public const int Prompt = 0x00000010;
		public const int Redirect = 0x00000080;
		public const int UpdateProfile = 0x00000001;
		public const int Commandline = 0x00000800;
		public const int CmdSaveCred = 0x00001000;
		public const int LocalDrive = 0x00000100;
	}
}
