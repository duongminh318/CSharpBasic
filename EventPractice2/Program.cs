using System.Timers;
using Timer = System.Timers.Timer;
public class AlarmEventArgs : EventArgs
{
    public DateTime Time { get; set; }
}
class AlarmClock
{
    public event EventHandler<AlarmEventArgs> AlarmClockTriggered;
    private Timer timer;
    public DateTime AlarmTime { set; get; }

    public AlarmClock()
    {
        timer = new Timer(1000);
        timer.Elapsed += CheckAlarm;
    }

    public void Start()
    {
        timer.Start();
    }

    public void Stop()
    {
        timer.Stop();
    }

    private void CheckAlarm(object sender, ElapsedEventArgs e)
    {
        if (DateTime.Now >= AlarmTime)
        {
            AlarmClockTriggered.Invoke(this, new AlarmEventArgs() { Time = AlarmTime });
        }
    }
}

class Program
{
    static void Main()
    {
        AlarmClock alarmClock = new AlarmClock();
        alarmClock.AlarmTime = DateTime.Now.AddSeconds(5);
        alarmClock.AlarmClockTriggered += Alarm_AlarmTriggered;
        Console.WriteLine("Alarm clock setup...");
        alarmClock.Start();

        Console.ReadLine();
    }

    static void Alarm_AlarmTriggered(object sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Time up! Time: {e.Time:HH:mm:ss}");
    }
}