﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word
{
    public string word;
    private int typeIndex;

    private bool reachedBottom;


    private WordDisplay display;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
        //Debug.Log(display.transform.position.y);
    }
    

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        //then remove the letter on screen
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            //remove word on screen
            display.RemoveWord();
        }

        return wordTyped;
    }
}
