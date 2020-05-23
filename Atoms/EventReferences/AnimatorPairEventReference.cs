using System;
using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Reference of type `AnimatorPair`. Inherits from `AtomEventReference&lt;AnimatorPair, AnimatorVariable, AnimatorPairEvent, AnimatorVariableInstancer, AnimatorPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorPairEventReference : AtomEventReference<
        AnimatorPair,
        AnimatorVariable,
        AnimatorPairEvent,
        AnimatorVariableInstancer,
        AnimatorPairEventInstancer>, IGetEvent 
    { }
}
