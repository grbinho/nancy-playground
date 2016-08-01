

namespace NancyApplication
{
    public class HomeModuleV2 : TenantModule
    {
        public HomeModuleV2() : base("home")
        {
            //Respond to api/{v}
            Get("/resource1", args => "Hello World, from current version.");
            Get("/resource2", args => "Hello from current version new resource.");          
        }
    }
}