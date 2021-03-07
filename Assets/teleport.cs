using UnityEngine;
using System;

public class teleport : MonoBehaviour
{
	public Collider2D exit_point;
	public Camera main_camera;
    public bool invert_direction = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
    	double distance = Math.Sqrt(Math.Pow(col.transform.position.x - exit_point.transform.position.x,2) + Math.Pow(col.transform.position.y - exit_point.transform.position.y,2));
        double distance_y = Math.Sqrt(Math.Pow(col.transform.position.y - exit_point.transform.position.y,2));
        Debug.Log(this.transform.position.x);
        Debug.Log(exit_point.transform.position.x);
        Debug.Log((float)distance);
        Debug.Log(col.transform.position.x - ((float)distance - (this.transform.position.x - col.transform.position.x)));
        if(invert_direction == true)
        {
            col.transform.position = new Vector3 (col.transform.position.x - ((float)distance + (this.transform.position.x - col.transform.position.x)),exit_point.transform.position.y + (float)distance_y, col.transform.position.z);
        }
        else
        {
            col.transform.position = new Vector3 (col.transform.position.x + ((float)distance - (this.transform.position.x - col.transform.position.x)),exit_point.transform.position.y + (float)distance_y, col.transform.position.z);
        }
    }
}
