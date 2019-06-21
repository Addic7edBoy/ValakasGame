﻿using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    public float timer;
    public bool ispuse;
    public bool guipuse;

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape) && ispuse == false)
        {
            ispuse = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ispuse == true)
        {
            ispuse = false;
        }
        if (ispuse == true)
        {
            timer = 0;
            guipuse = true;

        }
        else if (ispuse == false)
        {
            timer = 1f;
            guipuse = false;

        }
    }
    public void OnGUI()
    {
        if (guipuse == true)
        {
            Cursor.visible = true;// включаем отображение курсора
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 150f, 150f, 45f), "Resume"))
            {
                ispuse = false;
                timer = 0;
                Cursor.visible = false;
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 100f, 150f, 45f), "Restart"))
            {
                ispuse = false;
                timer = 0;
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), 150f, 45f), "Main Menu"))
            {
                ispuse = false;
                timer = 0;
                Application.LoadLevel("Main_Menu"); // здесь при нажатии на кнопку загружается другая сцена, вы можете изменить название сцены на свое

            }
        }
    }
}