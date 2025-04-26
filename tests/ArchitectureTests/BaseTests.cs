using System.Reflection;

namespace ShopiAPI.ArchitectureTests;

// Abstract class to inherit Assemblies and project
public abstract class BaseTests
{
    // Namespaces
    protected const string ApplicationNamespace = "Shopi.Aplication";
    protected const string InfrastructureNamespace = "ShopiInfrastructure";
    protected const string DomainNamespace = "Domain";
    protected const string PresentationNamespace = "Shopi.Presentation";
    protected const string WebNamespace = "Web.API";

    // Assembly Reference
    protected static Assembly ApplicationAssemblyReference = typeof(Application.AssemblyReference).Assembly;
    protected static Assembly InfrastructoreAssemblyReference = typeof(Infrastructure.AssemblyReference).Assembly;
    protected static Assembly DomainAssemblyReference = typeof(Domain.AssemblyReference).Assembly;
}