using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Title("Text")]
    public Text moneyText;
    public Text autoMoneyText;

    [Space]
    [Title("Value")]
    public int money = 0;
    public int addMoney = 1;

    [Space]
    [Title("bool")]
    public bool isPlay = false;


    [Space]
    [Title("Manager")]
    public InComeManager inComeManager;
    public AbilityManager abilityManager;
    public TimerManager timerManager;
    public ToDoManager toDoManager;

    [Space]
    [Title("DataBase")]
    PlayerDataBase playerDataBase;


    private void Awake()
    {
        instance = this;

        Initialize();
    }

    [Button]
    public void Initialize()
    {
        moneyText.text = "0";
        autoMoneyText.text = "0/s";

        inComeManager.Initialize();
        abilityManager.Initialize();
        timerManager.Initialize();
        toDoManager.Initialize();
    }

    public void Touch()
    {
        if (!isPlay) return;

        SetMoney(addMoney);
    }

    public void SetMoney(int number)
    {
        if (!isPlay) return;

        money += number;

        moneyText.text = MoneyUnitString.ToCurrencyString(money);
    }

    public void GameStart()
    {
        isPlay = true;

        inComeManager.GameStart();
        timerManager.GameStart();

        Debug.Log("게임이 시작되었습니다.");
    }

    public void NextDate()
    {
        abilityManager.NextDate();

        Debug.Log("새로운 하루가 시작되었습니다.");
    }
}
