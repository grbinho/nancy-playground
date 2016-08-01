using Nancy;

public abstract class TenantModule: NancyModule {
    public TenantModule(string routePart)
        :base ("api/{version?}/{tenantid}/" + routePart)
    {}

     public TenantModule()
        :base ("api/{version?}/{tenantid}")
    {}
}