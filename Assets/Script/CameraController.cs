using UnityEngine;

public class CameraController2 : MonoBehaviour {

    public float panSpeed = 20f;
    public float panBorderThickness = 60f;
    public Vector2 panLimitMax;
    public Vector2 panLimitMin;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update () {
        Vector3 pos = transform.position;
        Debug.Log(transform.position);
        if (Input.GetKey("z"))
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        pos.x = Mathf.Clamp(pos.x, -panLimitMin.x, panLimitMax.x);
        pos.y = Mathf.Clamp(pos.y, -panLimitMin.y, panLimitMin.y);

        transform.position = pos;	
	}
}
