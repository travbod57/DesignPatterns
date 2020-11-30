using System.Collections.Generic;

namespace Adapter
{
    // the interface needed to adhere to in the current system
    public interface ITarget
    {
        List<Employee> GetEmployees();
    }
}