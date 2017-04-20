using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Lupi.Data.Entities;
using Lupi.Data.Repository;
using Lupi.BusinessLogic;

namespace Lupi.Data.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void AddOwnerTest()
        {
            Mock<IUnitOfWork> mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(o => o.OwnerRepository.Create(It.IsAny<Owner>()));
            mockUnitOfWork.Setup(o => o.OwnerRepository.Save());

            AdmOwner admOwner = new AdmOwner(mockUnitOfWork.Object);

            Owner newOwner = new Owner()
            {
              
            };

            admOwner.CreateOwner(newOwner);

            mockUnitOfWork.VerifyAll();

        }

        [TestMethod]
        public void GetOwnerByIdTest()
        {
            Mock<IUnitOfWork> mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(o => o.OwnerRepository.GetByID(It.IsAny<Guid>()));

            AdmOwner admOwner = new AdmOwner(mockUnitOfWork.Object);

            Guid id = new Guid("22473748-27F2-4DB4-84C3-8557C0699C96");

            Owner owner = admOwner.GetByID(id);

            mockUnitOfWork.VerifyAll();

        }

        [TestMethod]
        public void GetExistentOwnerByIdTest()
        {
            Mock<IUnitOfWork> mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(o => o.OwnerRepository.GetByID(It.IsAny<Guid>()))
                .Returns( (Owner o) => o);

            mockUnitOfWork.Verify(un => un.OwnerRepository.GetByID(It.IsAny<Guid>()), Times.Exactly(1));

        }
    }
}
