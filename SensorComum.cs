namespace SmartCity {
    public class SensorComum : ISensorData {
        private double _valor;
        private string _nome;
        public SensorComum(string nome, double valor) { _nome = nome; _valor = valor; }
        public double GetValor() => _valor;
        public string GetDescricao() => _nome;
    }
}
