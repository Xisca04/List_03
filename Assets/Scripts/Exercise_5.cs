using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // Multiplication table

    public int num = 2;

    private void Calculator()
    {
        Debug.Log($"{num} * 1 = {num * 1}");
        Debug.Log($"{num} * 2 = {num * 2}");
        Debug.Log($"{num} * 3 = {num * 3}");
        Debug.Log($"{num} * 4 = {num * 4}");
        Debug.Log($"{num} * 5 = {num * 5}");
        Debug.Log($"{num} * 6 = {num * 6}");
        Debug.Log($"{num} * 7 = {num * 7}");
        Debug.Log($"{num} * 8 = {num * 8}");
        Debug.Log($"{num} * 9 = {num * 9}");
        Debug.Log($"{num} * 10 = {num * 10}");
    }

    private void Start()
    {
        Calculator();
    }
}
