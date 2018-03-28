using System;

namespace Day02
{
    public class DisposableClass:IDisposable
    {
        public string GetMessage()
        {
            return "This is from a Disposable class.";
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //disposing code here
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}