using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Is vowel or consonant

    public string letter;
    private bool isVowel = true;
    private bool isConsonant;
    
    private void isVowelorConsonant()
    {
        if(letter == "a" || letter == "e"|| letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log(isVowel);
        }
        else
        {
            Debug.Log(isConsonant);
        }
    }

    private void Start()
    {
        isVowelorConsonant();
    }
}
