using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note2 : MonoBehaviour
{
    public KeyCode activateNote2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(activateNote2)) {
            GetComponent<Rigidbody> ().velocity = new Vector3(0,0,4);
            StartCoroutine (moveCollider ()); 
            Debug.Log("W");
        }
        
    }

    IEnumerator moveCollider() {
        yield return new WaitForSeconds(.5f);
        GetComponent<Rigidbody> ().velocity = new Vector3(0,0,-4);
        yield return new WaitForSeconds(.5f);
       // GetComponent<Rigidbody> ().velocity = new Vector3(0,0,0);
    }
}
