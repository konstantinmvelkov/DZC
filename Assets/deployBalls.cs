using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBalls : MonoBehaviour
{
    public GameObject ballPrefab;
    public float respawnTime = 1.0f;
    [SerializeField] Transform spawnPoint;

    // Use this for initialization
    void Start () {
        StartCoroutine(ballWave());
    }
    private void spawnBall(){
        GameObject ball = Instantiate(ballPrefab) as GameObject;
        ball.transform.position =  spawnPoint.position;
    }
    IEnumerator ballWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnBall();
        }
    }
}
