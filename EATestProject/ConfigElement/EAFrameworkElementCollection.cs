using System.Configuration;

namespace EAAutoFramework.ConfigElement
{
    [ConfigurationCollection(typeof(EAFrameworkElement), AddItemName = "testSettings", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class EAFrameworkElementCollection : ConfigurationElementCollection
    {

        protected override ConfigurationElement CreateNewElement() => new EAFrameworkElement();

        protected override object GetElementKey(ConfigurationElement element) => (element as EAFrameworkElement).Name;

        public new EAFrameworkElement this[string type] => (EAFrameworkElement)base.BaseGet(type);
    }
}
