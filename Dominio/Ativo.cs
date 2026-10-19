using System;

namespace GestaoAtivos.Dominio;

public abstract class Ativo
{
    private string _codigo = string.Empty;
    private string _descricao = string.Empty;
    private string _localizacao = string.Empty;
    private string _responsavel = string.Empty;
    private decimal _valorAquisicao;
    private DateTime _dataAquisicao;

    protected Ativo(string codigo, string descricao, DateTime dataAquisicao,
                    decimal valorAquisicao, string localizacao, string responsavel)
    {
        Codigo = codigo;
        Descricao = descricao;
        DataAquisicao = dataAquisicao;
        ValorAquisicao = valorAquisicao;
        Localizacao = localizacao;
        Responsavel = responsavel;
        Estado = EstadoAtivo.EmUso;
    }

    public string Codigo
    {
        get => _codigo;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O código é obrigatório.", nameof(Codigo));
            _codigo = value.Trim().ToUpperInvariant();
        }
    }

    public string Descricao
    {
        get => _descricao;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A descrição é obrigatória.", nameof(Descricao));
            _descricao = value.Trim();
        }
    }

    public DateTime DataAquisicao
    {
        get => _dataAquisicao;
        private set
        {
            if (value > DateTime.Today)
                throw new ArgumentException("A data de aquisição não pode ser futura.", nameof(DataAquisicao));
            _dataAquisicao = value;
        }
    }

    public decimal ValorAquisicao
    {
        get => _valorAquisicao;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("O valor de aquisição tem de ser positivo.", nameof(ValorAquisicao));
            _valorAquisicao = value;
        }
    }

    public string Localizacao
    {
        get => _localizacao;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A localização é obrigatória.", nameof(Localizacao));
            _localizacao = value.Trim();
        }
    }

    public string Responsavel
    {
        get => _responsavel;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O responsável é obrigatório.", nameof(Responsavel));
            _responsavel = value.Trim();
        }
    }

    public EstadoAtivo Estado { get; private set; }

    // Cada subclasse indica o seu tipo (Equipamento, Veiculo, ...)
    public abstract string TipoAtivo { get; }

    public override string ToString() => $"[{Codigo}] {Descricao} ({TipoAtivo}) - {Localizacao}";
}