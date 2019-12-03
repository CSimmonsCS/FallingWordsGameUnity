using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;

    // Update is called once per frame
    void Update()
    {
        //returns keyboard input entered this frame
        foreach( char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
