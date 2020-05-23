using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Constant of type `Transform`. Inherits from `AtomBaseVariable&lt;Transform&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Transform", fileName = "TransformConstant")]
    public sealed class TransformConstant : AtomBaseVariable<Transform> { }
}
