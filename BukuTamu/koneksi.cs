using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BukuTamu
{
    class koneksi
    {
        public static MySqlConnection getKoneksi()
        {
            String konektor = "SERVER=localhost;" + "DATABASE=db_guestbook;" + "UID=root;" + "PASSWORD=;";
            return new MySqlConnection(konektor);
        }
    }
}
