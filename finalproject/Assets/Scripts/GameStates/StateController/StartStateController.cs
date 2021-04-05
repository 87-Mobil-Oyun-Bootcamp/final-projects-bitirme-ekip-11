using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStateController : MonoBehaviour
{

    [Space]
    [SerializeField]
    Button startButton;

    public System.Action OnClickedStartButton;

    private void Awake()
    {
        startButton.onClick.AddListener(StartButtonClicked);
    }

    void StartButtonClicked()
    {
        Debug.Log("Start Button Pressed!");
        OnClickedStartButton?.Invoke();
    }

    /*public System.Action OnSwipedToStart;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnSwipedToStart?.Invoke();
        }
    }*/
}
