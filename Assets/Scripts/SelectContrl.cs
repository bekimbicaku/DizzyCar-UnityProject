using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class SelectContrl : MonoBehaviour
{
    public GameObject square;
    public GameObject square1;
    [SerializeField] GameObject Joystick;
    [SerializeField] GameObject Buttons;

    void Awake()
    {
        if (PlayerPrefs.GetInt("Controller") == 0)
        {
            Joystick.SetActive(true);
            Buttons.SetActive(false);
        }else 
        {
            Joystick.SetActive(false);
            Buttons.SetActive(true);
        }
    }
    public void whenButtonClicked()
    {
        if (square.activeInHierarchy == true)
            square.SetActive(false);
        else
            square.SetActive(true);
    }
    public void whenJoystickClicked()
    {
        if (square.activeInHierarchy == true)
            square.SetActive(false);
        else
            square.SetActive(true);
    }
    public void UseJoystick()
    {
        PlayerPrefs.SetInt("Controller", 0);
    }
    public void UseButtons()
    {
        PlayerPrefs.SetInt("Controller", 1);
    }
}
