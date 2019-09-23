using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class UltimosLancamentosViewModel
    {
        public class Lancamento
        {
            public string Descricao { get; set; }
            public string Data { get; set; }
            public decimal Valor { get; set; }
            public Color CorTexto => Valor >= 0 ? Color.DeepSkyBlue : Color.OrangeRed;
        };

        public bool TemLancamentos => Lancamentos.Any();
        public ObservableCollection<Lancamento> Lancamentos { get; set; } = new ObservableCollection<Lancamento>();

        public UltimosLancamentosViewModel()
        {
            Lancamentos = new ObservableCollection<Lancamento>
            {
                new Lancamento
                {
                    Data = "11/09",
                    Descricao = "SAQUE REDE SAQ",
                    Valor = -340
                },new Lancamento
                {
                    Data = "11/09",
                    Descricao = "PGTO CARD",
                    Valor = -113.43M
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "DEPOSITO",
                    Valor = 554
                },new Lancamento
                {
                    Data = "12/09",
                    Descricao = "SAQUE INTERAGEN",
                    Valor = -40
                },new Lancamento
                {
                    Data = "12/09",
                    Descricao = "DEPOSITO",
                    Valor = 22.13M
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "SAQUE REDE SAQ",
                    Valor = -154
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "TED",
                    Valor = 112
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "PGTO CARD",
                    Valor = -45.54M
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "SAQUE REDE SAQ",
                    Valor = -154
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "TED",
                    Valor = 112
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "PGTO CARD",
                    Valor = -45.54M
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "SAQUE REDE SAQ",
                    Valor = -154
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "TED",
                    Valor = 112
                },new Lancamento
                {
                    Data = "13/09",
                    Descricao = "PGTO CARD",
                    Valor = -45.54M
                }
            };
        }
    }
}