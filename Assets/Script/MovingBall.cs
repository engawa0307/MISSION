using UnityEngine;
using System.Collections;


public class MovingBall : MonoBehaviour

{
    public float x, y;
    private float rand_x,rand_y;    //発射角度
	// Use this for initialization

	void Start ()
    {
        do
        {
            rand_x = Random.Range(-1, 1);
            rand_y = Random.Range(-1, 1);
        } while (rand_x == 0 || rand_y == 0);   //どちらかの発射角が0だった場合再抽選

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(x * 0.00001f * rand_x, y * 0.00001f * rand_y, 0));
    }
	
	// Update is called once per frame
	void Update ()

    {
	
	}


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DeadLine")
        {
            Destroy(gameObject);
        }
    }
}
