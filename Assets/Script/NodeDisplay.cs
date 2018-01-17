using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Objet a afficher initialisé depuis un node
public class NodeDisplay : MonoBehaviour {
    public Node node;
    private Sprite artworkSprite;

	// Use this for initialization
	void Start () {
        artworkSprite = node.artworkSprite;
	}
}
