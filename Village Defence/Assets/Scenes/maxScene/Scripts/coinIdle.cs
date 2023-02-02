using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinIdle : MonoBehaviour
{
    public float yRotation;

    void Update()
    {
        transform.Rotate(0, yRotation, 0);
    }
}



//balls
