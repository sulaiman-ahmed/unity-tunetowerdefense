using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    [SerializeField]
    private Text _title;

    public int currency = 0;
    // Start is called before the first frame update
    void Start()
    {
      _title.text = "Currency: " + currency;
    }

    public void addCurrency() {
      currency += 1;
      _title.text = "Currency: " + currency;
    }

    public void removeCurrency(int given) {
      currency -= given;
      _title.text = "Currency: " + currency;
    }

    public void removeCurrency() {
      currency -= 1;
      _title.text = "Currency: " + currency;
    }

    public int getCurrency() {
      return currency;
    }
}
