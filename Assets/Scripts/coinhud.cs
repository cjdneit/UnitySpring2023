using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinhud : MonoBehaviour
{
    public int coinsCollected;
    public int coinsInScene;
    public TMP_Text coinDisplay;
    public raycastScript rayscript;


    // Start is called before the first frame update
    void Start()
    {
        coinDisplay.text = $"Coins {coinsCollected}/{coinsInScene}";
    }

    public void CoinCollected()
    {
        coinsCollected++;
        coinDisplay.text = $"Coins {coinsCollected}/{coinsInScene}";
        if(coinsCollected == coinsInScene)
        {
            rayscript.canOpenDoor = true;
        }
    }

}
