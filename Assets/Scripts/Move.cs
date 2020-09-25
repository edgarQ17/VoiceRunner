using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private float backwardsSpeed = -0.1f;
    private Camera cam;

    void Start()
    {
        cam = FindObjectOfType<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(backwardsSpeed, 0.0f, 0.0f);

        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);
        

        if (viewPos.x < -0.1f) {
            Destroy(this.gameObject);
        }
        
    }
}
