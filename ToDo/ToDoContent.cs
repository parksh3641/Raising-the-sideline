using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoContent : DataBaseContent
{
    public ToDoType toDoType = ToDoType.InCome;

    public Image icon;

    public Text titleText;

    public GameObject checkMark;
    public GameObject lockedObj;

    Sprite[] toDoSpriteArray;

    ToDoManager toDoManager;

    private void Awake()
    {
        base.Awake();
        toDoSpriteArray = imageDataBase.GetToDoArray();
    }

    public void Initialize(ToDoType type, ToDoManager manager)
    {
        toDoType = type;
        toDoManager = manager;

        icon.sprite = toDoSpriteArray[(int)toDoType];

        checkMark.SetActive(false);
        lockedObj.SetActive(false);

        switch (toDoType)
        {
            case ToDoType.InCome:
                titleText.text = "����";
                break;
            case ToDoType.Upgrade:
                titleText.text = "���׷��̵�";
                break;
            case ToDoType.Shop:
                titleText.text = "����";
                break;
            case ToDoType.Realestate:
                titleText.text = "�ε���";
                break;
        }
    }

    public void ChoiceButton()
    {
        toDoManager.OpenToDoView(toDoType);
    }
}
