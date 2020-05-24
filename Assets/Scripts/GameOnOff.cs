﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SceneTestClickListener(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}