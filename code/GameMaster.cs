//game master to kill the player, show the gameover UI and finish UI, pause game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //vars
    public static GameMaster gm;
    [SerializeField] private GameObject GameoverUI;
    public GameObject winUI;

    void Start()
    {
        //find the game object with tag Gamemaster
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("Gamemaster").GetComponent<GameMaster>();
        }
    }
    //show the GameOverUI when player die
    public void Gameover()
    {
        GameoverUI.SetActive(true);
    }

    //kill the player
    public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
        gm.PauseGame();
        gm.Gameover();
    }

    //show the WinUI when the player complete the level
    public void End()
    {
        winUI.SetActive(true);
    }
    //pause game
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}