using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform checkPoint;

    void OnCollisionEnter2D(Collision2D collidedObject) {
        if(collidedObject.transform.CompareTag("Player")) {
            collidedObject.transform.position = spawnPoint.position;
        }
    }
}
