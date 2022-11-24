using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_6 : MonoBehaviour
{
    // What number isLarger

    public float num1 = 5f;
    public float num2 = 2f;

    private void IsLarger()
    {
        if ( num1 > num2)
        {
            Debug.Log($"The number {num1} is larger than {num2}.");
        }
        else
        {
            Debug.Log($"The number {num2} is larger than {num1}.");
        }
    }

    private void Start()
    {
        IsLarger();
    }
}
