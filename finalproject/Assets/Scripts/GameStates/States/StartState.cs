using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : MonoBehaviour, IState
{
    [Space]
    [SerializeField]
    GameObject startPanel;

    public void Enter()
    {
        startPanel.SetActive(true);
    }

    public void Exit()
    {
        Time.timeScale = 1;
        startPanel.SetActive(false);
    }
}
