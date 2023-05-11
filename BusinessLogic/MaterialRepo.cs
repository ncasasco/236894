using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MaterialRepo
    {
        IList<Material> Materials;

        public MaterialRepo()
        {
            Materials = new List<Material>();
        }

        public int Count { get => Materials.Count; }

        public void Add(Material material)
        {
            if (material is null)
                throw new BusinessLogicException(nameof(material));
            if (Exists(material.Name))
                throw new BusinessLogicException("Material already exsists");

            Materials.Add(material);
        }

        public bool Exists(string materialname)
        {
            return Materials.Any(material => material.Name == materialname);
        }

        public Material Get(string materialname)
        {
            if (!Exists(materialname))
                throw new BusinessLogicException("Material does not exist");
            return Materials.First(material => material.Name == materialname);
        }

        public void Update(Material material)
        {
            Remove(material.Name);
            Add(material);
        }

        public void Remove(string materialname)
        {
            Materials = Materials.Where(material => material.Name != materialname).ToList();
        }

        public IList<Material> GetAll()
        {
            return new List<Material>(Materials);
        }

        public void Clear()
        {
            Materials.Clear();
        }
    }
}

