using UnityEngine;

// Hudson Schumaker
// Unity 3D
// C#

// Will create a menuItem
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // will create a textArea to better input the text
   [TextArea(10,10)] [SerializeField] string value;
}
