using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    // Start is called before the first frame update
    Transform _transform;

    Vector3 _dropPosition;
    bool _isChopped;

    void Start()
    {
        _transform = GetComponent<Transform>();
        _dropPosition = _transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 desiredPosition = mousePosition;
        _transform.position = new Vector3(desiredPosition.x, desiredPosition.y, 0);
    }

    void OnMouseUp()
    {
        _transform.position = _dropPosition;
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log(collider);
        if (collider.gameObject.name != "FridgeFront")
        {
            _dropPosition = collider.gameObject.GetComponent<Transform>().position;
        }
        
    }

    public void chop()
    {
        if (_isChopped)
        {
            Debug.Log("Already chopped! No need to chop anymore!");
        }
        else
        {
            Debug.Log("Successfully chopped!");
            _isChopped = true;
        }

    }
}
