using UnityEngine;

// Hudson Schumaker

// Will create a menuItem
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
   [TextArea(10,10)] [SerializeField] string value;
}
