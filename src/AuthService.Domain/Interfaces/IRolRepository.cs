using AuthService.Domain.Entities;

namespace AuthService.Domain.Interfaces;

public interface IRolRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUserInRoleAsync(string roleName);
    Task<IReadOnlyList<Role>> GetUserByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNamesAsync(string userId);
    
}