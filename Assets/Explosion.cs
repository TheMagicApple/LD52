using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,0.25f);
        //transform.localScale=new Vector3(1f,1f,1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.localScale=new Vector3(transform.localScale.x+0.05f,transform.localScale.y+0.05f,transform.localScale.z);
    }
}
