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
    public static class ClassFactory
    {
        #region Static Constructor
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Type>> _nsMap = null;
        static ClassFactory()
        {
            _nsMap = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Type>>();
            System.Collections.Generic.Dictionary<string, System.Type> itemMap = null;
            itemMap = new System.Collections.Generic.Dictionary<string, System.Type>();
            itemMap.Add("Car", typeof(Model.Car));
            _nsMap.Add("", itemMap);
        }
        #endregion

        #region FromXml
        /// <summary>
        /// Creates an object from XML data held in a string.
        /// </summary>
        /// <param name="xmlIn">The data to be loaded</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXml(String xmlIn)
        {
            return FromXml(xmlIn, LiquidTechnologies.Runtime.Standard20.SerializationContext.Default);
        }
        /// <summary>
        /// Creates an object from XML data held in a string.
        /// </summary>
        /// <param name="xmlIn">The data to be loaded</param>
        /// <param name="context">The context to use when loading the data</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXml(String xmlIn, LiquidTechnologies.Runtime.Standard20.SerializationContext context)
        {
            XmlDocument xmlDoc = LiquidTechnologies.Runtime.Standard20.XmlObjectBase.LoadXmlDocument(xmlIn, context);
            return FromXmlElement(xmlDoc.DocumentElement, context);
        }
        #endregion

        #region FromXmlFile
        /// <summary>
        /// Creates an object from XML data held in a File
        /// </summary>
        /// <param name="FileName">The file to be loaded</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlFile(String FileName)
        {
            return FromXmlFile(FileName, LiquidTechnologies.Runtime.Standard20.SerializationContext.Default);
        }
        /// <summary>
        /// Creates an object from XML data held in a File
        /// </summary>
        /// <param name="FileName">The file to be loaded</param>
        /// <param name="context">The context to use when loading the data</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlFile(String FileName, LiquidTechnologies.Runtime.Standard20.SerializationContext context)
        {
            using (System.IO.Stream stream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read,System.IO.FileShare.Read))
            {
                return FromXmlStream(stream, context);
            }
        }
        #endregion

        #region FromXmlStream
        /// <summary>
        /// Creates an object from XML data held in a stream.
        /// </summary>
        /// <param name="stream">The data to be loaded</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlStream(System.IO.Stream stream)
        {
            return FromXmlStream(stream, LiquidTechnologies.Runtime.Standard20.SerializationContext.Default);
        }
        /// <summary>
        /// Creates an object from XML data held in a stream.
        /// </summary>
        /// <param name="stream">The data to be loaded</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlStream(System.IO.Stream stream, LiquidTechnologies.Runtime.Standard20.SerializationContext context)
        {
            XmlDocument xmlDoc = LiquidTechnologies.Runtime.Standard20.XmlObjectBase.LoadXmlDocument(stream, context);
            return FromXmlElement(xmlDoc.DocumentElement, context);
        }
        #endregion

        #region FromXmlElement
        /// <summary>
        /// Creates an object from an XML Element.
        /// </summary>
        /// <param name="xmlParent">The data that needs loading</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlElement(XmlElement xmlParent)
        {
            return FromXmlElement(xmlParent, LiquidTechnologies.Runtime.Standard20.SerializationContext.Default);
        }
        /// <summary>
        /// Creates an object from an XML Element.
        /// </summary>
        /// <param name="xmlParent">The data that needs loading</param>
        /// <param name="context">The context to use when loading the data</param>
        /// <returns>The wrapper object, loaded with the supplied data</returns>
        /// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
        public static LiquidTechnologies.Runtime.Standard20.XmlObjectBase FromXmlElement(XmlElement xmlParent, LiquidTechnologies.Runtime.Standard20.SerializationContext context)
        {
            LiquidTechnologies.Runtime.Standard20.XmlObjectBase retVal = null;
            String elementName;
            String elementNamespaceUri;

            // Get the type name this is either 
            // from the element i.e. <Parent>... = Parent
            // or from the type i.e. <Parent xsi:type="someNS:SomeElement">... = SomeElement
            if (LiquidTechnologies.Runtime.Standard20.ClassFactoryHelper.GetElementType(xmlParent) == "")
            {
                elementName = xmlParent.LocalName;
                elementNamespaceUri = xmlParent.NamespaceURI;
            }
            else
            {
                elementName = LiquidTechnologies.Runtime.Standard20.ClassFactoryHelper.GetElementType(xmlParent);
                elementNamespaceUri = LiquidTechnologies.Runtime.Standard20.ClassFactoryHelper.GetElementTypeNamespaceUri(xmlParent);
            }

            // create the appropriate object
            retVal = LiquidTechnologies.Runtime.Standard20.ClassFactoryHelper.CreateObject(_nsMap, elementName, elementNamespaceUri, context);
            if (retVal == null)
                throw new LiquidTechnologies.Runtime.Standard20.LtException(string.Format("Failed load the element {0}:{1}. No appropriate class exists to load the data into. Ensure that the XML document complies with the schema.", elementName, elementNamespaceUri));
            
            // load the data into the object
            retVal.FromXmlElement(xmlParent, context);

            return retVal;
        }
        #endregion
    }
}

