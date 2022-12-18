namespace Dependency_Injection_WebApi.Interface
{
    public interface IEmployee
    {
        public List<string> GetEmploeeList();
        public Guid GenerateGuid();
    }
}
