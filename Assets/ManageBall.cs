using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBall : MonoBehaviour
{
    [SerializeField] Transform ballSpawnPoint;
    
    void OnCollisionEnter2D(Collision2D col) {
        if(col.transform.CompareTag("Ball")) {
            col.transform.position = ballSpawnPoint.position;
        }

        if(col.transform.CompareTag("BigFlake")) {
            Destroy(col.gameObject);
        }
    }
}
