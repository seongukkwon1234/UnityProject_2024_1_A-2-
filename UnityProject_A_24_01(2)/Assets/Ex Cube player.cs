using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text TextUI = null;
    public int Count = 0;
    public int power = 100;
    public Rigidbody m_Rigidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Count += 1;
            TextUI.text = Count.ToString();
            power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * power);
        }
        if(gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2) 
        {
            TextUI.text = "½ÇÆÐ";
            Count = 0;

        }
    }
}
