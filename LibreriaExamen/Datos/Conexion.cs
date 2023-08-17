namespace LibreriaExamen.Datos
{
    public class Conexion
    {
        private string _cadenaSql = string.Empty;
        public Conexion() {
            var builder=new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            _cadenaSql = builder.GetSection("ConnectionStrings:cadenaSql").Value;
        }

        public string getCadena() {
            return _cadenaSql;
        }

    }
}
