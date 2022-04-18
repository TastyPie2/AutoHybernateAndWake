using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyIO;
using Newtonsoft.Json;

namespace ConfigAndLoader
{
    public static class Loader
    {
        static Config? _config;
        static readonly string appdata = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AutoHybernateAndWake");
        static readonly string dataFolder = Path.Combine(appdata, "data");
        static readonly string configFile = Path.Combine(dataFolder, "config.json");

        public static Config GetConfig()
        {
            if(_config == null)
            {
                if(File.Exists(configFile))
                {
                    try
                    {
                        _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configFile));
                    }
                    catch
                    {
                        _config = null;
                    }

                    if(_config == null)
                    {
                        goto CreateCofigFile;
                    }
                    else
                    {
                        return _config;
                    }
                }
                else
                {
                    goto CreateCofigFile;
                }
            }
            else
            {
                return _config;
            }

        CreateCofigFile:
            _config = new Config();
            SaveConfig(_config);
            
            return _config;
        }

        public static void SaveConfig(Config config)
        {
            Directory.CreateDirectory(appdata);
            Directory.CreateDirectory(dataFolder);

            using FileStream filestream = File.Create(configFile);
            filestream.Write(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(config)));
        }
    }
}
