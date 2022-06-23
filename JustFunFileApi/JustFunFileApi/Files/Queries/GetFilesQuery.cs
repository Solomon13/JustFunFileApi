using JustFunFileApi.Models;
using MediatR;

namespace JustFunFileApi.Files.Queries
{
    public class GetFilesQuery : IRequest<List<FileInfoDTO>>
    {
    }
}
