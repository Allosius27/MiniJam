﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Quit : MonoBehaviour
{
    public GameObject HoverButton;
    //public GameObject AnimFlam;
    public GameObject ClickButton;

    public GameObject HoverText;
    public GameObject ClickText;

    public static Button_Quit instance;

    public static bool Quit = false;

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
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (mainMenu.activesButtons)
        {
            Debug.Log("Mouse is over GameObject.");
            HoverButton.SetActive(true);
            HoverText.SetActive(true);
            //AnimFlam.GetComponent<Animator>().Play("Menu_Anim_flam");
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
            ClickButton.SetActive(true);
            ClickText.SetActive(true);
            Quit = true;
        }
    }

    public void OnMouseUp()
    {
        ClickButton.SetActive(false);
        ClickText.SetActive(false);
    }
}