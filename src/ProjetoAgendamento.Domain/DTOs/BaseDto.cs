﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Domain.DTOs
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        private DateTime? _createAt;
        public DateTime? CreateAt {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }
        public DateTime? UpdateAt { get; set; }
    }

}
