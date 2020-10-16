using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalQuestionsUI : MonoBehaviour
{

    [SerializeField] private SurvivalQuestions survivalQuestions;
    [SerializeField] private Text questionText;
    [SerializeField] private List<Button> options;
    [SerializeField] private Color correctCol, wrongCol, normalCol;

    private Question question;
    private bool answered;

    void Awake()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetQuestion(Question question)
    {
        this.question = question;

        questionText.text = question.questionInfo;

        //List<string> answerList = ShuffleList.ShuffleListItem<string>(question.options);

        List<string> answerList = question.options;
        for (int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = normalCol;
        }

        answered = false;
    }

    private void OnClick(Button btn)
    {
        if(!answered)
        {
            answered = true;
            bool val = survivalQuestions.Answer(btn.name);

            if(val)
            {
                btn.image.color = correctCol;
            }
            else
            {
                btn.image.color = wrongCol;
            }
        }
    }

}
