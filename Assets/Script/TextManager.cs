using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    public string[] textLines;

	// Use this for initialization
	void Start () {
	if (textFile!=null)
        {
            textLines = (textFile.text.Split('\n'));
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
