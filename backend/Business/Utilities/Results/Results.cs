using System;

namespace Business.Utilities.Results
{
    public static class Results
    {
        public class Result : IResult
        {
            public Result(bool success)
            {
                Success = success;
            }
            public Result(bool success, string info) : this(success)
            {
                InfoMessage = info;
            }

            public bool Success { get; }

            public string InfoMessage { get; set; }
        }

        public class SuccessfulResult : Result
        {
            public SuccessfulResult() : base(true)
            {

            }
            public SuccessfulResult(string infoMessage) : base(true, infoMessage)
            {
                
            }
        }

        public class ErrorResult : Result
        {
            public ErrorResult() : base(false)
            {

            }
            public ErrorResult(string infoMessage) : base(false, infoMessage)
            {

            }
        }

    }
}
