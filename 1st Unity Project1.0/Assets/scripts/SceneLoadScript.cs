using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//скрипт запуска new scene по окончанию анимации ban

public class SceneLoadScript : MonoBehaviour
{
    public void LoadNewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("game1");
    }
}
