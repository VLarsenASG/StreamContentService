using Application.Repository;
using Domain.Dtos;

namespace Application.Services
{
    public class VideoFileService : IVideoFileService
    {

        private readonly IVideoFileRepository videoFileRepository;

        public VideoFileService(IVideoFileRepository videoFileRepository)
        {
            this.videoFileRepository = videoFileRepository;
        }

        public async Task<VideoFileDto> GetVideoFileAsync(Guid movieId)
        {
            var videoFile = await videoFileRepository.GetFileIdAsync(movieId);
            return videoFile;
        }
    }
}
