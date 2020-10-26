using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update
    public void TryEscape () 
    {      
        Debug.Log("Escape number: " + PlayerPrefs.GetInt("escapeAttempts").ToString());
        PlayerPrefs.SetInt("escapeAttempts",PlayerPrefs.GetInt("escapeAttempts")+1);
        //based on which escape, play another video
    }
}
