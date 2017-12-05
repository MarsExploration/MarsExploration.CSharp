using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    /// <summary>
    /// Dados necessários para executar a movimentação de uma sonda
    /// </summary>
    public class ProbeData
    {
        public Position InitialPosition { get; set; }
        public IEnumerable<ProbeAction> Actions { get; set; }
    }
}
