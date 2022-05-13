using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.Find("cat").GetComponent<Transform>();  
            
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 player = cat.position;
        transform.position = new Vector3(transform.position.x, player.y, transform.position.z);
    }
}
