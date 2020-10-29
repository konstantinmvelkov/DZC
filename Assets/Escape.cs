using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
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

    // Start is called before the first frame update
    public void TryEscape () 
    {      
        Debug.Log("Escape number: " + PlayerPrefs.GetInt("escapeAttempts").ToString());
        PlayerPrefs.SetInt("escapeAttempts",PlayerPrefs.GetInt("escapeAttempts")+1);
        //based on which escape, play another video

        base1.SetActive(false);
        sail1.SetActive(false);
        food1.SetActive(false);
        spane1.SetActive(false);
        base2.SetActive(false);
        sail2.SetActive(false);
        food2.SetActive(false);
        spane2.SetActive(false);
        base3.SetActive(false);
        sail3.SetActive(false);
        food3.SetActive(false);
        spane3.SetActive(false);

        escapeButton.SetActive(false);

        emptyBase.SetActive(true);
        emptySail.SetActive(true);
        emptyFood.SetActive(true);
        emptySpane.SetActive(true);
    }
}
