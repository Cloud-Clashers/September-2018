﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class P1Controller_4player : MonoBehaviour
{

    bool playerIndexSet = false;
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;

    public float P1Speed = 600;

    public float P1savedSpeed;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (!playerIndexSet || !prevState.IsConnected)
        {
            for (int k = 0; k < 4; k++)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)k;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                {
                    Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                    playerIndex = testPlayerIndex;
                    playerIndexSet = true;
                    Debug.Log("Player One Index is: " + playerIndex);
                }
            }
        }

        prevState = state;
        state = GamePad.GetState(playerIndex);

        playerIndex = PlayerIndex.One;


        if (playerIndex == PlayerIndex.One)
        {

            float moveHorizontal = 0;
            float moveVertical = state.ThumbSticks.Left.Y * P1Speed * Time.deltaTime;

            this.transform.Translate(new Vector3(moveHorizontal, moveVertical, 0f));

        }

    }
}
