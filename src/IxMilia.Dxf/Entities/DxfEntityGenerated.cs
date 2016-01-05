﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Entities
{

    public enum DxfEntityType
    {
        Arc,
        ArcAlignedText,
        Attribute,
        AttributeDefinition,
        Body,
        Circle,
        DgnUnderlay,
        Dimension,
        DwfUnderlay,
        Ellipse,
        Face,
        Helix,
        Image,
        Insert,
        Leader,
        Light,
        Line,
        LwPolyline,
        MLeaderStyle,
        MLine,
        ModelerGeometry,
        MText,
        Ole2Frame,
        OleFrame,
        PdfUnderlay,
        Point,
        Polyline,
        ProxyEntity,
        Ray,
        Region,
        RText,
        Section,
        Seqend,
        Shape,
        Solid,
        Spline,
        Sun,
        Text,
        Tolerance,
        Trace,
        Underlay,
        Vertex,
        WipeOut,
        XLine,
    }

    /// <summary>
    /// DxfEntity class
    /// </summary>
    public partial class DxfEntity : IDxfItemInternal
    {
        uint IDxfItemInternal.Handle { get; set; }
        uint IDxfItemInternal.OwnerHandle { get; set; }
        public IDxfItem Owner { get; private set;}

        void IDxfItemInternal.SetOwner(IDxfItem owner)
        {
            Owner = owner;
        }

        IEnumerable<DxfPointer> IDxfItemInternal.GetPointers()
        {
            yield return PlotStylePointer;
        }

        internal DxfPointer PlotStylePointer { get; } = new DxfPointer();

        public bool IsInPaperSpace { get; set; }
        public string Layer { get; set; }
        public string LinetypeName { get; set; }
        public double Elevation { get; set; }
        public string MaterialHandle { get; set; }
        public DxfColor Color { get; set; }
        public short LineweightEnumValue { get; set; }
        public double LinetypeScale { get; set; }
        public bool IsVisible { get; set; }
        public int ImageByteCount { get; set; }
        public List<string> PreviewImageData { get; private set; }
        public int Color24Bit { get; set; }
        public string ColorName { get; set; }
        public int Transparency { get; set; }
        public IDxfItem PlotStyle { get { return PlotStylePointer.Item as IDxfItem; } set { PlotStylePointer.Item = value; } }
        public DxfShadowMode ShadowMode { get; set; }

        public string EntityTypeString
        {
            get
            {
                switch (EntityType)
                {
                    case DxfEntityType.Face:
                        return "3DFACE";
                    case DxfEntityType.ModelerGeometry:
                        return "3DSOLID";
                    case DxfEntityType.ProxyEntity:
                        return "ACAD_PROXY_ENTITY";
                    case DxfEntityType.Arc:
                        return "ARC";
                    case DxfEntityType.ArcAlignedText:
                        return "ARCALIGNEDTEXT";
                    case DxfEntityType.AttributeDefinition:
                        return "ATTDEF";
                    case DxfEntityType.Attribute:
                        return "ATTRIB";
                    case DxfEntityType.Body:
                        return "BODY";
                    case DxfEntityType.Circle:
                        return "CIRCLE";
                    case DxfEntityType.Dimension:
                        return "DIMENSION";
                    case DxfEntityType.Ellipse:
                        return "ELLIPSE";
                    case DxfEntityType.Helix:
                        return "HELIX";
                    case DxfEntityType.Image:
                        return "IMAGE";
                    case DxfEntityType.Insert:
                        return "INSERT";
                    case DxfEntityType.Leader:
                        return "LEADER";
                    case DxfEntityType.Light:
                        return "LIGHT";
                    case DxfEntityType.Line:
                        return "LINE";
                    case DxfEntityType.LwPolyline:
                        return "LWPOLYLINE";
                    case DxfEntityType.MLine:
                        return "MLINE";
                    case DxfEntityType.MLeaderStyle:
                        return "MLEADERSTYLE";
                    case DxfEntityType.MText:
                        return "MTEXT";
                    case DxfEntityType.OleFrame:
                        return "OLEFRAME";
                    case DxfEntityType.Ole2Frame:
                        return "OLE2FRAME";
                    case DxfEntityType.Point:
                        return "POINT";
                    case DxfEntityType.Polyline:
                        return "POLYLINE";
                    case DxfEntityType.Ray:
                        return "RAY";
                    case DxfEntityType.Region:
                        return "REGION";
                    case DxfEntityType.RText:
                        return "RTEXT";
                    case DxfEntityType.Section:
                        return "SECTION";
                    case DxfEntityType.Seqend:
                        return "SEQEND";
                    case DxfEntityType.Shape:
                        return "SHAPE";
                    case DxfEntityType.Solid:
                        return "SOLID";
                    case DxfEntityType.Spline:
                        return "SPLINE";
                    case DxfEntityType.Sun:
                        return "SUN";
                    case DxfEntityType.Text:
                        return "TEXT";
                    case DxfEntityType.Tolerance:
                        return "TOLERANCE";
                    case DxfEntityType.Trace:
                        return "TRACE";
                    case DxfEntityType.Underlay:
                        return "UNDERLAY";
                    case DxfEntityType.DgnUnderlay:
                        return "DGNUNDERLAY";
                    case DxfEntityType.DwfUnderlay:
                        return "DWFUNDERLAY";
                    case DxfEntityType.PdfUnderlay:
                        return "PDFUNDERLAY";
                    case DxfEntityType.Vertex:
                        return "VERTEX";
                    case DxfEntityType.WipeOut:
                        return "WIPEOUT";
                    case DxfEntityType.XLine:
                        return "XLINE";
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        protected DxfEntity(DxfEntity other)
            : this()
        {
            ((IDxfItemInternal)this).Handle = ((IDxfItemInternal)other).Handle;
            ((IDxfItemInternal)this).OwnerHandle = ((IDxfItemInternal)other).OwnerHandle;
            ((IDxfItemInternal)this).SetOwner(((IDxfItemInternal)other).Owner);
            this.IsInPaperSpace = other.IsInPaperSpace;
            this.Layer = other.Layer;
            this.LinetypeName = other.LinetypeName;
            this.Elevation = other.Elevation;
            this.MaterialHandle = other.MaterialHandle;
            this.Color = other.Color;
            this.LineweightEnumValue = other.LineweightEnumValue;
            this.LinetypeScale = other.LinetypeScale;
            this.IsVisible = other.IsVisible;
            this.ImageByteCount = other.ImageByteCount;
            this.PreviewImageData = other.PreviewImageData;
            this.Color24Bit = other.Color24Bit;
            this.ColorName = other.ColorName;
            this.Transparency = other.Transparency;
            this.PlotStylePointer.Handle = other.PlotStylePointer.Handle;
            this.PlotStylePointer.Item = other.PlotStylePointer.Item;
            this.ShadowMode = other.ShadowMode;
        }

        protected virtual void Initialize()
        {
            this.IsInPaperSpace = false;
            this.Layer = "0";
            this.LinetypeName = "BYLAYER";
            this.Elevation = 0.0;
            this.MaterialHandle = "BYLAYER";
            this.Color = DxfColor.ByLayer;
            this.LineweightEnumValue = 0;
            this.LinetypeScale = 1.0;
            this.IsVisible = true;
            this.ImageByteCount = 0;
            this.PreviewImageData = new List<string>();
            this.Color24Bit = 0;
            this.ColorName = null;
            this.Transparency = 0;
            this.ShadowMode = DxfShadowMode.CastsAndReceivesShadows;
        }

        protected virtual void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            pairs.Add(new DxfCodePair(0, EntityTypeString));
            if (outputHandles)
            {
                pairs.Add(new DxfCodePair(5, UIntHandle(((IDxfItemInternal)this).Handle)));
            }
            AddExtensionValuePairs(pairs, version, outputHandles);
            if (((IDxfItemInternal)this).OwnerHandle != 0 && outputHandles)
            {
                pairs.Add(new DxfCodePair(330, UIntHandle(((IDxfItemInternal)this).OwnerHandle)));
            }
            pairs.Add(new DxfCodePair(100, "AcDbEntity"));
            if (version >= DxfAcadVersion.R12 && this.IsInPaperSpace != false)
            {
                pairs.Add(new DxfCodePair(67, BoolShort(this.IsInPaperSpace)));
            }

            pairs.Add(new DxfCodePair(8, (this.Layer)));
            if (this.LinetypeName != "BYLAYER")
            {
                pairs.Add(new DxfCodePair(6, (this.LinetypeName)));
            }

            if (version <= DxfAcadVersion.R12 && this.Elevation != 0.0)
            {
                pairs.Add(new DxfCodePair(38, (this.Elevation)));
            }

            if (version >= DxfAcadVersion.R2007 && this.MaterialHandle != "BYLAYER")
            {
                pairs.Add(new DxfCodePair(347, (this.MaterialHandle)));
            }

            if (this.Color != DxfColor.ByLayer)
            {
                pairs.Add(new DxfCodePair(62, DxfColor.GetRawValue(this.Color)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(370, (this.LineweightEnumValue)));
            }

            if (version >= DxfAcadVersion.R13 && this.LinetypeScale != 1.0)
            {
                pairs.Add(new DxfCodePair(48, (this.LinetypeScale)));
            }

            if (version >= DxfAcadVersion.R13 && this.IsVisible != true)
            {
                pairs.Add(new DxfCodePair(60, NotBoolShort(this.IsVisible)));
            }

            if (version >= DxfAcadVersion.R2000 && this.ImageByteCount != 0)
            {
                pairs.Add(new DxfCodePair(92, (this.ImageByteCount)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.AddRange(this.PreviewImageData.Select(p => new DxfCodePair(310, p)));
            }

            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(420, (this.Color24Bit)));
            }

            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(430, (this.ColorName)));
            }

            if (version >= DxfAcadVersion.R2004)
            {
                pairs.Add(new DxfCodePair(440, (this.Transparency)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(390, DxfCommonConverters.UIntHandle(this.PlotStylePointer.Handle)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(284, (short)(this.ShadowMode)));
            }

        }

        internal virtual bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 5:
                    ((IDxfItemInternal)this).Handle = UIntHandle(pair.StringValue);
                    break;
                case 330:
                    ((IDxfItemInternal)this).OwnerHandle = UIntHandle(pair.StringValue);
                    break;
                case 6:
                    this.LinetypeName = (pair.StringValue);
                    break;
                case 8:
                    this.Layer = (pair.StringValue);
                    break;
                case 38:
                    this.Elevation = (pair.DoubleValue);
                    break;
                case 48:
                    this.LinetypeScale = (pair.DoubleValue);
                    break;
                case 60:
                    this.IsVisible = !BoolShort(pair.ShortValue);
                    break;
                case 62:
                    this.Color = DxfColor.FromRawValue(pair.ShortValue);
                    break;
                case 67:
                    this.IsInPaperSpace = BoolShort(pair.ShortValue);
                    break;
                case 92:
                    this.ImageByteCount = (pair.IntegerValue);
                    break;
                case 284:
                    this.ShadowMode = (DxfShadowMode)(pair.ShortValue);
                    break;
                case 310:
                    this.PreviewImageData.Add((pair.StringValue));
                    break;
                case 347:
                    this.MaterialHandle = (pair.StringValue);
                    break;
                case 370:
                    this.LineweightEnumValue = (pair.ShortValue);
                    break;
                case 390:
                    this.PlotStylePointer.Handle = DxfCommonConverters.UIntHandle(pair.StringValue);
                    break;
                case 420:
                    this.Color24Bit = (pair.IntegerValue);
                    break;
                case 430:
                    this.ColorName = (pair.StringValue);
                    break;
                case 440:
                    this.Transparency = (pair.IntegerValue);
                    break;
                default:
                    return false;
            }

            return true;
        }

        internal static DxfEntity FromBuffer(DxfCodePairBufferReader buffer)
        {
            var first = buffer.Peek();
            buffer.Advance();
            DxfEntity entity;
            switch (first.StringValue)
            {
                case "3DFACE":
                    entity = new Dxf3DFace();
                    break;
                case "3DSOLID":
                    entity = new Dxf3DSolid();
                    break;
                case "ACAD_PROXY_ENTITY":
                    entity = new DxfProxyEntity();
                    break;
                case "ARC":
                    entity = new DxfArc();
                    break;
                case "ARCALIGNEDTEXT":
                    entity = new DxfArcAlignedText();
                    break;
                case "ATTDEF":
                    entity = new DxfAttributeDefinition();
                    break;
                case "ATTRIB":
                    entity = new DxfAttribute();
                    break;
                case "BODY":
                    entity = new DxfBody();
                    break;
                case "CIRCLE":
                    entity = new DxfCircle();
                    break;
                case "DIMENSION":
                    entity = new DxfDimensionBase();
                    break;
                case "ELLIPSE":
                    entity = new DxfEllipse();
                    break;
                case "HELIX":
                    entity = new DxfHelix();
                    break;
                case "IMAGE":
                    entity = new DxfImage();
                    break;
                case "INSERT":
                    entity = new DxfInsert();
                    break;
                case "LEADER":
                    entity = new DxfLeader();
                    break;
                case "LIGHT":
                    entity = new DxfLight();
                    break;
                case "LINE":
                case "3DLINE":
                    entity = new DxfLine();
                    break;
                case "LWPOLYLINE":
                    entity = new DxfLwPolyline();
                    break;
                case "MLINE":
                    entity = new DxfMLine();
                    break;
                case "MLEADERSTYLE":
                    entity = new DxfMLeaderStyle();
                    break;
                case "MTEXT":
                    entity = new DxfMText();
                    break;
                case "OLEFRAME":
                    entity = new DxfOleFrame();
                    break;
                case "OLE2FRAME":
                    entity = new DxfOle2Frame();
                    break;
                case "POINT":
                    entity = new DxfModelPoint();
                    break;
                case "POLYLINE":
                    entity = new DxfPolyline();
                    break;
                case "RAY":
                    entity = new DxfRay();
                    break;
                case "REGION":
                    entity = new DxfRegion();
                    break;
                case "RTEXT":
                    entity = new DxfRText();
                    break;
                case "SECTION":
                    entity = new DxfEntitySection();
                    break;
                case "SEQEND":
                    entity = new DxfSeqend();
                    break;
                case "SHAPE":
                    entity = new DxfShape();
                    break;
                case "SOLID":
                    entity = new DxfSolid();
                    break;
                case "SPLINE":
                    entity = new DxfSpline();
                    break;
                case "SUN":
                    entity = new DxfSun();
                    break;
                case "TEXT":
                    entity = new DxfText();
                    break;
                case "TOLERANCE":
                    entity = new DxfTolerance();
                    break;
                case "TRACE":
                    entity = new DxfTrace();
                    break;
                case "UNDERLAY":
                    entity = new DxfUnderlay();
                    break;
                case "DGNUNDERLAY":
                    entity = new DxfDgnUnderlay();
                    break;
                case "DWFUNDERLAY":
                    entity = new DxfDwfUnderlay();
                    break;
                case "PDFUNDERLAY":
                    entity = new DxfPdfUnderlay();
                    break;
                case "VERTEX":
                    entity = new DxfVertex();
                    break;
                case "WIPEOUT":
                    entity = new DxfWipeout();
                    break;
                case "XLINE":
                    entity = new DxfXLine();
                    break;
                default:
                    SwallowEntity(buffer);
                    entity = null;
                    break;
            }

            if (entity != null)
            {
                entity = entity.PopulateFromBuffer(buffer);
            }

            return entity;
        }
    }

    public partial class DxfDimensionBase
    {
        protected override DxfEntity PostParse()
        {
            DxfDimensionBase newDimension = null;
            switch (DimensionType)
            {
                case DxfDimensionType.RotatedHorizontalOrVertical:
                    newDimension = new DxfRotatedDimension(this);
                    break;
                case DxfDimensionType.Aligned:
                    newDimension = new DxfAlignedDimension(this);
                    break;
                case DxfDimensionType.Angular:
                    newDimension = new DxfAngularDimension(this);
                    break;
                case DxfDimensionType.Diameter:
                    newDimension = new DxfDiameterDimension(this);
                    break;
                case DxfDimensionType.Radius:
                    newDimension = new DxfRadialDimension(this);
                    break;
                case DxfDimensionType.AngularThreePoint:
                    newDimension = new DxfAngularThreePointDimension(this);
                    break;
                case DxfDimensionType.Ordinate:
                    newDimension = new DxfOrdinateDimension(this);
                    break;
            }

            if (newDimension != null)
            {
                foreach (var pair in ExcessCodePairs)
                {
                    newDimension.TrySetPair(pair);
                }
            }

            return newDimension;
        }
    }

}

// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// This line is required for T4 template generation to work. 
// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// This line is required for T4 template generation to work. 

