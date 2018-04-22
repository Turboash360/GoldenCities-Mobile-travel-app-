// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using GoldenCities;
//
//    var welcome = WeatherForcaster.FromJson(jsonString);

namespace GoldenCities.ClassModels
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class WeatherForcaster
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("currently")]
        public Currently Currently { get; set; }

        [JsonProperty("minutely")]
        public Minutely Minutely { get; set; }

        [JsonProperty("hourly")]
        public Hourly Hourly { get; set; }

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }
    }

    public partial class Currently
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("nearestStormDistance", NullValueHandling = NullValueHandling.Ignore)]
        public long? NearestStormDistance { get; set; }

        [JsonProperty("nearestStormBearing", NullValueHandling = NullValueHandling.Ignore)]
        public long? NearestStormBearing { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("precipType", NullValueHandling = NullValueHandling.Ignore)]
        public PrecipType? PrecipType { get; set; }
    }

    public partial class Daily
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public List<DailyDatum> Data { get; set; }
    }

    public partial class DailyDatum
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("sunriseTime")]
        public long SunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public long SunsetTime { get; set; }

        [JsonProperty("moonPhase")]
        public double MoonPhase { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [JsonProperty("precipIntensityMaxTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrecipIntensityMaxTime { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("precipType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrecipType { get; set; }

        [JsonProperty("temperatureHigh")]
        public double TemperatureHigh { get; set; }

        [JsonProperty("temperatureHighTime")]
        public long TemperatureHighTime { get; set; }

        [JsonProperty("temperatureLow")]
        public double TemperatureLow { get; set; }

        [JsonProperty("temperatureLowTime")]
        public long TemperatureLowTime { get; set; }

        [JsonProperty("apparentTemperatureHigh")]
        public double ApparentTemperatureHigh { get; set; }

        [JsonProperty("apparentTemperatureHighTime")]
        public long ApparentTemperatureHighTime { get; set; }

        [JsonProperty("apparentTemperatureLow")]
        public double ApparentTemperatureLow { get; set; }

        [JsonProperty("apparentTemperatureLowTime")]
        public long ApparentTemperatureLowTime { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windGustTime")]
        public long WindGustTime { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("uvIndexTime")]
        public long UvIndexTime { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public long? Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temperatureMinTime")]
        public long TemperatureMinTime { get; set; }

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("temperatureMaxTime")]
        public long TemperatureMaxTime { get; set; }

        [JsonProperty("apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        [JsonProperty("apparentTemperatureMinTime")]
        public long ApparentTemperatureMinTime { get; set; }

        [JsonProperty("apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        [JsonProperty("apparentTemperatureMaxTime")]
        public long ApparentTemperatureMaxTime { get; set; }
    }

    public partial class Flags
    {
        [JsonProperty("sources")]
        public List<string> Sources { get; set; }

        [JsonProperty("isd-stations")]
        public List<string> IsdStations { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class Hourly
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public List<Currently> Data { get; set; }
    }

    public partial class Minutely
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public List<MinutelyDatum> Data { get; set; }
    }

    public partial class MinutelyDatum
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("precipIntensity")]
        public long PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public long PrecipProbability { get; set; }
    }

    public enum Icon { ClearDay, ClearNight, PartlyCloudyDay, PartlyCloudyNight };

    public enum PrecipType { Rain };

    public enum Summary { Clear, PartlyCloudy };

    public partial class WeatherForcaster
    {
        public static WeatherForcaster FromJson(string json) => JsonConvert.DeserializeObject<WeatherForcaster>(json, GoldenCities.ClassModels.Converter.Settings);
    }

    static class IconExtensions
    {
        public static Icon? ValueForString(string str)
        {
            switch (str)
            {
                case "clear-day": return Icon.ClearDay;
                case "clear-night": return Icon.ClearNight;
                case "partly-cloudy-day": return Icon.PartlyCloudyDay;
                case "partly-cloudy-night": return Icon.PartlyCloudyNight;
                default: return null;
            }
        }

        public static Icon ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Icon value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Icon.ClearDay: serializer.Serialize(writer, "clear-day"); break;
                case Icon.ClearNight: serializer.Serialize(writer, "clear-night"); break;
                case Icon.PartlyCloudyDay: serializer.Serialize(writer, "partly-cloudy-day"); break;
                case Icon.PartlyCloudyNight: serializer.Serialize(writer, "partly-cloudy-night"); break;
            }
        }
    }

    static class PrecipTypeExtensions
    {
        public static PrecipType? ValueForString(string str)
        {
            switch (str)
            {
                case "rain": return PrecipType.Rain;
                default: return null;
            }
        }

        public static PrecipType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PrecipType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PrecipType.Rain: serializer.Serialize(writer, "rain"); break;
            }
        }
    }

    static class SummaryExtensions
    {
        public static Summary? ValueForString(string str)
        {
            switch (str)
            {
                case "Clear": return Summary.Clear;
                case "Partly Cloudy": return Summary.PartlyCloudy;
                default: return null;
            }
        }

        public static Summary ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Summary value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Summary.Clear: serializer.Serialize(writer, "Clear"); break;
                case Summary.PartlyCloudy: serializer.Serialize(writer, "Partly Cloudy"); break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this WeatherForcaster self) => JsonConvert.SerializeObject(self, GoldenCities.ClassModels.Converter.Settings);
    }

    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Icon) || t == typeof(PrecipType) || t == typeof(Summary) || t == typeof(Icon?) || t == typeof(PrecipType?) || t == typeof(Summary?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Icon))
                return IconExtensions.ReadJson(reader, serializer);
            if (t == typeof(PrecipType))
                return PrecipTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Summary))
                return SummaryExtensions.ReadJson(reader, serializer);
            if (t == typeof(Icon?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return IconExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PrecipType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PrecipTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Summary?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SummaryExtensions.ReadJson(reader, serializer);
            }
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Icon))
            {
                ((Icon)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PrecipType))
            {
                ((PrecipType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Summary))
            {
                ((Summary)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
