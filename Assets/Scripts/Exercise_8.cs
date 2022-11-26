using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_8 : MonoBehaviour
{
    // Is a leap year or not

    public int year;
    private bool isLeapYear = true;
    private bool isNotLeapYear;

    private void LeapYear()
    {
        if (year % 4 == 0)
        {
            Debug.Log($"The year {year} is a leap year.");
            Debug.Log(isLeapYear);
        }

        if (year % 400 == 0)
        {
            Debug.Log($"The year {year} is a leap year.");
            Debug.Log(isLeapYear);
        }

        if (year % 100 == 0)
        {
            Debug.Log($"The year {year} is not a leap year.");
            Debug.Log(isNotLeapYear);
        }
    }

    private void Start()
    {
        LeapYear();
    }
}
