using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovePoints : MonoBehaviour {

    public int movePoints;
    public Image[] points;
    public Sprite activeSprite;
    public Sprite passiveSprite;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < points.Length; i++)
        {
            points[i].sprite = activeSprite;
        }
        movePoints = points.Length;
	}
	
	// Update is called once per frame
	void Update () {
        UpdatePoints();
	}

    //обновляем очки действия
    public void UpdatePoints()
    {
        for (int i = 0; i < points.Length; i++)
        {
            if(i>=movePoints)
            {
                points[i].sprite = passiveSprite;
            }
            else
            {
                points[i].sprite = activeSprite;
            }
        }
    }
}
