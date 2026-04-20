namespace SmartCity {
    class Prefeitura : IObserver {
        public void Atualizar(string s, double v) => Console.WriteLine($"   -> Alerta Prefeitura: {s} mudou para {v}");
    }

    class Program {
        static void Main() {
            CentralFacade central = new CentralFacade();
            Prefeitura sjc = new Prefeitura();

            central.ConfigurarMonitoramento(sjc);

            Console.WriteLine("Teste 1: Sensor Normal");
            central.GerarLeituraSimples("Termômetro Centro", 28.0);

            Console.WriteLine("\nTeste 2: Sensor com Decorator (Filtro)");
            central.GerarLeituraComFiltro("Termômetro Norte", 30.0);

            Console.WriteLine("\nTeste 3: Proxy Bloqueando Valor Errado");
            central.GerarLeituraSimples("Sensor Falho", 500.0);
        }
    }
}
