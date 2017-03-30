using UnityEngine;
using System.Collections;


public class StartAndStop : MonoBehaviour
{

    bool isStoping;
    public GameObject pose;
    public GameObject result;
    public GameObject ball;

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1;

        isStoping = false;
	}
	
	// Update is called once per frame

	void Update ()
    {
        if (GameObject.Find("Ball") == null && !(JudgeWinPlayer.checkWinner() > 0)) //ボールがない、かつ勝者が決まっていない
        {
            GameObject newBall = (GameObject)Instantiate(ball);
            newBall.name = ball.name;
        }

        if (JudgeWinPlayer.checkWinner() > 0)   //勝者が決まった場合1,2が入る
        {
            GameFinish();
        }
    }

    void GameFinish()
    {
        Time.timeScale = 0;
        result.SetActive(true);
    }

    public void GameStop()
    {
        if (!(JudgeWinPlayer.checkWinner() > 0))    //リザルト画面では無効
        {
            if (!isStoping)
            {
                // obj = Instantiate(ui); ポーズ画面呼び出し
                Time.timeScale = 0;
                pose.SetActive(true);
            }

            else
            {
                Time.timeScale = 1;
                pose.SetActive(false);
                //Destroy(obj);
            }
            isStoping = !isStoping;
        }
    }
}
