using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [Title("Text")]
    public Text dateText;
    public Text timerText;

    [Space]
    [Title("Value")]
    public int standardTime = 60;
    public int dayTime = 1440;
    public float timer = 0;

    [Space]
    [Title("Bool")]
    public bool isPause = false;

    public void Initialize()
    {
        dateText.text = "1ÀÏÂ÷";
        timerText.text = "00:00";

        timer = 0;
    }

    public void GameStart()
    {
        StartCoroutine(TimerCoroution());
    }

    public void GamePause(bool check)
    {
        isPause = check;
    }

    IEnumerator TimerCoroution()
    {
        while(timer < dayTime)
        {
            if (!isPause)
            {
                timer += (1 * dayTime / standardTime) * Time.smoothDeltaTime;
            }

            timerText.text = ((int)timer / 60).ToString("D2") + ":" + ((int)timer % 60).ToString("D2");

            yield return null;
        }

        NextDate();
    }

    void NextDate()
    {
        GameManager.instance.NextDate();
    }
}
