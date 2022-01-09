using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS201Exercise14WinForms
{
    public partial class Form1 : Form
    {
        // Instantiate a Stopwatch object using our Stopwatch class.
        private Stopwatch stopWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Delegate the Stopwatch.TimerTick event to the DisplayTime method on this Form.
            stopWatch.TimerTick += new System.Timers.ElapsedEventHandler(DisplayTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            DisplayTime(null, null);
        }

        // We wired the Stopwatch.TimerTick event to this method in the Form1_Load event above.
        // Since DisplayTime is a delegated event handler, it must have object and EventArgs parameters.
        private void DisplayTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                // Here is where it gets complicated when we need to update a control on the Form in response to another class' events.
                // It is considered "thread unsafe" to update any of the form's controls from a class other than the form itself.
                // So we have to "invoke" another method on the form to handle the update. 
                // Essentially the "DisplayTime" method, which is a delegate of the TimerTick event, passes control to a delegate of its own.
                // We want to update label1.Text to display stopWatch.Value.  So we delegate the "UpdateTimerLabel" method (below) to do that.
                // The compiler won't compile the code if you don't do this.
                if (label1.InvokeRequired)
                {
                    var d = new SafeCallDelegate(UpdateTimerLabel);
                    this.Invoke(d, new object[] { stopWatch.Value });
                }
                else
                {
                    label1.Text = stopWatch.Value;
                }
            }
            catch { }
        }

        // We won't cover multi-threading in this course.  However, to use our Stopwatch's TimerTick event to update a control on 
        // a Form, we have to use some special multi-threading code.  Information about this can be found at this link:
        // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls?view=netframework-4.8

        // This line creates a delegate so we can update the label1 control in a multi-threaded "thread-safe" manner.
        private delegate void SafeCallDelegate(string value);

        // Local delegated method used to update the value of label1.Text.
        private void UpdateTimerLabel(string value)
        {
            label1.Text = stopWatch.Value;
        }


    }
}
