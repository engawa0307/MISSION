using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WinnerNumber : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
        this.GetComponent<Text>().text = " PLAYER " + JudgeWinPlayer.checkWinner().ToString() + "\nWINNER！";
    }
}
