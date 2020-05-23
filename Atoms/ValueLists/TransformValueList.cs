using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Value List of type `Transform`. Inherits from `AtomValueList&lt;Transform, TransformEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Transform", fileName = "TransformValueList")]
    public sealed class TransformValueList : AtomValueList<Transform, TransformEvent> { }
}
