using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class hitNote : MonoBehaviour
{
    public Transform hitBurst;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "missCollider") {
            Destroy (gameObject);
            Debug.Log("Fail");
        }
        
        foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
                if(Input.GetKey(vKey)) {
                    if(vKey == KeyCode.Q && other.gameObject.name == "hitCollider1") { 
                        Debug.Log("success Q");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                    else if(vKey == KeyCode.W && other.gameObject.name == "hitCollider2") { 
                        Debug.Log("success W");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                    else if(vKey == KeyCode.E && other.gameObject.name == "hitCollider3") { 
                        Debug.Log("success E");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                    else if(vKey == KeyCode.A && other.gameObject.name == "hitCollider4") { 
                        Debug.Log("success A");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                    else if(vKey == KeyCode.S && other.gameObject.name == "hitCollider5") { 
                        Debug.Log("success S");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                    else if(vKey == KeyCode.D && other.gameObject.name == "hitCollider6") { 
                        Debug.Log("success D");
                        Destroy(gameObject);
                        Instantiate (hitBurst, transform.position, hitBurst.rotation);
                    }
                   
                }
            }

    }
}
