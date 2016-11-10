using UnityEngine;
using System.Collections;

public enum GameState
{
    menu,
    inGame,
    gameOver,
    win
}

public class GameManager : MonoBehaviour
{
    // Variables for UI stuff. 
    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas gameOverCanvas;
    public Canvas winCanvas;

    public static GameManager instance;
    public GameState currentGameState = GameState.menu;

    void Awake()
    {
        instance = this;
    }

    // When playing. 
    public void StartGame()
    {
        //SetGameState(GameState.inGame);
    }

    // Call when player loses. 
    public void GameOver()
    {
        // SetGameState(GameState.gameOver);
        Debug.Log("Stop game");
    }

    // Call when player wins. 
    public void Win()
    {
        //SetGameState(GameState.win);
        // Idk if we'll use this depends on UI. 
    }

    // Go back to menu. 
    public void BackToMenu()
    {
        //SetGameState(GameState.menu);
    }

    // Sets game state... 
    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //setup Unity scene for menu state
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
            winCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            gameOverCanvas.enabled = false;
            winCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver)
        {
            //setup Unity scene for gameOver state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = true;
            winCanvas.enabled = false;
        }
        else if (newGameState == GameState.win)
        {
            //setup Unity scene for win state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
            winCanvas.enabled = true;
        }

        currentGameState = newGameState;
    }

}