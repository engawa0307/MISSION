using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointStatePlayer1 : MonoBehaviour
{
    private int point;

    void Start ()
    {
        point = 0;
	}

	void Update ()
    {
       point = JudgeWinPlayer.checkP1();
        this.GetComponent<Text>().text =point.ToString();
    }
}
