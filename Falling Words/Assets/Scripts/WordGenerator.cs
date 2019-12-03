using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "cut", "jeans", "gamy", "war", "perpetual", "mark", "mask", "righteous", "tease", "head", "massive",
                                         "carry", "jellyfish", "grade", "humdrum", "boat", "peel", "obsolete", "various", "ask", "majestic",
                                        "straight", "mountainous", "harass", "fill", "whispering", "cellar", "discovery", "excellent",
                                        "competition", "coast", "multiply", "enthusiastic", "mug", "green", "elated", "pegal", "winter",
                                        "deep", "cruel", "shaky", "time", "sharp", "sprout"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);

        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
