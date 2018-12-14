using System.Threading.Tasks;
using Open.Graph.Preview.Models;
using OpenGraphNet;

namespace Open.Graph.Preview.Business
{
    public class Preview
    {
        public async Task<PreviewModel> GetPreviewFromUrl(string url)
        {
            try
            {
                OpenGraph openGraph = await OpenGraph.ParseUrlAsync(url);
                var preview = new PreviewModel()
                {
                    Title = openGraph.Title,
                    Image = openGraph.Image.AbsoluteUri,
                    Url = openGraph.Url,
                    Type = openGraph.Type
                };
                return preview;
            }
            catch
            {
                return null;
            }
        }
    }
}