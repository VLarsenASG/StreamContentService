using Application.Services;
using Domain.Dtos;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace StreamContentService.Controllers;

public class StreamContentController : ApiController
{
    private readonly IVideoFileService _videoFileService;

    public StreamContentController(IVideoFileService videoFileService)
    {
        _videoFileService = videoFileService;
    }


    [HttpGet("api/videoFile")]

    public async Task<VideoFileDto> GetVideoFile(Guid movieId)
    {
        var videoFile = await _videoFileService.GetVideoFileAsync(movieId);
        return videoFile;
    }
}
