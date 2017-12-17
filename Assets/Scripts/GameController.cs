using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [HideInInspector]
    public static float speedModifire;

    public GameObject obstacleReference;
    public float obstacleMinY = -1.3f;
    public float obstacleMaxY = 1.3f;

    private static Text scoreText;
    private static int score;

    public static int Score
    {
        get { return score; }
        set {
            score = value;
            scoreText.text = score.ToString();
        }
    }

    void CreateObstacle()
    {
        Instantiate(obstacleReference, 
                    new Vector3(RepeatingBackground.ScrollWidth, Random.Range(obstacleMinY, obstacleMaxY), 
                    0.0f),
                    Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
        speedModifire = 1.0f;
        //InvokeRepeating("CreateObstacle", 1.5f, 1.0f);
        gameObject.AddComponent<GameStartBehaviour>();
        score = 0;
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
