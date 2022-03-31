using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxController : MonoBehaviour
{
    static int bullet = 30;
    static int money = 0;
    [SerializeField] TextMeshProUGUI bulletText;
    [SerializeField] TextMeshProUGUI moneyText;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        bulletText.text = bullet + "";
        moneyText.text = "$" + money;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        bullet = bullet - 1;
        money = money + 500;
        bulletText.text = bullet + "";
        moneyText.text = "$" + money;
        Destroy(image);
        Destroy(gameObject);
    }
}
