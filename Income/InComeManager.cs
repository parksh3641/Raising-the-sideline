using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InComeManager : MonoBehaviour
{
    public InComeContent salaryContent;



    public void Initialize()
    {
        salaryContent.Initialize();
    }

    public void GameStart()
    {
        salaryContent.GameStart();
    }

}
