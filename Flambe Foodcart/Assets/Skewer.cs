using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skewer : MonoBehaviour
{
    // Start is called before the first frame update
    Transform _transform;
    Vector3 _dropPosition;
    SpriteRenderer _spriteRenderer;

    void Start()
    {
        _transform = GetComponent<Transform>();
        _dropPosition = _transform.position;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        _spriteRenderer.sortingLayerName = "OnPlate";
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
        if (collider.gameObject.name == "Meat")
        {
            if (collider.gameObject.GetComponent<Meat>()._isCooked)
            {
                Debug.Log("Kebab now exists!");
            }
            
        }
        
    }
}
