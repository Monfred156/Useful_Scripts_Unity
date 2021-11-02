using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private Dictionary<Collectible.Type, int> _inventory = new Dictionary<Collectible.Type, int>();

    private InventoryDisplay _inventoryDisplay;
    // Start is called before the first frame update
    void Start()
    {
        _inventoryDisplay = GetComponent<InventoryDisplay>();
        _inventoryDisplay.OnChangeInventory(_inventory);
    }

    public Dictionary<Collectible.Type, int> GetInventory()
    {
        return _inventory;
    }

    public void Add(Collectible item)
    {
        Collectible.Type type = item.type;
        int oldTotal = 0;

        if (_inventory.TryGetValue(type, out oldTotal))
        {
            _inventory[type] = oldTotal + 1;
        }
        else
        {
            _inventory.Add(type, 1);
        }

        _inventoryDisplay.OnChangeInventory(_inventory);
    }
}