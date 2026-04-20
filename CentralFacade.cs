namespace SmartCity {
    public class CentralFacade {
        private PCDProxy _pcd = new PCDProxy();

        public void ConfigurarMonitoramento(IObserver prefeitura) {
            _pcd.Registrar(prefeitura);
        }

        public void GerarLeituraSimples(string nome, double valor) {
            ISensorData s = new SensorComum(nome, valor);
            _pcd.EnviarDados(s);
        }

        public void GerarLeituraComFiltro(string nome, double valor) {
            ISensorData s = new FiltroCalibragem(new SensorComum(nome, valor));
            _pcd.EnviarDados(s);
        }
    }
}
