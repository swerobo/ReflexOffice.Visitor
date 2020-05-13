namespace ReflexOffice.Database
{
    public class Helper
    {
        public static string CnnVal(string name)
        {
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return "server = 192.168.0.16; userid = reflex; password = ; database = reflexoffice; Convert Zero Datetime = True";
        }
    }
}