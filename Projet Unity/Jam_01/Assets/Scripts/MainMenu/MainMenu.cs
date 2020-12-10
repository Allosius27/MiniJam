using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public static MainMenu instance;

    //public GameObject continueButton;
    public static bool ContinueButton;

    public string loadGameScene;

    public GameObject SettingsMenu;
    public bool activeSettings;
    public bool activesButtons = true;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayBGM(0);

        Cursor.SetCursor(null, hotSpot, cursorMode);

        if (PlayerPrefs.HasKey("Current_Scene"))
        {
            ContinueButton = true;
        }
        else
        {
            ContinueButton = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Button_NewGame.NewGame == true)
        {
            NewGame();
        }

        /*if (Button_Continue.Continue == true)
        {
            Continue();
        }*/

        if (Button_Options.Options == true)
        {
            Options();
        }

        if (Button_Quit.Quit == true)
        {
            Exit();
        }
    }

    /*public void Continue()
    {
        SceneManager.LoadScene(loadGameScene);
        Button_Continue.Continue = false;
    }*/

    public void NewGame()
    {
        StartCoroutine(LoadAsynchronously(newGameScene));

    }

    IEnumerator LoadAsynchronously(string SceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        Button_NewGame.NewGame = false;

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }

    public void Options()
    {
        Debug.Log("Launch Menu Options");
        SettingsMenu.SetActive(true);
        activesButtons = false;
        activeSettings = true;
        Button_Options.Options = false;
    }

    public void Exit()
    {
        Application.Quit();
        Button_Quit.Quit = false;
    }
}

