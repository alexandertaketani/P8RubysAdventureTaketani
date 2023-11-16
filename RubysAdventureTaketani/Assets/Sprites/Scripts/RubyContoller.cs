using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyContoller : MonoBehaviour
{
    public int maxHealth = 5;
    int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
    }
}
