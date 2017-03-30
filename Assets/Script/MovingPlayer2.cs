using UnityEngine;
using System.Collections;

public class MovingPlayer2 : MonoBehaviour

{
    public float key;   //速さ調整
	
	void Update ()
    {
        if (Time.timeScale > 0)
        {
            if (Input.GetKey("i") && this.transform.position.y <= 2.5)  //キー入力と壁への衝突回避
                this.transform.position += new Vector3(0, key, 0);

            else if (Input.GetKey("k") && this.transform.position.y >= -3)
                this.transform.position += new Vector3(0, -key, 0);
        }
    }

}
