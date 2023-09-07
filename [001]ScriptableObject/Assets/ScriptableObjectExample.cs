using Practice.ScriptableObject001;
using UnityEngine;
//Add menu
[CreateAssetMenu(fileName = "ScriptableObjectExample", menuName = "ScriptableObject/ScriptableObjectExample")]
public class ScriptableObjectExample : ScriptableObject //Inherit scriptable object
{
    public TestClass[] TestVariable;//Variable that contains data
}