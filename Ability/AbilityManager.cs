using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityManager : MonoBehaviour
{
    public GameObject abilityView;

    public Text titleText;

    public AbilityContent abilityContent;
    public Transform abilityContentTransform;

    List<AbilityContent> abilityContentList = new List<AbilityContent>();


    List<int> abilityIndexs = new List<int>();


    private void Awake()
    {
        abilityView.SetActive(false);

        for (int i = 0; i < System.Enum.GetValues(typeof(AbilityType)).Length; i++)
        {
            AbilityContent content = Instantiate(abilityContent);
            content.transform.parent = abilityContentTransform;
            content.transform.localPosition = Vector3.zero;
            content.transform.localScale = Vector3.one;
            content.Initialize(AbilityType.Blog + i, this);
            content.gameObject.SetActive(false);
            abilityContentList.Add(content);
        }
    }

    void UnDuplicateRandom(int min, int max)
    {
        int currentNumber = Random.Range(min, max);
        abilityIndexs.Clear();

        for (int i = 0; i < 3;)
        {
            if (abilityIndexs.Contains(currentNumber))
            {
                currentNumber = Random.Range(min, max);
            }
            else
            {
                abilityIndexs.Add(currentNumber);
                i++;
            }
        }
    }

    public void Initialize()
    {
        abilityView.SetActive(true);

        titleText.text = "1일차 부업 선택";

        UnDuplicateRandom(0, abilityContentList.Count);

        for(int i = 0; i < 3; i ++)
        {
            abilityContentList[abilityIndexs[i]].gameObject.SetActive(true);
        }
    }

    public void NextDate()
    {

    }

    public void ChoiceButton(AbilityType type)
    {
        Debug.Log(type + "선택");

        abilityView.SetActive(false);

        GameManager.instance.GameStart();
    }
}
