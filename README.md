# WindowsNetworking

This project's intent is to encapsulate [WNet](https://docs.microsoft.com/en-us/windows/win32/api/_wnet/) functionnalities, or at list part of them.

## Currently supported WNet features

### Connect to remote with WNetUseConnection
You can either connect using username and password, or ask for an authentication prompt. This operation will create a trust connection between the host and the targeted machine.  
[Native method documentation](https://docs.microsoft.com/en-us/windows/win32/api/winnetwk/nf-winnetwk-wnetuseconnectiona)

```csharp
// With prompt
  string targetUNC = "\\RemoteComputerUNC";
  PinvokeWindowsNetworking.ConnectToRemote(targetUNC, null, null, prompUser: true)

// With credentials
  string targetUNC = "\\RemoteComputerUNC";
  string userName = "DOMAIN\Username"
  string password = "123456"
  PinvokeWindowsNetworking.ConnectToRemote(targetUNC, userName, password, prompUser: true)
```

### Disconnect from remote with WNetCancelConnection2
Closes a connection created with WNetUseConnection.  
[Native method documentation](https://docs.microsoft.com/en-us/windows/win32/api/winnetwk/nf-winnetwk-wnetcancelconnection2a)

```csharp
  string targetUNC = "\\RemoteComputerUNC";
  PinvokeWindowsNetworking.DisconnectRemote(targetUNC)
```
