using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeFront : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite _closed;
    [SerializeField] Sprite _open;

    SpriteRenderer _spriteRenderer;
    Vector2 _originalPosition;
    public AudioSource fridgeOpen;
    public AudioSource fridgeClose;
    bool isOpen;

    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isOpen)
        {
            _spriteRenderer.sprite = _closed;
            _spriteRenderer.sortingLayerName = "Player";
            isOpen = false;
            fridgeClose.Play();
        }
        else
        {
            _spriteRenderer.sprite = _open;
            _spriteRenderer.sortingLayerName = "Background";
            isOpen = true;
            fridgeOpen.Play();
        }
    }
}
