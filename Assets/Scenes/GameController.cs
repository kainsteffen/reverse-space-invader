using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public int gameScore;

    public GameObject player;

    public Vector3 playerSpawnPos;

    private enum State
    {
        INGAME,
        GAMEOVER
    }

    private State gameState;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    // Use this for initialization
    void Start ()
    {
        gameState = State.INGAME;
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
}
