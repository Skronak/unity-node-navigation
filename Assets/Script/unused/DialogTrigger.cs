using UnityEngine;

public class DialogTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }
}
