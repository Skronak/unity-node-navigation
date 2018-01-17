using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeChoice : MonoBehaviour {
    public string nodeChoiceName;
    public Sprite nodeChoiceSprite;
    public Dialogue dialogue;

    // Use this for initialization
    void Start () {
		
	}

    /**
     * On declenche le dialogue au clic
     **/ 
    void OnMouseDown()
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
