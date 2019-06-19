using System;
using System.Collections.Generic;

namespace Salesforce.MarketingCloud.Client
{
    public static class RuntimeInformationProvider
    {
        static RuntimeInformationProvider()
        {
            ClientEnvironmentRuntimeInformation = new Dictionary<string, string>();
            try
            {
                ClientEnvironmentRuntimeInformation.Add("Framework-Description", System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
                ClientEnvironmentRuntimeInformation.Add("OS-Description", System.Runtime.InteropServices.RuntimeInformation.OSDescription);
                ClientEnvironmentRuntimeInformation.Add("OS-Architecture", System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static Dictionary<string, string> ClientEnvironmentRuntimeInformation { get; }
    }
}