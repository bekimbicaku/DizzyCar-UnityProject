using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] GameObject NextLevel;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            NextLevel.SetActive(true);
        }
        
    }
}
