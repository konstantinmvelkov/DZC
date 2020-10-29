using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurvivalQuestions : MonoBehaviour
{
    [SerializeField] private SurvivalQuestionsUI survivalQuestionsUI;
    [SerializeField] private SurvivalQuestionsDataScriptable survivalData;
    [SerializeField] private SurvivalQuestionsDataScriptable2 survivalData2;
    [SerializeField] private SurvivalQuestionsDataScriptable3 survivalData3;

    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject qLevel;
    [SerializeField] GameObject qLevelFail;

    [SerializeField] GameObject reward;

    private List<Question> questions;
    private Question selectedQuestion;

    private List<bool> isAsked;

    public bool allCorrect = true;

    // Start is called before the first frame update
    public void Start()
    {
        qLevel.SetActive(false);
        qLevelFail.SetActive(false);
        reward.SetActive(false);

        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "SurvivalQuestions_Level")
        {
            questions = survivalData.questions;
        } 
        else if (sceneName == "SurvivalQuestions_Level_2")
        {
            questions = survivalData2.questions;
        }
        else if (sceneName == "SurvivalQuestions_Level_3")
        {
            questions = survivalData3.questions;
        }

        isAsked = new List<bool>();

        for(int i = 0; i < questions.Count; i++)
        {
            isAsked.Add(false);
        }
        SelectQuestion();
    }

   void SelectQuestion()
    {
        if(isAsked.Contains(false))
        {
            int val = -1;
            while (val == -1)
            {
                val = Random.Range(0, questions.Count);
                if (isAsked[val] == true)
                {
                    val = -1;
                }
                else
                {
                    isAsked[val] = true;
                }
            }

            selectedQuestion = questions[val];
            survivalQuestionsUI.SetQuestion(selectedQuestion);
        }
        else
        {
            sqUI.SetActive(false);
            if (allCorrect == true)
            {
                //Quit Level Menu for all Correct answers
                qLevel.SetActive(true);
                if (reward.activeSelf == false)
                {
                    reward.SetActive(true);
                }
            }
            else
            {
                allCorrect = true;
                //Quit Level Menu for not all Correct answers
                qLevelFail.SetActive(true);
            }
        }
    }

    public bool Answer(string answered)
    {
        bool correctAns = false;

        if (answered == selectedQuestion.correctAns)
        {
            //Yes
            correctAns = true;
        }
        else
        {
            //No
            allCorrect = false;
        }

        Invoke("SelectQuestion", 0.8f);

        return correctAns;
    }

}

[System.Serializable]
public class Question
{
    public string questionInfo;
    public List<string> options;
    public string correctAns;
}


