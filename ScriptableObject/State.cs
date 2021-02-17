using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
   [TextArea(10,10)] [SerializeField] string value;
}
