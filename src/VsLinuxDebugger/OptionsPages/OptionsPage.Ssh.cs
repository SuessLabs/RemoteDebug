using System;
using System.ComponentModel;
using System.IO;
using Microsoft.VisualStudio.Shell;

namespace Xeno.VsLinuxDebug.OptionsPages
{
  public partial class OptionsPage : DialogPage
  {
    private const string Credentials = "Remote Credentials";
    private const string XDisplay = "Remote X11 Display";

    [Category(Credentials)]
    [DisplayName("Host IP Address")]
    [Description("Host IP Address. On VMs using 'NAT', set IP to '127.0.0.1' and forward Port 22. PCs and VMs 'Bridged', have their own IP.")]
    public string HostIp { get; set; } = "127.0.0.1";

    ////[Category(Credientials)]
    ////[DisplayName("Host Port Number (22)")]
    ////[Description("Remote Host Port Number (SSH Default is 22)")]
    public int HostPort { get; set; } = 22;

    [Category(Credentials)]
    [DisplayName("User Group Name (optional)")]
    [Description("Remote Machine Group Name. For basic setups (i.e. RaspberryPI) it's the same as UserName.")]
    public string UserGroupName { get; set; } = "";

    [Category(Credentials)]
    [DisplayName("User Name")]
    [Description("SSH User name on remote machine.")]
    public string UserName { get; set; } = "pi";

    [Category(Credentials)]
    [DisplayName("User Password")]
    [Description("SSH Password on remote machine.")]
    public string UserPass { get; set; } = "raspberry";

    [Category(Credentials)]
    [DisplayName("SSH Key File Enabled")]
    [Description("Use SSH Key for connecting to remote machine.")]
    public bool UserPrivateKeyEnabled { get; set; } = false;

    [Category(Credentials)]
    [DisplayName("SSH Private Key File (optional)")]
    [Description("Private key file.")]
    public string UserPrivateKeyPath { get; set; } = Path.Combine(
      Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
      ".ssh\\id_rsa");

    [Category(Credentials)]
    [DisplayName("SSH Private Key Password (optional)")]
    [Description("Private key password (only if it was set).")]
    public string UserPrivateKeyPassword { get; set; } = "";

    [Category(Credentials)]
    [DisplayName("Use SSH.exe with integrated user/[..]/.ssh/id_rsa instead of PLINK")]
    [Description("Use SSH.exe with integrated user/[..]/.ssh/id_rsa instead of PLINK")]
    public bool UseSSHExeEnabled { get; set; } = true;

    /*[Category(Credientials)]
    [DisplayName("PLINK PPK Key File Enabled")]
    [Description("Use SSH Key for connecting to remote machine.")]
    public bool UserPlinkPrivateKeyEnabled { get; set; } = false;

    [Category(Credientials)]
    [DisplayName("SSH Private Key File (optional)")]
    [Description("Private key file.")]
    public string UserPlinkPrivateKeyPath { get; set; } = Path.Combine(
      Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
      ".ssh\\id_rsa");
    */

    [Category(XDisplay)]
    [DisplayName("Remote X11 Display Number (optional)")]
    [Description("Remote X11 Display number (only if it was set). Defaults to ':0'.")]
    public string RemoteDebugDisplayNumber { get; set; } = ":0";
  }
}
