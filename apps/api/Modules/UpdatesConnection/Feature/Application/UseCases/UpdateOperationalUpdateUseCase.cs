public class UpdateOperationalUpdate
{
    private readonly IOperationalUpdateRepository _repository;

    public UpdateOperationalUpdate(
        IOperationalUpdateRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(int id, UpdateOperationalUpdateDto input)
    {
        var entity = await _repository.GetByIdAsync(id) 
        ?? throw new InvalidOperationException(
                "OperationalUpdate not found.");
        entity.Update(
        input.Title,
        input.Description,
        input.Content,
        input.Area,
        input.Author,
        input.Group
    );
        await _repository.UpdateAsync(entity);
    }
}