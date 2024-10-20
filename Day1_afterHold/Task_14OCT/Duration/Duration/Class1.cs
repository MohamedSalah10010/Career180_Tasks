using System;

public class Duration
{

    private int hours;
    private int minutes;
    private int seconds;


    public Duration(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public Duration(int totalSeconds)
    {

        this.hours = totalSeconds / 3600;
        totalSeconds %= 3600;
        this.minutes = totalSeconds / 60;
        this.seconds = totalSeconds % 60;
    }


    public string getString()
    {
        if (hours > 0)
            return $"Hours:{hours}, Minutes: {minutes}, Seconds: {seconds}";
        else
            return $"Minutes: {minutes}, Seconds: {seconds}";

    }


}
