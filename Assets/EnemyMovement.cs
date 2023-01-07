using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public int enemyType;
    private GameObject player;
    private Vector3 targetPosition;
    private bool lunging;
    private float velocity;
    private int timer=500;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        lunging = false;
    }

    void Update() {
        if (!lunging) {
            timer--;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        switch (enemyType) {
            case 0:
                //Follows the player
                transform.Translate(Vector3.Normalize((player.transform.position - transform.position))*speed);
                break;
            case 1:
                //Lunge
                Debug.Log(lunging);
                Debug.Log("Velocity: " + velocity);
                if (!lunging) {
                    if (timer < 0) {
                    lunging = true;
                    velocity = speed*10;
                    targetPosition = player.transform.position;
                    }
                    }
                    else {
                        transform.Translate(Vector3.Normalize((targetPosition-transform.position))*velocity);
                        velocity -= 0.001f;
                        if (velocity <= 0) {
                            lunging = false;
                            timer = 500;
                        }
                    }
                break;
                }
                
                
        }
    }

