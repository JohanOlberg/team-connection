public class ChangeStatusOperationalUpdate
{
    private readonly IOperationalUpdateRepository _repository;

    public ChangeStatusOperationalUpdate(
        IOperationalUpdateRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(int id, ChangeStatusOperationalUpdateDto input)
    {
        var entity = await _repository.GetByIdAsync(id) 
        ?? throw new InvalidOperationException(
                "OperationalUpdate not found.");
        entity.ChangeStatus(input.Status);
        await _repository.UpdateAsync(entity);
    }
}