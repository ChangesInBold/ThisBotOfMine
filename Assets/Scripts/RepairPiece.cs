using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairPiece : MonoBehaviour
{
    public enum RepairType
    {
        Leg,
        Arm,
        Head
    }

    public bool IsHeld = false;

    private float speed;

    private void Update()
    {
        if (IsHeld)
        {
            Vector3 direction = FindObjectOfType<Player>().transform.position - transform.position;
            if (direction.magnitude > 3.6f)
                GetComponent<Rigidbody>().AddForce(direction);
            //Debug.LogError(direction.magnitude);
        }
    }
}
