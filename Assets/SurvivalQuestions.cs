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

    private List<int> askedQuestions;

    // Start is called before the first frame update
    void Start()
    {
        questions = survivalData.questions;

        SelectQuestion();
    }

   void SelectQuestion()
    {
        if (questions.Count != 0)
        {
            int val = -1;
            while (val < 0)
            {
                val = Random.Range(0, questions.Count);
                bool hasAsked = false;
                for (int i = 0; i < askedQuestions.Count; i++)
                {
                    if (askedQuestions[i] == val)
                    {
                        hasAsked = true;
                    }
                }
                if (hasAsked == false)
                {
                    selectedQuestion = questions[val];
                    askedQuestions.Add(val);

                    survivalQuestionsUI.SetQuestion(selectedQuestion);
                }
            }
        }
        else
        {
            //SceneManager.LoadScene("Menu");
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

        //Remove question from the list so it cannot be picked again
        //questions.Remove(selectedQuestion);

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


