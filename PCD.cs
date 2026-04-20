using System.Collections.Generic;

namespace SmartCity {
    public class PCDReal {
        private List<IObserver> _obs = new List<IObserver>();
        public void Registrar(IObserver o) => _obs.Add(o);
        
        public void ProcessarLeitura(ISensorData dados) {
            Console.WriteLine($"[PCD] Processando: {dados.GetDescricao()} - Valor: {dados.GetValor()}");
            foreach(var o in _obs) o.Atualizar(dados.GetDescricao(), dados.GetValor());
        }
    }

    // Proxy: Valida se o valor não é perigoso/errado antes de enviar ao PCD Real
    public class PCDProxy {
        private PCDReal _real = new PCDReal();
        public void Registrar(IObserver o) => _real.Registrar(o);

        public void EnviarDados(ISensorData dados) {
            if (dados.GetValor() < -50 || dados.GetValor() > 100) {
                Console.WriteLine("[PROXY] Erro: Valor de temperatura impossível!");
            } else {
                _real.ProcessarLeitura(dados);
            }
        }
    }
}
