using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurvivalQuestions : MonoBehaviour
{
    [SerializeField] private SurvivalQuestionsUI survivalQuestionsUI;
    [SerializeField] private SurvivalQuestionsDataScriptable survivalData;

    private List<Question> questions;
    private Question selectedQuestion;

    private List<bool> isAsked;

    // Start is called before the first frame update
    void Start()
    {
        questions = survivalData.questions;

        isAsked = new List<bool>();

        for(int i = 0; i < questions.Count; i++)
        {
            Debug.Log(isAsked);
            isAsked.Add(false);
        }
        SelectQuestion();
    }

   void SelectQuestion()
    {
        if (isAsked.Contains(false))
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
            SceneManager.LoadScene("Menu");
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


