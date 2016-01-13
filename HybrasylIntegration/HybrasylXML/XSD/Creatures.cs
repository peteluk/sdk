// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.433
//    <NameSpace>Hybrasyl</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net45</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>True</sspNullable><sspString>True</sspString><sspCollection>True</sspCollection><sspComplexType>True</sspComplexType><sspSimpleType>True</sspSimpleType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.XSD
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Creatures")]
    [System.Xml.Serialization.XmlRootAttribute("mob", Namespace="http://www.hybrasyl.com/XML/Creatures", IsNullable=false)]
    public partial class Mob
    {
        
        private string _name;
        
        private string _description;
        
        private Properties _properties;
        
        private ushort _sprite;
        
        public Mob()
        {
            this._properties = new Properties();
        }
        
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        public Properties properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort sprite
        {
            get
            {
                return this._sprite;
            }
            set
            {
                this._sprite = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class Properties
    {
        
        private PropertiesDifficulty _difficulty;
        
        private PropertiesDamage _damage;
        
        private PropertiesDefense _defense;
        
        private Loot _loot;
        
        private object _scriptname;
        
        public Properties()
        {
            this._loot = new Loot();
            this._defense = new PropertiesDefense();
            this._damage = new PropertiesDamage();
            this._difficulty = new PropertiesDifficulty();
        }
        
        public PropertiesDifficulty difficulty
        {
            get
            {
                return this._difficulty;
            }
            set
            {
                this._difficulty = value;
            }
        }
        
        public PropertiesDamage damage
        {
            get
            {
                return this._damage;
            }
            set
            {
                this._damage = value;
            }
        }
        
        public PropertiesDefense defense
        {
            get
            {
                return this._defense;
            }
            set
            {
                this._defense = value;
            }
        }
        
        public Loot loot
        {
            get
            {
                return this._loot;
            }
            set
            {
                this._loot = value;
            }
        }
        
        public object scriptname
        {
            get
            {
                return this._scriptname;
            }
            set
            {
                this._scriptname = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class PropertiesDifficulty
    {
        
        private byte _level;
        
        private float _multiplier;
        
        private float _speed;
        
        public PropertiesDifficulty()
        {
            this._multiplier = ((float)(1F));
            this._speed = ((float)(1F));
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float multiplier
        {
            get
            {
                return this._multiplier;
            }
            set
            {
                this._multiplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Creatures")]
    [System.Xml.Serialization.XmlRootAttribute("dropset", Namespace="http://www.hybrasyl.com/XML/Creatures", IsNullable=false)]
    public partial class Dropset
    {
        
        private string _name;
        
        private List<object> _drops;
        
        public Dropset()
        {
            this._drops = new List<object>();
        }
        
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("gold", typeof(DropGold), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(DropItem), IsNullable=false)]
        public List<object> drops
        {
            get
            {
                return this._drops;
            }
            set
            {
                this._drops = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class DropGold
    {
        
        private byte _minqty;
        
        private byte _maxqty;
        
        private float _chance;
        
        public DropGold()
        {
            this._minqty = ((byte)(1));
            this._maxqty = ((byte)(1));
            this._chance = ((float)(1F));
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte minqty
        {
            get
            {
                return this._minqty;
            }
            set
            {
                this._minqty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte maxqty
        {
            get
            {
                return this._maxqty;
            }
            set
            {
                this._maxqty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                this._chance = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class DropItem
    {
        
        private byte _minqty;
        
        private byte _maxqty;
        
        private float _chance;
        
        private string _variant;
        
        private string _value;
        
        public DropItem()
        {
            this._minqty = ((byte)(1));
            this._maxqty = ((byte)(1));
            this._chance = ((float)(1F));
            this._variant = "none";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte minqty
        {
            get
            {
                return this._minqty;
            }
            set
            {
                this._minqty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte maxqty
        {
            get
            {
                return this._maxqty;
            }
            set
            {
                this._maxqty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                this._chance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("none")]
        public string variant
        {
            get
            {
                return this._variant;
            }
            set
            {
                this._variant = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class Drop
    {
        
        private List<object> _items;
        
        public Drop()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("gold", typeof(DropGold))]
        [System.Xml.Serialization.XmlElementAttribute("item", typeof(DropItem))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class Loot
    {
        
        private List<object> _items;
        
        private uint _exp;
        
        private uint _gold;
        
        public Loot()
        {
            this._items = new List<object>();
            this._exp = ((uint)(0));
            this._gold = ((uint)(0));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("drops", typeof(Drop))]
        [System.Xml.Serialization.XmlElementAttribute("dropset", typeof(string))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint exp
        {
            get
            {
                return this._exp;
            }
            set
            {
                this._exp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint gold
        {
            get
            {
                return this._gold;
            }
            set
            {
                this._gold = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class PropertiesDamage
    {
        
        private uint _min;
        
        private uint _max;
        
        private Element _element;
        
        public PropertiesDamage()
        {
            this._element = Element.none;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(Element.none)]
        public Element element
        {
            get
            {
                return this._element;
            }
            set
            {
                this._element = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.hybrasyl.com/XML/Creatures")]
    public partial class PropertiesDefense
    {
        
        private byte _mr;
        
        private byte _ac;
        
        private Element _element;
        
        public PropertiesDefense()
        {
            this._mr = ((byte)(1));
            this._element = Element.none;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte mr
        {
            get
            {
                return this._mr;
            }
            set
            {
                this._mr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ac
        {
            get
            {
                return this._ac;
            }
            set
            {
                this._ac = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(Element.none)]
        public Element element
        {
            get
            {
                return this._element;
            }
            set
            {
                this._element = value;
            }
        }
    }
}
#pragma warning restore
