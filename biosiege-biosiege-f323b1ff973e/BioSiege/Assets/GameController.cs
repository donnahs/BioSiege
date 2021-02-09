using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private static GameController instance;// this is the singleton for the game-controller class

    public GameObject[] StarterUnits;

    public static GameController Instance()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
