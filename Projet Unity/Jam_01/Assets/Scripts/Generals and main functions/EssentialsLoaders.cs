﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EssentialsLoaders : MonoBehaviour
{
    //public GameObject[] objects;

    public GameObject audioManager;


    public static EssentialsLoaders instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de EssentialsLoaders dans la scène");
            return;
        }

        instance = this;

        if (AudioManager.instance == null)
        {
            Instantiate(audioManager);
        }

        /*foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        }*/
    }

    /*public void RemoveFromDontDestroyOnLoad()
    {
        foreach (var element in objects)
        {
            SceneManager.MoveGameObjectToScene(element, SceneManager.GetActiveScene());
        }
    }*/
}