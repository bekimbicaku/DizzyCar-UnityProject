using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WhenWatch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenWatch()
    {
        PlayerPrefs.SetInt("NumberOfCoins", PlayerPrefs.GetInt("NumberOfCoins", 0) + 20);
    }
}
