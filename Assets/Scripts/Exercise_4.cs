using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // Movement of the game object with Vector3
    public Vector3 movement = new Vector3(1, 0, 0);

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position += movement;
        }
    }
}
