using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using SyncfusionIssue.Client;

namespace SyncfusionIssue.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfR19mSHpSc0BrWXZceQ==;Mgo+DSMBPh8sVXJ1S0R+X1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jTHxWd0FiXHpWcXRSTw==;ORg4AjUWIQA/Gnt2VFhiQlJPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtRc0RnWHpbeHVXQmk=;MjE5OTA1M0AzMjMxMmUzMjJlMzNTTmdCWkk3NEg4RjNpTGNTVVRlYTZDMU9PZGJJSzV0ZWV4RlU3MEZXdHVRPQ==;MjE5OTA1NEAzMjMxMmUzMjJlMzNKN0V6M0ZlR0tnSVljV0tOaDFpanBES2p3OFFBdFhiWDgyYUJvNVRCVm4wPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5WdEBiXX5bdXxXR2VV;MjE5OTA1NkAzMjMxMmUzMjJlMzNHRE1YNy8yT05ETGdsdDhvcGJaWjZHZW1qMWs5d25sVUp4R3M3VEVLcTRVPQ==;MjE5OTA1N0AzMjMxMmUzMjJlMzNBcDZFNkdtTUpMcjUwaWNma0V5S1FyeUVUUXM2ZWMzRmY4OG9kUmFXM1VBPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtRc0RnWHpbeHdVRGk=;MjE5OTA1OUAzMjMxMmUzMjJlMzNsQTNsZXFJZTNIVTAzaExDOENWZEw4RWRvRXBiU3B1WjdFVnJmbXVsWlowPQ==;MjE5OTA2MEAzMjMxMmUzMjJlMzNTQ1FRYzFjbGdNenlTMVhJZzF2MHpmbll3Wk1IckEybEtFTy84eUFUZWxrPQ==;MjE5OTA2MUAzMjMxMmUzMjJlMzNHRE1YNy8yT05ETGdsdDhvcGJaWjZHZW1qMWs5d25sVUp4R3M3VEVLcTRVPQ==");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}