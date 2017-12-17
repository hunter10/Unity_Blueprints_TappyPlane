using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBehaviour : MonoBehaviour {

    private GameObject player;

	void Start () {
        player = GameObject.Find("Plane");
        player.GetComponent<Rigidbody2D>().isKinematic = true;
	}
	
	void Update () {
        if((Input.GetKeyUp("space") || Input.GetMouseButtonDown(0)))
        {
            GameController controller = GetComponent<GameController>();
            controller.InvokeRepeating("CreateObstacle", 1f, 1.5f);

            player.GetComponent<Rigidbody2D>().isKinematic = false;
            Destroy(this);
        }
	}
}
