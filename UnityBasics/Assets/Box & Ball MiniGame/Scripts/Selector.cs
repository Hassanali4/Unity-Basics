using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    public Text text;
    public GameObject Square;   
    public GameObject Ball;
    bool select = true;

    private void Update()
    {
        if (select)
        {
            Square.gameObject.SetActive(true);    
            Ball.gameObject.SetActive(false);
            text.text = "Box";
        }
        else
        {
            Ball.gameObject.SetActive(true);
            Square.gameObject.SetActive(false);    
            text.text = "Ball";
        }
    }
    public void Selection()
    {
        if (select == true)
            select = false;
        else
            select = true;
        
        Debug.Log("Value is :" + select);
    }
}
