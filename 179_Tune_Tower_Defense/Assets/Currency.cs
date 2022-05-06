using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{

    public int currency = 0;
    public Text message;
    // Start is called before the first frame update
    void Start()
    {
      message.text = "Currency: " + currency;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
