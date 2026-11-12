public class OperationalUpdate
{
    public int Id {get; private set;}
    public  string Title {get; private set;}
    public  string Description {get; private set;}
    public  string Content {get; private set;}
    public  DateTimeOffset CreatedAt {get; private set;}
    public  string Area {get; private set;}
    public  string Author {get; private set;}
    public  string Group {get; private set;}
    public Status Status {get; private set;} = Status.Pending;
    public DateTimeOffset UpdatedAt {get; private set;}

    public OperationalUpdate(
        string title, 
        string description, 
        string content, 
        string area, 
        string author, 
        string group)
    {
        Title = StringValidation(title, 10, 50);
        Description = StringValidation(description, 50, 120);
        Content = StringValidation(content,50, 1000);
        CreatedAt = DateTimeOffset.UtcNow;
        Area = StringValidation(area, 1, 30);
        Author = StringValidation(author, 1, 100);
        Group = StringValidation(group, 1, 50);
    }

public void Update(
    string title,
    string description,
    string content,
    string area,
    string author,
    string group)
{
    Title = StringValidation(title, 10, 50);
    Description = StringValidation(title, 50, 120);
    Content = StringValidation(title, 50, 1000);
    Area = StringValidation(title, 1, 30);
    Author = StringValidation(title, 1, 100);
    Group = StringValidation(title, 1, 50);
    UpdatedAt = DateTimeOffset.UtcNow;
}
public void ChangeStatus(Status status)
{
    Status = status;
    UpdatedAt = DateTimeOffset.UtcNow;
}
private static string StringValidation(
    string value,
    int minLength,
    int maxLength)
{
    if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Value cannot be empty.");

    value = value.Trim();

    if (value.Length < minLength)
        throw new ArgumentException($"Minimum length is {minLength}.");

    if (value.Length > maxLength)
        throw new ArgumentException($"Maximum length is {maxLength}.");

    return value;
}


}