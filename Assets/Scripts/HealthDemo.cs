using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthDemo : MonoBehaviour {

    //public int health;
    /*
    public float speed;
    public RectTransform healthTransform;
    private float changedY;
    private float minXValue;
    private float maxXValue;
    private int currentHealth;
    public int maxHealth;
    public Text healthText;
    public Image visualHealth;
    private bool onCD;
    public float coolDown;

    private int CurrentHealth
    {
        get{return currentHealth;}
        set
        {
            currentHealth = value;
            HandleHeath();
        }
    }

    IEnumerator CoolDownDmg()
    {
        onCD = true;
        yield return new WaitForSeconds(coolDown);
        onCD = false;
    }

	// Use this for initialization
	void Start () {
        changedY = healthTransform.position.y;
        maxXValue = healthTransform.position.x;
        minXValue = healthTransform.position.x - healthTransform.rect.width;
        currentHealth = maxHealth;
	}

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (!onCD && currentHealth > 0)
            {
                StartCoroutine(CoolDownDmg());
                CurrentHealth -= 1;
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (!onCD && currentHealth > 0)
            {
                StartCoroutine(CoolDownDmg());
                CurrentHealth += 1;
            }
        }
    }

    private void HandleHeath()
    {
        healthText.text = "Health " + currentHealth;
        float currentXValues = MapValues(currentHealth, 0, maxHealth, minXValue, maxXValue);
        healthTransform.position = new Vector3(currentXValues,changedY);

    }

    

    private float MapValues(float x,float inMin,float inMax,float outMin,float outmax)
    {
        return (x - inMin) * (outmax - outMin) / (inMax - inMin) + outMin;
    }
    //шилина изображения деленая на количество хп равно 1 процент хп в пикселях
    //при уроне уменьшаем изображение на 1 процент в пикселях и сдвигаем на столько же
     */
}
