using Dependency_Injection_WebApi.Interface;
using System.Reflection.Metadata.Ecma335;

namespace Dependency_Injection_WebApi.DAL
{
    public class Employee : IEmployee
    {
        Guid id;
        public Employee()
        {
            id= Guid.NewGuid();
        }
        public Guid GenerateGuid()
        {
           return id;
        }
        public List<string> GetEmploeeList()
        {
            List<string> objList = new List<string>();
            objList.Add("Vinay");
            objList.Add("Rintu");
            objList.Add("Ravula");
            
            return objList;
        }       
    }
}
