using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillet : MonoBehaviour
{

    public AudioSource fire;
    Meat _meatScript;

    Collider2D _itemOnSkillet;
    // Start is called before the first frame update
    void Start()
    {
        _itemOnSkillet = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        _itemOnSkillet = collider;
    }

    void OnMouseDown()
    {
        if (_itemOnSkillet)
        {
            if (_itemOnSkillet.gameObject.name == "Meat")
            {
                fire.Play();
                _itemOnSkillet.GetComponent<Meat>().cook();
            }
        }
    }
}
