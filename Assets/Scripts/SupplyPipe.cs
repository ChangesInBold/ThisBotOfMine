using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyPipe : MonoBehaviour
{
    public GameObject RepairPiecePrefab;

    public float PieceGenerationRate = 5;
    public float GenerateThrust = 500;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > PieceGenerationRate)
        {
            timer -= PieceGenerationRate;
            GameObject lNewPiece = Instantiate(RepairPiecePrefab, transform.position - new Vector3(0,7,0), transform.rotation);
            lNewPiece.GetComponent<Rigidbody>().AddForce(0, -GenerateThrust, 0);
        }
    }
}
