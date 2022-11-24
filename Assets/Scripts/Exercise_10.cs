using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    // Increase the scale by one unit all the axes

    public Vector3 bigger = new Vector3(1,1,1);

    private void Scale()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += bigger;
        }
    }

    private void Update()
    {
        Scale();
    }
}
