namespace GettingStartedApp.Exceptions;

class NotFoundException : Exception
{
    private readonly string entityName;

    public NotFoundException(string entityName)
    {
        this.entityName = entityName;
    }

    public override string Message => $"Entity '{this.entityName}' not found!";
}