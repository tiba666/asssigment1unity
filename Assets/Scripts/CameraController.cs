using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	// Start is called before the first frame update
	public Transform target;
	public Vector3 offset;
	private float currentzoom = 10f;
	public float pitch = 2f;
	private void LateUpdate()
	{
		transform.position = target.position - offset * currentzoom;
		transform.LookAt(target.position + Vector3.up * pitch);
	}

}
