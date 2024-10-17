using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public int currentCarIndex;
    public GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        currentCarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in cars)
            car.SetActive(false);

        cars[currentCarIndex].SetActive(true);
    }
}
