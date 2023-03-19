using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    Queue<string> sentences;

    public Text nameText;
    public Text dialogueText;
    public Button nextButton;
    public Image portrait;

    public GameObject dialogueUI;

    void Start()
    {
        sentences = new Queue<string>();
        dialogueUI.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        dialogueUI.SetActive(true);
        nameText.text = dialogue.name;
        portrait.sprite = dialogue.portrait;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        dialogueText.text = sentences.Dequeue();
    }

    public void EndDialogue()
    {
        dialogueUI.SetActive(false);
    }
}
