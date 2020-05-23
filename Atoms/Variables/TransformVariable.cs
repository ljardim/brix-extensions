using UnityEngine;
using System;


namespace UnityAtoms.Brix
{

    /// <summary>
    /// Variable of type `Transform`. Inherits from `AtomVariable&lt;Transform, TransformPair, TransformEvent, TransformPairEvent, TransformTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Transform", fileName = "TransformVariable")]
    public sealed class TransformVariable : AtomVariable<Transform, TransformPair, TransformEvent, TransformPairEvent, TransformTransformFunction>
    {
        protected override bool ValueEquals(Transform other) {
            return _value.Equals(other);
        }
    }
}
