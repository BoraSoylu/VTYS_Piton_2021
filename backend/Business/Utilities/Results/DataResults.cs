using System;

namespace Business.Utilities.Results
{
    public static class DataResults
    {
        public class DataResult<TData> : Results.Result, IDataResult<TData>
        {
            public DataResult(TData data, bool success) : base(success)
            {
                Data = data;
            }
            public DataResult(TData data, bool success, string info) : base(success, info)
            {
                Data = data;
            }
            public TData Data { get; set; }
        }

        public class SuccessfulDataResult<TData> : DataResult<TData>
        {
            public SuccessfulDataResult(TData data) : base(data, true)
            {

            }
            public SuccessfulDataResult(TData data, string infoMessage) : base(data, true, infoMessage)
            {

            }
        }

        public class ErrorDataResult<TData> : DataResult<TData>
        {
            public ErrorDataResult(TData data) : base(data, false)
            {

            }
            public ErrorDataResult(TData data, string infoMessage) : base(data, false, infoMessage)
            {

            }
            public ErrorDataResult(string infoMessage) : base(default, false, infoMessage)
            {

            }
        }
    }
}
