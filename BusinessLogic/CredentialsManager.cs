//using BusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CredentialsManager
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private readonly ProducerRepo producersRepo;
        public Producer ProducerLogged { get; set; }
        public CredentialsManager(ProducerRepo producersRepo, Producer admin)
        {
            this.producersRepo = producersRepo;
            SaveProducer(admin);
        }

        public bool IsLogged { get; private set; }

        public void Login(Credentials producerCredentials)
        {
            if (!producersRepo.Exists(producerCredentials.Mail))
                throw new BusinessLogicException("Invalid mail or password");

            Producer storedProducer = producersRepo.Get(producerCredentials.Mail);
            IsLogged = storedProducer.Password == Hash(producerCredentials.Password);
            ProducerLogged = IsLogged ? storedProducer : throw new BusinessLogicException("Invalid mail or password");
        }

        public void Register(Producer producer)
        {
            if (!IsLogged)
                throw new BusinessLogicException("Not logged in");
            SaveProducer(producer);
        }

        public void Logout() => IsLogged = false;

        public void SaveProducer(Producer producer)
        {
            Producer newProducer = producer.DeepClone();
            newProducer.Password = Hash(producer.Password);
            producersRepo.Add(newProducer);
        }

        private string Hash(string password, int iterations = 1000)
        {
            byte[] salt = new byte[SaltSize]; 
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hashedBase46String = Convert.ToBase64String(hash);

            return hashedBase46String;
        }
    }
}
