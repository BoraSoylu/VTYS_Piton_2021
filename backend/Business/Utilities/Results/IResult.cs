using System;

namespace Business.Utilities.Results
{
    public interface IResult
    {
        public bool Success { get; }
        public string InfoMessage { get; set; }
    }
}
