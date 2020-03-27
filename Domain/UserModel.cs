using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao varUserDao = new UserDao();
        public bool LoginUser(string usermail, string pass)
        {
            return varUserDao.Login(usermail, pass);
        }

        public int InsertUser(string parNombreU, string parApellidoU, string parTelefonoU, string parMailU, string parClaveU)
        {
            return varUserDao.InsertUser(parNombreU, parApellidoU, parTelefonoU, parMailU, parClaveU);

        }

        public int InsertVehicle(string ubicacionveh, string tipoveh, string placaveh, string marcaveh, string anioveh, int kmveh, string versionveh, string tpcombustible, int puertasveh, string tptransmision, string colorveh, string tpdireccion, string traccion, int cilindraje, string tpcarroceria, string MailUsuario)
        {
            return varUserDao.InsertVehicle(ubicacionveh, tipoveh, placaveh, marcaveh, anioveh, kmveh, versionveh, tpcombustible, puertasveh, tptransmision, colorveh, tpdireccion, traccion, cilindraje, tpcarroceria, MailUsuario);
        }

        public DataTable ConsultarPublicaciones(string Consulta)
        {
            return varUserDao.ejecutarSelectUserDao(Consulta);
        }

        public int InsertPublicacion(string usermail, string placaveh, string marcaveh, string submarcaveh, string precio)
        {
            return varUserDao.InsertPublicacion(usermail, placaveh, marcaveh, submarcaveh, precio);
        }
        public int Actualizar(string parConsulta)
        {
            return varUserDao.ActualizarUserDao(parConsulta);
        }

        public int EliminarPulicacion(string parPlacaveh)
        {
            return varUserDao.EliminarPublicacionUserDao(parPlacaveh);
        }

        public int EliminarVehiculo(string parPlacaveh, string parUsuario)
        {
            return varUserDao.EliminarVehiculoUserDao(parPlacaveh , parUsuario);
                }


    }
}
