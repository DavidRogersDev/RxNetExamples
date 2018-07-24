using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace Observers
{
    public partial class Form1 : Form
    {
        private readonly IObservable<string> _eventsListObservable;
        private IDisposable _eventsListObservableSubscription;

        public Form1()
        {
            InitializeComponent();

            // Grab all the possible events on a TextBox using reflection and create an Observable
            // using the convenient ToObservable extension method.
            _eventsListObservable = typeof(TextBox)
                .GetEvents()
                .Select(evt => evt.Name)
                .ToObservable();
        }

        private void btnStartPump_Click(object sender, EventArgs e)
        {
            txtObserverLog.Clear();

            // This is our custom IObserver, created for demonstration purposes.
            var exampleWinformsObserver = new ExampleWinformsObserver(txtObserverLog);

            // Invoke the Subscribe method which is the only method prescrived by the IObservable interface.
            _eventsListObservableSubscription = _eventsListObservable.Subscribe(exampleWinformsObserver);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _eventsListObservableSubscription.Dispose(); // cleanup

            base.OnClosing(e);
        }
    }
}
