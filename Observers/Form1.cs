using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observers
{
    public partial class Form1 : Form
    {
        private IObservable<string> eventsListObservable;

        public Form1()
        {
            InitializeComponent();

            eventsListObservable = typeof(TextBox)
                .GetEvents()
                .Select(evt => evt.Name)
                .ToObservable();
        }

        private void btnStartPump_Click(object sender, EventArgs e)
        {
            ExampleWinformsObserver exampleWinformsObserver = new ExampleWinformsObserver(txtObserverLog);

            eventsListObservable.Subscribe(exampleWinformsObserver);
        }
    }
}
