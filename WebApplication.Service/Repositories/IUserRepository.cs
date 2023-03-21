namespace WebApplication1.Service.Repositories
{
    public interface IUserRepository
    {
        bool ValidateLastChanged(string lastChanged);
    }
}