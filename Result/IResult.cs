namespace OperationResult;

public interface IResult
{
    string ErrorMessage { get; }
    bool IsSuccess { get; }
}
