using GPRS_CLOUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GPRS_CLOUD.Repo
{
    public static class LiveMonitoringRepo
    {

        public static List<LiveWeather> GetWeatherdata()
        {
            var theLiveWeather = new List<LiveWeather>();
            var c = new SqlConnection(TrueChange.LiveMoniterConnectionString);
            var man = new SqlCommand
            {
                Connection = c,
                CommandText = "select * from Live_Monitoring"
            };
           // man.Parameters.AddWithValue("@seoUrl", seoUrl);
            using (c)
            {
                c.Open();
                var reader = man.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var newLiveWeather = new LiveWeather
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            Serial_No = Convert.ToString(reader["Serial_No"].ToString()),

                            Model_No = Convert.ToString(reader["Model_No"].ToString()),

                            Location = Convert.ToString(reader["Location"].ToString()),
                            Solar_Power = Convert.ToString(reader["Solar_Power"].ToString()),
                            Pump = Convert.ToString(reader["Pump"].ToString()),

                            Motor_Speed = Convert.ToString(reader["Motor_Speed"].ToString()),
                            Weather = Convert.ToString(reader["Weather"].ToString()),
                            Status = Convert.ToString(reader["Status"].ToString()),
                           // Installation_Date = Convert.ToDateTime(reader["Installation_Date"].ToString()),
                            View = Convert.ToString(reader["View"].ToString()),

                            Temp = Convert.ToString(reader["Temp"].ToString()),
                        };
                        theLiveWeather.Add(newLiveWeather);
                    }
                }
                return theLiveWeather;
            }

        }






        public static DeviceLog Insert(DeviceLog log)
        {
            var conn = new SqlConnection(TrueChange.LiveMoniterConnectionString);
            Int32 Deviceid = 0;
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO DeviceLog (DeviceId,[Key],value) Output Inserted.DeviceId   VALUES ( " + "'" + log.DeviceId + "'" + "," + "'" + log.Key + "'" + "," + "'" + log.value+ "'" + ")";
                // cmd.Parameters.AddWithValue("@id", article.Id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }
                    else
                    {
                        Deviceid = Convert.ToInt32(reader[0]);
                    }
                    //return new ArticleModel()
                    //{
                    //    ArticleId = reader.GetInt32(reader.GetOrdinal("ArticleId")),
                    //    MetaKeywords = reader.GetString(reader.GetOrdinal("Content")),
                    //};
                }
            }

            //DeviceLog arc = Get(articleId);
            return log;

        }





    }
}