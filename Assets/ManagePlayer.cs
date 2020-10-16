using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform checkPoint;

    void OnCollisionEnter2D(Collision2D col) {
        if(col.transform.CompareTag("Player")) {
            col.transform.position = spawnPoint.position;
        }
    }
}
