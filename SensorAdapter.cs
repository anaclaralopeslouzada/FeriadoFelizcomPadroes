namespace SmartCity {
    public class LegacySensor {
        public string ObterLeitura() => "TEMP_SJC:25.5";
    }

    
    public class SensorAdapter : ISensorData {
        private LegacySensor _legacy = new LegacySensor();
        public double GetValor() => 25.5; 
        public string GetDescricao() => "Sensor Legado SJC";
    }
}
