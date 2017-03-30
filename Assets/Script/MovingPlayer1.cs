using UnityEngine;
using System.Collections;

public class MovingPlayer1 : MonoBehaviour
{
        public float key;   //速さ調整

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {

            if (Input.GetKey("w") && this.transform.position.y <= 2.5)  //キー入力と壁への衝突回避
                this.transform.position += new Vector3(0, key, 0);

            else if (Input.GetKey("s") && this.transform.position.y >= -3)
                this.transform.position += new Vector3(0, -key, 0);
        }
    }
}
