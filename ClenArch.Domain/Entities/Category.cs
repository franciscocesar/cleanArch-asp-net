using ClenArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClenArch.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(int id, string name)
        {
            DomainExceptionValidator.When(id < 0,  "Invalid Id value");
            Id = id;
            ValidateDomain(name);
        }
        public Category(string name)
        {
            ValidateDomain(name);
            Name = name;
        }
        public void Update(string name)
        {

        }
        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidator.When(string.IsNullOrEmpty(name), "Nome invalido, nome é requirido");

            DomainExceptionValidator.When(name.Length < 3, "Nome invalido, minimo de 3 caracteres");

            Name = name;
        }
    }
}
