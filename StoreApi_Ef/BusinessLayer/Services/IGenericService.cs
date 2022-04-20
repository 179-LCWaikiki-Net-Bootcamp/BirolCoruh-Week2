using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IGenericService<Entity,Dto> 
    {
        void AddService(Dto item);
        void UpdateService(Dto item);
        void DeleteService(int id);
        List<Dto> GetAllService();
        void GetByIdService(int id);
    }
}
