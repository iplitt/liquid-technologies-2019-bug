using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2018 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  :  by Liquid XML Data Binder 16.1.19.8878
 * Using Schema: C:\GitHub\liquid-technologies-2019-bug\Model\Schemas\Car.xsd
 **********************************************************************************************/

namespace Model
{
    /// <summary>
    /// This class represents the Element Car
    /// </summary>
    [LiquidTechnologies.Runtime.Standard20.XmlObjectInfo(LiquidTechnologies.Runtime.Standard20.XmlObjectBase.XmlElementGroupType.Sequence,
                                                    LiquidTechnologies.Runtime.Standard20.XmlObjectBase.XmlElementType.Element,
                                                    "Car", "", true, false, false)]
    public partial class Car : Model.XmlCommonBase
    {
        #region Constructors
        /// <summary>
        /// Constructor for Car
        /// </summary>
        /// <remarks>
        /// The class is created with all the mandatory fields populated with the
        /// default data. 
        /// All Collection object are created.
        /// However any 1-n relationships (these are represented as collections) are
        /// empty. To comply with the schema these must be populated before the xml
        /// obtained from ToXml is valid against the schema C:\GitHub\liquid-technologies-2019-bug\Model\Schemas\Car.xsd
        /// </remarks>
        public Car()
        {
            _elementName = "Car";
            Init();
        }
        public Car(string elementName)
        {
            _elementName = elementName;
            Init();
        }
        #endregion

        #region Initialization methods for the class
        /// <summary>
        /// Initializes the class
        /// </summary>
        /// <remarks>
        /// This creates all the mandatory fields (populated with the default data) 
        /// All Collection object are created.
        /// However any 1-n relationships (these are represented as collections) are
        /// empty. To comply with the schema these must be populated before the xml
        /// obtained from ToXml is valid against the schema C:\GitHub\liquid-technologies-2019-bug\Model\Schemas\Car.xsd.
        /// </remarks>
        protected override void Init()
        {
            Model.Registration.iRegistrationIndicator = 0; // causes registration to take place
            m_Make = "";
            m_Color = "";
            m_IsValidColor = false;
            m_Owner = "";
            m_IsValidOwner = false;

// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
        }
        #endregion

        #region ICloneable Interface
        /// <summary>
        /// Allows the class to be copied
        /// </summary>
        /// <remarks>
        /// Performs a 'deep copy' of all the data in the class (and its children)
        /// </remarks>
        public override object Clone()
        {
            Model.Car newObject = new Model.Car(_elementName);
            newObject.m_Make = m_Make;
            newObject.m_Color = m_Color;
            newObject.m_IsValidColor = m_IsValidColor;
            newObject.m_Owner = m_Owner;
            newObject.m_IsValidOwner = m_IsValidOwner;

// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

            return newObject;
        }
        #endregion

        #region Member variables

        protected override string TargetNamespace
        {
            get { return ""; }
        }

        #region Attribute - Make
        /// <summary>
        /// Represents a mandatory Element in the XML document
        /// </summary>
        /// <remarks>
        /// This property is represented as an Element in the XML.
        /// It is mandatory and therefore must be populated within the XML.
        /// It is defaulted to "".
        /// </remarks>
        [LiquidTechnologies.Runtime.Standard20.ElementInfoSeqPrimMnd("Make", "", null, LiquidTechnologies.Runtime.Standard20.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1, -1, -1, null)]
        public string Make
        {
            get
            {
                return m_Make;
            }
            set 
            {
                // Apply whitespace rules appropriately
                value = LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.Preserve(value);
                m_Make = value;
            }
        }
        protected string m_Make;

        #endregion

        #region Attribute - Color
        /// <summary>
        /// Represents an optional Element in the XML document
        /// </summary>
        /// <remarks>
        /// This property is represented as an Element in the XML.
        /// It is optional, initially it is not valid.
        /// </remarks>
        [LiquidTechnologies.Runtime.Standard20.ElementInfoSeqPrimOpt("Color", "", "IsValidColor", null, LiquidTechnologies.Runtime.Standard20.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1, -1, -1, null)]
        public string Color
        {
            get 
            { 
                if (m_IsValidColor == false)
                    throw new LiquidTechnologies.Runtime.Standard20.LtInvalidStateException("The Property Color is not valid. Set ColorValid = true");
                return m_Color;  
            }
            set 
            { 
                // Apply whitespace rules appropriately
                value = LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.Preserve(value); 
                m_IsValidColor = true;
                m_Color = value;
            }
        }
        /// <summary>
        /// Indicates if Color contains a valid value.
        /// </summary>
        /// <remarks>
        /// true if the value for Color is valid, false if not.
        /// If this is set to true then the property is considered valid, and assigned its
        /// default value ("").
        /// If its set to false then its made invalid, and subsequent calls to get Color
        /// will raise an exception.
        /// </remarks>
        public bool IsValidColor
        {
            get
            {
                return m_IsValidColor;
            }
            set 
            { 
                if (value != m_IsValidColor)
                {
                    m_Color = "";
                    m_IsValidColor = value;
                }
            }
        }
        protected bool m_IsValidColor;
        protected string m_Color;
        #endregion

        #region Attribute - Owner
        /// <summary>
        /// Represents an optional Element in the XML document
        /// </summary>
        /// <remarks>
        /// This property is represented as an Element in the XML.
        /// It is optional, initially it is not valid.
        /// </remarks>
        [LiquidTechnologies.Runtime.Standard20.ElementInfoSeqPrimOpt("Owner", "", "IsValidOwner", null, LiquidTechnologies.Runtime.Standard20.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1, -1, -1, null)]
        public string Owner
        {
            get 
            { 
                if (m_IsValidOwner == false)
                    throw new LiquidTechnologies.Runtime.Standard20.LtInvalidStateException("The Property Owner is not valid. Set OwnerValid = true");
                return m_Owner;  
            }
            set 
            { 
                // Apply whitespace rules appropriately
                value = LiquidTechnologies.Runtime.Standard20.WhitespaceUtils.Preserve(value); 
                m_IsValidOwner = true;
                m_Owner = value;
            }
        }
        /// <summary>
        /// Indicates if Owner contains a valid value.
        /// </summary>
        /// <remarks>
        /// true if the value for Owner is valid, false if not.
        /// If this is set to true then the property is considered valid, and assigned its
        /// default value ("").
        /// If its set to false then its made invalid, and subsequent calls to get Owner
        /// will raise an exception.
        /// </remarks>
        public bool IsValidOwner
        {
            get
            {
                return m_IsValidOwner;
            }
            set 
            { 
                if (value != m_IsValidOwner)
                {
                    m_Owner = "";
                    m_IsValidOwner = value;
                }
            }
        }
        protected bool m_IsValidOwner;
        protected string m_Owner;
        #endregion

        #region Attribute - Namespace
        public override string Namespace
        {
            get { return ""; }
        }    
        #endregion    

        #region Attribute - GetBase
        public override LiquidTechnologies.Runtime.Standard20.XmlObjectBase GetBase()
        {
            return this;
        }
        #endregion
        #endregion


// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
    }
}


