using Data.Context;
using Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utils.Enums;

namespace Data.Entities
{
    public class Circulo : UsuarioBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EventoId { get; set; }
        [ForeignKey("EventoId")]
        public Evento Evento { get; set; }
        public int EquipanteId { get; set; }
        public EquipanteEvento Equipante { get; set; }
        public CoresEnum Cor { get; set; }
        public virtual ICollection<CirculoParticipante> Participantes { get; set; }
    }
}