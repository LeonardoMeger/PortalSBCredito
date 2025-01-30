using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Titulo
    {
        public Titulo()
        {
            Titulos = new List<Titulo>();
        }
        public Guid Id { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Fone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Covarage { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public double Discount { get; set; }

        public List<Titulo> Titulos;

    }
}
