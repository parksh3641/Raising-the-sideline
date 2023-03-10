using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AbilityInformation
{

}

[CreateAssetMenu(fileName = "AbilityDataBase", menuName = "ScriptableObjects/AbilityDataBase")]
public class AbilityDataBase : ScriptableObject
{
    public AbilityInformation[] abilityInformation;
}
