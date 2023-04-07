namespace BuildingBlocks.Core.Utils
{
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public string Error { get; }

        protected Result(bool isSuccess, string error)
        {
            if (isSuccess && !string.IsNullOrWhiteSpace(error))
                throw new InvalidOperationException("A successful result cannot contain an error message.");

            if (!isSuccess && string.IsNullOrWhiteSpace(error))
                throw new InvalidOperationException("A failed result must contain an error message.");

            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success() => new Result(true, null);

        public static Result Success(string message) => new Result(true, message);

        public static Result Failure(string error) => new Result(false, error); 
    }
}
