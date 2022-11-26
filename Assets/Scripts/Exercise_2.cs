using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Number is even or not

    public int number;

    private void EvenNumber()
    {
        if ( number % 2 == 0)
        {
            Debug.Log($"The number {number} is even.");
        }
        else
        {
            Debug.Log($"The number {number} is not even.");
        }
    }

    private void Start()
    {
        EvenNumber();
    }
    
}
