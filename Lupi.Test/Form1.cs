using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lupi.Data.DataAccess;
using Lupi.Data.Entities;

namespace Lupi.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region prueba
            //using (LupiDbContext context = new LupiDbContext())
            //{
            //    Breed breed = new Breed();
            //    Guid breedId = Guid.NewGuid();
            //    breed.Id = breedId;
            //    breed.Name = "Chicho";
            //    context.Breeds.Add(breed);
            //    context.SaveChanges();
            //}

            //Product newProduct = new ExtendedProduct()
            //{
            //    Descripcion = "Producto loco",
            //    Id = Guid.NewGuid(),
            //    Precio = 120.5,
            //    properties = new List<Property>()
            //};

            //Property newProperty = new GenericProperty<>();

            //Breed breed = new Breed();
            //breed.HairType = "Golden";
            //breed.Name = "Nombre 1";
            //breed.Id = Guid.NewGuid();

            //List<string> listaColores = new List<string>() { "pelo1", "pelo2", "pelo3" };

            //breed.HairColors = listaColores;

            //Breed breed1 = new Breed();
            //breed.HairType = "Hair 2";
            //breed.Name = "Nombre 2";
            //breed.Id = Guid.NewGuid();

            //List<string> listaColores1 = new List<string>() { "pelo2", "pelo3", "pelo4" };

            //breed.HairColors = listaColores1;


            //Breed breed2 = new Breed();
            //breed.HairType = "Golden";
            //breed.Name = "Nombre 2";
            //breed.Id = Guid.NewGuid();

            //List<string> listaColores2 = new List<string>() { "pelo1", "pelo2", "pelo5" };

            //breed.HairColors = listaColores2;


            //Breed breed3 = new Breed();
            //breed.HairType = "Golden";
            //breed.Name = "Nombre 3";
            //breed.Id = Guid.NewGuid();

            //List<string> listaColores3 = new List<string>() { "pelo6", "pelo2","pelo2", "pelo7" };

            //breed.HairColors = listaColores3;

            //List<Breed> listBreeds = new List<Breed>() { breed, breed1, breed2, breed3 };

            //var pelo = listaColores3.GroupBy(x);
            #endregion

            Int32 i = 23;

            object objInt = i;

            Type t = objInt.GetType();

            MessageBox.Show(objInt.GetType().ToString());

            LupiDbContext db = new LupiDbContext();

            Guid id = new Guid("22473748-27F2-4DB4-84C3-8557C0699C97");

            Owner ownerFind = db.Owners.Find(id);

            Owner o = new Data.Entities.Owner()
            {
                BirthDate = new DateTime(),
                Id = Guid.NewGuid()
            };
            Owner o1 = new Data.Entities.Owner()
            {
                BirthDate = new DateTime(),
                Id = Guid.NewGuid()
            };
            Owner o2 = new Data.Entities.Owner()
            {
                BirthDate = new DateTime(),
                Id = Guid.NewGuid()
            };

            List<Owner> owners = new List<Data.Entities.Owner>() { o, o1, o2 };

            Pet p = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = "Perro"
            };
            Pet p1 = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = "Perro1"
            };
            Pet p2 = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = "Perro2"
            };
            Pet p3 = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = "Perro3"
            };
            Pet p4 = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = "Perro4"
            };

            o.Pets = new List<Pet>() { p, p1, p2, p3, p4 };
            o1.Pets = new List<Pet>() { p4 };
            o2.Pets = new List<Pet>() { p, p3, p4 };

            List<Pet> pets = new List<Pet>() { p, p1, p2, p3, p4 };

            var list = owners.SelectMany(x => x.Pets, (ownerObj, petId)
                => new { ownerObj, petId })
                .GroupBy(x => x.petId)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key.Name)
                .Take(10);

            foreach (var item in list)
            {
                MessageBox.Show(item.ToString());
            }

        }
    }
}
