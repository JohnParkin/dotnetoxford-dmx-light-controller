<Query Kind="Program">
  <NuGetReference>Microsoft.Azure.Management.AppService.Fluent</NuGetReference>
  <NuGetReference>Microsoft.Azure.Management.Fluent</NuGetReference>
  <NuGetReference>Microsoft.Azure.Management.ServiceBus.Fluent</NuGetReference>
  <Namespace>Microsoft.Azure.Management.AppService.Fluent</Namespace>
  <Namespace>Microsoft.Azure.Management.Fluent</Namespace>
  <Namespace>Microsoft.Azure.Management.ResourceManager.Fluent</Namespace>
  <Namespace>Microsoft.Azure.Management.ResourceManager.Fluent.Core</Namespace>
  <Namespace>Microsoft.Azure.Management.ServiceBus.Fluent</Namespace>
  <Namespace>static Microsoft.Azure.Management.Fluent.Azure</Namespace>
  <Namespace>Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions</Namespace>
</Query>

string resourceGroupName = "DNOLights";

IAzure azure = Azure.Authenticate(Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "azureauth"))
    .WithDefaultSubscription();

void Main()
{
    "Creating service bus...".Dump();
    CreateServiceBusWithQueue();
    
    "Creating resource group...".Dump();
    CreateResourceGroup(resourceGroupName);

    "Creating webapp for website...".Dump();
    var web = CreateWebApp("dnolights-web");
    
    "Creating webapp for API...".Dump();
    var api = CreateWebApp("dnolights-api", web.AppServicePlanId);
}

IResourceGroup CreateResourceGroup(string name) =>
    azure.ResourceGroups
        .Define(name)
        .WithRegion(Region.UKSouth)
        .Create();

IServiceBusNamespace CreateServiceBusWithQueue() =>
    azure.ServiceBusNamespaces
        .Define("namespacedno")
        .WithRegion(Region.UKSouth)
        .WithExistingResourceGroup(resourceGroupName)
        .WithSku(NamespaceSku.Basic)
        .WithNewQueue("TestQueue", 1024)
        .Create();

IWebApp CreateWebApp(string name) =>
    azure.WebApps.Define(name)
        .WithRegion(Region.UKSouth)
        .WithExistingResourceGroup(resourceGroupName)
        .WithNewWindowsPlan(PricingTier.FreeF1)
        .Create();

IWebApp CreateWebApp(string name, string servicePlanId) =>
    azure.WebApps.Define(name)
        .WithExistingWindowsPlan(azure.AppServices.AppServicePlans.GetById(servicePlanId))
        .WithExistingResourceGroup(resourceGroupName)
        .Create();
