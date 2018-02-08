using System;

namespace Task_1Services
{
    public interface IMessageBoxService
    {
        void SearchErrors(Action method);
        TResult SearchErrors<TResult>(Func<TResult> method);
    }
}
