using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickUpClip, _dropClip;

    private bool _dragging;

    private Vector2 _offset, _originalPosition;

    private ItemSlot _slot;

    public void Init(ItemSlot _item)
    {
        _renderer.sprite = _item.Renderer.sprite;
        var item = _item;
    }

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        if(!_dragging)
        {
            return;
        }

        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;
    }

    void OnMouseDown()
    {
        _dragging = true;
        _source.PlayOneShot(_pickUpClip);

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        transform.position = _originalPosition;
        _dragging = false;
        _source.PlayOneShot(_dropClip);
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
