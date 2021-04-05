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
        finishPanel.SetActive(true);
        Debug.Log("Finish State!");
    }

    public void Exit()
    {
        finishPanel.SetActive(false);
        Debug.Log("Finish State exited!");
    }
}
