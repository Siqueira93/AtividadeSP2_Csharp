namespace Atividade
{
    class PessoaJuridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public override void PagarImposto(float valor) //
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}