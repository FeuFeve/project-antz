using UnityEngine;

public class Timer : MonoBehaviour
{
    public int days;
    public int hours;
    public int minutes;
    public int seconds;


    // CALCULATE REMAINING TIME (D:H:M:S) WITH REMAINING SECONDS
    public void CalculateRemainingTime(double remainingSeconds)
    {
        int secondsLeft = (int)remainingSeconds;

        // Days
        days = secondsLeft / 86400;

        // Hours
        secondsLeft %= 86400;
        hours = secondsLeft / 3600;

        // Minutes
        secondsLeft %= 3600;
        minutes = secondsLeft / 60;

        // Seconds
        seconds = secondsLeft % 60;
    }
}
