using Domain.Dtos;

namespace Application.Repository
{
    public class VideoFileRepository : IVideoFileRepository
    {
        private readonly Dictionary<Guid, VideoFileDto> movieCollection = new Dictionary<Guid, VideoFileDto>()
        {
            { Guid.Parse("b4315028-60cb-4571-b81c-ecec008d908c"), new VideoFileDto("MarioBros.mp4")  }
        };


        public Task<VideoFileDto> GetFileIdAsync(Guid MovieId)
        {
            movieCollection.TryGetValue(MovieId, out var id);
            return Task.FromResult(id);
        }
    }
}
