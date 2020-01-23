using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebZSPrev.ObjetoTransferencia
{
    public class Processo
    {
        public int id { get; set; }
        public int? id_cliente { get; set; }
        public string numero_processo { get; set; }
        public int? id_status_processo { get; set; }
        public int? id_area_atuacao { get; set; }
        public int? id_objeto_da_acao { get; set; }
        public int? id_assunto { get; set; }
        public DateTime? data_contratacao { get; set; }
        public DateTime? data_encerramento { get; set; }
        public DateTime? data_distribuicao { get; set; }
        public int? id_num_vara { get; set; }
        public int? id_vara { get; set; }
        public int? id_comarca { get; set; }
        public int? id_fase { get; set; }
        public double? valor_causa { get; set; }



        AcessaDados.AcessaDadosSqlServer acesso = new AcessaDados.AcessaDadosSqlServer();

        public string manutencao(string procedure, string metodo)
        {
            try
            {
                acesso.LimpaParametros();

                acesso.AdicionarParametros("@id", this.id);
                acesso.AdicionarParametros("@id_cliente", this.id_cliente);
                acesso.AdicionarParametros("@numero_processo", this.numero_processo);
                acesso.AdicionarParametros("@id_status_processo", this.id_status_processo);
                acesso.AdicionarParametros("@id_area_atuacao", this.id_area_atuacao);
                acesso.AdicionarParametros("@id_objeto_da_acao", this.id_objeto_da_acao);
                acesso.AdicionarParametros("@id_assunto", this.id_assunto);
                acesso.AdicionarParametros("@data_contratacao", this.data_contratacao);
                acesso.AdicionarParametros("@data_encerramento", this.data_encerramento);
                acesso.AdicionarParametros("@data_distribuicao", this.data_distribuicao);
                acesso.AdicionarParametros("@id_num_vara", this.id_num_vara);
                acesso.AdicionarParametros("@id_vara", this.id_vara);
                acesso.AdicionarParametros("@id_comarca", this.id_comarca);
                acesso.AdicionarParametros("@id_fase", this.id_fase);
                acesso.AdicionarParametros("@valor_causa", this.valor_causa);



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ao chamar a " + procedure + " para o método: " + metodo + ". Motivo: " + ex.Message);
            }
        }



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