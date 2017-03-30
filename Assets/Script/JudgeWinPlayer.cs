using UnityEngine;
using System.Collections;


public class JudgeWinPlayer : MonoBehaviour

{
    
    private static bool winFlag;
    private static int winner;
    private static int p1;
    private static int p2;

	// Use this for initialization

	void Start ()
    {

        p1 = 0;
        p2 = 0;
        winner = 0;
       winFlag = false;

	}

    public static bool checkWinFlag() { return winFlag; }
    public static int checkWinner() { return winner; }
    public static int checkP1() { return p1; }
    public static int checkP2() { return p2; }

    //ポイント処理
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (this.name == "DeadLine_P1")
                p2++;


            else if (this.name == "DeadLine_P2")
                p1++;
        }

        if(p1 >= 11 || p2 >= 11)    //勝者が決まったらゲームエンド処理
            winner = judgeWinner();

        
    }

    //勝者のナンバーを返す
    int judgeWinner()
    {
            if(p1 >= 11)
                return 1;

            else if(p2 >= 11)
                return 2;

        return 0;

	}
}
