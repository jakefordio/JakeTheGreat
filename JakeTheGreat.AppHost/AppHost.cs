var builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<KeycloakResource> keycloak = builder.AddKeycloak("keycloak", 8001)
    .WithDataVolume("keycloak_data");
builder.Build().Run();
