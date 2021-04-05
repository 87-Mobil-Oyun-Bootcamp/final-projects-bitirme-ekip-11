using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishStateController : MonoBehaviour
{
    [Space]
    [SerializeField]
    Button resumeButton;

    [Space]
    [SerializeField]
    Button replayButton;

    [Space]
    [SerializeField]
    Button quitButton;

    public System.Action OnClickedResumeButton;
    public System.Action OnClickedReplayButton;
    public System.Action OnClickedQuitButton;

    private void Awake()
    {
        resumeButton.onClick.AddListener(ResumeButtonClicked);
        replayButton.onClick.AddListener(ReplayButtonClicked);
        quitButton.onClick.AddListener(QuitButtonClicked);
    }

    void ResumeButtonClicked()
    {
        OnClickedResumeButton?.Invoke();
    }

    void ReplayButtonClicked()
    {
        OnClickedReplayButton?.Invoke();
    }

    void QuitButtonClicked()
    {
        OnClickedQuitButton?.Invoke();
    }
}
