using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelFireball : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    [SerializeField] GameObject reward;

    public FireballSpawner fireballSpawner;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            endLevelMenu.SetActive(true);
            reward.SetActive(false);
            fireballSpawner.Stop();
        }

        if(PlayerPrefs.GetInt("fireballLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("fireballLevelLastCompleted", levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("fireballLevelLastCompleted"));
    }
}
