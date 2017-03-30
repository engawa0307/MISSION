using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public int minute;
    public float second;
    int second_o;


    // Use this for initialization
    void Start ()
    {
        second_o = 0;
    }
	
	void FixedUpdate()    //Fixed:処理落ち対策(チェック回数)
    {
            second += Time.deltaTime; //スタートしてからの秒数を格納

            if (second >= 60)
            {
                second -= 60;
                minute++;
            }

            if ((int)second != second_o)    //処理落ち対策(前回の秒と違う時だけ描写)
                this.GetComponent<Text>().text = minute.ToString() + ":" + second.ToString("00");

            second_o = (int)second;
    }
}
