using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class hitNote : MonoBehaviour
{
    
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

        // if(other.gameObject.name == "hitCollider1" || 
        //     other.gameObject.name == "hitCollider2" ||
        //     other.gameObject.name == "hitCollider3" || 
        //     other.gameObject.name == "hitCollider4" || 
        //     other.gameObject.name == "hitCollider5" ||
        //     other.gameObject.name == "hitCollider6") {
        //     Destroy (gameObject);
        //     //Debug.Log("success");
        //     foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))){
        //         if(Input.GetKey(vKey)){
        //             //your code here
        //             Debug.Log("success " + vKey);
        //         }
        //     }
        //}

        // if(other.gameObject.name == "hitCollider1") {
        //     foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
        //         if(Input.GetKey(vKey)) {
        //             if(vKey == KeyCode.A) { 
        //                 Debug.Log("note 1 not working");
        //                 Destroy(gameObject);
        //             }
                   
        //         }
        //     }
            // if(Input.GetKeyDown(KeyCode.A)) {
            //     Destroy(gameObject);
            //     Debug.Log("success A");
            // }
       // }
        
        foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
                if(Input.GetKey(vKey)) {
                    if(vKey == KeyCode.A && other.gameObject.name == "hitCollider1") { 
                        Debug.Log("success A");
                        Destroy(gameObject);
                    }
                    else if(vKey == KeyCode.W && other.gameObject.name == "hitCollider2") { 
                        Debug.Log("success W");
                        Destroy(gameObject);
                    }
                    else if(vKey == KeyCode.S && other.gameObject.name == "hitCollider3") { 
                        Debug.Log("success S");
                        Destroy(gameObject);
                    }
                    else if(vKey == KeyCode.E && other.gameObject.name == "hitCollider4") { 
                        Debug.Log("success E");
                        Destroy(gameObject);
                    }
                    else if(vKey == KeyCode.D && other.gameObject.name == "hitCollider5") { 
                        Debug.Log("success D");
                        Destroy(gameObject);
                    }
                    else if(vKey == KeyCode.F && other.gameObject.name == "hitCollider6") { 
                        Debug.Log("success F");
                        Destroy(gameObject);
                    }
                   
                }
            }

    }
}
