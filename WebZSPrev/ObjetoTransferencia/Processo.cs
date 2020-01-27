using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        public int apagado { get; set; }



        AcessaDados.AcessaDadosSqlServer acesso = new AcessaDados.AcessaDadosSqlServer();

        CultureInfo cultures = new CultureInfo("pt-BR");

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
                acesso.AdicionarParametros("@apagado", this.apagado);


                acesso.AdicionarParametros("@metodo", metodo);
                return acesso.ExecutaManipulacao(System.Data.CommandType.StoredProcedure, procedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ao chamar a " + procedure + " para o método: " + metodo + ". Motivo: " + ex.Message);
            }
        }


        public List<Processo> consulta(string procedure, string metodo)
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
                acesso.AdicionarParametros("@data_contratacao", this.data_contratacao);
                acesso.AdicionarParametros("@data_encerramento", this.data_encerramento);
                acesso.AdicionarParametros("@data_distribuicao", this.data_distribuicao);
                acesso.AdicionarParametros("@id_num_vara", this.id_num_vara);
                acesso.AdicionarParametros("@id_vara", this.id_vara);
                acesso.AdicionarParametros("@id_comarca", this.id_comarca);
                acesso.AdicionarParametros("@id_fase", this.id_fase);
                acesso.AdicionarParametros("@valor_causa", this.valor_causa);

                DataTable dt;

                List<Processo> listaProcesso = new List<Processo>();
                using (dt = acesso.ExecutaConsulta(CommandType.StoredProcedure, procedure))
                    foreach (DataRow dr in dt.Rows)
                    {

                        Processo novoProcesso = new Processo();


                        novoProcesso.id = Convert.ToInt32("id");
                        novoProcesso.id_cliente = Convert.ToInt32("id_cliente");
                        novoProcesso.numero_processo = Convert.ToString("numero_processo");
                        novoProcesso.id_status_processo = Convert.ToInt32("id_status_processo");
                        novoProcesso.id_area_atuacao = Convert.ToInt32("id_area_atuacao");
                        novoProcesso.id_objeto_da_acao = Convert.ToInt32("id_objeto_da_acao");
                        novoProcesso.data_contratacao = Convert.ToDateTime("data_contratacao");
                        novoProcesso.data_encerramento = Convert.ToDateTime("data_encerramento");
                        novoProcesso.data_distribuicao = Convert.ToDateTime("data_distribuicao");
                        novoProcesso.id_num_vara = Convert.ToInt32("id_num_vara");
                        novoProcesso.id_vara = Convert.ToInt32("id_vara");
                        novoProcesso.id_comarca = Convert.ToInt32("id_comarca");
                        novoProcesso.id_fase = Convert.ToInt32("id_fase");
                        novoProcesso.valor_causa = Convert.ToDouble("valor_causa");


                        listaProcesso.Add(novoProcesso);
                    }
            

                return listaProcesso;

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar consultar, motivo: " + ex.Message);
            }

        }


        public DataTable consultadt(string procedure, string metodo)
        {
            try
            {
                acesso.LimpaParametros();

                acesso.AdicionarParametros("@id", this.id);
                acesso.AdicionarParametros("@numero_processo", this.numero_processo);
                acesso.AdicionarParametros("@apagado", this.apagado);
                acesso.AdicionarParametros("@metodo", metodo);

                using (DataTable dt = acesso.ExecutaConsulta(CommandType.StoredProcedure, procedure))
                {
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar consultar, motivo: " + ex.Message);
            }

        }
    }
}
