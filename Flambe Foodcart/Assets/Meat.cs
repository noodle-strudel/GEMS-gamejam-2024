using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite _raw;
    [SerializeField] Sprite _rawChopped;
    [SerializeField] Sprite _cooked;
    Transform _transform;
    Vector3 _dropPosition;
    SpriteRenderer _spriteRenderer;
    bool _isChopped;
    public bool _isCooked;

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
            _spriteRenderer.sprite = _rawChopped;
            _isChopped = true;
        }

    }

    public void cook()
    {
        
    }

    public void skewer()
    {

    }
}
