using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CheckInternet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI loadingText;
    [SerializeField] GameObject TryAgain;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckInternetConnection());
    }

    IEnumerator CheckInternetConnection()
    {
        UnityWebRequest request = new UnityWebRequest("http://google.com");
        yield return request.SendWebRequest();

        if(request.error != null)
        {
            loadingText.gameObject.SetActive(true);
            TryAgain.gameObject.SetActive(true);

        }
        else
        {
            loadingText.gameObject.SetActive(false);
            TryAgain.gameObject.SetActive(false);

        }
    }
    public void GoAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
