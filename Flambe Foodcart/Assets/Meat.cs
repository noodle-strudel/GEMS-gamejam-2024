using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite _raw;
    [SerializeField] Sprite _rawChopped;
    [SerializeField] Sprite _cooked;
    [SerializeField] Sprite _kebab;
    Transform _transform;
    Vector3 _dropPosition;
    SpriteRenderer _spriteRenderer;

    GameObject _player;
    bool _isChopped;
    bool _isCooked;
    bool _isKebab;

    void Start()
    {
        _transform = GetComponent<Transform>();
        _dropPosition = _transform.position;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _player = GameObject.Find("Player");

        _isChopped = false;
        _isCooked = false;
        _isKebab = false;
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
        if (collider.gameObject.name != "FridgeFront" && collider.gameObject.name != "GreenCustomer")
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
        if (_isCooked)
        {
            Debug.Log("Already cooked! It will be burnt! (Though, perhaps that's the idea...)");
        }
        else if (_isChopped == false)
        {
            Debug.Log("Cannot cook yet! It needs to be chopped first!");
        }
        else
        {
            _spriteRenderer.sprite = _cooked;
            //_player.GetComponent<Animator>().play("dragon_fire_anim");
            _isCooked = true;
        }
    }

    public void skewer()
    {
        if (_isCooked)
        {
            _spriteRenderer.sprite = _kebab;
        }
        else
        {
            Debug.Log("It's not cooked yet!!");
        }
    }
}
