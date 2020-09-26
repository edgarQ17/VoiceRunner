using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float backwardsSpeed;
    private Camera cam;
///////player movement
 public float Speed;    ///player speed
 public Rigidbody2D rigidb;

 public float jumpForce = 20f;///default jjump

 float hx;
 
    void Start(){
        cam = FindObjectOfType<Camera>();
<<<<<<< HEAD
=======

        float scale = Mathf.Round(Random.Range(1.0f, 2.0f)); 
        transform.localScale = new Vector2(scale, 1);        
>>>>>>> 79c4d3eaef8e713afadc4389bda654a1639fd1aa
    }

    // Update is called once per frame
     
    void Update()
    {
<<<<<<< HEAD
        hx = Input.GetAxisRaw("Horizontal");

     if(Input.GetButtonDown("Jump") ){            //////this will check if grounded to allow jump
         Jump(); ///jump mthod
     }

        transform.position = transform.position + new Vector3(backwardsSpeed, 0.0f, 0.0f);

        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);
        
      //  if (viewPos.x < -0.1f) {
         //   Destroy(this.gameObject);
       /// }
=======
        transform.position = transform.position + new Vector3(backwardsSpeed / 10.0f, 0.0f, 0.0f);

        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);
        

        if (viewPos.x < -1.0f) {
            Destroy(this.gameObject);
        }
>>>>>>> 79c4d3eaef8e713afadc4389bda654a1639fd1aa
        
    }
    private void moveUpdate() {   ////player move method
     Vector2 movement = new Vector2(hx * Speed, rigidb.velocity.y );
     rigidb.velocity = movement;
}
    void Jump(){
        Vector2 movement = new Vector2(rigidb.velocity.x, jumpForce);
        rigidb.velocity = movement;
    }
}

