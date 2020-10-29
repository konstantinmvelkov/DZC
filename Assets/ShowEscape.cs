using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEscape : MonoBehaviour
{
    [SerializeField] GameObject escapeButton;

    [SerializeField] GameObject emptyBase;
    [SerializeField] GameObject emptySail;
    [SerializeField] GameObject emptyFood;
    [SerializeField] GameObject emptySpane;

    [SerializeField] GameObject base1;
    [SerializeField] GameObject base2;
    [SerializeField] GameObject base3;

    [SerializeField] GameObject sail1;
    [SerializeField] GameObject sail2;
    [SerializeField] GameObject sail3;

    [SerializeField] GameObject food1;
    [SerializeField] GameObject food2;
    [SerializeField] GameObject food3;

    [SerializeField] GameObject spane1;
    [SerializeField] GameObject spane2;
    [SerializeField] GameObject spane3;

    void Awake()
    {
        //First part
        if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 2 && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            emptyBase.SetActive(false);
            base1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("fireballLevelLastCompleted") == 1 && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            emptySail.SetActive(false);
            sail1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2 && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            emptyFood.SetActive(false);
            food1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("questionsLevelLastCompleted") == 1 && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            emptySpane.SetActive(false);
            spane1.SetActive(true);
        }
        //Second part
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 4 && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            emptyBase.SetActive(false);
            base2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("fireballLevelLastCompleted") == 2 && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            emptySail.SetActive(false);
            sail2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lavaLevelLastCompleted") == 4 && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            emptyFood.SetActive(false);
            food2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("questionsLevelLastCompleted") == 2 && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            emptySpane.SetActive(false);
            spane2.SetActive(true);
        }
        //Third Part
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 6 && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            emptyBase.SetActive(false);
            base3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("fireballLevelLastCompleted") == 3 && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            emptySail.SetActive(false);
            sail3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lavaLevelLastCompleted") == 6 && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            emptyFood.SetActive(false);
            food3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("questionsLevelLastCompleted") == 3 && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            emptySpane.SetActive(false);
            spane3.SetActive(true);
        }

        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 2 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 1 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 1 &&
            PlayerPrefs.GetInt("escapeAttempts") == 0) 
        {
            escapeButton.SetActive(true);
        }   
        else if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 4 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 4 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("escapeAttempts") == 1) 
        {
            escapeButton.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 6 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 6 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 3 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 3 &&
            PlayerPrefs.GetInt("escapeAttempts") == 2) 
        {
            escapeButton.SetActive(true);
        }
        else 
        {
            escapeButton.SetActive(false);
        }
    }
}
