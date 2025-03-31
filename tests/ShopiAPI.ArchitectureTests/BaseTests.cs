using System.Reflection;

namespace ShopiAPI.ArchitectureTests;

// Abstract class to inherit Assemblies and project
public abstract class BaseTests
{
    // Namespaces
    protected const string ApplicationNamespace = "Shopi.Aplication";
    protected const string InfrastructureNamespace = "ShopiInfrastructure";
    protected const string DomainNamespace = "Shopi.Domain";
    protected const string PresentationNamespace = "Shopi.Presentation";
    protected const string WebNamespace = "Shopi.API";

    // Assembly Reference
    protected static Assembly ApplicationAssemblyReference = typeof(Shopi.Application.AssemblyReference).Assembly;
    protected static Assembly InfrastructoreAssemblyReference = typeof(Shopi.Infrastructure.AssemblyReference).Assembly;
    protected static Assembly DomainAssemblyReference = typeof(Shopi.Domain.AssemblyReference).Assembly;
}