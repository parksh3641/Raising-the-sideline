using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ImageDataBase", menuName = "ScriptableObjects/ImageDataBase")]
public class ImageDataBase : ScriptableObject
{
    [Title("InCome")]
    public Sprite[] inComeArray;

    [Title("Ability")]
    public Sprite[] abilityArray;

    [Title("ToDo")]
    public Sprite[] toDoArray;

    public Sprite[] GetInComeArray()
    {
        return inComeArray;
    }

    public Sprite[] GetAbilityArray()
    {
        return abilityArray;
    }

    public Sprite[] GetToDoArray()
    {
        return toDoArray;
    }
}
