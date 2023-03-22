using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool isAnswerInQuestion = false;
    float timerValue;
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (timerValue <= 0)
        {
            timerValue = timeToCompleteQuestion;
            isAnswerInQuestion = true;
        }

        Debug.Log(timerValue);

    }

}
