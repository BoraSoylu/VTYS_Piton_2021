using System;

namespace Business.Utilities.Results
{
    public interface IDataResult<TData> : IResult
    {
        public TData Data { get; set; }
    }
}
