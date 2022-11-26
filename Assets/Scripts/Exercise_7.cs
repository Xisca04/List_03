using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7 : MonoBehaviour
{
    // Give a real number, return his absolute value

    public float number;

    private void AbsoluteValue()
    {
       if (number == 0)
        {
            Debug.Log($"The absolute value of {number} is 0.");
        }

       if (number < -1)
        {
            Debug.Log($"The absolute value of {number} is {(-1) * number}.");
        }

       if (number > 1)
        {
            Debug.Log($"The absolute value of {number} is {number = number}.");
        }
    }

    private void Start()
    {
        AbsoluteValue();
    }
}
