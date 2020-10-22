using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayer : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform checkPoint;

    public AudioSource dieSound;
    
    void OnCollisionEnter2D(Collision2D collidedObject) {
        dieSound = GetComponent<AudioSource>();
        if(collidedObject.transform.CompareTag("Player")) {
            dieSound.Play();
            collidedObject.transform.position = spawnPoint.position;
        }
    }
}
