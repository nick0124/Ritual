using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject camera;
    public GameObject player;
    public float deltaX;
    public float deltaY;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        camera.transform.position = new Vector3(player.transform.position.x+deltaX, 
                                                player.transform.position.y+deltaY, 
                                                camera.transform.position.z);
	}
}
