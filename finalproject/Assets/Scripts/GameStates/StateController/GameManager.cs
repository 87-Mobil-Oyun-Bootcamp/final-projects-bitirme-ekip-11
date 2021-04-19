using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public static event System.Action showTotalScore;

    private void Awake()
    {
        Time.timeScale = 0;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();

        Player.GameOver += PauseTheGame;
        Player.GameOver += ShowScore;

        uiManager.ClickedToStart += StartTheGame;
        uiManager.ClickedToResume += ResumeTheGame;
        uiManager.ClickedToReplay += ReplayTheGame;
        uiManager.ClickedToQuit += QuitFromGame;

        if (PlayerPrefs.GetInt("isReplayed") == 0)
        {
            startState.Enter();
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    void StartTheGame()
    {
        startState.Exit();
    }

    void PauseTheGame()
    {
        finishState.Enter();
    }

    void ShowScore()
    {
        showTotalScore?.Invoke();
    }

    void ResumeTheGame()
    {
        // TODO: play the ad
        player.SetEnergy();
        Time.timeScale = 1;
        finishState.Exit();
    }

     void ReplayTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("isReplayed", 1);
    }

    void QuitFromGame()
    {
        Application.Quit();
        PlayerPrefs.SetInt("isReplayed", 0);
    }
}
