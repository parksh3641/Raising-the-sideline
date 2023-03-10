using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityContent : DataBaseContent
{
    public AbilityType abilityType;

    public Text titleText;
    public Text infoText;

    public Image icon;

    public Image[] starArray;

    public GameObject newObj;

    Sprite[] abilitySprite;

    AbilityManager abilityManager;

    private void Awake()
    {
        base.Awake();

        abilitySprite = imageDataBase.GetAbilityArray();
    }


    public void Initialize(AbilityType type, AbilityManager manager)
    {
        newObj.SetActive(false);

        abilityType = type;

        abilityManager = manager;

        icon.sprite = abilitySprite[(int)abilityType];

        switch (abilityType)
        {
            case AbilityType.Blog:
                titleText.text = "블로그";
                break;
            case AbilityType.Youtube:
                titleText.text = "영상 편집";
                break;
            case AbilityType.OnlineShop:
                titleText.text = "온라인 쇼핑몰";
                break;
            case AbilityType.SNS:
                titleText.text = "SNS 채널";
                break;
            case AbilityType.Ebook:
                titleText.text = "전자책";
                break;
            case AbilityType.ExpGroup:
                titleText.text = "체험단";
                break;
            case AbilityType.Delivery:
                titleText.text = "배달";
                break;
            case AbilityType.Stock:
                titleText.text = "주식";
                break;
            case AbilityType.AppDev:
                titleText.text = "앱 개발";
                break;
            case AbilityType.Design:
                titleText.text = "디자인";
                break;
        }
    }

    public void ChoiceButton()
    {
        abilityManager.ChoiceButton(abilityType);
    }
}
