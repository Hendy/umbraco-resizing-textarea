using ClientDependency.Core;
using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.ResizingTextarea.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Resizing Textarea", "~/App_Plugins/ResizingTextarea/ResizingTextarea.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/ResizingTextarea/ResizingTextarea.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/ResizingTextarea/ResizingTextarea.js")]
    public class ResizingTextareaPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.ResizingTextarea";

        public ResizingTextareaPropertyEditor() : base()
        {
            this.DefaultPreValues = new Dictionary<string, object>
            {
                { "style", "width:100%;" }
            };
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new ResizingTextareaPreValueEditor();
        }
    }
}
