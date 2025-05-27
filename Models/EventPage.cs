using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache.Internal;

namespace ContentModels
{
    public partial class EventPage : PublishedContentModel
    {
        public EventPage(IPublishedContent content) : base(content)
        {
        }

        public string Title => this.Value<string>("title");
        public string Description => this.Value<string>("description");
        public string EmojiLabel => this.Value<string>("emojiLabel");
    }
} 