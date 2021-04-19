using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Space]
    [SerializeField]
    StartStateController startStateController;

    [Space]
    [SerializeField]
    FinishStateController finishStateController;

    public System.Action ClickedToStart;
    public System.Action ClickedToResume;
    public System.Action ClickedToReplay;
    public System.Action ClickedToQuit;

    private void Awake()
    {
        startStateController.OnClickedStartButton += StartTheGame;
        finishStateController.OnClickedResumeButton += ResumeTheGame;
        finishStateController.OnClickedReplayButton += ReplayTheGame;
        finishStateController.OnClickedQuitButton += QuitFromGame;
    }

    public void StartTheGame()
    {
        ClickedToStart?.Invoke();
    }

    public void ResumeTheGame()
    {
        ClickedToResume?.Invoke();
    }

    public void ReplayTheGame()
    {
        ClickedToReplay?.Invoke();
    }

    public void QuitFromGame()
    {
        ClickedToQuit?.Invoke();
    }
}
