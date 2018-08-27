using System;
using System.Windows.Forms;

namespace Observers
{
    public class ExampleWinformsObserver :  IObserver<string>
    {
        private readonly Control _control;

        public ExampleWinformsObserver(Control control)
        {
            _control = control;
        }

        public void OnNext(string value)
        {
            _control.Text += $"{value}{Environment.NewLine}";
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            _control.Text += $"{Environment.NewLine}Done!";
        }
    }
}
