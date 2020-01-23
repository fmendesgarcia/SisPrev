using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebZSPrev.ObjetoTransferencia
{
    public class Processo
    {
        public int id { get; set; }
        public string numero_processo { get; set; }
        public int MyProperty { get; set; }


        // id_cliente
        // Numero do Processo, ex: 5025545-79.2019.4.03.6182
        // Status do processo, ex: Demandante
        // Área de atuação, ex: Direito cível
        // Objeto da ação, ex: Embargos de terceiro
        // Assunto
        // Data contratação
        // Data encerramento
        // Data distribuição
        // vara
        // comarca
        // fase, ex: instrução
        // valor da causa
    }
}