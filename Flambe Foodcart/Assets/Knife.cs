using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public AudioSource audio;
    Meat _meatScript;
    Collider2D _itemOnKnife;

    // Start is called before the first frame update
    void Start()
    {
        _itemOnKnife = null;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        _itemOnKnife = collider;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        _itemOnKnife = null;
    }

    void OnMouseDown()
    {
        if (_itemOnKnife)
        {
            audio.Play();
            if (_itemOnKnife.gameObject.name == "Meat")
            {
                _itemOnKnife.GetComponent<Meat>().chop();
            }
        }
    }

    }
