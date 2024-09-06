using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    public void SetClearCounter(ClearCounter _clearCounter)
    {
        // Clear kitchen object from old counter
        if (clearCounter != null)
        {
            clearCounter.ClearKitchenObject();
        }

        // Add new clear counter
        clearCounter = _clearCounter;
        if (_clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter has already kitchen object!");
        }
        _clearCounter.SetKitchenObject(this);

        // Update visual
        transform.parent = clearCounter.GetCounterTopPoint();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}
