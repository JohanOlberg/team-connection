public class CreateOperationalUpdate
{
    private readonly IOperationalUpdateRepository _repository;

    public CreateOperationalUpdate(
        IOperationalUpdateRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(CreateOperationalUpdateDto input)
    {
        var entity = new OperationalUpdate(
            input.Title,
            input.Description,
            input.Content,
            input.Area,
            input.Author,
            input.Group
        );

        await _repository.AddAsync(entity);
    }
}