using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.ResizingTextarea.PropertyEditors
{
    internal class ResizingTextareaPreValueEditor : PreValueEditor
    {
        [PreValueField("style", "Style", "textstring", Description = "Optional semicolon delimeted, style attribute values")]
        public string Style { get; set; }
    }
}
