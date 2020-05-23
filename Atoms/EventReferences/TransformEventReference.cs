using System;
using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Reference of type `Transform`. Inherits from `AtomEventReference&lt;Transform, TransformVariable, TransformEvent, TransformVariableInstancer, TransformEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TransformEventReference : AtomEventReference<
        Transform,
        TransformVariable,
        TransformEvent,
        TransformVariableInstancer,
        TransformEventInstancer>, IGetEvent 
    { }
}
