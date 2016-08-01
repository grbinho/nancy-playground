using Nancy;
namespace NancyApplication
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("api/{tenantid}")
        {
            //Respond to api/{v}

            //Get("/resource1", args => "Hello World, from old version");


            
        }
    }
}