using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explayer : MonoBehaviour
{
    public Text TextUI = null;
    public float Power = 100.0f;
    public Rigidbody m_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            m_Rigidbody.AddForce(transform.up * Power);
           
        }
        
    }
}
