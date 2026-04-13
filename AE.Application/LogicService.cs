using AE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AE.Application
{
    public class LogicService
    {
        private readonly IContactRepository _repository;

        public LogicService(IContactRepository repository)
        {
            _repository = repository;
        }

        public int Insert(Contact contact)
        {
            Validate(contact);
            return _repository.Insert(contact);
        }

        public bool Update(Contact contact)
        {
            if (contact.Id <= 0)
                throw new ArgumentException("El Id del contacto es inválido.");

            Validate(contact);
            return _repository.Update(contact);
        }

        public bool Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id es inválido.");

            return _repository.Delete(id);
        }

        public Contact GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id es inválido.");

            return _repository.GetById(id);
        }

        public List<Contact> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Contact> Search(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return _repository.GetAll();

            input = input.Trim();

            if (int.TryParse(input, out int id))
                return _repository.Search(id, null);

            return _repository.Search(null, input);
        }

        private void Validate(Contact c)
        {
            if (c == null)
                throw new ArgumentNullException(nameof(c), "El contacto no puede ser nulo.");

            if (string.IsNullOrWhiteSpace(c.Name))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(c.LastName))
                throw new ArgumentException("El apellido es obligatorio.");

            if (!string.IsNullOrWhiteSpace(c.Email) && !IsValidEmail(c.Email))
                throw new ArgumentException("El correo electrónico no es válido.");

            if ((int)c.Gender <= 0)
                throw new ArgumentException("Debe seleccionar un género.");

            if ((int)c.CivilStatusType <= 0)
                throw new ArgumentException("Debe seleccionar un estado civil.");
        }

        private bool IsValidEmail(string email)
        {
           
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }
    }
}
