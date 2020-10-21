using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] SurvivalQuestions survivalQuestions;

    [SerializeField] GameObject startLevel;
    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject quitLevel;

    // Start is called before the first frame update
    void Start()
    {
        sqUI.SetActive(false);
        quitLevel.SetActive(false);
    }

    public void PlayLevel () 
    {
        startLevel.SetActive(false);
        sqUI.SetActive(true);
        quitLevel.SetActive(true);
        survivalQuestions.Start();
    }
}
