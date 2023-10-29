using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Configurations
{
    public class CustomTokenOption
    {
        public string Issuer { get; set; } // Token'ı yayınlayan tarafın adı veya URL'si
        public List<String> Audience { get; set; } // Token'ı kullanacak olan tarafın adı veya URL'si
        public string SecurityKey { get; set; } // Token için kullanılacak gizli anahtar
        public int AccessTokenExpiration { get; set; } // Erişim token'ının geçerlilik süresi 
        public int RefreshTokenExpiration { get; set; } // Yenileme token'ının geçerlilik süresi 
    }
}
