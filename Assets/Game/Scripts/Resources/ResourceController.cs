using System.Collections.Generic;
using UnityEngine;
using static ResourceSO;

public class ResourceController
{
    private Dictionary<ResourceType, ResourceHolder> _resources;

    public ResourceController(List<ResourceHolder> resources)
    {
        _resources = new Dictionary<ResourceType, ResourceHolder>();
        
        foreach (var resourceHolder in resources)
        {
            _resources[resourceHolder.Resource.Type] = resourceHolder;
        }
    }
}
