using UnityEngine;

public class NodeInputManager : MonoBehaviour {
    public GameObject nodeMenu;
    private bool isMenuVisible;
    private GameObject spawnedGameMenu;
	
    // Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject selectedGameObject = ClickSelect();
            if (selectedGameObject != null && selectedGameObject.tag == "node"){
                Debug.Log(selectedGameObject.transform.position);
                if (spawnedGameMenu!= null) {
                    Destroy(spawnedGameMenu);
                    spawnedGameMenu = null;
                }
                spawnedGameMenu = Instantiate(nodeMenu);
                Vector3 pos = selectedGameObject.transform.position;
                spawnedGameMenu.transform.position = new Vector3(pos.x, pos.y, -10) ;
                spawnedGameMenu.transform.eulerAngles = new Vector3(0f, 0f, -36f);

            }
        }
        if (spawnedGameMenu!=null && spawnedGameMenu.transform.rotation.z < 0f)
        {
            spawnedGameMenu.transform.Rotate(0,0,60 * Time.deltaTime);
        }
    }

    GameObject ClickSelect()
    {
        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            return hit.transform.gameObject;
        }
        else return null;
    }
}
