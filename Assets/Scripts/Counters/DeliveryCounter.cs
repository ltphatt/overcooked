using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryCounter : BaseCounter
{

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            if (player.GetKitchenObject().TryGetPlate(out var plateKitchenObject))
            {
                // Only acept plates
                player.GetKitchenObject().DestroySelf();
            }
        }
    }
}
