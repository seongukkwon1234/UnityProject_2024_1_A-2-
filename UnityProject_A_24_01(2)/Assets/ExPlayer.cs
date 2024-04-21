using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null;
    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            Hp -= 10;
            if(Hp <= 0)              //체력 0 이하되면 오브젝트 파괴
            {
                Destroy(gameObject); //게임오브젝트는 스크립트가 붙어있는 오브젝트 지칭
            }

        } 
    }
}
