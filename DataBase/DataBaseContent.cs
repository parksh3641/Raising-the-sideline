using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseContent : MonoBehaviour
{
    public PlayerDataBase playerDataBase;
    public ImageDataBase imageDataBase;
    public AbilityDataBase abilityDataBase;


    public void Awake()
    {
        if (playerDataBase == null) playerDataBase = Resources.Load("PlayerDataBase") as PlayerDataBase;
        if (imageDataBase == null) imageDataBase = Resources.Load("ImageDataBase") as ImageDataBase;
        if (abilityDataBase == null) abilityDataBase = Resources.Load("AbilityDataBase") as AbilityDataBase;
    }
}
