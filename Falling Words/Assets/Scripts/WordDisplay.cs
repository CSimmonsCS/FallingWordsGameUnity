using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;
    //public bool reachedBottom = false;
    //public GameObject wordPrefab;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;//focus point for letter
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        //Debug.Log(transform.localPosition.y);

        /*when a text reaches the bottom of the screen,
        the background turns red and the text stops moving*/
        if(transform.localPosition.y <= -350)
        {
            Time.timeScale = 0;
            Camera.main.backgroundColor = Color.red; 
        }
    }
}

