using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishState : MonoBehaviour, IState
{
    [Space]
    [SerializeField]
    GameObject finishPanel;
    
    public void Enter()
    {
        Time.timeScale = 0;

        if(finishPanel != null)
        {
            finishPanel.SetActive(true);
        }
    }

    public void Exit()
    {
        finishPanel.SetActive(false);
    }
}
