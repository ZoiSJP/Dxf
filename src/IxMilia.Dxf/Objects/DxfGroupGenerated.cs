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
    /// DxfGroup class
    /// </summary>
    public partial class DxfGroup : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.Group; } }
        public string Description { get; set; }
        public bool IsNamed { get; set; }
        public bool IsSelectable { get; set; }
        public List<uint> EntityHandles { get; private set; }

        public DxfGroup()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Description = null;
            this.IsNamed = true;
            this.IsSelectable = true;
            this.EntityHandles = new List<uint>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbGroup"));
            pairs.Add(new DxfCodePair(300, (this.Description)));
            pairs.Add(new DxfCodePair(70, NotBoolShort(this.IsNamed)));
            pairs.Add(new DxfCodePair(71, BoolShort(this.IsSelectable)));
            pairs.AddRange(this.EntityHandles.Select(p => new DxfCodePair(340, UIntHandle(p))));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 70:
                    this.IsNamed = NotBoolShort(pair.ShortValue);
                    break;
                case 71:
                    this.IsSelectable = BoolShort(pair.ShortValue);
                    break;
                case 300:
                    this.Description = (pair.StringValue);
                    break;
                case 340:
                    this.EntityHandles.Add(UIntHandle(pair.StringValue));
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
