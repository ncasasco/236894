using BusinessLogic;
//using BusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class ProducerRepo
    {

        IList<Producer> Producers;

        public ProducerRepo()
        {
            Producers = new List<Producer>();
        }

        public int Count { get => Producers.Count; }

        public void Add(Producer producer)
        {
            if (producer is null)
                throw new ArgumentNullException(nameof(producer));
            if (Exists(producer.Mail))
                throw new BusinessLogicException("Producer already exsists");

            Producers.Add(producer);
        }

        public bool Exists(string mail)
        {
            return Producers.Any(producer => producer.Mail == mail);
        }

        public Producer Get(string mail)
        {
            if (!Exists(mail))
                throw new BusinessLogicException("Producer does not exsist");
            return Producers.First(producer => producer.Mail == mail);
        }

        public void Update(Producer producer)
        {
            Remove(producer.Mail);
            Add(producer);
        }

        public void Remove(string mail)
        {
            Producers = Producers.Where(producer => producer.Mail != mail).ToList();
        }

        public IList<Producer> GetAll()
        {
            return new List<Producer>(Producers); //return a copy, not the actual list!
        }

        public void Clear()
        {
            Producers.Clear();
        }
    }
}
