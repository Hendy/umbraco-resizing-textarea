using ClientDependency.Core;
using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.ResizingTextarea.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Resizeable Textarea", "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.js")]
    public class ResizeableTextareaPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.ResizeableTextarea";

        //public ResizeableTextareaPropertyEditor() : base()
        //{
        //    this.DefaultPreValues = new Dictionary<string, object>
        //    {
        //        { "nullText", "Null" },
        //        { "falseText", "False" },
        //        { "trueText", "True" }
        //    };
        //}

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new ResizeableTextareaPreValueEditor();
        }
    }
}
