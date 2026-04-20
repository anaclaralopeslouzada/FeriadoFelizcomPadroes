namespace SmartCity
{
    // Observer: Interface para quem quer receber alertas
    public interface IObserver {
        void Atualizar(string sensor, double valor);
    }

    // Dados do Sensor 
    public interface ISensorData {
        double GetValor();
        string GetDescricao();
    }
}
