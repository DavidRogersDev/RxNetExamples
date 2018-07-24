using System;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace EventsToObservables
{
    public partial class Form1 : Form
    {
        private int a, z;
        private IDisposable afterHalfwaySubscriber, mirrorCharSubscriber;

        public Form1()
        {
            a = Convert.ToInt32('a');
            z = Convert.ToInt32('z');

            InitializeComponent();

            label2.Text = label1.Text = string.Empty;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            var keyPressesObservable = Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                    h => textBox1.KeyPress += h,
                    h => textBox1.KeyPress -= h
                )
                .Select(k => k.EventArgs.KeyChar);

            var mirrorCharObservable = keyPressesObservable
                .Select(k =>
                    (char)(z - Convert.ToInt32(k) + a)
                );

            mirrorCharSubscriber = mirrorCharObservable.Subscribe(text =>
            {
                label1.Text += text;
            });


            //var afterHalfwayObservable = keyPressesObservable
            //    .Where(k =>
            //        Convert.ToInt32(k) - a > 26 / 2
            //    );

            //afterHalfwaySubscriber = afterHalfwayObservable.Subscribe(text =>
            //{
            //    label2.Text += text;
            //});

            keyPressesObservable = null; // You can even set the original observable to null!
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //afterHalfwaySubscriber.Dispose();
            mirrorCharSubscriber.Dispose();

            base.OnFormClosing(e);
        }
    }
}
