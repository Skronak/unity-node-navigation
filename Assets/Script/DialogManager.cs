using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    private Queue<string> sentences;
    public Text titleText;
    public Text dialogueText;
    public Animator animator;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
    }
	
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        titleText.text = dialogue.title;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplaynextSentence();
    }

    public void DisplaynextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        // Depile 
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    // Lance sous routine pour faire apparaitre text lettre par lettre
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
