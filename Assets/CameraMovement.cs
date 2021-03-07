using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
		Vector3 position = target.position + offset;        
		Vector3 Smooth = Vector3.Lerp(transform.position,position,smoothSpeed);
		transform.position = Smooth;
	}
    
}
