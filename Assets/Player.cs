using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 goal;
    bool moving=false;
    float moveX;
    float moveY;
    int move=0;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
           // goal=new Vector2(Input.mousePosition.x/54f-transform.position.x,Input.mousePosition.y/60f);
            moveX=(Input.mousePosition.x/54f-transform.position.x)/5f;
            moveY=(Input.mousePosition.y/54f-transform.position.y)/5f;
            move=5;
        }
        
        

    }
    void FixedUpdate(){
        if(move>0){
            transform.position+=new Vector3(moveX,moveY,0);
            move--;
            if(move==0){
                Instantiate(explosion,transform.position,transform.rotation);
            }
        }
    }

}
