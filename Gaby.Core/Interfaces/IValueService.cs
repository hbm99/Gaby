using Gaby.Core.Model;

namespace Gaby.Core.Interfaces
{
    public interface IValueService
    {
        Task<Value> GetAValue(int id);
    }
}
