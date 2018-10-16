using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour {

    [SerializeField] Transform target;
    public float speed = 6f;
    Vector2 targetPos;

    private void Start()
    {
        targetPos = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if ((targetPos.x >= transform.position.x))
            {
                transform.localScale = new Vector2(0.3f, 0.3f); 
            }
            else
            {
                transform.localScale = new Vector2(-0.3f, 0.3f); 
            }
            target.position = targetPos;
        }
        if ((Vector2)transform.position != targetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }
}
