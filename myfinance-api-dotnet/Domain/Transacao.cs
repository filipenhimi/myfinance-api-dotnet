﻿namespace myfinance_api_dotnet.Domain
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Historico { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int PlanoContaId { get; set; }
        public PlanoConta PlanoConta { get; set; }
    }
}