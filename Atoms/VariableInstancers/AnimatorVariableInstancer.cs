using UnityEngine;
using UnityAtoms.BaseAtoms;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Variable Instancer of type `Animator`. Inherits from `AtomVariableInstancer&lt;AnimatorVariable, AnimatorPair, Animator, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Animator Variable Instancer")]
    public class AnimatorVariableInstancer : AtomVariableInstancer<
        AnimatorVariable,
        AnimatorPair,
        Animator,
        AnimatorEvent,
        AnimatorPairEvent,
        AnimatorAnimatorFunction>
    { }
}
