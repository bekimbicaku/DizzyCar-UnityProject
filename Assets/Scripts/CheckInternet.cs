using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        bool hasInternet = Application.internetReachability != NetworkReachability.NotReachable;
        yield return null;
        if (!hasInternet)
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
