using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessPreview = Open.Graph.Preview.Business.Preview;

namespace Open.Graph.Preview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        private readonly BusinessPreview m_preview = new BusinessPreview();
        [HttpGet]
        public async Task<IActionResult> GetPreview(string url)
        {
            var preview = await m_preview.GetPreviewFromUrl(url);
            if (preview != null)
            {
                return Ok(preview);
            }
            else
            {
                return NotFound();
            }
        }
    }
}