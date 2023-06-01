using Application.Services;
using Domain.Dtos;
using FakeItEasy;
using FluentAssertions;
using StreamContentService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamContentServices.Tests.Controller
{
    public class StreamContentControllerTests
    {


        private readonly IVideoFileService _videoFileService;

        
        public StreamContentControllerTests()
        {
            _videoFileService = A.Fake<IVideoFileService>();

        }

        [Fact]
        public void StreamContentController_GetVideoFile_Return_Fake_Data()
        {
            var videoId = Guid.NewGuid();
            var videoFile = A.Fake<VideoFileDto>();
            A.CallTo(() => _videoFileService.GetVideoFileAsync(videoId)).Returns(videoFile);
            var controller = new StreamContentController(_videoFileService);

            var result = controller.GetVideoFile(videoId);

            result.Should().NotBeNull();
        }
    }
}
