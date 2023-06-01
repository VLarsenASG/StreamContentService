using Domain.Dtos;

namespace Application.Services
{
    public interface IVideoFileService
    {

        Task<VideoFileDto> GetVideoFileAsync(Guid movieId);
    }
}
