using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject box;
    private float firstX = 0.0f;
    private float floorLevel = -3.17f;

    private float frequency = 1.0f;
    private float timer;

    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(box, new Vector2(firstX + 20, floorLevel), Quaternion.identity);
        timer = frequency;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0.0f)
        {
            Instantiate(box, new Vector2(firstX + 20, floorLevel), Quaternion.identity);
            timer = frequency;
        }

        
    }
}
