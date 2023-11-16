using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyContoller controller = other.GetComponent<RubyContoller>();

        if (controller != null)
        {
           controller.ChangeHealth(-1);
        }
    }
}
