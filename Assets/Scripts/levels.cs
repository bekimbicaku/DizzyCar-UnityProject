using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour
{
    [SerializeField] GameObject NextMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextMenu()
    {
        NextMenu.SetActive(true);
    }
    public void privMenu()
    {
        NextMenu.SetActive(false);
    }
}
