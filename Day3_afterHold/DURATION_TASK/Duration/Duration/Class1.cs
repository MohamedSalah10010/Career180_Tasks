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


    public override bool Equals(object obj)
    {
        Duration D = obj as Duration;
        if (D == null) return false;
        else return (D.hours == hours && D.minutes == minutes && D.seconds == seconds);
    }


    public override string ToString()
    {
        if (hours > 0)
            return $"{hours}H:{minutes}M:{seconds}S";
        else if (hours <= 0 && minutes > 0)
            return $"{minutes}M:{seconds}S";
        else
            return $"{seconds}S";
    }
    public static Duration operator +(Duration D1, Duration D2) {

        return new Duration(D1.hours + D2.hours, D1.minutes + D2.minutes, D1.seconds + D2.seconds);
    }
    public static Duration operator +(Duration D1, int sec)
    {

        return new Duration(D1.seconds + sec);
    }
    public static Duration operator +( int sec, Duration D1)
    {

        return new Duration(D1.seconds + sec);
    }
    public static Duration operator ++(Duration D1)
    {
        D1.minutes++;
        if (D1.minutes > 59)
        {
            D1.hours++;
            D1.minutes = 0;
        }
        return D1;
    }
    public static Duration operator --(Duration D1)
    {
        D1.minutes--;
        if (D1.minutes < 0)
        {
            D1.hours--;
            D1.minutes = 59;
            return D1;
        }
        else if (D1.minutes < 0 && D1.hours <= 0)
        {
            D1.hours = 0;
            D1.minutes = 0;
            D1.seconds = 0;
            return D1;
        }
        else return D1;

    }
    public static bool operator <=(Duration D1, Duration D2)
    {
        
        return (D1.hours * 3600 + D1.minutes * 60 + D1.seconds) <= (D2.hours * 3600 + D2.minutes * 60 + D2.seconds);
    }
    public static bool operator >=(Duration D1, Duration D2)
    {

        return (D1.hours * 3600 + D1.minutes * 60 + D1.seconds) >= (D2.hours * 3600 + D2.minutes * 60 + D2.seconds);
    }
}
