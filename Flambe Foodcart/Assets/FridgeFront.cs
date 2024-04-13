using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeFront : MonoBehaviour
{
    // Start is called before the first frame update

    Transform _transform;
    Vector2 _movePosition;
    Vector2 _originalPosition;
    bool isOpen;

    
    void Start()
    {
        _transform = GetComponent<Transform>();
        _originalPosition = GetComponent<Transform>().position;
        _movePosition = _transform.position + new Vector3(-2,0,0);
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Test");
        if (isOpen)
        {
            _transform.position = _originalPosition;
            isOpen = false;
        }
        else
        {
            _transform.position = _movePosition;
            isOpen = true;
        }
    }
}
