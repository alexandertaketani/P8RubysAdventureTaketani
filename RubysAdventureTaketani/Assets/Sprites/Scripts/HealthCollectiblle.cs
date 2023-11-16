using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectiblle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyContoller controller = other.GetComponent<RubyContoller>();

        if (controller != null )
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}