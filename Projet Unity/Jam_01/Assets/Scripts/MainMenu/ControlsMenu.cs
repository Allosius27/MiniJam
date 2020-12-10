﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsMenu : MonoBehaviour
{
    public SettingsMenu settingsMenu;

    public GameObject Settings;

    public Button generalCommandsButton;
    public GameObject generalsCommands;
    public GameObject generalsCommandsHoverText;

    //public GameObject zorCommands;
    //public GameObject zorCommandsHoverText;

    //public GameObject salamanderCommands;
    //public GameObject salamanderCommandsHoverText;

    //public GameObject earthSpiritCommands;
    //public GameObject earthSpiritCommandsHoverText;

    // Start is called before the first frame update
    void Start()
    {
        //GeneralsControls();
    }

    // Update is called once per frame
    void Update()
    {
        if(settingsMenu.windowControls == true)
        {
            settingsMenu.windowControls = false;
            settingsMenu.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitSettings();
        }
    }

    /*public void GeneralsControls()
    {
        generalCommandsButton.Select();

        generalsCommands.SetActive(true);
        generalsCommandsHoverText.SetActive(true);
        //zorCommands.SetActive(false);
        //zorCommandsHoverText.SetActive(false);
        //salamanderCommands.SetActive(false);
        //salamanderCommandsHoverText.SetActive(false);
        //earthSpiritCommands.SetActive(false);
        //earthSpiritCommandsHoverText.SetActive(false);
    }*/

    /*public void ZorControls()
    {
        generalsCommands.SetActive(false);
        generalsCommandsHoverText.SetActive(false);
        zorCommands.SetActive(true);
        zorCommandsHoverText.SetActive(true);
        salamanderCommands.SetActive(false);
        salamanderCommandsHoverText.SetActive(false);
        earthSpiritCommands.SetActive(false);
        earthSpiritCommandsHoverText.SetActive(false);
    }*/

    /*public void SalamanderControls()
    {
        generalsCommands.SetActive(false);
        generalsCommandsHoverText.SetActive(false);
        zorCommands.SetActive(false);
        zorCommandsHoverText.SetActive(false);
        salamanderCommands.SetActive(true);
        salamanderCommandsHoverText.SetActive(true);
        earthSpiritCommands.SetActive(false);
        earthSpiritCommandsHoverText.SetActive(false);
    }*/

    /*public void EarthSpiritControls()
    {
        generalsCommands.SetActive(false);
        generalsCommandsHoverText.SetActive(false);
        zorCommands.SetActive(false);
        zorCommandsHoverText.SetActive(false);
        salamanderCommands.SetActive(false);
        salamanderCommandsHoverText.SetActive(false);
        earthSpiritCommands.SetActive(true);
        earthSpiritCommandsHoverText.SetActive(true);
    }*/

    public void ExitSettings()
    {
        settingsMenu.enabled = true;
        //GeneralsControls();
        gameObject.SetActive(false);
        settingsMenu.ExitSettings();
    }

    public void Return()
    {
        settingsMenu.enabled = true;
        //GeneralsControls();
        gameObject.SetActive(false);
    }
}
