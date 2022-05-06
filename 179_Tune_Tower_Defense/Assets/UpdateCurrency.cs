using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCurrency : MonoBehaviour
{
    public int i = 0;
    public Currency currency;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currency.GetComponent<UnityEngine.UI.Text>().text = "Currency: " + i;
    }
}
