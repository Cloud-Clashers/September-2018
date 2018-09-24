using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterConfirm : MonoBehaviour 
{
	

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Application.loadedLevelName == "Character Select")
        {

            if (PlayerSelection.P1Ok == true && PlayerSelectionP2.P2Ok == true)
            {
                SceneManager.LoadScene("Game");
            }

        }

        if (Application.loadedLevelName == "4 Player Character Select" )
        {

            if (PlayerSelection.P1Ok == true && PlayerSelectionP2.P2Ok == true && PlayerSelectionP3.P3Ok == true && PlayerSelectionP4.P4Ok == true)
            {
                SceneManager.LoadScene("Game (Four player)");
            }

        }



	}
}
