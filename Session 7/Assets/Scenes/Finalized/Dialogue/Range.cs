using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    bool interactable = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && interactable)
        {
            Dialogue dialogue = this.transform.parent.GetComponent<DialogueTrigger>().dialogue;
            this.transform.parent.GetComponent<DialogueTrigger>().TriggerDialogue(dialogue);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactable = false;
        }
    }
}
