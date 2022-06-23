using JustFunFileApi.Models;
using MediatR;

namespace JustFunFileApi.Files.Queries
{
    public class GetFilesQueryHandler : IRequestHandler<GetFilesQuery, List<FileInfoDTO>>
    {
        Task<List<FileInfoDTO>> IRequestHandler<GetFilesQuery, List<FileInfoDTO>>.Handle(GetFilesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<FileInfoDTO>()
            {
                new FileInfoDTO ("Test1", "JPEG", 10)
            });
        }
    }
}
