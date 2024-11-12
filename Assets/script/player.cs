using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    

    // Update is called once per frame
    void Update()
    {   
        // 키보드로 상하좌우 이동
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("ertical");
        // Vector3 moveTo = new Vector3(horizontalInput, 0f, 0f);
        // transform.position += moveTo*moveSpeed*Time.deltaTime;
    
        // 키보드로 제어하기    
        // Vector3 moveTo = new Vector3(moveSpeed*Time.deltaTime, 0, 0);
        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.position -= moveTo;
        // }    else if (Input.GetKey(KeyCode.RightArrow)) {
        //     transform.position += moveTo;
        
        // 마우스 위치로 제어하기
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float tox = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);
        transform.position = new Vector3(tox, transform.position.y, transform.position.z);
    }
}

