using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialogue2Manager : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int index = 0;
    public float DialogueSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
    }

    void NextSentence()
    {
        if(index <= Sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
    }

    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[index].ToCharArray())
        {
            DialogueText.text += Character; 
            yield return new WaitForSeconds(DialogueSpeed);
        }
        index++;
    }
}
