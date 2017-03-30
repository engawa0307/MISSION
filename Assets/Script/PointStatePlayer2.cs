using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointStatePlayer2 : MonoBehaviour
{
    private int point;

    void Start ()
    {
        point = 0;
	}
	
	// Update is called once per frame

	void Update ()
    {
        point = JudgeWinPlayer.checkP2();
        this.GetComponent<Text>().text = point.ToString();
    }
}
