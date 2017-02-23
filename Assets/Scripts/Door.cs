using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public GameObject fromDoor;
    public GameObject toDoor;
    public bool open;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        //its player?
        if(coll.gameObject.name == "Player")
        {
            //если дверь открыта перемещаем игрока к  двери если нет то открываем если есть очки
            if(open)
            {
                coll.gameObject.transform.position = toDoor.transform.position;
            }
            else
            {
                //что то придумать с очками
                coll.gameObject.GetComponent<MovePoints>().movePoints -= 1;
                open = true;
            }
        }
    }
}
