// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IxMilia.Dxf.Entities;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfVisualStyle class
    /// </summary>
    public partial class DxfVisualStyle : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.VisualStyle; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2007; } }
        public string Description { get; set; }
        public short Type { get; set; }
        public DxfFaceLightingModel FaceLightingModel { get; set; }
        public DxfFaceLightingQuality FaceLightingQuality { get; set; }
        public DxfFaceColorMode FaceColorMode { get; set; }
        public DxfFaceModifier FaceModifier { get; set; }
        public double FaceOpacityLevel { get; set; }
        public double FaceSpecularLevel { get; set; }
        public DxfColor Color1 { get; set; }
        public DxfColor Color2 { get; set; }
        public int FaceStyleMonoColor { get; set; }
        public DxfEdgeStyleModel EdgeStyleModel { get; set; }
        public int EdgeStyle { get; set; }
        public DxfColor EdgeIntersectionColor { get; set; }
        public DxfColor EdgeObscuredColor { get; set; }
        public short EdgeObscuredLinetype { get; set; }
        public short EdgeIntersectionLinetype { get; set; }
        public double EdgeCreaseAngle { get; set; }
        public int EdgeModifiers { get; set; }
        public DxfColor EdgeColor { get; set; }
        public double EdgeOpacityLevel { get; set; }
        public short EdgeWidth { get; set; }
        public short EdgeOverhang { get; set; }
        public short EdgeJitter { get; set; }
        public DxfColor EdgeSilhouetteColor { get; set; }
        public short EdgeSilhouetteWidth { get; set; }
        public short EdgeHaloGap { get; set; }
        public int EdgeIsoLineCount { get; set; }
        public bool HideEdgeLinePrecision { get; set; }
        public int EdgeStyleApplyFlags { get; set; }
        public int DisplayStyleSettings { get; set; }
        public double Brightness { get; set; }
        public short ShadowType { get; set; }
        public bool InternalFlag { get; set; }

        public DxfVisualStyle()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Description = null;
            this.Type = 0;
            this.FaceLightingModel = DxfFaceLightingModel.Visible;
            this.FaceLightingQuality = DxfFaceLightingQuality.PerFace;
            this.FaceColorMode = DxfFaceColorMode.ObjectColor;
            this.FaceModifier = DxfFaceModifier.None;
            this.FaceOpacityLevel = 0.0;
            this.FaceSpecularLevel = 0.0;
            this.Color1 = DxfColor.ByBlock;
            this.Color2 = DxfColor.ByBlock;
            this.FaceStyleMonoColor = 0;
            this.EdgeStyleModel = DxfEdgeStyleModel.NoEdges;
            this.EdgeStyle = 0;
            this.EdgeIntersectionColor = DxfColor.ByBlock;
            this.EdgeObscuredColor = DxfColor.ByBlock;
            this.EdgeObscuredLinetype = 0;
            this.EdgeIntersectionLinetype = 0;
            this.EdgeCreaseAngle = 0.0;
            this.EdgeModifiers = 0;
            this.EdgeColor = DxfColor.ByBlock;
            this.EdgeOpacityLevel = 0.0;
            this.EdgeWidth = 0;
            this.EdgeOverhang = 0;
            this.EdgeJitter = 0;
            this.EdgeSilhouetteColor = DxfColor.ByBlock;
            this.EdgeSilhouetteWidth = 0;
            this.EdgeHaloGap = 0;
            this.EdgeIsoLineCount = 0;
            this.HideEdgeLinePrecision = false;
            this.EdgeStyleApplyFlags = 0;
            this.DisplayStyleSettings = 0;
            this.Brightness = 0.0;
            this.ShadowType = 0;
            this.InternalFlag = false;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbVisualStyle"));
            pairs.Add(new DxfCodePair(2, (this.Description)));
            pairs.Add(new DxfCodePair(70, (this.Type)));
            pairs.Add(new DxfCodePair(71, (short)(this.FaceLightingModel)));
            pairs.Add(new DxfCodePair(72, (short)(this.FaceLightingQuality)));
            pairs.Add(new DxfCodePair(73, (short)(this.FaceColorMode)));
            pairs.Add(new DxfCodePair(90, (int)(this.FaceModifier)));
            pairs.Add(new DxfCodePair(40, (this.FaceOpacityLevel)));
            pairs.Add(new DxfCodePair(41, (this.FaceSpecularLevel)));
            pairs.Add(new DxfCodePair(62, GetRawValue(this.Color1)));
            pairs.Add(new DxfCodePair(63, GetRawValue(this.Color2)));
            pairs.Add(new DxfCodePair(421, (this.FaceStyleMonoColor)));
            pairs.Add(new DxfCodePair(74, (short)(this.EdgeStyleModel)));
            pairs.Add(new DxfCodePair(91, (this.EdgeStyle)));
            pairs.Add(new DxfCodePair(64, GetRawValue(this.EdgeIntersectionColor)));
            pairs.Add(new DxfCodePair(65, GetRawValue(this.EdgeObscuredColor)));
            pairs.Add(new DxfCodePair(75, (this.EdgeObscuredLinetype)));
            pairs.Add(new DxfCodePair(175, (this.EdgeIntersectionLinetype)));
            pairs.Add(new DxfCodePair(42, (this.EdgeCreaseAngle)));
            pairs.Add(new DxfCodePair(92, (this.EdgeModifiers)));
            pairs.Add(new DxfCodePair(66, GetRawValue(this.EdgeColor)));
            pairs.Add(new DxfCodePair(43, (this.EdgeOpacityLevel)));
            pairs.Add(new DxfCodePair(76, (this.EdgeWidth)));
            pairs.Add(new DxfCodePair(77, (this.EdgeOverhang)));
            pairs.Add(new DxfCodePair(78, (this.EdgeJitter)));
            pairs.Add(new DxfCodePair(67, GetRawValue(this.EdgeSilhouetteColor)));
            pairs.Add(new DxfCodePair(79, (this.EdgeSilhouetteWidth)));
            pairs.Add(new DxfCodePair(170, (this.EdgeHaloGap)));
            pairs.Add(new DxfCodePair(171, (short)(this.EdgeIsoLineCount)));
            pairs.Add(new DxfCodePair(290, (this.HideEdgeLinePrecision)));
            pairs.Add(new DxfCodePair(174, (short)(this.EdgeStyleApplyFlags)));
            pairs.Add(new DxfCodePair(93, (this.DisplayStyleSettings)));
            pairs.Add(new DxfCodePair(44, (this.Brightness)));
            pairs.Add(new DxfCodePair(173, (this.ShadowType)));
            pairs.Add(new DxfCodePair(291, (this.InternalFlag)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 2:
                    this.Description = (pair.StringValue);
                    break;
                case 40:
                    this.FaceOpacityLevel = (pair.DoubleValue);
                    break;
                case 41:
                    this.FaceSpecularLevel = (pair.DoubleValue);
                    break;
                case 42:
                    this.EdgeCreaseAngle = (pair.DoubleValue);
                    break;
                case 43:
                    this.EdgeOpacityLevel = (pair.DoubleValue);
                    break;
                case 44:
                    this.Brightness = (pair.DoubleValue);
                    break;
                case 62:
                    this.Color1 = FromRawValue(pair.ShortValue);
                    break;
                case 63:
                    this.Color2 = FromRawValue(pair.ShortValue);
                    break;
                case 64:
                    this.EdgeIntersectionColor = FromRawValue(pair.ShortValue);
                    break;
                case 65:
                    this.EdgeObscuredColor = FromRawValue(pair.ShortValue);
                    break;
                case 66:
                    this.EdgeColor = FromRawValue(pair.ShortValue);
                    break;
                case 67:
                    this.EdgeSilhouetteColor = FromRawValue(pair.ShortValue);
                    break;
                case 70:
                    this.Type = (pair.ShortValue);
                    break;
                case 71:
                    this.FaceLightingModel = (DxfFaceLightingModel)(pair.ShortValue);
                    break;
                case 72:
                    this.FaceLightingQuality = (DxfFaceLightingQuality)(pair.ShortValue);
                    break;
                case 73:
                    this.FaceColorMode = (DxfFaceColorMode)(pair.ShortValue);
                    break;
                case 74:
                    this.EdgeStyleModel = (DxfEdgeStyleModel)(pair.ShortValue);
                    break;
                case 75:
                    this.EdgeObscuredLinetype = (pair.ShortValue);
                    break;
                case 76:
                    this.EdgeWidth = (pair.ShortValue);
                    break;
                case 77:
                    this.EdgeOverhang = (pair.ShortValue);
                    break;
                case 78:
                    this.EdgeJitter = (pair.ShortValue);
                    break;
                case 79:
                    this.EdgeSilhouetteWidth = (pair.ShortValue);
                    break;
                case 90:
                    this.FaceModifier = (DxfFaceModifier)(pair.IntegerValue);
                    break;
                case 91:
                    this.EdgeStyle = (pair.IntegerValue);
                    break;
                case 92:
                    this.EdgeModifiers = (pair.IntegerValue);
                    break;
                case 93:
                    this.DisplayStyleSettings = (pair.IntegerValue);
                    break;
                case 170:
                    this.EdgeHaloGap = (pair.ShortValue);
                    break;
                case 171:
                    this.EdgeIsoLineCount = (pair.ShortValue);
                    break;
                case 173:
                    this.ShadowType = (pair.ShortValue);
                    break;
                case 174:
                    this.EdgeStyleApplyFlags = (pair.ShortValue);
                    break;
                case 175:
                    this.EdgeIntersectionLinetype = (pair.ShortValue);
                    break;
                case 290:
                    this.HideEdgeLinePrecision = (pair.BoolValue);
                    break;
                case 291:
                    this.InternalFlag = (pair.BoolValue);
                    break;
                case 421:
                    this.FaceStyleMonoColor = (pair.IntegerValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
