using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoManager : MonoBehaviour
{
    public GameObject[] toDoViewArray;

    public ToDoContent toDoContent;
    public Transform toDoContentTransform;

    List<ToDoContent> toDoContentList = new List<ToDoContent>();


    private void Awake()
    {
        for (int i = 0; i < System.Enum.GetValues(typeof(ToDoType)).Length; i++)
        {
            ToDoContent content = Instantiate(toDoContent);
            content.transform.parent = toDoContentTransform;
            content.transform.localPosition = Vector3.zero;
            content.transform.localScale = Vector3.one;
            content.gameObject.SetActive(true);
            content.Initialize(ToDoType.InCome + i, this);
            toDoContentList.Add(content);
        }
    }

    public void Initialize()
    {
        OpenToDoView(ToDoType.InCome);
    }

    public void OpenToDoView(ToDoType type)
    {
        for(int i = 0; i < toDoViewArray.Length; i ++)
        {
            toDoContentList[i].lockedObj.SetActive(true);
            toDoContentList[i].checkMark.SetActive(false);
        }

        toDoContentList[(int)type].lockedObj.SetActive(false);
        toDoContentList[(int)type].checkMark.SetActive(true);
        toDoViewArray[(int)type].transform.SetAsLastSibling();
    }
}
