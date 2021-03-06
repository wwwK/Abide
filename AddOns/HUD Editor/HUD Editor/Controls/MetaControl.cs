﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace HUD_Editor.Controls
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<MetaControl, UserControl>))]
    public abstract class MetaControl : UserControl
    {
        public int FieldOffset
        {
            get
            {
                int offset = 0;
                if (int.TryParse(PluginElement?.Attributes["offset"]?.Value, out offset))
                    return offset;
                else return -1;
            }
        }
        public int FieldSize
        {
            get
            {
                int size = 0;
                if (int.TryParse(PluginElement?.Attributes["size"]?.Value, out size))
                    return size;
                else return -1;
            }
        }

        public LabelReference Label
        {
            get { return labelRef; }
        }
        public abstract string ControlName { get; set; }
        public abstract string Type { get; set; }
        public XmlNode PluginElement { get; set; }
        public long Address { get; set; }
        
        private readonly LabelReference labelRef = new LabelReference();
        
        public MetaControl() { }

        public override string ToString()
        {
            //Return
            return labelRef?.Text;
        }
    }

    internal class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
        public AbstractControlDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(TAbstract))) { }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType == typeof(TAbstract))
                return typeof(TBase);

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType == typeof(TAbstract))
                objectType = typeof(TBase);

            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }

    public class LabelReference : IEquatable<LabelReference>, IComparable<LabelReference>
    {
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string text;

        public LabelReference() : this(string.Empty)
        {
        }
        public LabelReference(string text)
        {
            this.text = text;
        }
        public bool Equals(LabelReference other)
        {
            return text.Equals(other.text);
        }
        public int CompareTo(LabelReference other)
        {
            return text.CompareTo(other.text);
        }
        public override string ToString()
        {
            if (text != null) return text;
            return "null";
        }
    }
}
