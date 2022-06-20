using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Employee;

public class CoachService : EmployeeService
{
    public CoachService(IHttpService httpService) : base(httpService)
    {
    }
    
    public override async Task<IList<Gaby.Shared.Model.Employee>> GetEmployees(string? name)
    {
        return await _httpService.Get<IList<Gaby.Shared.Model.Employee>>("api/coach" + "?name=" + name);
    }

    public async Task AddEmployee(Coach coach)
    {
        await _httpService.Post($"api/coach", coach);
    }

    public async Task UpdateEmployee(Coach coach)
    {
        await _httpService.Put($"api/coach", coach);
    }
}