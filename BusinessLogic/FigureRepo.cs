using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FigureRepo
    {
        IList<Figure> Figures;

        public FigureRepo()
        {
            Figures = new List<Figure>();
        }

        public int Count { get => Figures.Count; }

        public void Add(Figure figure)
        {
            if (figure is null)
                throw new BusinessLogicException(nameof(figure));
            if (Exists(figure.Name))
                throw new BusinessLogicException("Figure already exsists");

            Figures.Add(figure);
        }

        public bool Exists(string figurename)
        {
            return Figures.Any(figure => figure.Name == figurename);
        }

        public Figure Get(string figurename)
        {
            if (!Exists(figurename))
                throw new BusinessLogicException("Figure does not exist");
            return Figures.First(figure => figure.Name == figurename);
        }

        public void Update(Figure figure)
        {
            Remove(figure.Name);
            Add(figure);
        }

        public void Remove(string figurename)
        {
            Figures = Figures.Where(figure => figure.Name != figurename).ToList();
        }

        public IList<Figure> GetAll()
        {
            return new List<Figure>(Figures);
        }

        public void Clear()
        {
            Figures.Clear();
        }
    }
}