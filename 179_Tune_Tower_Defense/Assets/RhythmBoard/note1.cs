using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note1 : MonoBehaviour
{
    public KeyCode activateNote;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(activateNote)) {
            GetComponent<Rigidbody> ().velocity = new Vector3(0,0,2.78f);
            StartCoroutine (moveCollider ()); 
        }
        
    }

    IEnumerator moveCollider() {
        yield return new WaitForSeconds(.5f);
        GetComponent<Rigidbody> ().velocity = new Vector3(0,0,-2.78f);
        yield return new WaitForSeconds(.5f);
        GetComponent<Rigidbody> ().velocity = new Vector3(0,0,0);
    }
}
