using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace StokTakip
{
    enum Language
    {
        en,
        tr
    }
  
    static class Ayar
    {
        static JavaScriptSerializer jss = new JavaScriptSerializer();

        public static void ChangedLanguage(Language lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
           
            var json = jss.Serialize(lang);
            File.WriteAllText("setting.json",json);
        }
        public static void GetDefaultLanguage()
        {
            Language lang = Language.tr;
            if (File.Exists("setting.json"))
            {
                var settingContent = File.ReadAllText("setting.json");
                lang= jss.Deserialize<Language>(settingContent);

               

            }
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
        }
    }
}
