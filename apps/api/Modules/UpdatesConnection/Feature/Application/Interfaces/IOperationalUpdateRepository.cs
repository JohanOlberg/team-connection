public interface IOperationalUpdateRepository
{
    Task<OperationalUpdate?> GetByIdAsync(int id);
    Task<IReadOnlyList<OperationalUpdate>> GetAllAsync();
    Task<IReadOnlyList<OperationalUpdate>> GetByStatusAsync(Status status);
    Task AddAsync(OperationalUpdate entity);
    Task UpdateAsync(OperationalUpdate entity);
}