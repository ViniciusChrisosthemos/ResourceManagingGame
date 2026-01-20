using UnityEngine;

[CreateAssetMenu(fileName = "Resource_", menuName = "ScriptableObjects/Game/Resource")]
public class ResourceSO : ScriptableObject
{
    public enum ResourceType
    {
        Wood,
        Stone,
        Food,
        Gold,
        Steel,
        Population
    }

    [SerializeField] private string _resourceName;
    [SerializeField] private ResourceType _resourceType;
    [SerializeField] private Sprite _icon;

    public string ResourceName => _resourceName;
    public ResourceType Type => _resourceType;
    public Sprite Icon => _icon;
}
