using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {

    [Tooltip("The force added when the player jumps")]
    public Vector2 jumpForce = new Vector2(0, 300);

    private bool beenHit;

    //private Rigidbody2D rigibody2D;

    void Start () {
        beenHit = false;
        //rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	
	void LateUpdate () {
        if((Input.GetKeyUp("space") || Input.GetMouseButton(0)) && !beenHit)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        beenHit = true;
        GetComponent<Animator>().speed = 0.0f;
        GameController.speedModifire = 0;

        if(!gameObject.GetComponent<GameEndBehaviour>())
        {
            gameObject.AddComponent<GameEndBehaviour>();
        }
    }
}
