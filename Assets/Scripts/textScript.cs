using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    public static int totalCoins = 0;
    public static string coins = "Coins:";
    public static int coinValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = coins + totalCoins;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = coins + totalCoins;
    }
    public void CollectCoins()
    {
        totalCoins += coinValue;
    }
}
