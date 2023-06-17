using System.Collections.Generic;
using System.Threading.Tasks;
using AppCitas.Service.DTOs;
using AppCitas.Service.Entities;

namespace AppCitas.Service.Interfaces
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}