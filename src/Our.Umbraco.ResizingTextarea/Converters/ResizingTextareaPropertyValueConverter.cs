using Our.Umbraco.ResizingTextarea.PropertyEditors;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.ResizingTextarea.Converters
{
    [PropertyValueType(typeof(string))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class ResizingTextareaPropertyValueConverter : PropertyValueConverterBase
    {
        /// <summary>
        /// Check to see if this property value converter should take effect for the supplied published property type
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <returns></returns>
        public override bool IsConverter(PublishedPropertyType publishedPropertyType)
        {
            return publishedPropertyType.PropertyEditorAlias == ResizingTextareaPropertyEditor.PropertyEditorAlias;
        }

        /// <summary>
        /// Convert the saved value into a nullable boolean
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <param name="source">The saved json from the property editor</param>
        /// <param name="preview"></param>
        /// <returns>A string</returns>
        public override object ConvertSourceToObject(PublishedPropertyType publishedPropertyType, object source, bool preview)
        {
            return source as string ?? string.Empty;
        }
    }
}
