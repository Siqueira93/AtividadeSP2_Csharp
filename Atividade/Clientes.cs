namespace Atividade
{
    class Clientes
    {
        public string Nome { get; set; }
        public string Eendereco { get; set; }
        public float Valor { get; set; }
        public float ValorImposto { get; set; }
        public float Total { get; set; }
        public virtual void PagarImposto(float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 10/100;
            this.Total = this.Valor + this.ValorImposto;
        }
    
    }
}