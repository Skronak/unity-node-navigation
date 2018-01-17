using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Template de node reutilisable
* a initialiser 
**/
[CreateAssetMenu(fileName = "New Node", menuName = "Node")]
public class Node : ScriptableObject {

    public string nodeName;
    public Sprite artworkSprite;

}
