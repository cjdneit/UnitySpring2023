using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupitem : MonoBehaviour
{
    coinhud coinDisplay;

    private void Awake()
    {
        coinDisplay = GameObject.Find("coinDisplay").GetComponent<coinhud>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1.5f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            coinDisplay.CoinCollected();
            Destroy(gameObject);
            Debug.Log("collected");
        }
    }
}
