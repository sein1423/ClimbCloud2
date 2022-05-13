using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cat.position = new Vector3(-0.5f, 16.5f, 0f);
    }
}
