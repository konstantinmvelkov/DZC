using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurvivalQuestions : MonoBehaviour
{
    [SerializeField] private SurvivalQuestionsUI survivalQuestionsUI;
    [SerializeField] private SurvivalQuestionsDataScriptable survivalData;
    [SerializeField] private QuitLevel quitLevel;

    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject qLevel;

    private List<Question> questions;
    private Question selectedQuestion;

    private List<bool> isAsked;
    private int numberofAnsweredQuestions; 

    // Start is called before the first frame update
    public void Start()
    {
        qLevel.SetActive(false);

        questions = survivalData.questions;

        isAsked = new List<bool>();

        for(int i = 0; i < questions.Count; i++)
        {
            isAsked.Add(false);
        }
        numberofAnsweredQuestions = 0;
        SelectQuestion();
    }

   void SelectQuestion()
    {
        if(numberofAnsweredQuestions < 3)
        {
            numberofAnsweredQuestions++;

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
            sqUI.SetActive(true);
            qLevel.SetActive(true);
            quitLevel.Start();
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


