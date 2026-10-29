using System;
namespace GestaoAtivos.core
{
  
    
    public class Ativo 
    {
        public int codigo { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal ValorAquisicao { get; set; }
        public int VidaUtilAnos { get; set; }
        public string Estado { get; set; }

public Ativo(string descricao, string categoria, decimal valorAquisicao, int vidaUtilAnos, string estado)
        {
            Descricao = descricao;
            Categoria = categoria;
            ValorAquisicao = valorAquisicao;
            VidaUtilAnos = vidaUtilAnos;
            Estado = "Ativo";
        }
        public decimal CalcularAmortizacaoAnual()
        {
            // Proteção contra divisão por zero
            if (VidaUtilAnos <= 0) return 0;
            
            return ValorAquisicao / VidaUtilAnos;

        }
        
        public virtual void ExibirDetalhes()
        {
Console.WriteLine($"[Ativo] Código: {codigo}, Descrição: {Descricao}, Categoria: {Categoria}, Valor de Aquisição: {ValorAquisicao:C}, Vida Útil (anos): {VidaUtilAnos}, Estado: {Estado}");
} 
}
}