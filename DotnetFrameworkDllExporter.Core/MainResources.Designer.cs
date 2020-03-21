using System.Reflection;
using System.Resources;

namespace DotnetFrameworkDllExporter.Core 
{
    public static class MainResources
    {
        public static string AssemblyDtdString = @"
<!ELEMENT Assembly (Model)*>
<!ELEMENT Model (Namespace|Model)*>

<!ELEMENT Namespace (Namespace|Interface|Class|Enum|Struct)*>
    <!ATTLIST Namespace entityId CDATA #REQUIRED>
    <!ATTLIST Namespace name CDATA #REQUIRED>

<!ELEMENT Interface (InterfaceMethod|InterfaceProperty)*>
    <!ATTLIST Interface entityId CDATA #REQUIRED>
    <!ATTLIST Interface name CDATA #REQUIRED>

<!ELEMENT Enum (EnumMember)>
    <!ATTLIST Enum entityId CDATA #REQUIRED>
    <!ATTLIST Enum name CDATA #REQUIRED>

<!ELEMENT EnumMember (#PCDATA)>
    <!ATTLIST EnumMember entityId CDATA #REQUIRED>
    <!ATTLIST EnumMember name CDATA #REQUIRED>

<!ELEMENT Class (Interface|Class|Enum|Struct|Field|Property|Method|Constructor|GenericParameter|BaseClass|InterfaceImplemented)*>
    <!ATTLIST Class entityId CDATA #REQUIRED>
    <!ATTLIST Class name CDATA #REQUIRED>
    <!ATTLIST Class BaseClass CDATA "">
    <!ATTLIST Class InterfaceImplemented CDATA "">
    <!ELEMENT GenericParameter (#PCDATA)>
        <!ATTLIST GenericParameter entityId CDATA #REQUIRED>
        <!ATTLIST GenericParameter name CDATA #REQUIRED>

<!ELEMENT Delegate (GenericParameter|Parameter)*>
    <!ATTLIST Delegate entityId CDATA #REQUIRED>
    <!ATTLIST Delegate name CDATA #REQUIRED>
    <!ATTLIST Delegate return CDATA #REQUIRED>

<!ELEMENT Struct (Interface|Class|Enum|Struct|Field|Property|Method|Constructor|GenericParameter|InterfaceImplemented)*>
    <!ATTLIST Struct entityId CDATA #REQUIRED>
    <!ATTLIST Struct name CDATA #REQUIRED>

<!ELEMENT Field (#PCDATA)>
    <!ATTLIST Field entityId CDATA #REQUIRED>
    <!ATTLIST Field name CDATA #REQUIRED>
    <!ATTLIST Field static CDATA #REQUIRED>
    <!ATTLIST Field type CDATA #REQUIRED>

<!ELEMENT Property (#PCDATA)>
    <!ATTLIST Property entityId CDATA #REQUIRED>
    <!ATTLIST Property name CDATA #REQUIRED>
    <!ATTLIST Property type CDATA #REQUIRED>
    <!ATTLIST Property set (True|False) ""False"">
    <!ATTLIST Property get (True|False) ""False"">

<!ELEMENT InterfaceProperty (#PCDATA)>
    <!ATTLIST InterfaceProperty entityId CDATA #REQUIRED>
    <!ATTLIST InterfaceProperty name CDATA #REQUIRED>
    <!ATTLIST InterfaceProperty type CDATA #REQUIRED>
    <!ATTLIST InterfaceProperty set (True|False) ""False"">
    <!ATTLIST InterfaceProperty get (True|False) ""False"">

<!ELEMENT Method (GenericParameter|Parameter)*>
    <!ATTLIST Method entityId CDATA #REQUIRED>
    <!ATTLIST Method name CDATA #REQUIRED>
    <!ATTLIST Method static (True|False) #REQUIRED>
    <!ATTLIST Method return CDATA #REQUIRED>
    <!ELEMENT Parameter (#PCDATA)>
        <!ATTLIST Parameter entityId CDATA #REQUIRED>
        <!ATTLIST Parameter name CDATA #REQUIRED>
        <!ATTLIST Parameter type CDATA #REQUIRED>
        <!ATTLIST Parameter ref CDATA #REQUIRED>
        <!ATTLIST Parameter out CDATA #REQUIRED>

<!ELEMENT InterfaceMethod (GenericParameter|Parameter)*>
    <!ATTLIST InterfaceMethod entityId CDATA #REQUIRED>
    <!ATTLIST InterfaceMethod name CDATA #REQUIRED>
    <!ATTLIST InterfaceMethod static (True|False) #REQUIRED>
    <!ATTLIST InterfaceMethod return CDATA #REQUIRED>

<!ELEMENT Constructor (Parameter)*>
";
        public static string AssemblyDtd
        {
            get
            {
                var rm = new ResourceManager("DotNetFrameworkDllExporter.Core.MainResources", Assembly.GetExecutingAssembly());
                return (string)rm.GetObject("AssemblyDtd");
            }
        }
    }     
}
