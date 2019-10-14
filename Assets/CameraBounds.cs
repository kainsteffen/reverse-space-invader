using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public float boundWidth;
    public GameObject top;  
    public GameObject right;
    public GameObject bottom;
    public GameObject left;
     
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = Camera.main;
        float cameraHeight = camera.orthographicSize;
        float cameraWidth = camera.aspect * cameraHeight;

        top.transform.localScale = new Vector2(cameraWidth * 2, boundWidth);
        top.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y + cameraHeight);

        right.transform.localScale = new Vector2(boundWidth, cameraHeight * 2);
        right.transform.position = new Vector2(camera.transform.position.x + cameraWidth, camera.transform.position.y);

        bottom.transform.localScale = new Vector2(cameraWidth * 2, boundWidth);
        bottom.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y - cameraHeight);

        left.transform.localScale = new Vector2(boundWidth, cameraHeight * 2);
        left.transform.position = new Vector2(camera.transform.position.x - cameraWidth, camera.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
