﻿namespace API_Hospitalar.DTOs.AtendimentosDTO
{
    public class AtendimentosGetDTO
    {
        public int Id_Atendimento { get; set; } 
        public string Descricao { get; set; }
        public int Identificador_medico { get; set; }
        public int Identificador_paciente { get; set; }
    }
}
