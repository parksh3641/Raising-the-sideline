using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeManager : MonoBehaviour
{

    public int inComeIndex = 0;


    public InComeContent inComeContent;
    public Transform inComeContentTransform;

    List<InComeContent> inComeContentList = new List<InComeContent>();

    private void Awake()
    {
        for(int i = 0; i < 3; i ++)
        {
            InComeContent content = Instantiate(inComeContent);
            content.transform.parent = inComeContentTransform;
            content.transform.localPosition = Vector3.zero;
            content.transform.localScale = Vector3.one;
            content.gameObject.SetActive(false);
            inComeContentList.Add(content);
        }
    }

    public void Initialize()
    {

    }

    public void GameStart()
    {
        SetInCome(InComeType.Salary);
    }

    public void SetInCome(InComeType type)
    {
        inComeContentList[inComeIndex].gameObject.SetActive(true);
        inComeContentList[inComeIndex].Initialize(type);
    }
}
