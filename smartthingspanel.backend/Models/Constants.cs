namespace smartthingspanel.backend.Models
{
    public static class Constants
    {
        public static string MongoDbConnectionString = "mongodb://smartthingspanel:YNCRXYRvUUX7WzaA@smartthingspanel-shard-00-00-qmbe5.mongodb.net:27017,smartthingspanel-shard-00-01-qmbe5.mongodb.net:27017,smartthingspanel-shard-00-02-qmbe5.mongodb.net:27017/panel?ssl=true&replicaSet=SmartThingsPanel-shard-0&authSource=admin&retryWrites=true";
        public static string MongoDbDatabaseName = "Panel";

        public static class ErrorMessages
        {
            public static string AuthError = "Invalid username or password";
            public static string DeviceNotFound = "Device {0} not found";
        }
    }
}