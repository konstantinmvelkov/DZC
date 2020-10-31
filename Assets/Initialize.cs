using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(!PlayerPrefs.HasKey("jumpingLevelLastCompleted")) {
            PlayerPrefs.SetInt("jumpingLevelLastCompleted",0);
        }
        if(!PlayerPrefs.HasKey("lavaLevelLastCompleted")) {
            PlayerPrefs.SetInt("lavaLevelLastCompleted",0);
        }
        if(!PlayerPrefs.HasKey("questionsLevelLastCompleted")) {
            PlayerPrefs.SetInt("questionsLevelLastCompleted",0);
        }
        if(!PlayerPrefs.HasKey("fireballLevelLastCompleted")) {
            PlayerPrefs.SetInt("fireballLevelLastCompleted",0);
        }
        if(!PlayerPrefs.HasKey("escapeAttempts")) {
            PlayerPrefs.SetInt("escapeAttempts",0);
        }
        Debug.Log("_____________________________________________________vvvvvvv");
        Debug.Log("Jumping: " + PlayerPrefs.GetInt("jumpingLevelLastCompleted").ToString());
        Debug.Log("Lava: " + PlayerPrefs.GetInt("lavaLevelLastCompleted").ToString());
        Debug.Log("Questions: " + PlayerPrefs.GetInt("questionsLevelLastCompleted").ToString());
        Debug.Log("Fireball: " + PlayerPrefs.GetInt("fireballLevelLastCompleted").ToString());
        Debug.Log("Escape: " + PlayerPrefs.GetInt("escapeAttempts").ToString());
    }
}
