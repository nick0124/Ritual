using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

    public GameObject gameObj;
    public float moveSpeed;
    private Transform currentPoint;
    public Transform[] points;
    private int pointSelection;
    public bool parentCollideObj;
    //public bool onceWork;
    public bool activate;
    //public Trigger trigger;

    // Use this for initialization
    void Start()
    {
        currentPoint = points[pointSelection];
    }

    void FixedUpdate()
    {

        //if (trigger != null && trigger.detect == true)
        //    activate = true;

        //движение объекта
        if (activate)
            gameObj.transform.position = Vector3.MoveTowards(gameObj.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

        //смена точки в которую движемся
        if (gameObj.transform.position == currentPoint.position)
        {
            pointSelection++;
            if (pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (parentCollideObj)
            coll.transform.parent = gameObj.transform;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (parentCollideObj)
            coll.transform.parent = null;
    }
}
