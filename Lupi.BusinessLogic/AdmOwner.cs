using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lupi.Data.Entities;
using Lupi.Data.Repository;

namespace Lupi.BusinessLogic
{
    public class AdmOwner
    {
        private readonly IUnitOfWork unitOfWork;

        public AdmOwner()
        {
            unitOfWork = new UnitOfWork();
            Pet p = new Pet()
            {
                Age = 19,
                Name = "Tito"
            };

            if(!p.IsNameValueValid())
            {
                throw new Exception();
            }
        }

        public AdmOwner(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateOwner(Owner owner)
        {
            unitOfWork.OwnerRepository.Create(owner);
            unitOfWork.OwnerRepository.Save();
        }

        public Owner GetByID(Guid id)
        {
            return unitOfWork.OwnerRepository.GetByID(id);
        }

    }
}
