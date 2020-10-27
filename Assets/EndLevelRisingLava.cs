using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelRisingLava : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    [SerializeField] GameObject reward;

    public RisingLava risingLava;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            endLevelMenu.SetActive(true);
            if (reward)
            {
                reward.SetActive(false);
            }
            risingLava.Stop();
        }
        //Copied from EndLevelJumping
        if(PlayerPrefs.GetInt("lavaLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("lavaLevelLastCompleted", levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("lavaLevelLastCompleted"));
    }
}
