using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate()
	{

		if (Input.GetMouseButtonDown (0)) {
			//刚体操作要在fixedupdate中进行操作
			rigidbody.AddForce(new Vector2(200f,300f));
		}

	}

	/// <summary>
	/// 碰撞
	/// </summary>
	/// <param name="col"></param>
	void OnCollisionEnter2D(Collision2D col)
	{
		 if (col.collider) {
				
			print(1);
		}

	}
}
