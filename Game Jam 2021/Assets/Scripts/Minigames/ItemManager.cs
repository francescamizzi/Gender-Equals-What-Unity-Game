using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private List<ItemSlot> _slotPrefabs;
    [SerializeField] private Item _itemPrefab;
    [SerializeField] private Transform _slotParent, _itemParent;
    
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        var spawnedItem = _slotPrefabs;
        var spawnedSlot = _slotParent;

        //spawnedItem.Init(spawnedSlot);
    }
}
