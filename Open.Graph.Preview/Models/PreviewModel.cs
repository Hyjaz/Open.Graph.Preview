using System;

namespace Open.Graph.Preview.Models
{
    public class PreviewModel
    {
        public string Type { get; set; }

        /// <summary>Gets the title of the open graph document.</summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>Gets the image for the open graph document.</summary>
        /// <value>The image.</value>
        public string Image { get; set; }

        /// <summary>Gets the URL for the open graph document</summary>
        /// <value>The URL.</value>
        public Uri Url { get; set; }
    }
}