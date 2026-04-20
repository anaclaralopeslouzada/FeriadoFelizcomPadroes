namespace SmartCity {
    public abstract class FiltroDecorator : ISensorData {
        protected ISensorData _sensor;
        public FiltroDecorator(ISensorData sensor) => _sensor = sensor;
        public abstract double GetValor();
        public abstract string GetDescricao();
    }

    // Exemplo de Decorator: Aplica uma calibração (soma 1.0 ao valor)
    public class FiltroCalibragem : FiltroDecorator {
        public FiltroCalibragem(ISensorData s) : base(s) {}
        public override double GetValor() => _sensor.GetValor() + 1.0;
        public override string GetDescricao() => _sensor.GetDescricao() + " (Calibrado)";
    }
}
