using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Blocks
{
    [BlockType(Name = "Custom Example", Category = "Content", Icon = "fas fa-quote-right")]
    public class CustomBlockExample : Block
    {
        [Field(Title = "Quote")]
        public TextField Quote { get; set; }

        [Field(Title = "Author", Placeholder = "Author (optional)")]
        public TextField Author { get; set; }

        [Field(Title = "Pull Top", Options = FieldOption.HalfWidth)]
        public CheckBoxField PullTop { get; set; }

        [Field(Title = "Pull Bottom", Options = FieldOption.HalfWidth)]
        public CheckBoxField PullBottom { get; set; }
    }
}
