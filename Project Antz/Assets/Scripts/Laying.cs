using System;
using UnityEngine;

public class Laying : MonoBehaviour
{
    public string unitName;

    public double totalUnits;
    public double layedUnits;
    public double remainingUnits;
    public double secondsPerUnit;

    public double remainingSeconds;
    public Timer timer;
    public Timer queueTimer;


    // CONSTRUCTOR
    Laying(string unitName, double totalUnits, double secondsPerUnit)
    {
        this.unitName = unitName;

        this.totalUnits = totalUnits;
        layedUnits = 0;
        remainingUnits = totalUnits;

        this.secondsPerUnit = secondsPerUnit;
        remainingSeconds = totalUnits * secondsPerUnit;
        timer = new Timer();
        queueTimer = new Timer();
    }


    // UPDATE LAYING AND RETURN THE NUMBER OF UNITS LAYED
    public int UpdateWith(double secondsSinceLastUpdate)
    {
        double rawLayedInUpdate = secondsSinceLastUpdate / secondsPerUnit;
        remainingUnits -= rawLayedInUpdate;

        int reallyLayedInUpdate = (int)(layedUnits + rawLayedInUpdate) - (int)layedUnits;
        layedUnits += rawLayedInUpdate;

        remainingSeconds -= secondsSinceLastUpdate;
        timer.CalculateRemainingTime(remainingSeconds);

        return reallyLayedInUpdate;
    }


    // UPGRADE SECONDS PER UNIT
    public void UpgradeSecondsPerUnit()
    {
        secondsPerUnit *= 0.9;
        remainingSeconds *= 0.9;
        timer.CalculateRemainingTime(remainingSeconds);
    }


    // (STATIC) CALCULATE TIME PER UNIT WITH CURRENT LAYING SPEED
    public static double CalculateSecondsPerUnit(double baseSecondsPerUnit, int layingSpeed)
    {
        return (baseSecondsPerUnit * Math.Pow(0.9, layingSpeed));
    }
}
