using Domain.Dtos;

namespace Application.Repository
{
    public interface IVideoFileRepository
    {

        Task<VideoFileDto> GetFileIdAsync(Guid MovieId);
    }
}
