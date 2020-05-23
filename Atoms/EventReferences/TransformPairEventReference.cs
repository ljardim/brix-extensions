using System;
using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Reference of type `TransformPair`. Inherits from `AtomEventReference&lt;TransformPair, TransformVariable, TransformPairEvent, TransformVariableInstancer, TransformPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TransformPairEventReference : AtomEventReference<
        TransformPair,
        TransformVariable,
        TransformPairEvent,
        TransformVariableInstancer,
        TransformPairEventInstancer>, IGetEvent 
    { }
}
