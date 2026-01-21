namespace AuthService.Application.Interfaces;

public interface IPasswordHashService
{
    string hashPassword(string password);
    bool verifyPassword(string password, string hashedPassword);
}