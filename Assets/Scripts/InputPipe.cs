using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPipe : MonoBehaviour
{
    public enum RepariType
    {
        Leg,
        Arm,
        Head
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
            Debug.Log("Collision detected");
    }
}
