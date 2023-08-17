namespace OperationResult;

public class Result : IResult
{
    private readonly bool _isSuccess;
    private readonly string _errorMessage;

    public bool IsSuccess => _isSuccess;
    public string ErrorMessage => _errorMessage;

    private Result(bool isSuccess, string errorMessage)
    {
        _isSuccess = isSuccess;
        _errorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
    }

    public static Result Success()
    {
        return new Result(true, string.Empty);
    }

    public static Result Error(string errorMessage)
    {
        if (string.IsNullOrEmpty(errorMessage))
            throw new ArgumentException("Error message should not be null or empty.", nameof(errorMessage));

        return new Result(false, errorMessage);
    }
}

