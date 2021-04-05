using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Space]
    [SerializeField]
    UIManager uiManager;

    [Space]
    [SerializeField]
    StartState startState;

    [Space]
    [SerializeField]
    FinishState finishState;

    Player player;
    GameObject playerObj;

    private void Awake()
    {
        Time.timeScale = 0;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();

        Player.GameOver += PauseTheGame;

        uiManager.ClickedToStart += StartTheGame;
        uiManager.ClickedToResume += ResumeTheGame;
        uiManager.ClickedToReplay += ReplayTheGame;
        uiManager.ClickedToQuit += QuitFromGame;
        startState.Enter();
    }

    void StartTheGame()
    {
        startState.Exit();
    }

    void PauseTheGame()
    {
        finishState.Enter();
    }
    void ResumeTheGame()
    {
        // TODO: play the ad
        player.SetEnergy();
        Debug.Log("your energy: " + player.getEnergy());
        Time.timeScale = 1;
        finishState.Exit();
    }
     void ReplayTheGame()
    {
        // do sth
        Debug.Log("CLICKED REPLY!");
    }

    void QuitFromGame()
    {
        // do sth
    }
    


}
