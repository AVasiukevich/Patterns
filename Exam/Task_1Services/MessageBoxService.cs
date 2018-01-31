using System;
using System.Windows.Forms;

namespace Task_1Services
{
    internal class MessageBoxService : IMessageBoxService
    {
        private static readonly Lazy<MessageBoxService> _lazy = new Lazy<MessageBoxService>(() => new MessageBoxService());

        private MessageBoxService()
        { }
        public static MessageBoxService GetInstance()
        {
            return _lazy.Value;
        }
        public void SearchErrors(Action method)
        {
            try
            {
                method.Invoke();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public TResult SearchErrors<TResult>(Func<TResult> method)
        {
            try
            {
                return method.Invoke();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}
