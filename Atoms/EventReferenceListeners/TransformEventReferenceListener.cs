using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Reference Listener of type `Transform`. Inherits from `AtomEventReferenceListener&lt;Transform, TransformEvent, TransformEventReference, TransformUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Transform Event Reference Listener")]
    public sealed class TransformEventReferenceListener : AtomEventReferenceListener<
        Transform,
        TransformEvent,
        TransformEventReference,
        TransformUnityEvent>
    { }
}
