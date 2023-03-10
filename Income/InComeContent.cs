using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InComeContent : DataBaseContent
{
    public InComeType inComeType = InComeType.Salary;

    public Image icon;

    public Text levelText;
    public Text titleText;
    public Text infoText;

    public Image fillAmount;

    [Space]
    [Title("Value")]
    public int money = 1000;
    public float coolTime = 5.0f;

    [Space]
    [Title("Bool")]
    public bool isPuase = false;

    Sprite[] inComeSprite;


    public void Awake()
    {
        base.Awake();
        inComeSprite = imageDataBase.GetInComeArray();
    }

    public void Initialize()
    {
        icon.sprite = inComeSprite[(int)inComeType];

        levelText.text = "Lv. 1";

        infoText.text = MoneyUnitString.ToCurrencyString(money) + "/s";

        fillAmount.fillAmount = 0;
    }

    public void GameStart()
    {
        StartCoroutine(DelayCoroution());
    }

    public void GamePause(bool check)
    {
        isPuase = check;
    }

    IEnumerator DelayCoroution()
    {
        fillAmount.fillAmount = 0;

        while (fillAmount.fillAmount < 1)
        {
            if(!isPuase)
            {
                fillAmount.fillAmount += 1 * Time.smoothDeltaTime / coolTime;
            }

            yield return null;
        }

        fillAmount.fillAmount = 0;

        GetMoney();
    }

    void GetMoney()
    {
        GameManager.instance.SetMoney(money);

        StartCoroutine(DelayCoroution());
    }

    public void LevelUpButton()
    {

    }
}
