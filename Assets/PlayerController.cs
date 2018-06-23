//adapted from example script available at
//https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	Rigidbody rb;

	public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () 
	{
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
		var turn = Quaternion.Euler(0f, rotation, 0f);
		rb.MovePosition(rb.position + this.transform.forward * translation);
		rb.MoveRotation(rb.rotation * turn);
	}
}
