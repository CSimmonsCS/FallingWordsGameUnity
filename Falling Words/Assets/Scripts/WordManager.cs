﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    //gameObject.SetActive(false);

    //private void Start()
    //{
    //    AddWord();
    //    AddWord();
    //    AddWord();
    //}

    public void AddWord()
    {

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            //Check if letter was next
                //Remove it from word

            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }


        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
