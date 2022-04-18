using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Utils.Enums
{
    public enum TipoCirculoEnum
    {
        [Description("Endereco")]
        Endereco,
        [Description("Aleatório")]
        Aleatorio,
        [Description("Idade")]
        Idade,
    }

    public enum TipoPessoaEnum
    {
        [Description("Equipante")]
        Equipante,
        [Description("Participante")]
        Participante
    }
    public enum CamposEnum
    {
        [Description("Email")]
        Email,
        [Description("Nome Completo")]
        Nome,
        [Description("Apelido")]
        Apelido,
        [Description("Gênero")]
        Genero,
        [Description("Data Nascimento")]
        DataNascimento,
        [Description("Fone")]
        Fone,
        [Description("Instagram")]
        Instagram,
        [Description("Profissão")]
        Profissao,
        [Description("Endereço")]
        Endereco,
        [Description("Dados da Mãe")]
        Mae,
        [Description("Dados do Pai")]
        Pai,
        [Description("Dados do Contato")]
        Contato,
        [Description("Dados do Convite")]
        Convite,
        [Description("Ônibus")]
        Onibus,
        [Description("Parente")]
        Parente,
        [Description("Congregação")]
        Congregacao,
        [Description("Alergia")]
        Alergia,
        [Description("Medicação")]
        Medicacao,
        [Description("Restrição Alimentar")]
        Restricao,


    }
    public enum StatusEnum
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 2,
        [Description("Deletado")]
        Deletado = 3,
        [Description("Aberto")]
        Aberto = 4,
        [Description("Quitado")]
        Quitado = 5,
        [Description("Cancelado")]
        Cancelado = 6,
        [Description("Encerrado")]
        Encerrado = 7,
        [Description("Inscrito")]
        Inscrito = 8,
        [Description("Confirmado")]
        Confirmado = 9,
        [Description("Em Espera")]
        Espera = 10
    }

    public enum SexoEnum
    {
        [Description("Masculino")]
        Masculino = 1,
        [Description("Feminino")]
        Feminino = 2
    }
    public enum EquipesEnum
    {
        [Description("Vaila de Apoio Integral")]
        VailaAI = 1,
        [Description("Refeitório")]
        Refeitorio = 2,
        [Description("Grupo de Oração e Encorajamento")]
        GOE = 3,
        [Description("Reitores")]
        Reitores = 4,
        [Description("Secretaria")]
        Secretaria = 5,
        [Description("Circulação")]
        Circulacao = 6,
        [Description("Vaila de Pequeno Grupo")]
        Circulo = 7,
        [Description("Drama")]
        Drama = 8,
        [Description("Mídia")]
        Midia = 9,
        [Description("Louvor")]
        Louvor = 10,
        [Description("Cozinha")]
        Cozinha = 11,
        [Description("Pastores")]
        Pastores = 12,
        [Description("Bomboniere")]
        Bomboniere = 13,
        [Description("Coordenação")]
        Coordenacao = 14
    }

    public enum TiposEventoEnum
    {
        [Nickname("Realidade")]
        [Description("Realidade")]
        [Equipes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 })]
        Realiadde = 1,

    }

    public enum BancosEnum
    {
        [Description("Bradesco")]
        Bradesco = 1,
        [Description("Santander")]
        Santander = 2,
        [Description("Itaú")]
        Itau = 3,
        [Description("Caixa")]
        Caixa = 4,
        [Description("Banco do Brasil")]
        BancoBrasil = 5,
        [Description("NuBank")]
        Nubank = 6,
        [Description("Banco Inter")]
        Inter = 7,
        [Description("HSBC")]
        HSBC = 8
    }

    public enum TiposEquipeEnum
    {
        [Description("Coordenador")]
        Coordenador = 1,
        [Description("Membro")]
        Membro = 2
    }

    public enum PerfisUsuarioEnum
    {
        [Description("Master")]
        Master,
        [Description("Admin")]
        Admin,
        [Description("Coordenador")]
        Coordenador,
        [Description("Secretaria")]
        Secretaria,
    }

    public enum TiposLancamentoEnum
    {
        [Description("Receber")]
        Receber = 1,
        [Description("Pagar")]
        Pagar = 2
    }

    public enum TiposCentroCustoEnum
    {
        [Description("Receita")]
        Receita = 1,
        [Description("Despesa")]
        Despesa = 2
    }

    public enum CentroCustoPadraoEnum
    {
        [Description("Inscrições")]
        Inscricoes = 1,
        [Description("Taxa de Equipante")]
        TaxaEquipante = 2
    }

    public enum ValoresPadraoEnum
    {
        [Description("Inscrições")]
        Inscricoes = 300,
        [Description("Taxa de Equipante")]
        TaxaEquipante = 150
    }

    public enum MeioPagamentoPadraoEnum
    {
        [Description("Pix")]
        Transferencia,
        [Description("Dinheiro")]
        Dinheiro,
        [Description("Isenção")]
        Isencao
    }

    public enum CoresEnum
    {
        [Description("Vermelho")]
        Vermelho,
        [Description("Laranja")]
        Laranja,
        [Description("Rosa")]
        Rosa,
        [Description("Azul Claro")]
        AzulClaro,
        [Description("Azul Escuro")]
        AzulEscuro,
        [Description("Verde Claro")]
        VerdeClaro,
        [Description("Verde Escuro")]
        VerdeEscuro,
        [Description("Amarelo")]
        Amarelo,
        [Description("Cinza")]
        Cinza,
        [Description("Lilás")]
        Lilas
    }

    internal class NicknameAttribute : Attribute
    {
        public virtual string Nickname { get; }

        public NicknameAttribute(string Nickname)
        {
            this.Nickname = Nickname;
        }
    }

    internal class EquipesAttribute : Attribute
    {
        public virtual int[] Equipes { get; }

        public EquipesAttribute(int[] Equipes)
        {
            this.Equipes = Equipes;
        }
    }

    internal class EmailPagSeguroAttribute : Attribute
    {
        public virtual string EmailPagSeguro { get; }

        public EmailPagSeguroAttribute(string EmailPagSeguro)
        {
            this.EmailPagSeguro = EmailPagSeguro;
        }
    }

    internal class TokenPagSeguroAttribute : Attribute
    {
        public virtual string TokenPagSeguro { get; }

        public TokenPagSeguroAttribute(string TokenPagSeguro)
        {
            this.TokenPagSeguro = TokenPagSeguro;
        }
    }
}