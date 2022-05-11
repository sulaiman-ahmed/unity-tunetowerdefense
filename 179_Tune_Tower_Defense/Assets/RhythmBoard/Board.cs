using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    List <float> NoteOrder = new List <float> () {1, 3, 4, 6, 1, 2, 5, 5, 6, 2, 4, 3, 5, 1, 5, 2, 4};
    //List <float> NoteOrder = new List <float> () {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
    // Start is called before the first frame update
    public Transform noteObj;
    public int notePos = 0;
    public string timerStart = "y";
    public float xpos = 0; 

    IEnumerator spawn() {
        yield return new WaitForSeconds(1);
        if(NoteOrder[notePos] == 1) {
            xpos = -98.83f;
        }

        if(NoteOrder[notePos] == 2) {
            xpos = -92.28f;
        }

        if(NoteOrder[notePos] == 3) {
            xpos = -85.19f;
        }

        if(NoteOrder[notePos] == 4) {
            xpos = -78.39f;
        }

        if(NoteOrder[notePos] == 5) {
            xpos = -71.4f;
        }

        if(NoteOrder[notePos] == 6) {
            xpos = -64.64f;
        }

        if(notePos < NoteOrder.Count) {
            notePos += 1; 
        }
        timerStart = "y";
        //Instantiate (noteObj, new Vector3 (xpos, -3.44f, 7.27f), noteObj.rotation);     
        Instantiate (noteObj, new Vector3 (xpos, 13f, 65.6f), noteObj.rotation); 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerStart == "y") {
            StartCoroutine (spawn());
            timerStart = "n";
        }
       // Debug.Log("notes");
        
    }
}
