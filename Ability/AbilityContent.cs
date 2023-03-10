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
                titleText.text = "��α�";
                break;
            case AbilityType.Youtube:
                titleText.text = "���� ����";
                break;
            case AbilityType.OnlineShop:
                titleText.text = "�¶��� ���θ�";
                break;
            case AbilityType.SNS:
                titleText.text = "SNS ä��";
                break;
            case AbilityType.Ebook:
                titleText.text = "����å";
                break;
            case AbilityType.ExpGroup:
                titleText.text = "ü���";
                break;
            case AbilityType.Delivery:
                titleText.text = "���";
                break;
            case AbilityType.Stock:
                titleText.text = "�ֽ�";
                break;
            case AbilityType.AppDev:
                titleText.text = "�� ����";
                break;
            case AbilityType.Design:
                titleText.text = "������";
                break;
        }
    }

    public void ChoiceButton()
    {
        abilityManager.ChoiceButton(abilityType);
    }
}
