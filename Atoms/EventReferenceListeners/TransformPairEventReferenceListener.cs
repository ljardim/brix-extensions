using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Reference Listener of type `TransformPair`. Inherits from `AtomEventReferenceListener&lt;TransformPair, TransformPairEvent, TransformPairEventReference, TransformPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TransformPair Event Reference Listener")]
    public sealed class TransformPairEventReferenceListener : AtomEventReferenceListener<
        TransformPair,
        TransformPairEvent,
        TransformPairEventReference,
        TransformPairUnityEvent>
    { }
}
