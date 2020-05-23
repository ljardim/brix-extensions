using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event of type `TransformPair`. Inherits from `AtomEvent&lt;TransformPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TransformPair", fileName = "TransformPairEvent")]
    public sealed class TransformPairEvent : AtomEvent<TransformPair> { }
}
