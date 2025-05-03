namespace WebApplication1.Models
{
    public class TemperaturaSensor
    {
        public int Id { get; set; } // ID automático no banco
        public double Sensor1 { get; set; }
        public double Sensor2 { get; set; }
        public double Sensor3 { get; set; }
        public double Sensor4 { get; set; }
        public double Sensor5 { get; set; }
        public double Sensor6 { get; set; }
        public double Sensor7 { get; set; }
        public double Sensor8 { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
    }

    public class TensaoCell
    {
        public int Id { get; set; } // ID automático no banco
        public double Cel1 { get; set; }
        public double Cel2 { get; set; }
        public double Cel3 { get; set; }
        public double Cel4 { get; set; }
        public double Cel5 { get; set; }
        public double Cel6 { get; set; }
        public double Cel7 { get; set; }
        public double Cel8 { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
    }
}
