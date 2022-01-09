using System;
using System.Timers;

namespace COMS201Exercise14WinForms
{
    class Stopwatch
    {

        // #1: Add three private fields: elapsedSeconds which has a data type of "double", 
        // and elapsedMinutes and elapsedHours which have data types of "int".
        private double elapsedSeconds;
        private int elapsedMinutes;
        private int elapsedHours;

        // #2: Add a private field named systemTimer and set it = a new instance of a System.Timers.Timer object.

        private System.Timers.Timer systemTimer;


        // #3: Add a public event named TimerTick that we will raise whenever something happens in our Stopwatch class.
        // Note: Built-in .NET System.Timers.Timer objects use a specific type of event handler named ElapsedEventHandler.
        // Declare the public TimerTick event as an ElapsedEventHandler data type.

        public event ElapsedEventHandler TimerTick;

        // #4: Add a public Start method. This method must call systemTimer's Start() method.

        public void Start()
        {
            systemTimer.Start();
        }

        // #5: Add a public Stop method. This method must call systemTimer's Stop() method.

        public void Stop()
        {
            systemTimer.Stop();
        }

        // #6: Add a public Reset method. This method must stop systemTimer and set all the "elapsed" field values to zero.

        public void Reset()
        {
            systemTimer.Stop();
            elapsedSeconds = 0;
            elapsedMinutes = 0;
            elapsedHours = 0;
        }

        // #7: Add a public Value property of type string.
        // The Value property should only have a "getter" so it can read from outside the Stopwatch class but not set from outside the class.
        // Value should output a string showing the current elapsed time of the stopwatch.
        // The challenge here: Format the return value as hours, minutes, seconds, and 10ths.  
        // Example return value of this property: 1:23:20.5

        public string Value
        {
            get { return Value; }
        }

        // #8: Add a private void method named OnTimer which will be wired to the systemTimer.Elapsed event in a later step.
        // Remember that methods which handle events have two parameters (object sender, EventArgs e).
        // Note: Built-in .NET System.Timers.Timer objects use a specific type of EventArgs named ElapsedEventArgs.
        // So declare the private void OnTimer method using (object sender, ElapsedEventArgs e) as its parameters.
        // #9: Increment the elapsedSeconds field's value by 0.1 (1/10 seconds)
        // #10: Increment elapsedMinutes whenever elepsedSeconds reaches 60 and reset elepsedSeconds to 0.
        // #11: Increment elapsedHours whenever elapsedMinutes reaches 60 and reset elepsedMinutes to 0.
        // #12: Call the TimerTick event (declared above).

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            this.elapsedSeconds += 0.1;
            if (elapsedSeconds == 60)
            {
                this.elapsedMinutes += 1;
                elapsedSeconds = 0;
            }
            if (elapsedMinutes == 60)
            {
                this.elapsedHours += 1;
                elapsedMinutes = 0;
            }

            TimerTick(sender, e);
        }

        // #13: Add a public Stopwatch constructor.
        // BEGIN code that goes inside the constructor -------------------------------------------------------
        // #14: Set systemTimer's Interval property to 100. (A value of 100 is 1/10 second.)
        // #15: Wire the systemTimer object's Elapsed event to the OnTimer method. This will cause the OnTimer method to be
        // called when the systemTimer object's "Elapsed" event occurs every 1/10 second.
        // END code that goes inside the constructor ---------------------------------------------------------


        public Stopwatch()
        {
            systemTimer.Interval = 1 / 10;
            systemTimer.Start();
            systemTimer.Elapsed += new ElapsedEventHandler(OnTimer);
        }
        // BEGIN code that goes inside the constructor -------------------------------------------------------
        // #14: Set systemTimer's Interval property to 100. (A value of 100 is 1/10 second.)
        // #15: Wire the systemTimer object's Elapsed event to the OnTimer method. This will cause the OnTimer method to be
        // called when the systemTimer object's "Elapsed" event occurs every 1/10 second.
        // END code that goes inside the constructor ---------------------------------------------------------
    }
}
