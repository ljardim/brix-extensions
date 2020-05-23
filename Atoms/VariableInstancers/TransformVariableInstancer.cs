using UnityEngine;
using UnityAtoms.BaseAtoms;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Variable Instancer of type `Transform`. Inherits from `AtomVariableInstancer&lt;TransformVariable, TransformPair, Transform, TransformEvent, TransformPairEvent, TransformTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Transform Variable Instancer")]
    public class TransformVariableInstancer : AtomVariableInstancer<
        TransformVariable,
        TransformPair,
        Transform,
        TransformEvent,
        TransformPairEvent,
        TransformTransformFunction>
    { }
}
