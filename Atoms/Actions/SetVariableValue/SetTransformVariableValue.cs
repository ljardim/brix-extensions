using UnityEngine;
using UnityAtoms.BaseAtoms;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Set variable value Action of type `Transform`. Inherits from `SetVariableValue&lt;Transform, TransformPair, TransformVariable, TransformConstant, TransformReference, TransformEvent, TransformPairEvent, TransformVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Transform", fileName = "SetTransformVariableValue")]
    public sealed class SetTransformVariableValue : SetVariableValue<
        Transform,
        TransformPair,
        TransformVariable,
        TransformConstant,
        TransformReference,
        TransformEvent,
        TransformPairEvent,
        TransformTransformFunction,
        TransformVariableInstancer>
    { }
}
