﻿namespace Abide.H2Guerilla
{
    /// <summary>
    /// Represents an enumeration containing every Guerilla field type.
    /// </summary>
    public enum FieldType : short
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        FieldString,
        FieldLongString,
        FieldStringId,
        FieldOldStringId,
        FieldCharInteger,
        FieldShortInteger,
        FieldLongInteger,
        FieldAngle,
        FieldTag,
        FieldCharEnum,
        FieldEnum,
        FieldLongEnum,
        FieldLongFlags,
        FieldWordFlags,
        FieldByteFlags,
        FieldPoint2D,
        FieldRectangle2D,
        FieldRgbColor,
        FieldArgbColor,
        FieldReal,
        FieldRealFraction,
        FieldRealPoint2D,
        FieldRealPoint3D,
        FieldRealVector2D,
        FieldRealVector3D,
        FieldQuaternion,
        FieldEulerAngles2D,
        FieldEulerAngles3D,
        FieldRealPlane2D,
        FieldRealPlane3D,
        FieldRealRgbColor,
        FieldRealArgbColor,
        FieldRealHsvColor,
        FieldRealAhsvColor,
        FieldShortBounds,
        FieldAngleBounds,
        FieldRealBounds,
        FieldRealFractionBounds,
        FieldTagReference,
        FieldBlock,

        FieldLongBlockFlags,
        FieldWordBlockFlags,
        FieldByteBlockFlags,

        FieldCharBlockIndex1,
        FieldCharBlockIndex2,
        FieldShortBlockIndex1,
        FieldShortBlockIndex2,
        FieldLongBlockIndex1,
        FieldLongBlockIndex2,

        FieldData,
        FieldVertexBuffer,
        FieldArrayStart,
        FieldArrayEnd,
        FieldPad,
        FieldUselessPad,
        FieldSkip,
        FieldExplanation,
        FieldCustom,
        FieldStruct,
        FieldTerminator,
#pragma warning restore CS1591
    }
}
