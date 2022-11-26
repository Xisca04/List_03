using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    // The division is exact or not

    public int dividend;
    public int divisor;

    private void Division()
    {
        if (dividend % divisor == 0)
        {
            Debug.Log($"The division of {dividend} / {divisor} is exact.");
        }
        else
        {
            Debug.Log($"The division of {dividend} / {divisor} is not exact.");
        }
    }

    private void Start()
    {
        Division();
    }
    
}
