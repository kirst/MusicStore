namespace E2ETests
{
    public class RemoteDeploymentConfig
    {
        /// <summary>
        /// Name or IP address of the server to deploy to
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Account name for the credentials required to setup a powershell session to the target server
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Account password for the credentials required to setup a powershell session to the target server
        /// </summary>
        public string AccountPassword { get; set; }

        /// <summary>
        /// The file share on the target server to copy the files to
        /// </summary>
        public string FileSharePath { get; set; }

        /// <summary>
        /// Location of the dotnet runtime zip file which is later copied to the target file share and unzipped over
        /// there
        /// </summary>
        public string DotnetRuntimeZipPath { get; set; }
    }
}
