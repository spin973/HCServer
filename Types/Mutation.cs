namespace HCServer.Types;

[MutationType]
public static class Mutation
{
    [Error<UnknownUserError>]
    public static MutationResult<bool> GetUser(int userId)
    {
        if (userId == 0)
        {
            return new(new UnknownUserError("Stefano"));
        }

        return true;
    }
}

public record UnknownUserError(string Name)
{
    public string Message => $"User {Name} not found";

    //public UnknownUserError(Exception ex) : this(ex.Message) { }
}