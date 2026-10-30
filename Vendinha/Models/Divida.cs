using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vendinha.Models {
    public class Divida {
        public int Id {  get; set; }

        [Required]
        [Range(0.01, 99999999.99)]
        public decimal Valor {  get; set; }

        public bool Paga {  get; set; } = false;

        public DateTime DataCriacao {  get; set; } = DateTime.Today;

        public DateTime? DataPagamento { get; set; } = null;//? se não informar nada vai como null

        [Range(1, int.MaxValue)]//impedir que o id seja 0
        public int ClienteId {  get; set; }
    }
}
