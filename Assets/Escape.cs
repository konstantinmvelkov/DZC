using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
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

        //all part one levels are completed
        if (base1.activeSelf == true || sail1.activeSelf == true || food1.activeSelf == true || spane1 == true)
        {
            base1.SetActive(false);
            sail1.SetActive(false);
            food1.SetActive(false);
            spane1.SetActive(false);

            emptyBase.SetActive(true);
            emptySail.SetActive(true);
            emptyFood.SetActive(true);
            emptySpane.SetActive(true);
        }
        //all part two levels are completed
        if (base2.activeSelf == true || sail2.activeSelf == true || food2.activeSelf == true || spane2 == true)
        {
            base2.SetActive(false);
            sail2.SetActive(false);
            food2.SetActive(false);
            spane2.SetActive(false);

            emptyBase.SetActive(true);
            emptySail.SetActive(true);
            emptyFood.SetActive(true);
            emptySpane.SetActive(true);
        }
        //all part three levels are completed
        if (base3.activeSelf == true || sail3.activeSelf == true || food3.activeSelf == true || spane3 == true)
        {
            base3.SetActive(false);
            sail3.SetActive(false);
            food3.SetActive(false);
            spane3.SetActive(false);

            emptyBase.SetActive(true);
            emptySail.SetActive(true);
            emptyFood.SetActive(true);
            emptySpane.SetActive(true);
        }
    }
}
