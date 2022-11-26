using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_9 : MonoBehaviour
{
    // The area of the triangle

    public float Base;
    public float Height;

    private void AreaOfTheTriangle()
    {
        if (Base > 0 && Height > 1)
        {
            Debug.Log($"The area of the triangle is {Base * Height / 2}.");
        }
        else
        {
            Debug.Log($"The area of the triangle can not be calculated.");
        }
    }

    private void Start()
    {
        AreaOfTheTriangle();
    }
}
