using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(TaskOnClick_Button2);
        m_YourThirdButton.onClick.AddListener(TaskOnClick_Button3);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Application.LoadLevel("main_nuPogodi");
    }

    void TaskOnClick_Button2()
    {
        Debug.Log("You have clicked the button!");
        Application.LoadLevel("Flappy_Ded");
    }

    void TaskOnClick_Button3()
    {
        Debug.Log("You have clicked the button!");
        Application.LoadLevel("contra");
    }

}