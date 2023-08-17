namespace OperationResult;

public class Result<T> : IResult
{
    private readonly T _value;
    private readonly bool _isSuccess;
    private readonly string _errorMessage;

    public T Value => _value;
    public bool IsSuccess => _isSuccess;
    public string ErrorMessage => _errorMessage;

    private Result(bool isSuccess, string errorMessage, T value = default)
    {
        _isSuccess = isSuccess;
        _errorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
        _value = value;
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(true, null, value);
    }

    public static Result<T> Error(string errorMessage)
    {
        return new Result<T>(false, errorMessage);
    }
}
