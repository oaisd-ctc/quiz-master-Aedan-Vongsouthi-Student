using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctanswerindex;
    [SerializeField] Sprite defaultAnswerSpirte;
    [SerializeField] Sprite correctAnswerSpirte;

    void Start()
    {
        questionText.text = question.GetQuestion();
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    public void OnAnswerSelected(int index)
    {
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSpirte;
        } else {
            questionText.text = "Wrong, ya idiot! The correct answer is \n" + question.GetAnswer(question.GetCorrectAnswerIndex());
            Image buttonImage = answerButtons[question.GetCorrectAnswerIndex()].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSpirte;
        }
    }
}
