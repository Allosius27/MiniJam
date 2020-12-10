using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public string SampleScene;
    public string TitleScreen;

    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        //Cursor.SetCursor(null, hotSpot, cursorMode);

        //AudioManager.instance.PlayBGM(1);
    }

    public void RetryButton()
    {
        // Relancer le niveau
        SceneManager.LoadScene(SampleScene);
        // Recharge la scène
        // Replacer le joueur au spawn
        // Réactiver les mouvements du joueurs et lui rendre sa vie
    }

    public void MainMenuButton()
    {
        //EssentialsLoaders.instance.RemoveFromDontDestroyOnLoad();
        // Retourner au menu principal
        SceneManager.LoadScene(TitleScreen);
    }
}
