namespace Twitter.Post.Application.Exceptions;

public class ValidationException : Exception
{
    public ValidationException(): base("ValidationError occurred") 
    {
        
    }

    public ValidationException(String message) : base(message)
    {
        
    }

    public ValidationException(Exception ex) : base(ex.Message)
    {
        
    }
}