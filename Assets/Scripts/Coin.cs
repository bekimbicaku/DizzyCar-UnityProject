using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0, 0, 40 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CarScript.numberOfCoins++;
            PlayerPrefs.SetInt("NumberOfCoins", CarScript.numberOfCoins);
            //Add 1 to points;
            Destroy(gameObject); // This destroys things;
        }
    }
}
