﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Continue : MonoBehaviour
{
    public GameObject HoverButton;
    //public GameObject AnimFlam;
    public GameObject ClickButton;

    public GameObject HoverText;
    public GameObject ClickText;

    public static Button_Continue instance;

    public static bool Continue = false;

    public MainMenu mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        HoverButton.SetActive(false);
        HoverText.SetActive(false);
        ClickButton.SetActive(false);
        ClickText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver()
    {
        if (mainMenu.activesButtons)
        {
            /*if (MainMenu.ContinueButton)
            {
                
                Debug.Log("Mouse is over GameObject.");
                HoverButton.SetActive(true);
                HoverText.SetActive(true);
               
            }*/
        }

    }

    public void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        HoverButton.SetActive(false);
        HoverText.SetActive(false);
        //AnimFlam.GetComponent<Animator>().Play("Menu_Idle_flam");
    }

    public void OnMouseDown()
    {
        if (mainMenu.activesButtons)
        {
            /*if (MainMenu.ContinueButton)
            {
                ClickButton.SetActive(true);
                ClickText.SetActive(true);
                Continue = true;
            }*/
        }

    }

    public void OnMouseUp()
    {
        ClickButton.SetActive(false);
        ClickText.SetActive(false);
    }
}
