using System;
using UnityEngine.Events;
using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// None generic Unity Event of type `Transform`. Inherits from `UnityEvent&lt;Transform&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TransformUnityEvent : UnityEvent<Transform> { }
}
